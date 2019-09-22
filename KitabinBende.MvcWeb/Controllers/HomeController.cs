using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabinBende.Business.Abstract;
using KitabinBende.Entities.Concrete;
using KitabinBende.MvcWeb.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KitabinBende.MvcWeb.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private ILibraryService _LibraryService;
        private ICategoryService _CategoryService;
        public HomeController(ILibraryService libraryService, ICategoryService categoryService)
        {
            _LibraryService = libraryService;
            _CategoryService = categoryService;
        }

        [Route("")]
        public IActionResult Index()
        {
            //List<Library> _LibraryList = _LibraryService.GetListing();
            HomeIndexViewModel returnData = new HomeIndexViewModel()
            {
                MainCategoryMenu =_CategoryService.GetMainCategoryMenu(),
                NewBooks = _LibraryService.GetNewBooks(),
                MostPopularBooks=_LibraryService.GetMostPopularBooks()
            };
            return View(returnData);
        }
    }
}