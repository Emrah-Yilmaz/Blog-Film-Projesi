using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Moderator")]
    public class UserController : Controller
    {
        
        private readonly AppUserrManager userrManager = new(new EfAppUserRepository());
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public UserController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult AllMembers()
        {

            var values = userrManager.GetList();
            return View(values);
        }
        public IActionResult ProfileDetails(int id)
        {
            ViewBag.writerId = id;
            var values = userrManager.GetListItem(id);
            return View(values);
        }
        public async Task<IActionResult> Writers()
        {
            Context db = new();
            var users = _userManager.Users;
            var useradminrole = await (from user in db.Users
                                       join userRole in db.UserRoles on user.Id equals userRole.UserId
                                       join role in db.Roles on userRole.RoleId equals role.Id
                                       where role.Name == "Writer"
                                       select user).ToListAsync();
            return View(useradminrole);
        }
        

        public async Task<IActionResult> Moderators()
        {
            Context db = new();
            var users = _userManager.Users;
            var useradminrole = await(from user in db.Users
                                      join userRole in db.UserRoles on user.Id equals userRole.UserId
                                      join role in db.Roles on userRole.RoleId equals role.Id
                                      where role.Name == "Moderator"
                                      select user).ToListAsync();
            return View(useradminrole);
        
        }
        public async Task<IActionResult> Admins()
        {
            Context db = new();
            var users = _userManager.Users;
            var useradminrole = await(from user in db.Users
                                      join userRole in db.UserRoles on user.Id equals userRole.UserId
                                      join role in db.Roles on userRole.RoleId equals role.Id
                                      where role.Name == "Admin"
                                      select user).ToListAsync();
            return View(useradminrole);
        }
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
