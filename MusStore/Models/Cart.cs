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
    public class Cart
    {
        [Key]
        public long RecordId { get; set; }

        public string CartId { get; set; }

        public long AlbumId { get; set; }

        public long Count { get; set; }
        public string DateCreated { get; set; }

        public virtual Album Album { get; set; }
    }
}
