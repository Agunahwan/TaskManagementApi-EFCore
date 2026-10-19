using System.Collections.Generic;
using TaskManagementApi.Models;

namespace TaskManagementApi.Services
{
    public interface ITaskService
    {
        IEnumerable<TaskItem> GetTasks();

        TaskItem? GetTask(int id);

        TaskItem CreateTask(TaskItem task);

        bool UpdateTask(int id, TaskItem updatedTask);

        bool DeleteTask(int id);
    }
}