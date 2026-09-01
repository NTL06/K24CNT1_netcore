using Microsoft.AspNetCore.Mvc;
using NTLLesson04Lab.Models;

namespace NTLLesson04Lab.Controllers
{
    public class NTLAccountController : Controller
    {
        private readonly List<NTLAccount> nTLAccount = new()
        {
            new NTLAccount
            {
                Id = 1,
                Name = "Nguyễn Văn An",
                Email = "an.nguyen@example.com",
                Phone = "0901234567",
                Avatar = "/images/anh3.jpg",
                Address = "123 Đường Lê Lợi, Quận 1, TP. Hồ Chí Minh",
                Bio = "Kỹ sư phần mềm đam mê công nghệ và du lịch.",
                Gender = 1,
                Birthday = new DateTime(1995, 5, 15)
            },

            new NTLAccount
            {
                Id = 2,
                Name = "Trần Thị Bích",
                Email = "bich.tran@example.com",
                Phone = "0912345678",
                Avatar = "/images/anh4.jpg",
                Address = "45 Đường Cầu Giấy, Quận Cầu Giấy, Hà Nội",
                Bio = "Chuyên viên Marketing sáng tạo và yêu thích nghệ thuật.",
                Gender = 0,
                Birthday = new DateTime(1998, 8, 22)
            },

            new NTLAccount
            {
                Id = 3,
                Name = "Lê Hoàng Nam",
                Email = "nam.le@example.com",
                Phone = "0923456789",
                Avatar = "/images/anh1.jpg",
                Address = "78 Đường Hải Phòng, Quận Hải Châu, Đà Nẵng",
                Bio = "Tự do, thích đi du lịch và cà phê.",
                Gender = 1,
                Birthday = new DateTime(1992, 11, 30)
            },

            new NTLAccount
            {
                Id = 4,
                Name = "Phạm Minh Châu",
                Email = "chau.pm@example.com",
                Phone = "0934567890",
                Avatar = "/images/anh2.jpg",
                Address = "12 Đường Nguyễn Văn Linh, Quận Ninh Kiều, Cần Thơ",
                Bio = "Yêu du lịch, quan tâm đến khởi nghiệp và công nghệ.",
                Gender = 0,
                Birthday = new DateTime(1990, 3, 10)
            },

            new NTLAccount
            {
                Id = 5,
                Name = "Hoàng Quốc Dũng",
                Email = "dung.hoang@example.com",
                Phone = "0945678901",
                Avatar = "/images/anh3.jpg",
                Address = "56 Đường Quang Trung, TP. Nha Trang, Khánh Hòa",
                Bio = "Chuyên văn tích cực, thích chơi bóng rổ.",
                Gender = 1,
                Birthday = new DateTime(1997, 12, 5)
            }
        };


        // Trang danh sách tài khoản
        public IActionResult NTLIndex()
        {
            ViewBag.NTLAccount = nTLAccount;

            return View();
        }


        // Trang Profile
        [Route("ho-so-cua-toi", Name = "NTLProfile")]
        public IActionResult NTLProfile(int? id)
        {
            // Mặc định hiển thị tài khoản số 5
            NTLAccount profile = nTLAccount[4];

            // Nếu có id thì tìm tài khoản tương ứng
            if (id != null)
            {
                var account = nTLAccount.FirstOrDefault(x => x.Id == id);

                if (account != null)
                {
                    profile = account;
                }
            }

            ViewBag.NTLAccount = profile;

            return View();
        }
    }
}