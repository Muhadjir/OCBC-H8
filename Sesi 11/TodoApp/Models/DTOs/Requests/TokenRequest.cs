using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models.DTOs.Requests
{
    public class TokenRequest
    {
        [Required]
        public string token {get; set;}
        [Required]
        public string refreshtoken {get; set;}
        
    }
}