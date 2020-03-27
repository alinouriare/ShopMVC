using System.ComponentModel.DataAnnotations;

namespace MyShop.Models
{
    internal class Product_GroupsMetadata
    {
        [Key]
        public int GroupID { get; set; }

        [Display(Name ="عنوان گروه")]
        [Required(ErrorMessage ="لطفاْ {0} گروه را وارد کنید")]
        public string GroupTitle { get; set; }
    }
}