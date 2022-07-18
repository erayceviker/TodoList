using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTaskDal: EfEntityRepositoryBase<Task,AppDbContext>,ITaskDal
    {
        public void UpdateCompleted(Task tasks)
        {
            using (AppDbContext _context = new AppDbContext())
            {
                var task = _context.Tasks.Find(tasks.Id);
                task.IsCompleted = tasks.IsCompleted;
                _context.SaveChanges();
            }
        }
    }
}
