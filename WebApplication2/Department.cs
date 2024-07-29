namespace WebApplication2
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Employee> employees { get; set; }  // one department has many employees
    }
}
