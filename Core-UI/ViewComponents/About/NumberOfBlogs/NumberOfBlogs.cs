using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.ViewComponents.About.NumberOfBlogs
{
    public class NumberOfBlogs:ViewComponent
    {
        readonly BlogManager blogManager = new (new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetList().Count;
            ViewBag.NumberOfBlogs = values;

            return View();
        }
    }
}
