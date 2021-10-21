using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using final018.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace final018.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<PaymentDetailsModel> payment_details { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {

        }

    }
}
