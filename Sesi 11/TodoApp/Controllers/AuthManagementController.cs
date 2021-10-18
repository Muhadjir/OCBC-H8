using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TodoApp.Configuration;
using TodoApp.Data;
using TodoApp.Models;
using TodoApp.Models.DTOs.Requests;
using TodoApp.Models.DTOs.Responses;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthManagementController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtConfig _jwtConfig;
        private readonly TokenValidationParameters _tokenValidationParams;
        private readonly ApiDbContext _apiDbContext;

        public AuthManagementController(
            UserManager<IdentityUser> userManager,
            IOptionsMonitor<JwtConfig> optionsMonitor,
            IOptionsMonitor<JwtBearerOptions> optionsMonitorJwtBearerOpt,
            ApiDbContext apiDbContext
        )
        {
            _userManager = userManager;
            _jwtConfig = optionsMonitor.CurrentValue;
            var jwtBearerOpt = optionsMonitorJwtBearerOpt.Get(JwtBearerDefaults.AuthenticationScheme);
            _tokenValidationParams = jwtBearerOpt.TokenValidationParameters;
            _apiDbContext = apiDbContext;
        }

        [HttpPost("Register")]
        //[HttpPost]
        //[Route("Register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto user)
        {
            if(ModelState.IsValid)
            {
                // We can utilise the model
                var existingUser = await _userManager.FindByEmailAsync(user.email);

                if(existingUser!= null)
                {
                    return BadRequest(new RegistrationResponse(){
                        errors = new List<string>(){
                            "Email is already registered."
                        },
                        success = false
                    });
                }

                var newUser = new IdentityUser() {Email = user.email, UserName = user.username};
                var isCreated = await _userManager.CreateAsync(newUser, user.password);
                if(isCreated.Succeeded)
                {
                    // var jwtToken = GenerateJwtToken(newUser);

                    // return Ok(new RegistrationResponse(){
                    //     success = true,
                    //     token = jwtToken
                    // });
                    
                    var jwtToken = await GenerateJwtToken(newUser);

                    return Ok(jwtToken);
                } else {
                    return BadRequest(new RegistrationResponse(){
                        errors = isCreated.Errors.Select(x => x.Description).ToList(),
                        success = false
                    });
                }
            }

            return BadRequest(new RegistrationResponse(){
                errors = new List<string>(){
                    "Invalid payload"
                },
                success = false
            });
        }

        [HttpPost("Login")]
        //[HttpPost]
        //[Route("Login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest user)
        {
            if(ModelState.IsValid)
            {
                var existingUser = await _userManager.FindByEmailAsync(user.email);

                if(existingUser == null){
                    return BadRequest(new RegistrationResponse(){
                        errors = new List<string>(){
                            "Invalid login request"
                        },
                        success = false
                    });
                }

                var isCorrect = await _userManager.CheckPasswordAsync(existingUser, user.password);


                if(!isCorrect){
                    return BadRequest(new RegistrationResponse(){
                        errors = new List<string>(){
                            "Invalid login request"
                        },
                        success = false
                    });
                }

                var jwtToken = await GenerateJwtToken(existingUser);

                return Ok(jwtToken);
            }

            return BadRequest(new RegistrationResponse(){
                errors = new List<string>(){
                    "Invalid payload"
                },
                success = false
            });
        }

        private async Task<AuthResult> GenerateJwtToken(IdentityUser user)
        {
            var jwTokenHandler = new JwtSecurityTokenHandler();
            
            var key = Encoding.ASCII.GetBytes(_jwtConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new []
                {
                    new Claim("id", user.Id),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = jwTokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = jwTokenHandler.WriteToken(token);

            var refreshToken = new RefreshToken()
            {
                jwtId = token.Id,
                isUsed = false,
                isRevorked = false,
                userId = user.Id,
                addedDate = DateTime.UtcNow,
                expiryDate = DateTime.UtcNow.AddMonths(6),
                token = RandomString(35) + Guid.NewGuid()
            };

            await _apiDbContext.RefreshToken.AddAsync(refreshToken);
            await _apiDbContext.SaveChangesAsync();
            
            // return jwtToken;

            return new AuthResult()
            {
                token = jwtToken,
                success = true,
                refreshtoken = refreshToken.token
            };
        }

        private string RandomString(int length)
        {
            var random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(x => x[random.Next(x.Length)]).ToArray());
        }

        [HttpPost("RefreshToken")]
        // [HttpPost]
        // [Route("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] TokenRequest tokenRequest)
        {
            if(ModelState.IsValid)
            {
                var result = await VerifyAndGenerateToken(tokenRequest);

                if(result == null){
                    return BadRequest(new RegistrationResponse(){
                        errors = new List<string>(){
                            "Invalid token"
                        },
                        success = false
                    });
                }

                return Ok(result);
            }

            return BadRequest(new RegistrationResponse(){
                errors = new List<string>(){
                    "Invalid payload"
                },
                success = false
            });
        }

        private async Task<AuthResult> VerifyAndGenerateToken(TokenRequest tokenRequest)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            try
            {
                 var tokenInVerification = jwtTokenHandler.ValidateToken(tokenRequest.token, _tokenValidationParams, out var validatedToken);

                 if(validatedToken is JwtSecurityToken jwtSecurityToken)
                 {
                     var result = jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase);
                     if(result == false)
                     {
                         return null;
                     }
                 }

                 // Validation 3 - Validate expiry date
                var utcExpiryDate = long.Parse(tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Exp).Value);
                var expiryDate = UnixTimeStampToDateTime(utcExpiryDate);

                if (expiryDate > DateTime.UtcNow)
                {
                    return new AuthResult()
                    {
                        success = false,
                        errors = new List<string>() {
                                "Token has not yet expired"
                            }
                    };
                }
                // // Validation 4 - Validate existence of the token
                var storedToken = await _apiDbContext.RefreshToken.FirstOrDefaultAsync(x => x.token == tokenRequest.refreshtoken);

                 if (storedToken == null)
                 {
                     return new AuthResult()
                     {
                         success = false,
                         errors = new List<string>()
                         {
                             "Token does not exist"
                         }
                     };
                 }

                 if (storedToken.isUsed)
                 {
                     return new AuthResult()
                     {
                         success = false,
                         errors = new List<string>()
                         {
                             "Token has been used"
                         }
                     };
                 }
                 
                 if (storedToken.isRevorked)
                 {
                     return new AuthResult()
                     {
                         success = false,
                         errors = new List<string>()
                         {
                             "Token has been revoked"
                         }
                     };
                 }
                 
                 var jti = tokenInVerification.Claims.FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti).Value;

                 if(storedToken.jwtId != jti)
                 {
                     return new AuthResult()
                     {
                         success = false,
                         errors = new List<string>()
                         {
                             "Token doesn't match"
                         }
                     };

                 }

                //update current token
                 storedToken.isUsed = true;
                 _apiDbContext.RefreshToken.Update(storedToken);
                 await _apiDbContext.SaveChangesAsync();

                 // generate new token
                 var dbUser = await _userManager.FindByIdAsync(storedToken.userId);
                 return await GenerateJwtToken(dbUser);



            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("Lifetime validation failed. The token is expired."))
                {
                     return new AuthResult()
                     {
                         success = false,
                         errors = new List<string>()
                         {
                             "Token has expired. Please re-login"
                         }
                     };

                } else {
                    
                     return new AuthResult()
                     {
                         success = false,
                         errors = new List<string>()
                         {
                             "Something went wrong"
                         }
                     };
                }
                // throw;
            }
        }

        private DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            var dateTimeVal = new DateTime(1970,1,1,0,0,0,0, DateTimeKind.Utc);
            dateTimeVal = dateTimeVal.AddSeconds(unixTimeStamp).ToUniversalTime();
            return dateTimeVal;
        }
    }
}