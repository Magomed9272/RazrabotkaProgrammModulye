using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Созданию_приложения_для_управления_задачами
{
    using System.Collections.Generic;

    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();
        private int nextId = 1;

        public void AddTask(Task task)
        {
            task.Id = nextId++;
            tasks.Add(task);
        }

        public void RemoveTask(int taskId)
        {
            tasks.RemoveAll(t => t.Id == taskId);
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }
    }
}
