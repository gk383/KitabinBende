using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabinBende.Business.Abstract;
using KitabinBende.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace KitabinBende.MvcWeb.Controllers
{
    public class BookController : Controller
    {
        private ILibraryService _LibraryService;
        public BookController(ILibraryService libraryService)
        {
            _LibraryService = libraryService;
        }
        public IActionResult Listing()
        {
            List<Library> tList = _LibraryService.GetListing();
            return View();
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