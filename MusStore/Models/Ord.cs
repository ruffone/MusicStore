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
    public partial class Ord
    {
        public Ord()
        {
            OrdDetails = new List<OrdDetail>();
        }
        [ScaffoldColumn(false)]
        public long OrdId { get; set; }
        [ScaffoldColumn(false)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Имя необходимо")]
        [DisplayName("Имя")]
        [StringLength(160)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Фамилия необходима")]
        [DisplayName("Фамилия")]
        [StringLength(160)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Адрес необходим")]
        [DisplayName("Адрес")]
        [StringLength(70)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Город необходим")]
        [DisplayName("Город")]
        [StringLength(40)]
        public string City { get; set; }
        [Required(ErrorMessage = "Почтовый индекс необходим")]
        [DisplayName("Почтовый индекс")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Страна необходима")]
        [DisplayName("Страна")]
        [StringLength(40)]
        public string Country { get; set; }
        [Required(ErrorMessage = "Введите телефон")]
        [DisplayName("Телефон")]
        [StringLength(24)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Введите адрес электронной почты!")]
        [DisplayName("Электронная почта")]

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email is is not valid.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }
        [ScaffoldColumn(false)]
        public string OrderDate { get; set; }

        public virtual ICollection<OrdDetail> OrdDetails { get; set; }
    }
}
