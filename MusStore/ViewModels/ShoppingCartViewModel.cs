using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusStore.Models;

namespace MusStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel()
        {
            CartItems = new List<Cart>();
        }
        public IEnumerable<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}
