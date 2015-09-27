using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Web.Mvc;

namespace MusStore.Models
{
   public class Album
    {
       public Album() 
       {
           Tracks = new List<Track>();
           OrdDetails = new List<OrdDetail>();
       }
       [ScaffoldColumn(false)]
       public long AlbumId { get; set; }

       [DisplayName("Название"), Required(ErrorMessage= "Введите название!")]
       public string Title { get; set; }
       
       [DisplayName("Цена"),Range(0.01, 10000, ErrorMessage = "Цена должна быть не меньше нуля!")]
       public decimal Price { get; set; }

       [DisplayName("Жанр")]
       public long GenreId { get; set; }
       
       //[ForeignKey("GenreId")]
       public virtual Genre Genre { get; set; }

       //[ForeignKey("ArtistId")]
       [DisplayName("Исполнитель")]
       public long ArtistId { get; set; }

       //[ForeignKey("ArtistId")]
       public virtual Artist Artist { get; set; }

       public virtual ICollection<Track> Tracks { get; set; }

       [DisplayName("Веб-сайт исполнителя"), StringLength(1024)]
       public string URL { get; set; }

       [DisplayName("В наличии")]
       public long Stock { get; set; }

       public virtual ICollection<OrdDetail> OrdDetails { get; set; }

    }
}
