using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Core_UI.ViewComponents.AdminDashboard
{
    public class DashboardStats1:ViewComponent
    {
        private readonly BlogManager blogManager = new(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            DateTime date = DateTime.Now;
            int dayOfWeek = DateTime.Today.DayOfWeek == DayOfWeek.Sunday
                 ? 7
                 : (int)DateTime.Today.DayOfWeek;
            ViewBag.DayOfWeek = dayOfWeek;  

            DateTime firstdayofthemonth = new (DateTime.Now.Year, DateTime.Now.Month, 1);
            var monthly = blogManager.GetListSelected(x => x.CreateDate > firstdayofthemonth).Count;
            var weekly = blogManager.GetListSelected(x => x.CreateDate > date.AddDays(- dayOfWeek)).Count;
            var daily = blogManager.GetListSelected(x => x.CreateDate >= date.AddDays(-1)).Count;
            var total = blogManager.GetList().Count;

            DateTime d1 = date.AddDays(-dayOfWeek);
            ViewBag.testday = d1.ToShortDateString();
            ViewBag.today = date.ToShortDateString();
            ViewBag.monthly = monthly;
            ViewBag.weekly = weekly;
            ViewBag.daily = daily;
            ViewBag.total = total;
            
            return View();
        }
    }
}
