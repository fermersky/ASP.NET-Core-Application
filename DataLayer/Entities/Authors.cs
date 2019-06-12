using System;
using System.Collections.Generic;

namespace BooksWebApp.Models
{
    public partial class Authors
    {
        public Authors()
        {
            Books = new HashSet<Books>();
        }

        public int IdAuthor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? IdCountry { get; set; }

        public virtual Country IdCountryNavigation { get; set; }
        public virtual ICollection<Books> Books { get; set; }
    }
}
