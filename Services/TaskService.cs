using Simple_Task_Manager_WASA.Models;

namespace SimpleTaskManager.Services
{
    public class TaskService
    {
        private List<TaskItem> tasks = new();
        private int nextId = 1;

        public List<TaskItem> GetAllTasks() => tasks;

        public void AddTask(string description, string dueDate)
        {
            tasks.Add(new TaskItem
            {
                Id = nextId++,
                Description = description,
                DueDate = dueDate,
                IsCompleted = false
            });
        }

        public void ToggleComplete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null) task.IsCompleted = !task.IsCompleted;
        }

        public void DeleteTask(int id)
        {
            tasks.RemoveAll(t => t.Id == id);
        }
    }
}
