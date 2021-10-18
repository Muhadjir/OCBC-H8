using Microsoft.EntityFrameworkCore;
using TodoApp.Models;
using TodoApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI;

namespace TodoApp.Data
{
    public class ApiDbContext : IdentityDbContext
    {
        public virtual DbSet<ItemData> Items {get;set;}
        public ApiDbContext(DbContextOptions<ApiDbContext> options) 
            : base(options)
        {

        }
        
    }
}