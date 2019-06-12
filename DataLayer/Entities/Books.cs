using System;
using System.Collections.Generic;

namespace BooksWebApp.Models
{
    public partial class Books
    {
        public Books()
        {
            Sales = new HashSet<Sales>();
        }

        public int IdBook { get; set; }
        public string NameBook { get; set; }
        public int? IdTheme { get; set; }
        public int? IdAuthor { get; set; }
        public int? Price { get; set; }
        public int? DrawingOfBook { get; set; }
        public DateTime? DateOfPublish { get; set; }
        public int? Pages { get; set; }

        public virtual Authors IdAuthorNavigation { get; set; }
        public virtual Themes IdThemeNavigation { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
