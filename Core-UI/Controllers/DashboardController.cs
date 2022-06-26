using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_UI.Controllers
{
    [Authorize(Roles = "Admin, Moderator, Writer")]
    public class DashboardController : Controller
    {
      
        public IActionResult Index()
        {
           
            return View();
        }

       
    }
}
