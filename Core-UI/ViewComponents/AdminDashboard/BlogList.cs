using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.ViewComponents.AdminDashboard
{
    public class BlogList:ViewComponent
    {
        private readonly BlogManager blogManager = new(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var result = blogManager.GetList();
            return View(result);
        }
    }
}
