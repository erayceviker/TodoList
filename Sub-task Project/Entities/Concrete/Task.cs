using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Task : IEntity
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int ListId { get; set; }
        public string Text { get; set; }
        public bool IsCompleted { get; set; }

        [NotMapped]
        public List<Task> SubTasks { get; set; }

        public List List { get; set; }
    }
}
