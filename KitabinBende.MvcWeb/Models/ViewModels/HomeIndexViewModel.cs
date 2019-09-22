using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabinBende.Entities.ComplexTypes;
using KitabinBende.Entities.Concrete;

namespace KitabinBende.MvcWeb.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<GetAvailableParentCategoriesResult> MainCategoryMenu { get; internal set; }
        public List<Book> NewBooks { get; internal set; }
        public List<Book> MostPopularBooks { get; internal set; }
    }
}
