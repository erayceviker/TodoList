using System;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using WebUI.Models;

namespace WebUI.ViewComponents
{
    public class ListListViewComponent : ViewComponent
    {
        private IListService _listService;

        public ListListViewComponent(IListService listService)
        {
            _listService = listService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new ListListViewModel()
            {
                Lists = _listService.GetList().Data,
                CurrentList = Convert.ToInt32(HttpContext.Request.Query["listId"])
            };
            return View(model);
        }
    }
}
