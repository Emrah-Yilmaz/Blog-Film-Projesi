using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_UI.ViewComponents.Blog
{
    public class SingleBlogRightSide:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var db = new Context();
            var categoryVmList = db.Categories.Select(x => new CategoryVm
            {
                Id = x.CategoryId,
                Name = x.CategoryName,
                ItemCount = x.Blogs.Count
            }
                                                     ).ToList();
            return View(categoryVmList);
        }
    }
}
