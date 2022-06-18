using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_UI.ViewComponents.Navbar
{
    public class DashboardNotification:ViewComponent
    {
        private readonly NotificationManager notificationManager = new (new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var notifications = notificationManager.GetList().Take(3);
            return View(notifications);
        }
    }
}
