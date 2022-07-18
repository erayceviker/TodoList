using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class AddTaskViewModel
    {
        public Task Task { get; set; }
        public List<List> Lists { get; set; }
    }
}
