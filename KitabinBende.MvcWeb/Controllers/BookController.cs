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
        public BookController(ILibraryService libraryService, ICategoryService categoryService)
        {
            _LibraryService = libraryService;
            _CategoryService = categoryService;
        }
        [Route("Book/Listing/{categoryId}")]
        public IActionResult Listing(int categoryId, int page = 1, int pageSize = 20 )
        {
            List<Category> _categoryWithChilds = _CategoryService.GetCategoryAndAllSubCategoryIds(categoryId);
            List<Library> _LibraryList = _LibraryService.GetListing(_categoryWithChilds);
            BookListingViewModel returnData = new BookListingViewModel
            {
                Library = _LibraryList.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                CategoryListForFilter = _CategoryService.GetCategoriesForList(_LibraryList, categoryId),
                CategoryListForBreadcrumbs=_CategoryService.GetCategoryAndAllParentCategories(categoryId),
                LanguagesListForFilter = _LibraryService.GetLanguagesForList(_LibraryList),
                AuthorListForFilter = _LibraryService.GetAuthorForList(_LibraryList),
                PublisherListForFilter = _LibraryService.GetPublisherForList(_LibraryList),
                PageSize = pageSize,
                PageCount = (int)Math.Ceiling(_LibraryList.Count / (double)pageSize),
                CurrentPage =page,
                TotalBookCount = _LibraryList.Count(),
                CurrentCategoryID=categoryId
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