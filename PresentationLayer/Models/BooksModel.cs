using BooksWebApp.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Models
{
    public class BooksViewModel
    {
        public int Id { get; set; }

        public string NameBook { get; set; }
        public Themes Theme { get; set; }
        public Authors Author { get; set; }
    }

    public class BooksEditModel
    {
        public int Id { get; set; }

        [Required]
        public string NameBook { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]

        public int ThemeId { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public DateTime DateOfPublish { get; set; }
    }
}