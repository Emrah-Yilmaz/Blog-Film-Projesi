using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Moderator")]
    public class Contact : Controller
    {
        private readonly ContactManager contacManager = new(new EfContactRepository());
        public IActionResult Index()
        {
            var values = contacManager.GetList();
            return View(values);
        }
        public IActionResult Inbox(int id)
        {
            var values = contacManager.GetListItem(id);
            return View(values);  
        }
    }
}
