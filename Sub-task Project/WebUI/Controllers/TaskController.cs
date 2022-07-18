using System.Collections.Generic;
using System.Diagnostics;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class TaskController : Controller
    {
        private ITaskService _taskService;
        private IListService _listService;

        public TaskController(ITaskService taskService, IListService listService)
        {
            _taskService = taskService;
            _listService = listService;
        }

        public IActionResult Index(int listId)
        {
            var model = new TaskListViewModel()
            {
                Tasks = listId > 0 ? _taskService.GetListByList(listId).Data : _taskService.GetList().Data
            };
            return View(model);
        }

        public IActionResult Detail(int taskId)
        {
            var model = new TaskListViewModel()
            {
                Tasks = _taskService.GetParentListByTaskId(taskId).Data,
                Task = _taskService.GetById(taskId).Data
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Detail(TaskListViewModel modelList)
        {
            _taskService.UpdateCompleted(modelList.Task);

            if (modelList.Tasks != null)
            {
                foreach (var task in modelList.Tasks)
                {
                    if (modelList.Task.IsCompleted == true)
                    {
                        task.IsCompleted = true;
                        _taskService.UpdateCompleted(task);
                    }
                    else
                    {
                        _taskService.UpdateCompleted(task);
                    }
                }
            }

            return RedirectToAction("Detail", new { taskId = modelList.Task.Id });
        }


        public IActionResult AddSubtask()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddSubtask(TaskViewModel model , int Id)
        {
            var task = _taskService.GetById(Id);
            model.Task.ListId = task.Data.ListId;
            model.Task.ParentId = Id;
            model.Task.IsCompleted = false;
            _taskService.Add(model.Task);
            return RedirectToAction("Detail", new { taskId = Id });
        }


        public IActionResult DeleteSubtask(int Id)
        {
            var model = new TaskListViewModel()
            {
                Tasks = _taskService.GetParentListByTaskId(Id).Data,
                Task = _taskService.GetById(Id).Data
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteSubtask(TaskViewModel model, int Id)
        {
            if (model.Task.Id != 0)
            {
                _taskService.Delete(model.Task);
            }

            if (model.Task.Id == Id)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Detail", new { taskId = Id });
        }


        public IActionResult AddTask()
        {
            var model = new AddTaskViewModel()
            {
                Lists = _listService.GetList().Data,
            };
            return View(model);
        }


        [HttpPost]
        public IActionResult AddTask(AddTaskViewModel model)
        {
            _taskService.Add(model.Task);
            return RedirectToAction("Detail", new {taskId = model.Task.Id});
        }
    }
}
