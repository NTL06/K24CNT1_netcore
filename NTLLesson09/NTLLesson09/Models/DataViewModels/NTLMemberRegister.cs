using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NTLLesson09.Models.DataViewModels
{
    //data annotation - validation
    public class NTLMemberRegister
    {
        public int NTLMemberId { get; set; }
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập ko để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tên đăng nhập có độ dài trong khoảng 2-20 ký tự")]
        public string NTLUserName { get; set; }
        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage ="Mật khẩu không dc để trống")]
        [DataType(DataType.Password)]
        public string NTLPassword { get; set; }
        public string NTLEmail { get; set; }
        public string NTLPhoneNumber { get; set; }
        public string NTLFullName { get; set; }
        public DateTime NTLBirthday { get; set; }
    }
}
