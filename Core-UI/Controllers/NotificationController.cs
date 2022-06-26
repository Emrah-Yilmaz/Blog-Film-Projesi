using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.Controllers
{
    [Authorize(Roles = "Admin, Moderator, Writer")]

    public class NotificationController : Controller
    {
        readonly NotificationManager notificationManager = new(new EfNotificationRepository());

        public  IActionResult Index()
        {
            var result = notificationManager.GetList();
            return View(result);
        }
        public IActionResult Details(int id)
        {
            var result = notificationManager.GetListItem(id);
            return View(result);
        }
    }
}
