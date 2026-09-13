using Microsoft.AspNetCore.Mvc;
using NTLLesson07Models.Models.DataModels;

namespace NTLLesson07Models.Controllers
{

    public class NTLMemberController : Controller
    {
        //Mock data
        protected static List<NTLMember> _members = new List<NTLMember>
        {
            new NTLMember
            {
                NTLMemberId = Guid.NewGuid().ToString(),
                NTLUserName = "Ngole",
                NTLPassword = "password123",
                NTLFullName = "NGO THI LE",
                NTLEmail = "tuanlam0605@gmail.com"
            },
            new NTLMember
            {
                NTLMemberId = Guid.NewGuid().ToString(),
                NTLUserName = "tranthibinh",
                NTLPassword = "123456",
                NTLFullName = "Trần Thị Bình",
                NTLEmail = "tranthibinh@example.com"
            },
            new NTLMember
            {
                NTLMemberId = Guid.NewGuid().ToString(),
                NTLUserName = "levancuong",
                NTLPassword = "123456",
                NTLFullName = "Lê Văn Cường",
                NTLEmail = "levancuong@example.com"
            },
            new NTLMember
            {
                NTLMemberId = Guid.NewGuid().ToString(),
                NTLUserName = "phamthiduyen",
                NTLPassword = "123456",
                NTLFullName = "Phạm Thị Duyên",
                NTLEmail = "phamthiduyen@example.com"
            },
            new NTLMember
            {
                NTLMemberId = Guid.NewGuid().ToString(),
                NTLUserName = "hoangminhduc",
                NTLPassword = "123456",
                NTLFullName = "Hoàng Minh Đức",
                NTLEmail = "hoangminhduc@example.com"
            }
        };
        public IActionResult Index()
        {

            return View(_members);
        }
        public IActionResult GetMember() 
        {
            var member = new NTLMember
            {
                NTLMemberId = Guid.NewGuid().ToString(),
                NTLUserName = "Ngole",
                NTLPassword = "password123",
                NTLFullName = "NGO THI LE",
                NTLEmail = "tuanlam0605@gmail.com"

            };
            //ViewBag.Member = member;    
            return View(member);
        }
        //đưa dữ liệu dạng list ra view
        public IActionResult GetMembers()
        {
            //lấy từ mock data
            ViewBag.Members = _members;
            return View();
        }
        //get : create member
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //post:Create member
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NTLMember member)
        {
            if (ModelState.IsValid)
            {
                member.NTLMemberId = Guid.NewGuid().ToString();
                _members.Add(member);
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }
    }
}
