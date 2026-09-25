using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NTLLesson09.Models.DataModels;

namespace NTLLesson09.Controllers
{
    public class NTLMemberController : Controller
    {

        private static List<NTLMember> nTLMembers = new List<NTLMember>();
        // GET: NTLMemberController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: NTLMemberController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NTLMemberController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NTLMemberController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NTLMemberController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NTLMemberController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NTLMemberController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NTLMemberController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
