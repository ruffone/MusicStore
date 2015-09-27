using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusStore.Models
{
    public class Guitar
    {
        public Int64 Id{ get; set;    }
        public string Name {get; set; }
        public int StringsCount {get; set; }
        public string Color {get; set; }
        public string Wood { get; set; }
        public Int64 goodId  { get; set; }
    }
}
