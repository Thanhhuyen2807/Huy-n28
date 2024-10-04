using Microsoft.EntityFrameworkCore;
using demomvc.Models;

namespace demomvc.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
       public DbSet<Person> Persons { get; set;}
       public DbSet<Person> Employee { get; set;}
        public DbSet<Person> Students  { get; set; }
    }
    
}
