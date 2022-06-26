using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UI.ViewComponents.AdminDashboard
{
    public class UserInfo:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public UserInfo(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        private Task<AppUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Context db = new();
            var user = await GetCurrentUserAsync();
            ViewBag.username = user.UserName;
            var userinfos = db.AppUsers.Where(x => x.UserName == user.UserName).ToList();
            return View(userinfos);
        }
    }
}
