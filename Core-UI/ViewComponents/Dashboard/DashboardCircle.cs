using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_UI.ViewComponents.DashboardCircle
{
    public class DashboardCircle:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private Task<AppUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        private readonly  BlogManager blogManager = new (new EfBlogRepository());

        public DashboardCircle(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }



        public async Task <IViewComponentResult> InvokeAsync()
        {

            var user = await GetCurrentUserAsync();
            
            var writerblogstats = blogManager.GetListSelected(x => x.UserID == user.Id).Count;
            //var numberofcategories = blogManager.GetListWithCategory().Count;
            var numberofblogs = blogManager.GetList().Count;

            ViewBag.writerblogstats = writerblogstats;
            //ViewBag.numberofcategories = numberofcategories;
            ViewBag.numberofblogs = numberofblogs;

            return View();

        }
    }

}
