using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabinBende.Entities.Concrete;

namespace KitabinBende.MvcWeb.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public Dictionary<Category, int> CategoryListForFilter { get; internal set; }
    }
}
