using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        readonly CommentManager commentManager = new(new EfCommentRepository());


        public IViewComponentResult Invoke(int id)
        {

            var values = commentManager.GetListItem(id);
            return View(values);
        }
    }
}
