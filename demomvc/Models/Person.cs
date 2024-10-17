using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demomvc.Models
{
    [Table("Persons")]
    public class Person
    {
        private string v1;
        private string v2;
        private string v3;

        public Person(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        [Key]
   public required string PersonId { get; set;}
   public required string FullName { get; set;}
  public required string Address { get; set;}
       
        
    }
}