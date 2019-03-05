using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabinBende.Business.Abstract;

namespace KitabinBende.MvcWeb.Controllers
{
    public class AuthorTypeController: Controller
    {
        private IAuthorService _authorService;
        public AuthorTypeController(IAuthorService authorService)
        {
            _authorService = authorService;
        }
        public ActionResult Index()
        {
           var aaa =  _authorService.GetAll();
            return View();
        }
    }
}
