using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Amin")]

    public class CommentController : Controller
    {
        private readonly CommentManager commentManager = new(new EfCommentRepository());
        public IActionResult Index()
        {
            var values = commentManager.GetList();
            return View(values);
        }
    }
}
