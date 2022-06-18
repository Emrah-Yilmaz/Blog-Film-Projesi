using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_UI.ViewComponents.Dashboard
{
    public class DashboardCircleCategory:ViewComponent
    {
        private readonly CategoryManager categoryManager = new(new EfCategoryRepository());

       
        public IViewComponentResult Invoke()
        {
            var numberofcategories = categoryManager.GetList().Count;
            ViewBag.numberofcategories = numberofcategories;    
            return View();
        }
    }
}
