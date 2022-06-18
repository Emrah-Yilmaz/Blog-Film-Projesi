using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_UI.ViewComponents.About.NumberOfCategories
{
    public class NumberOfCategories:ViewComponent
    {
        readonly CategoryManager categoryManager = new (new EfCategoryRepository());

            public IViewComponentResult Invoke()
            {
            var values = categoryManager.GetList().Count;
            ViewBag.NumberOfCategories = values;    

                return View();
            }
    }
}
