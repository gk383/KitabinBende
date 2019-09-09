using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabinBende.Business.Abstract;
using KitabinBende.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using KitabinBende.MvcWeb.Models.ViewModels;
using KitabinBende.Entities.ComplexTypes;

namespace KitabinBende.MvcWeb.Controllers
{
    public class BookController : Controller
    {
        private ILibraryService _LibraryService;
        private ICategoryService _CategoryService;
        private IAuthorService _AuthorService;
        private enum _DefaultValues
        {
            pageSize = 20
        }
        public BookController(ILibraryService libraryService, ICategoryService categoryService, IAuthorService authorService)
        {
            _LibraryService = libraryService;
            _CategoryService = categoryService;
            _AuthorService = authorService;
        }
        [Route("Book/Listing/{categoryId}")]
        public IActionResult Listing(int categoryId, int page = 1,
            int pageSize = (int)_DefaultValues.pageSize, int authorId = 0)
        {

            int _pageSize = pageSize == 0 ? (int)_DefaultValues.pageSize : pageSize;
            List<Category> _categoryWithChilds = _CategoryService.GetCategoryAndAllSubCategoryIds(categoryId);
            List<Library> _LibraryList = _LibraryService.GetListing(_categoryWithChilds, authorId);
            BookListingViewModel returnData = new BookListingViewModel((int)_DefaultValues.pageSize)
            {
                Library = _LibraryList.Skip((page - 1) * _pageSize).Take(_pageSize).ToList(),
                CategoryListForFilter = _CategoryService.GetCategoriesForList(_LibraryList, categoryId),
                CategoryListForBreadcrumbs = _CategoryService.GetCategoryAndAllParentCategories(categoryId),
                LanguagesListForFilter = _LibraryService.GetLanguagesForList(_LibraryList),
                AuthorListForFilter = _AuthorService.GetAuthorForList(_LibraryList),
                PublisherListForFilter = _LibraryService.GetPublisherForList(_LibraryList),
                PageSize = pageSize,
                PageCount = (int)Math.Ceiling(_LibraryList.Count / (double)_pageSize),
                CurrentPage = page,
                TotalBookCount = _LibraryList.Count(),
                CurrentCategoryID = categoryId,
                CurrentAuthorID = authorId
            };

            return View(returnData);
        }


        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Add()
        {

            return View();
        }

    }
}