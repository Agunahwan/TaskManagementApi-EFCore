using TaskManagementApi.Models;

namespace TaskManagementApi.Services
{
    public class TaskService : ITaskService
    {
        private static readonly List<TaskItem> Tasks = new()
        {
            new TaskItem
            {
                Id = 1,
                Title = "Learn ASP.NET Core",
                IsCompleted = false
            },
            new TaskItem
            {
                Id = 2,
                Title = "Build REST API",
                IsCompleted = false
            },
            new TaskItem
            {
                Id = 3,
                Title = "Upload YouTube Video",
                IsCompleted = true
            }
        };

        public IEnumerable<TaskItem> GetTasks()
        {
            return Tasks;
        }

        public TaskItem? GetTask(int id)
        {
            return Tasks.FirstOrDefault(x => x.Id == id);
        }

        public TaskItem CreateTask(TaskItem task)
        {
            task.Id = Tasks.Count > 0
                ? Tasks.Max(x => x.Id) + 1
                : 1;

            Tasks.Add(task);

            return task;
        }

        public bool UpdateTask(int id, TaskItem updatedTask)
        {
            var task = Tasks.FirstOrDefault(x => x.Id == id);

            if (task == null)
            {
                return false;
            }

            task.Title = updatedTask.Title;
            task.IsCompleted = updatedTask.IsCompleted;

            return true;
        }

        public bool DeleteTask(int id)
        {
            var task = Tasks.FirstOrDefault(x => x.Id == id);

            if (task == null)
            {
                return false;
            }

            Tasks.Remove(task);

            return true;
        }
    }
}