using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatLesson07Annotation.Models;

namespace PatLesson07Annotation.Controllers
{
    public class PatMemberController : Controller
    {
        private static List<PatMember> patMembers = new List<PatMember>();
      
        // GET: PatMemberController
        public ActionResult Index()
        {
            return View(patMembers);
        }

        // GET: PatMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PatMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PatMember patMember)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(patMember);
                }
                
                patMembers.Add(patMember);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            var patMember = patMembers.FirstOrDefault(m => m.Id == id);
            return View(patMember);
        }

        // POST: PatMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PatMember patMember)
        {
            try
            {
                for (int i = 0; i < patMembers.Count; i++)
                {
                    if (patMembers[i].Id == id)
                    {
                        patMembers[i].Id = patMember.Id;
                        patMembers[i].PatUserName = patMember.PatUserName;
                        patMembers[i].PatPassword = patMember.PatPassword;
                        patMembers[i].PatEmail = patMember.PatEmail;
                        patMembers[i].PatPhone = patMember.PatPhone;
                        break;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PatMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatMemberController/Delete/5
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
