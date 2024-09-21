using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demomvc.Models
{
  [Table("Persons")]
  public class Person
  {
    [Key]
    public required string PersonId { get; set; }
    public required string FullName { get; set; }
    public required string Address { get; set; }


  }
}