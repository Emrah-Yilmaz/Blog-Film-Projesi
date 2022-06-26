using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject_Emrah_Yilmaz.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        readonly AboutManager aboutManager = new(new EfAboutRepository());

        public IActionResult Index()
        {
            var values = aboutManager.GetList();

            return View(values);
        }
    }
}
