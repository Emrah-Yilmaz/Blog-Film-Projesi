using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject_Emrah_Yilmaz.ViewComponents.Home.Slider2
{
    public class Slider2:ViewComponent
    {
        readonly BlogManager blogManager = new(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetList();
            return View(values);

        }
    }
}
