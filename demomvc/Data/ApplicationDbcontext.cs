using Microsoft.EntityFrameworkCore;
using demomvc.Models;

namespace demomvc.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
<<<<<<< HEAD
        public DbSet<Persons> Person { get; set;}
    }

    public class Persons
    {
    }
=======
       public DbSet<Person> Persons { get; set;}
       public DbSet<Person> Employee { get; set;}
        public DbSet<Person> Students  { get; set; }
    }
    
>>>>>>> parent of fc2878c (commit note)
}
