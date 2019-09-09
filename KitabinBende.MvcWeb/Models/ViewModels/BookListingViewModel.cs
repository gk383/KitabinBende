using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitabinBende.MvcWeb.Models.ViewModels
{
    public class BookListingViewModel
    {
        public List<Library> Library { get; set; }
        public Dictionary<Category, int> CategoryListForFilter { get; set; }
        public Dictionary<Language, int> LanguagesListForFilter { get; set; }
        public Dictionary<Author, int> AuthorListForFilter { get;  set; }
        public Dictionary<Publisher, int> PublisherListForFilter { get;  set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalBookCount { get; set; }
        public int PageCount { get;  set; }
        public int CurrentCategoryID { get; set; }
        public List<Category> CategoryListForBreadcrumbs { get;  set; }
    }
}
