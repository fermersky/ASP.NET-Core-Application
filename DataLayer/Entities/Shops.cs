using System;
using System.Collections.Generic;

namespace BooksWebApp.Models
{
    public partial class Shops
    {
        public Shops()
        {
            Sales = new HashSet<Sales>();
        }

        public int IdShop { get; set; }
        public string NameShop { get; set; }
        public int? IdCountry { get; set; }

        public virtual Country IdCountryNavigation { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
