using Microsoft.EntityFrameworkCore;
using Vira.Technical.Interview.Models.Entites;

namespace Viraap.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
