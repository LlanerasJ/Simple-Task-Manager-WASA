namespace Simple_Task_Manager_WASA.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
