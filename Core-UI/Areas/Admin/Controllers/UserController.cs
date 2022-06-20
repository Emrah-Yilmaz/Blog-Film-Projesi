using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Amin")]

    public class UserController : Controller
    {
        
        private readonly AppUserrManager userrManager = new(new EfAppUserRepository());
        public IActionResult AllMembers()
        {

            var values = userrManager.GetList();
            return View(values);
        }
        public IActionResult ProfileDetails(int id)
        {
            ViewBag.writerId = id;
            var values = userrManager.GetListItem(id);
            return View(values);
        }
        public IActionResult Writers()
        {
            return View();
        }
        public IActionResult Moderators()
        {

            return View();
        }
        public IActionResult Admins()
        {
            return View();
        }
    }
}
