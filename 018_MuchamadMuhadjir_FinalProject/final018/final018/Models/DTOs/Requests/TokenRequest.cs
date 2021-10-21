using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace final018.Models.DTOs.Requests
{
    public class TokenRequest
    {

        [Required]
        public string token { get; set; }
        [Required]
        public string refreshtoken { get; set; }
    }
}
