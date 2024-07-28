namespace WebApplication2
{
    public class ToDoItem
    {

        public int taskNum { get; set; } = 0; 

        public Boolean done { get; set; } = false; 
        public string taskName { get; set; }


        public ToDoItem(String taskName) {
            this.taskNum = taskNum; 
            this.taskName = taskName;
        }

        public void ToggleDone()
        {
            done = !done;
        }
    }
}
