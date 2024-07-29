
namespace WebApplication2
{
    public class Employee
    {
        public int Id { get; set; } //Id is by default the primary key if you want to rename it use [key]

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public Department Department { get; set; }  // one employee to one department 

        public List<Project> Projects { get; set; } // one employee to many projects

       public CarLicense CarLicense { get; set; }
    }
}
