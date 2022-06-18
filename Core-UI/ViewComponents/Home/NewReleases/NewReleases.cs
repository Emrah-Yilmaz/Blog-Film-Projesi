using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject_Emrah_Yilmaz.ViewComponents.Home.NewReleases
{
    public class NewReleases:ViewComponent
    {
        readonly BlogManager blogManager = new(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetListSelected(x => x.SubCategory == 1);
            return View(values);

        }
    }
}
