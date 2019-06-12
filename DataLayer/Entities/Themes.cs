using System;
using System.Collections.Generic;

namespace BooksWebApp.Models
{
    public partial class Themes
    {
        public Themes()
        {
            Books = new HashSet<Books>();
        }

        public int IdTheme { get; set; }
        public string NameTheme { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
