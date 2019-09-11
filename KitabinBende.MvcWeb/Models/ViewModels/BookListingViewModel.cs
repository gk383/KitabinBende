using KitabinBende.Entities.ComplexTypes;
using KitabinBende.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitabinBende.MvcWeb.Models.ViewModels
{
    public class BookListingViewModel
    {
        private int _DefaultPageSize;
        public BookListingViewModel(int defaultPageSize)
        {
            _DefaultPageSize = defaultPageSize;
        }
        public List<Library> Library { get; set; }
        public Dictionary<Category, int> CategoryListForFilter { get; set; }
        public Dictionary<Language, int> LanguagesListForFilter { get; set; }
        public Dictionary<Author, int> AuthorListForFilter { get; set; }
        public Dictionary<Publisher, int> PublisherListForFilter { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalBookCount { get; set; }
        public int PageCount { get; set; }
        public int CurrentCategoryID { get; set; }
        public List<Category> CategoryListForBreadcrumbs { get; set; }
        public int CurrentAuthorID { get; internal set; }
        public int CurrentPublisherID { get; internal set; }
        public int CurrentLanguageID { get; internal set; }
        public int CurrentSortID { get; internal set; }
        public List<string> GetQueryStringParametes
        {
            get
            {
               List<string> returnData = new List<string>();
                returnData.Add(PageSize == _DefaultPageSize ? "" : "&pageSize=" + PageSize);
                returnData.Add(CurrentAuthorID == 0 ? "" : "&authorId=" + CurrentAuthorID);
                returnData.Add(CurrentPublisherID == 0 ? "" : "&publisherId=" + CurrentPublisherID);
                returnData.Add(CurrentLanguageID == 0 ? "" : "&languageId=" + CurrentLanguageID);
                returnData.Add(CurrentSortID == 0 ? "" : "&pageSortId=" + CurrentSortID);
                return returnData;
            }
        }

        public List<SortOption<IGrouping<Book, Library>, object>> SortOptions { get; internal set; }
    }
}
