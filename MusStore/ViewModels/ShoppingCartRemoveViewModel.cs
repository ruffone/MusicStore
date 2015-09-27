using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusStore.Models;

namespace MusStore.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public string Message { get; set; }
        public decimal CartTotal { get; set; }
        public long CartCount { get; set; }
        public long ItemCount { get; set; }
        public long DeleteId { get; set; }
    }
}
