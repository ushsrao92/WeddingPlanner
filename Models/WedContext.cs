using Microsoft.EntityFrameworkCore;
 
namespace WedProj.Models
{
    public class WedContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public WedContext(DbContextOptions options) : base(options) { }
        public DbSet<RegUser> Users {get;set;}
        public DbSet<Wedding> Weddings {get;set;}
        public DbSet<Assoc> Assocs {get;set;}

    }
}