using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UI.ViewComponents.Navbar.DashboardMessage
{
    public class DashboardMessage:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private Task<AppUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        private readonly MessageManager messageManager = new(new EfMessageRepository());

        public DashboardMessage(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var user = User.Identity.Name;

            var messages = messageManager.GetListSelected(
                x => x.ReceiverUsername == user).TakeLast(3);
            return View(messages.OrderByDescending(x => x.MessageDate));
        }
    }
}
