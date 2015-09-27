using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusStore.Models
{
   public class Track
    {
       public long TrackId { get; set; }
       public string Title { get; set; }
       public decimal Length { get; set; }

       public long AlbumId { get; set; }
    }
}
