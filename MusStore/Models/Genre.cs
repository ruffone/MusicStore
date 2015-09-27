using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusStore.Models
{
    public class Genre
    {
        public Genre()
        {
            Albums = new List<Album>();
        }
        public long GenreId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }       
    }
}
