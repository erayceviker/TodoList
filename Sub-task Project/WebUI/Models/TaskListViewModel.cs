using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class TaskListViewModel
    {
        public List<Task> Tasks { get; set; }
        public Task Task { get; set; }
    }
}
