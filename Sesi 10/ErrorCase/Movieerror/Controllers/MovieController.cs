using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Movie.Models;
using Movie.Data;

namespace Movie.Controllers
{
    // [Route("api/[controller]")]
    // [ApiController]
    // public class MovieController : ControllerBase
    // {
        
    // }
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private ApiDbContext _context;

        public MovieController(ApiDbContext context)
        {
            this._context = context;
        }

        //get: api/user
        public ActionResult<IEnumerable<MovieData>> GetMovieData()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieData)) as MovieData;

            return _context.GetAllMovie();
        }

        //get: api/user/{id}
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<IEnumerable<MovieItem>> GetMovieItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieData)) as MovieData;

            return _context.GetMovie(id);
        }

    }

}