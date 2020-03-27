using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyShop.Models
{
   public class RegisterViewModel
    {
        [Display(Name ="نام کاربری")]
        [Required(ErrorMessage ="لطفاْ {0} گروه را وارد کنید")]
        public string username { get; set; }

        [Display(Name ="رمز عبور")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        [DataType(DataType.Password)]
        public string pass { get; set; }

        [Display(Name ="تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        [DataType(DataType.Password)]
        [Compare("pass",ErrorMessage ="کلمه عبور با هم مغایرت دارند")]
        public string repass { get; set; }

        [Display(Name ="ایمیل")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="ایمیل وارد شده معتبر نیست")]
        public string email { get; set; }

       


    }
    public class LoginViewModel
    {

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        public string username { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]

        public bool Rememeber { get; set; }
    }
}