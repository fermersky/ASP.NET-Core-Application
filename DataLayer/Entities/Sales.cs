using System;
using System.Collections.Generic;

namespace BooksWebApp.Models
{
    public partial class Sales
    {
        public int IdSale { get; set; }
        public int? IdBook { get; set; }
        public DateTime? DateOfSale { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public int? IdShop { get; set; }

        public virtual Books IdBookNavigation { get; set; }
        public virtual Shops IdShopNavigation { get; set; }
    }
}
