using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Созданию_приложения_для_управления_задачами
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        // Переопределяем ToString() для красивого отображения в ListBox
        public override string ToString()
        {
            string status = IsCompleted ? "✓" : "○";
            return $"{Id}: {Title} [{status}]";
        }
    }
}
