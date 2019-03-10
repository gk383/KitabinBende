using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabinBende.MvcWeb.Entities;
using KitabinBende.MvcWeb.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KitabinBende.MvcWeb.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private RoleManager<CustomIdentityRole> _roleManager;
        private SignInManager<CustomIdentityUser> _signInManager;

        public AccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager, SignInManager<CustomIdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(AccountRegisterViewModel accountRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                CustomIdentityUser user = new CustomIdentityUser
                {
                    UserName = accountRegisterViewModel.UserName,
                    Email = accountRegisterViewModel.Email,
                    BirthDate = accountRegisterViewModel.BirthDate,
                    FirstName = accountRegisterViewModel.FirstName,
                    LastName = accountRegisterViewModel.LastName,
                    PhoneNumber = accountRegisterViewModel.Phone,
                    PhotoUrl = accountRegisterViewModel.PhotoUrl,
                    GenderId = accountRegisterViewModel.GenderId,
                    EmailConfirmed = false,
                    PhoneNumberConfirmed = false
                };

                IdentityResult result =
                    _userManager.CreateAsync(user, accountRegisterViewModel.Password).Result;

                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("User").Result)
                    {
                        CustomIdentityRole role = new CustomIdentityRole
                        {
                            Name = "Admin"
                        };

                        IdentityResult roleResult = _roleManager.CreateAsync(role).Result;

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "Role eklenemedi.");
                            return View(accountRegisterViewModel);
                        }
                    }

                    _userManager.AddToRoleAsync(user, "User").Wait();
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    string errorMessage = "<ul>";
                    foreach (var item in result.Errors)
                    {

                        errorMessage += "<li>" + item.Description + "</li>";
                    }
                    errorMessage += "</ul>";
                    ViewData.Add("message", String.Format(errorMessage));
                }
            }
           
            return View(accountRegisterViewModel);
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountLoginViewModel accountLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = _signInManager.PasswordSignInAsync(accountLoginViewModel.UserName,
                    accountLoginViewModel.Password, accountLoginViewModel.RememberMe, false).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid login!");
            }

            return View(accountLoginViewModel);
        }
    }
}