using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITaskService
    {
        IDataResult<Task> GetById(int taskId);
        IDataResult<List<Task>> GetList();
        IDataResult<List<Task>> GetListByList(int listId);
        IDataResult<List<Task>> GetParentListByTaskId(int taskId);
        IResult Add (Task task);
        IResult Update (Task task);
        IResult Delete (Task task);

        IResult UpdateCompleted(Task task);
    }
}
