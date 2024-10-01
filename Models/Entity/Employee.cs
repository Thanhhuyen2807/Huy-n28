using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demomvc.Models.Entity
{
    [Table("Employee")]
  public class Employee
  {
    [Key]
    public string EmployeeId { get; set; }
    public required string FullName { get; set; }
    public required string Address { get; set; }
  }


}
  