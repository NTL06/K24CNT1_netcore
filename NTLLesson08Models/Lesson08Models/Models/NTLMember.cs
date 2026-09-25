using System.ComponentModel;

namespace NTLLesson08Models.Models
{
    public class NTLMember
    {
        public string NTLMemberId {  get; set; }
        public string NTLUserName { get; set; }
        public string NTLPassword {  get; set; }

        [DisplayName("Họ và Tên")]
        public string NTLFullName { get; set; }
        public string NTLEmail { get; set; }
    }
}
