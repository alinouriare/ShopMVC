
using System;
using System.ComponentModel.DataAnnotations;

using System.Web.Mvc;

namespace MyShop.Models
{
    internal class ProductsMetadata
    {
        [Key]
        public int ProductID { get; set; }
        [Display(Name ="گروه محصول")]
        [Required(ErrorMessage ="لطفاْ {0} گروه را وارد کنید")]
        public int GroupID { get; set; }
        [Display(Name = "عنوان محصول")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        public string ProductTitle { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        [AllowHtml]
        [DataType(DataType.MultilineText)]

        public string ProductDescription { get; set; }
        [Display(Name = "مبلغ")]
        [DisplayFormat(DataFormatString = "{0: #,0}")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        public int ProductPrice { get; set; }
        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        public string ProductImage { get; set; }

        [Display(Name = "تاریخ ثبت")]
        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}