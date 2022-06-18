using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogProject_Emrah_Yilmaz.Controllers
{

    [AllowAnonymous]
    public class CommentController : Controller
    {
        

        private readonly CommentManager commentManager = new(new EfCommentRepository());
        [HttpGet]       
        public IActionResult PartialCommentAdd()
        {

            return PartialView();
        }
        [HttpPost]

        public IActionResult PartialCommentAdd(Comment comment )
        {
         
            comment.CommentStatus = true;
            comment.BlogScore = 5;
            comment.CommentDate = DateTime.Now;
            commentManager.AddT(comment);

            return RedirectToAction("SingleBlog", "Blog" , new { @id = comment.BlogId });
        }
    }
}
