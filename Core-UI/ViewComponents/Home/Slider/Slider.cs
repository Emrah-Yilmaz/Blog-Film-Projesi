using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject_Emrah_Yilmaz.ViewComponents.Slider
{
    
    public class Slider: ViewComponent
    {
        readonly BlogManager blogManager = new(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetListSelected(x => x.SubCategory == 2);
            return View(values);

        }
    }
}
