using System.ComponentModel;
using System.Web.Mvc.Html;
using System.ComponentModel.DataAnnotations;

namespace MyShop.Models
{
    [DisplayName("کاربر")]
    [DisplayPluralName("کاربران")]
     class UsersMetadata
    {
        [Key]
        public int UserID { get; set; }

        [Display(Name ="نقش کاربر")]
        [Required(ErrorMessage ="لطفاْ {0} گروه را وارد کنید")]
        public int RoleID { get; set; }

        [Display(Name ="نام کاربری")]
        [Required(ErrorMessage ="لطفاْ {0} گروه را وارد کنید")]
        public string UserName { get; set; }

        [Display(Name ="رمز عبور")]
        [Required(ErrorMessage ="لطفاْ {0} گروه را وارد کنید")]
        public string Password { get; set; }

        [Display(Name ="ایمیل")]
        [Required(ErrorMessage ="لطفاْ {0} گروه را وارد کنید")]
        public string Email { get; set; }

        [Display(Name ="کد فعال سازی")]

        public string ActiveCode { get; set; }

        [Display(Name ="فعال / غیر فعال")]
        public bool IsActive { get; set; }

        [Display(Name ="تاریخ ثبت نام")]
        [DisplayFormat(DataFormatString ="{0: yyyy/MM/dd}",ApplyFormatInEditMode =true)]
        public System.DateTime CreateDate { get; set; }
    }
}