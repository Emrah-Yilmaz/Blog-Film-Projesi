using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject_Emrah_Yilmaz.Controllers
{
    
    public class AboutController : Controller
    {
        readonly AboutManager blogManager = new(new EfAboutRepository());
        
        public IActionResult Index()
        {
            var values = blogManager.GetList();

            return View(values);
        }
    }
}
