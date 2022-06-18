using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_UI.ViewComponents.Dashboard
{
    public class DashboardBlogListByWriter:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private Task<AppUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        private readonly BlogManager blogManager = new(new EfBlogRepository());
        public DashboardBlogListByWriter(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
         var user = await GetCurrentUserAsync();
        var bloglist = blogManager.GetListSelected(x => x.UserID == user.Id);
            return View(bloglist);
        }
       
    }
}
