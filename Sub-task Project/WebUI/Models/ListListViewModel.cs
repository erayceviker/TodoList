using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class ListListViewModel
    {
        public List<List> Lists { get; set; }
        public int CurrentList { get; set; }
    }
}
