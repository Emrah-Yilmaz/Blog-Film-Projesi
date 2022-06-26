using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.ViewComponents.UsInfo
{
    public class ContactInformation : ViewComponent
    {
        private readonly AboutManager aboutManager = new(new EfAboutRepository());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.GetList();
            return View(values);
        }
    }
}
