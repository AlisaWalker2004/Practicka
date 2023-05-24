using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TCompany> Companies { get; set; }
        public DbSet<TDepartament> Departaments { get; set; }
        public DbSet<TPosition> Positions { get; set; }
        public ApplicationDbContext() : base() 
        {
            Database.EnsureCreated();
        }
    }
}
