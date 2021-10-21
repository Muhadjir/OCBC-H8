using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace final018.Models
{
    public class RefreshToken
    {
        public int id { get; set; }
        public string userId { get; set; }
        public string token { get; set; }
        public string jwtId { get; set; }
        public bool isUsed { get; set; }
        public bool isRevorked { get; set; }
        public DateTime addedDate { get; set; }
        public DateTime expiryDate { get; set; }

        [ForeignKey(nameof(userId))]
        public IdentityUser user { get; set; }
    }
}
