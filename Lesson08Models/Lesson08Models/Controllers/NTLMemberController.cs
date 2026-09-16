using Microsoft.AspNetCore.Mvc;
using NTLLesson08Models.Models;

namespace NTLLesson08Models.Controllers
{
    public class NTLMemberController : Controller
    {
        //mock data - NTLMember
        private static List<NTLMember> _member = new List<NTLMember>()
        {
             new NTLMember
             {
                 NTLMemberId = Guid.NewGuid().ToString(),
                 NTLUserName = "TN Le",
                 NTLPassword = "Password123!",
                 NTLFullName = "Ngô Thị Lệ",
                 NTLEmail = "tuanlam0605@gmail.com"
             },
             new NTLMember
             {
                 NTLMemberId = Guid.NewGuid().ToString(),
                 NTLUserName = "tranthib",
                 NTLPassword = "SecurePass456",
                 NTLFullName = "Trần Thị B",
                 NTLEmail = "tranthib@outlook.com"
             },
             new NTLMember
             {
                 NTLMemberId = Guid.NewGuid().ToString(),
                 NTLUserName = "levanc",
                 NTLPassword = "MyPassword789",
                 NTLFullName = "Lê Văn C",
                 NTLEmail = "levanc@company.com"
             }
        };

        //get: danh sách thành viên
        public IActionResult Index()
        {
            return View(_member);
        }

        [HttpGet]
        public IActionResult NTLCreate()
        {
            var member = new NTLMember();
            return View(member);
        }

        [HttpPost]
        public IActionResult NTLCreate(NTLMember nTLMember)
        {
            nTLMember.NTLMemberId = Guid.NewGuid().ToString();
            _member.Add(nTLMember);
            return RedirectToAction("Index");
            //return view(nTLMember)
        }

        [HttpGet]
        public IActionResult NTLEdit(string id)
        {
            var member = _member.Where(x=>x.NTLMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult NTLEdit(string id, NTLMember nTLMember)
        {
            //var member = _member.Where(x => x.NTLMemberId.Equals(id)).FirstOrDefault();
            for(int i=0;i< _member.Count ;i++)
            {
                if (_member[i].NTLMemberId==id)
                {
                    _member[i].NTLUserName = nTLMember.NTLUserName;
                    _member[i].NTLPassword= nTLMember.NTLPassword;
                    _member[i].NTLFullName = nTLMember.NTLFullName;
                    _member[i].NTLEmail= nTLMember.NTLEmail;

                    return RedirectToAction("Index");
                }    
            }
            return View();
        }
        [HttpGet]
        public IActionResult NTLDetails(string id)
        {
            var member = _member.Where(x => x.NTLMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpGet]
        public IActionResult NTLDelete(string id)
        {
            var member = _member.Where(x => x.NTLMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult NTLDeleted(string id)
        {
            foreach(var item in _member){
                if (item.NTLMemberId.Equals(id))
                {
                    _member.Remove(item);
                    return RedirectToAction("Index");
                }
            }
            return View("NTLDelate");
        }
    }
}
