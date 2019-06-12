using System;
using System.Collections.Generic;

namespace BooksWebApp.Models
{
    public partial class Country
    {
        public Country()
        {
            Authors = new HashSet<Authors>();
            Shops = new HashSet<Shops>();
        }

        public int IdCountry { get; set; }
        public string NameCountry { get; set; }

        public virtual ICollection<Authors> Authors { get; set; }
        public virtual ICollection<Shops> Shops { get; set; }
    }
}
