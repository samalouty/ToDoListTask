using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2
{
    public class CarLicense
    {
        public int Id { get; set; }
        public DateTime ExpiryDate { get; set; }

        [ForeignKey("Employee")]

        public int EmployeeID { get; set; }   // no need for foreign key here as it has the default name of [Class + attribute]

        public Employee Employee { get; set; }
    }
}
