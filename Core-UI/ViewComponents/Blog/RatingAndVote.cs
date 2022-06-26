using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.ViewComponents.Blog
{
    public class RatingAndVote : ViewComponent
    {
        private readonly RatingManager ratingManager = new(new EfRatingRepository());
        public IViewComponentResult Invoke(int id)
        {

            var values = ratingManager.GetListItem(id);
            return View(values);
        }


    }
}
