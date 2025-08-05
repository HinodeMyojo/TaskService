using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskService.Contracts
{
    internal class TaskResponce
    {
        public Guid ID { get; set; }
        public string Title { get; set; }   
        public string? Description { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
