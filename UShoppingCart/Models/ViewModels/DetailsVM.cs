using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UShoppingCart.Models.ViewModels
{
    public class DetailsVM
    {
        public DetailsVM()
        {
            Product = new Product();
        }
        public Product Product { get; set; }
        public bool ExistsInCart { get; set; } //bool flag
    }
}
