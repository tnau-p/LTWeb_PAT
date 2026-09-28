using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PatLesson07Annotation.Models
{
    /// <summary>
    ///model class member
    /// author pham anh tuan
    /// </summary>
    public class PatMember
    {
       
        public int Id { get; set; }
        [DisplayName("tai khoan")]
        [Required(ErrorMessage = "tai khoan khong duoc de trong")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "tai khoan tu 3 den 20 ky tu")]
        public string PatUserName { get; set; }
        [DisplayName("mat khau")]
        [Required(ErrorMessage = "mat khau khong duoc de trong")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "mat khau toi thieu 8 ky tu")]
        public string PatPassword { get; set; }
        [DisplayName("email")]
        [Required(ErrorMessage = "email khong duoc de trong")]
        [EmailAddress(ErrorMessage = "dia chi email khong hop le")]
        public string PatEmail { get; set; }
        [DisplayName("so dien thoai")]
        [Required(ErrorMessage = "so dien thoai khong duoc de trong")]
        [RegularExpression(@"^0\d{9,9}$",ErrorMessage = "so dien thoai khong hop le")]
        public string PatPhone { get; set; }

    }
}
