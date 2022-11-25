using Microsoft.EntityFrameworkCore;
using yep.Models.Domain;

namespace yep.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees {get;set;}
    }
}
