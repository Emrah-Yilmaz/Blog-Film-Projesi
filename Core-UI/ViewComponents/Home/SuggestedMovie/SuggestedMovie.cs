using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.ViewComponents.Home.SuggestedMovie
{
    public class SuggestedMovie:ViewComponent
    {
        private readonly BlogManager blogManager = new(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = blogManager.GetListSelected(x => x.SubCategory == 2);
            return View(values);
        }
    }
}
