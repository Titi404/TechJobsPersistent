using TechJobsPersistent.Models;
using Microsoft.EntityFrameworkCore;


namespace TechJobsPersistent.Controllers
{
    public class EmployerDbContext : DbContext
    {
        public DbSet<Employer> Employers { get; set; }

        public EmployerDbContext(DbContextOptions<EmployerDbContext> options) : base(options) { }

    }
}