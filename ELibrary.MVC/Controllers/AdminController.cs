using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELibrary.MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Rating()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Book()
        {
            return View();
        }

        public IActionResult AddBook()
        {
            return View();
        }

        public IActionResult AddUser()
        {
            return View();
        }

        public IActionResult Comment()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        public IActionResult SubCategory()
        {
            return View();
        }
    }
}
