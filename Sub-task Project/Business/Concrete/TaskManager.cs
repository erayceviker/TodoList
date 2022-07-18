using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        private ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }

        public IDataResult<Task> GetById(int taskId)
        {
            return new SuccessDataResult<Task>(_taskDal.Get(t => t.Id == taskId));
        }

        public IDataResult<List<Task>> GetList()
        {
            return new SuccessDataResult<List<Task>>(_taskDal.GetList(t=> !t.ParentId.HasValue));
        }

        public IDataResult<List<Task>> GetListByList(int listId)
        {
            var tasks = _taskDal.GetList(t => t.ListId == listId);

            foreach (var task in tasks.Where(t => !t.ParentId.HasValue))
            {
                task.SubTasks = tasks.Where(t => t.ParentId == task.Id).ToList();
            }

            var result = new SuccessDataResult<List<Task>>(tasks.Where(t => !t.ParentId.HasValue).ToList());

            return result;
        }

        public IDataResult<List<Task>> GetParentListByTaskId(int taskId)
        {
            var result = new SuccessDataResult<List<Task>>(_taskDal.GetList(t=> t.ParentId == taskId));

            return result;
        }

        public IResult Add(Task task)
        {
            _taskDal.Add(task);
            return new SuccessResult(Messages.TaskAdded);
        }

        public IResult Update(Task task)
        {
            _taskDal.Update(task);
            return new SuccessResult(Messages.TaskUpdated);
        }

        public IResult Delete(Task task)
        {
            RemoveSubTasks(task);

            _taskDal.Delete(task);

            return new SuccessResult(Messages.TaskDeleted);
        }

        public IResult UpdateCompleted(Task task)
        {
            _taskDal.UpdateCompleted(task);
            return new SuccessResult(Messages.TaskUpdated);
        }

        private void RemoveSubTasks(Task parentTask)
        {
            var tasks = _taskDal.GetList(t => t.ParentId == parentTask.Id);

            foreach (var task in tasks)
            {
                _taskDal.Delete(task);
            }
        }
    }
}
