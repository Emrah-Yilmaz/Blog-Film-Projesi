using Microsoft.AspNetCore.Mvc;

namespace Core_UI.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
       
    }
}
