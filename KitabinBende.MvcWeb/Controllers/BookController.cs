using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabinBende.Business.Abstract;
using KitabinBende.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using KitabinBende.MvcWeb.Models.ViewModels;


namespace KitabinBende.MvcWeb.Controllers
{
    public class BookController : Controller
    {
        private ILibraryService _LibraryService;
        public BookController(ILibraryService libraryService)
        {
            _LibraryService = libraryService;
        }
        public IActionResult Listing(int page = 1, int pageSize = 20)
        {
            List<Library> _LibraryList = _LibraryService.GetListing();
            BookListingViewModel returnData = new BookListingViewModel
            {
                Library = _LibraryList.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                CategoriesListForFilter = _LibraryService.GetCategoriesForList(_LibraryList),
                LanguagesListForFilter = _LibraryService.GetLanguagesForList(_LibraryList),
                AuthorListForFilter = _LibraryService.GetAuthorForList(_LibraryList),
                PublisherListForFilter = _LibraryService.GetPublisherForList(_LibraryList),
                PageSize = pageSize,
                PageCount = (int)Math.Ceiling(_LibraryList.Count / (double)pageSize),
                CurrentPage =page,
                TotalBookCount = _LibraryList.Count()
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