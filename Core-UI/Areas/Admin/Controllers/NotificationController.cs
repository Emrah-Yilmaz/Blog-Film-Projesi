using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Moderator")]
    public class NotificationController : Controller
    {
        private readonly NotificationManager notificationManager = new(new EfNotificationRepository());


        public IActionResult CreateNotification()
        {
            SubCategory();
            return View();
        }
        [HttpPost]
        public IActionResult CreateNotification(Notification notification)
        {


            if (notification.NotificationType == "Etkinlik")
            {
                notification.NotificationTypeSymbol = "mdi mdi-calendar";
                notification.NotificationColor = "preview-icon bg-success";
                notification.NotificationStatus = true;
                notification.NotificationDate = DateTime.Now;
            }
            else if (notification.NotificationType == "Ayarlar")
            {
                notification.NotificationTypeSymbol = "mdi mdi-calendar";
                notification.NotificationColor = "preview-icon bg-warning";
                notification.NotificationTypeSymbol = "mdi mdi-calendar";

                notification.NotificationStatus = true;
                notification.NotificationDate = DateTime.Now;
            }
            else
            {
                notification.NotificationTypeSymbol = "mdi mdi-link-variant";
                notification.NotificationColor = "preview-icon bg-info";

                notification.NotificationStatus = true;
                notification.NotificationDate = DateTime.Now;
            }
            SubCategory();
                notificationManager.AddT(notification);
                ViewBag.message = "Bildirim Gönderme İşleminiz Başarılı Bir Şekilde Gerçekleşti";
           
            return View();

        }

        private void SubCategory()
        {
            List<SelectListItem> categories = (from x in notificationManager.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.NotificationType,
                                                   Value = x.NotificationType,
                                               }).ToList();

            ViewBag.categories = categories;
        }
        public IActionResult AllNotification()
        {
            var values = notificationManager.GetList();
            return View(values);
        }
        public IActionResult DeleteNotification(int id)
        {
            var result = notificationManager.GetItem(id);
            result.NotificationStatus = false;
            notificationManager.RemoveT(result);
            return RedirectToAction("AllNotification", "Notification");
        }

    }
}
