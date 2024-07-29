namespace WebApplication2
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }  // one project to many employees 

    }
}
