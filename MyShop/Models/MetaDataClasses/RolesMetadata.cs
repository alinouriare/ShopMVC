using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyShop.Models
{
    [MetadataType(typeof(RolesMetadata))]
    public class RolesMetadata
    {
        [Key]
        
        public int RoleID { get; set; }

        [Display(Name = "عنوان نمایشی نقش")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        public string RoleTitle { get; set; }
        [Display(Name = "عنوان سیستمی نقش")]
        [Required(ErrorMessage = "لطفاْ {0} گروه را وارد کنید")]
        public string RoleName { get; set; }
    }
}