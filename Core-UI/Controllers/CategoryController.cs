using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogProject_Emrah_Yilmaz.Controllers
{
    public class CategoryController : Controller
    {
       readonly CategoryManager categoryManager = new(new EfCategoryRepository());
       readonly BlogManager blogManager = new(new EfBlogRepository());
        [AllowAnonymous]
        public IActionResult Index()
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

        [AllowAnonymous]
        public IActionResult CategoryDetails(int id)
        {
            var values2 = categoryManager.GetItem(id);
            ViewBag.CategoryName = values2.CategoryName;
            var values = blogManager.GetListSelected(x => x.CategoryId == id);
            

            return View(values);

        }

    }
}
