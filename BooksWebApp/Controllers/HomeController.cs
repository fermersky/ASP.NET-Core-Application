using BooksWebApp.Models;
using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PresentationLayer;
using PresentationLayer.Models;

namespace BooksWebApp.Controllers
{
    public class HomeController : Controller
    {
        private ServicesManager _servicesManager;


        public HomeController(ServicesManager servicesManager)
        {
            _servicesManager = servicesManager;
        }

        public IActionResult Index() // main page
        {
            return View();
        }

        public IActionResult Books()
        {
            var model = _servicesManager.BooksService.GetBooksList();
            return View(model);
        }

        public IActionResult Details(int? authorId)
        {
            return View();
        }

        public IActionResult List(string genre)
        {
            //var model = _dataManager.BookRepository
            //    .GetAllBooks()
            //    .Where(b => b.IdThemeNavigation.NameTheme == genre)
            //    .ToList();

            //return View(model);

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BooksEditModel book)
        {
            book.DateOfPublish = DateTime.Now;
            
            _servicesManager.BooksService.AddBookToDataBase(book);
            return RedirectPermanent("/home/index");
        }
    }
}
