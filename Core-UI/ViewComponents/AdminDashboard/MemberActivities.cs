using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.ViewComponents.AdminDashboard
{
    public class MemberActivities:ViewComponent
    {
        private readonly BlogManager blogManager = new(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = blogManager.GetListSelected(filter: x => x.UserID == id);
            return View(values);
        }
    }
}
