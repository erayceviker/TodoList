using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ITaskDal: IEntityRepository<Task>
    {
        public void UpdateCompleted(Task task);
    }
}
