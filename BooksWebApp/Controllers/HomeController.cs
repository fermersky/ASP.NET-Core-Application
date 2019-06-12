using BooksWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApp.Controllers
{
    public class HomeController : Controller
    {
        private PublishingHouseContext context = new PublishingHouseContext();

        public IActionResult Index() // main page
        {
            var authors = context.Authors.ToList();
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
            context.Authors.Add(aut);
            context.SaveChanges();
            return RedirectPermanent("index");
        }
    }
}
