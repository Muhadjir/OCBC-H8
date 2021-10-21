using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using finalproject018.Models;

namespace finalproject018.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<PaymentDetailsModel> payment_details { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        {

        }

    }
}
