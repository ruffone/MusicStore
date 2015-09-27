using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusStore.Models
{
    public class OrdDetail
    {
           
        public long OrdDetailId { get; set; }

        public long OrdId { get; set; }
        public long AlbumId { get; set; }
        public long Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual Album Album { get; set; }
        public virtual Ord Order { get; set; }
    }
}
