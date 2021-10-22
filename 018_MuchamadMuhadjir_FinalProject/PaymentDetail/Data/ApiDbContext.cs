using Microsoft.EntityFrameworkCore;
using PaymentDetail.Models;
namespace PaymentDetail.Data
{
    public class ApiDbContext : DbContext
    {
        public virtual DbSet<PaymentDetailModel> tb_payment_detail {get;set;}
        public ApiDbContext(DbContextOptions<ApiDbContext> options) 
            : base(options)
        {

        }
        
    }
}