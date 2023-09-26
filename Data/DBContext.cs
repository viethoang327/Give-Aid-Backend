using BackEnd.Model;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) 
        {
            
        }
        public DbSet<NGO> NGO { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Images> Images { get; set; } 
        public DbSet<Partners> Partners { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Queries> Queries { get; set; } 
        public DbSet<Admin> Admins { get; set; }

    }
}
