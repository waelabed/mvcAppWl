using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myMvcApp.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50),MinLength(4)]
        [Display(Name="Product Name")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [StringLength(1000),MinLength(20)]
        public string Descrption { get; set; }
        [DataType(DataType.Currency)]
        [Range(100,3000,ErrorMessage ="من فضلك ادخل ام ارقام من 100 الي 300")]
        public decimal? Price { get; set; }
        //[DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateAdded { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}