using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.ViewComponents.About.NumberOfWriters
{
    public class NumberOfWriters:ViewComponent
    {
        readonly AppUserrManager appuser = new(new EfAppUserRepository());

        public IViewComponentResult Invoke()
        {
            var values = appuser.GetList().Count;
            ViewBag.NumberOfWriters = values;

            return View();
        }
    }
}
