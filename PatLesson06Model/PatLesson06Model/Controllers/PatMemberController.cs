using Microsoft.AspNetCore.Mvc;
using PatLesson06Model.Models;

namespace PatLesson06Model.Controllers
{
    public class PatMemberController : Controller
    {
        //mock data 
        private static readonly List<PatMember> _patMembers = new List<PatMember>()
        {

            new PatMember
            {
                PatMemberId = Guid.NewGuid().ToString(),
                PatMemberUserName = "tuan01",
                PatMemberPassword = "123456",
                PatMemberFullName = "Phạm Anh Tuấn",
                PatMemberEmail = "tuan123@gmail.com"
            },

            new PatMember
            {
                PatMemberId = Guid.NewGuid().ToString(),
                PatMemberUserName = "nguyenan",
                PatMemberPassword = "123456",
                PatMemberFullName = "Nguyễn Văn An",
                PatMemberEmail = "an@gmail.com"
            },

            new PatMember
            {
                PatMemberId = Guid.NewGuid().ToString(),
                PatMemberUserName = "tranbinh",
                PatMemberPassword = "123456",
                PatMemberFullName = "Trần Văn Bình",
                PatMemberEmail = "binh@gmail.com"
            },

            new PatMember
            {
                PatMemberId = Guid.NewGuid().ToString(),
                PatMemberUserName = "leminh",
                PatMemberPassword = "123456",
                PatMemberFullName = "Lê Minh Đức",
                PatMemberEmail = "minhduc@gmail.com"
            },

            new PatMember
            {
                PatMemberId = Guid.NewGuid().ToString(),
                PatMemberUserName = "phamhoa",
                PatMemberPassword = "123456",
                PatMemberFullName = "Phạm Thị Hoa",
                PatMemberEmail = "hoa@gmail.com"
            }
        };
        //get list

        public IActionResult PatIndex()
        {
            return View(_patMembers);
        }

        /// <summary>
        /// create 
        /// </summary>
        /// <returns></returns>
        public IActionResult Patcreate()
        {
            return View();
        }
        /// <summary>
        /// create - submit form 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult PatCreate(PatMember patMember)
        {
            patMember.PatMemberId = Guid.NewGuid().ToString();
            _patMembers.Add(patMember);
            return RedirectToAction(nameof(PatIndex));
        }
        public IActionResult PatGetDetails()
        {
            var patMember = new PatMember() { 
                PatMemberId = Guid.NewGuid().ToString(),
                PatMemberUserName = "anhtuan",
                PatMemberEmail= "tuan123@gmail.com",
                PatMemberPassword = "tuan123",
                PatMemberFullName = "pham anh tuan"
                
            };
            return View(patMember);
        }
    }
}
