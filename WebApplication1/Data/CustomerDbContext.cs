using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class CustomerDbContext : DbContext
    { 
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        { 
        }

        public DbSet<Customer> Customers { get; set; }
    }
}