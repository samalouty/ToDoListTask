using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
//        private static int id = 0;

        private static int num = 0;

//        private static List<Employee> employees = new List<Employee>();

        private static List<ToDoItem> toDoItems = new List<ToDoItem>();


        [HttpGet("GetAllTasks")]
        public IActionResult getAllTasks()
        {
            return Ok(toDoItems);

        }

        [HttpPost("addTask")]
        public IActionResult addTask(ToDoItem toDoItem)
        {
            if (toDoItems.Count == 0)
            {
                num = 0;
            }
            num++;
            toDoItem.taskNum = num;
            toDoItems.Add(toDoItem);
            return CreatedAtAction(nameof(getAllTasks), new { taskName = toDoItem.taskName }, toDoItem);
        }


        [HttpGet("getTask")]

        public IActionResult getTask(int num)
        {
            var task = toDoItems.SingleOrDefault(x => x.taskNum == num);
            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);

        }

        [HttpPut("updateTask")]
        public IActionResult updateTask(ToDoItem updatedTask)
        {
            var task = toDoItems.SingleOrDefault(t => t.taskNum == updatedTask.taskNum);
            if (task == null)
            {
                return NotFound();
            }
            if (!string.IsNullOrEmpty(updatedTask.taskName))
            {
                task.taskName = updatedTask.taskName;
            }
            task.taskName = updatedTask.taskName;

            return Ok(updatedTask);
        }


        [HttpDelete("DeleteTask")]

        public IActionResult DeleteTask(int num)
        {
            var task = toDoItems.SingleOrDefault(t => t.taskNum == num);
            if (task == null)
            {
                return NotFound();
            }
            toDoItems.Remove(task);
            return NoContent();
        }


        /*        [HttpGet("GetEmployee")]
                public IActionResult GetAllEmployees() {
                    return Ok(employees);
                }*/
        /*
                [HttpPost("CreateEmployee")]
                public IActionResult CreateEmployee(Employee newEmployee)
                {
                    newEmployee.Id = id++;
                    employees.Add(newEmployee);
                    return CreatedAtAction(nameof(GetEmployee), new { id = newEmployee.Id }, newEmployee);
                }*/

        /* [HttpGet("getByID")]

         public IActionResult GetEmployee(int id)
         {
             var employee = employees.SingleOrDefault(x => x.Id == id);
             if (employee == null)
             {
                 return NotFound();
             }

             return Ok(employee);

         }*/

        /* [HttpDelete("DeleteEmployee")]

         public IActionResult DeleteEmployee(int id)
         {
             var employee = employees.SingleOrDefault(employee => employee.Id == id);
             if (employee == null)
             {
                 return NotFound();
             }
             employees.Remove(employee);
             return NoContent();
         }*/

        /* [HttpPut]
         public IActionResult UpdateEmployee(Employee updatedEmployee)
         {
             var employee = employees.SingleOrDefault(e => e.Id == updatedEmployee.Id);
             if (employee == null)
             {
                 return NotFound();
             }
             if (!string.IsNullOrEmpty(updatedEmployee.Name))
             {
                 employee.Name = updatedEmployee.Name;
             }
             employee.Name = updatedEmployee.Name;
             employee.Salary = updatedEmployee.Salary;

             return Ok(updatedEmployee);
         }*/

    }
}
