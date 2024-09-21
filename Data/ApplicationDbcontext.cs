using Microsoft.EntityFrameworkCore;
using demomvc.Models;

namespace demomvc.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
       public DbSet<Person> Persons { get; set;}
    }
    
}
