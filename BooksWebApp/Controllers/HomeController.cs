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
            var model = _dataManager.BookRepository.GetAllBooks();
            return View(model);
        }

        public IActionResult Books()
        {
            var model = _dataManager.BookRepository
                .GetAllBooks()
                .Take(6)
                .ToList();

            return View(model);
        }

        public IActionResult Details(int? authorId)
        {
            return View();
        }

        public IActionResult Create() // add author page
        {
            return View();
        }

        public IActionResult List(string genre)
        {
            var model = _dataManager.BookRepository
                .GetAllBooks()
                .Where(b => b.IdThemeNavigation.NameTheme == genre)
                .ToList();

            return View(model);
        }

        public RedirectResult AddAuthor(Authors aut) // add author page
        {
            return RedirectPermanent("index");
        }
    }
}
