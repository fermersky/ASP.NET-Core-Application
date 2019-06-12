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

        public IActionResult Index()
        {
            var author = context.Authors.FirstOrDefault(a => a.IdAuthor == 1);
            return View(author);
        }
    }
}
