using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.Controllers
{
    public class RatingController : Controller
    {
        private readonly RatingManager ratingManager = new(new EfRatingRepository());
        public IActionResult Index()
        {
            var values = ratingManager.GetListItem(5);
            return View(values);
        }

    }
}
