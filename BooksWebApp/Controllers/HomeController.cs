using BooksWebApp.Models;
using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApp.Controllers
{
    public class HomeController : Controller
    {
        private DataManager _dataManager;
        

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public IActionResult Index() // main page
        {
            var authors = _dataManager.AuthorRepository.GetAllAuthors();
            return View(authors);
        }

        public IActionResult Details(int? authorId)
        {
            return View();
        }

        public IActionResult Create() // add author page
        {
            return View();
        }

        public RedirectResult AddAuthor(Authors aut) // add author page
        {
            
            return RedirectPermanent("index");
        }
    }
}
