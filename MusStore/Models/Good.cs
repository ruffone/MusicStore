using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusStore.Models
{
    public class Good
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Guitar> Guitars { get; set; }

    }
}
