using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class ListController : Controller
    {
        private  IListService _listService;

        public ListController(IListService listService)
        {
            _listService = listService;
        }

        public IActionResult AddList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddList(List list)
        {
            if (string.IsNullOrEmpty(list.Name))
            {
                return RedirectToAction("AddList");
            }
            _listService.Add(list);
            return RedirectToAction("Index", "Task");
        }


        public IActionResult UpdateList()
        {
            var model = new ListListViewModel()
            {
                Lists = _listService.GetList().Data
            };
            return View(model);
        }

        public IActionResult Deletelist(List list)
        {
            _listService.Delete(list);
            return RedirectToAction("UpdateList");
        }


        public IActionResult ChangeNameList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangeNameList(List list)
        {
            _listService.Update(list);
            return RedirectToAction("UpdateList");
        }
    }
}
