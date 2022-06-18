using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_UI.ViewComponents.Dashboard
{
    public class DashboardWriterAbout:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private Task<AppUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        private readonly AppUserrManager appUserrManager = new(new EfAppUserRepository());

        public DashboardWriterAbout(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await GetCurrentUserAsync();
            ViewBag.username = user.UserName;
            ViewBag.createData = user.CreateData;
            ViewBag.desc = user.Description;
            ViewBag.imageUrl = user.ImageUrl;
            
            return View();
        }
    }
}
