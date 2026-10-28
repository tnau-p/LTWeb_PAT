using System.ComponentModel.DataAnnotations;

namespace Lesson10_Lab2.Models
{
    public class Student
    {
        [Display(Name = "Mã sinh viên")]
        public int Id { get; set; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Họ tên bắt buộc phải nhập")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên phải có từ 4 đến 100 ký tự")]
        public string? Name { get; set; } //Họ tên

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email bắt buộc phải nhập")]
        [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
        [RegularExpression(@"^[^@\s]+@gmail\.com$", ErrorMessage = "Email phải có đuôi gmail.com")]
        public string? Email { get; set; } //Email

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Mật khẩu bắt buộc phải nhập")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có ít nhất 8 ký tự")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z\d]).+$", ErrorMessage = "Mật khẩu phải có chữ hoa, chữ thường, chữ số và ký tự đặc biệt")]
        public string? Password { get; set; }//Mật khẩu

        [Display(Name = "Ngành học")]
        [Required(ErrorMessage = "Ngành học bắt buộc phải chọn")]
        public Branch? Branch { get; set; }//Ngành học

        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Giới tính bắt buộc phải chọn")]
        public Gender? Gender { get; set; }//Giới tính

        [Display(Name = "Hệ đào tạo")]
        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq

        [Display(Name = "Địa chỉ")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải nhập")]
        public string? Address { get; set; }//Địa chỉ

        [Display(Name = "Ngày sinh")]
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage = "Ngày sinh phải nằm trong khoảng từ 01/01/1963 đến 31/12/2005")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày sinh bắt buộc phải nhập")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh

        [Display(Name = "Điểm")]
        [Required(ErrorMessage = "Điểm bắt buộc phải nhập")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
        public decimal? Score { get; set; }
    }
}
