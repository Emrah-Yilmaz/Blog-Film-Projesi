using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private readonly BlogManager blogManager = new(new EfBlogRepository());

        public IActionResult BlogDetails(int id )
        {
            var values = blogManager.GetListItem(id);
            return View(values);  
        }
        public IActionResult BlogApprovalProcess(int id)
        {
            TempData["appid"] = id;
            var result = blogManager.GetItem(id);
            if (result.BlogStatus == true)
            {
                ViewBag.published = "Blog Yayında";
            }
            else
            {
                ViewBag.unpublished = "Blog Yayında Değil";
            }
            return View(result);
        }
        [HttpPost]
        public IActionResult BlogApprovalProcess(Blog blog)
        {
            Context db = new Context();
            var update = db.Blogs.Where(w => w.BlogId == blog.BlogId).FirstOrDefault();
            if (update.BlogStatus == false)
            {
                update.BlogStatus = true;
                ViewBag.approvalMessage = "Blog Yayınlama İşlemi Başarılı Bir Şekilde Gerçekleşti";
            }
            else
            {
                update.BlogStatus = false;
                ViewBag.approvalMessage = "Blog  Başarılı Bir Şekilde Yayından Kaldırıldı";
            }
            db.SaveChanges();
            return RedirectToAction("BlogApprovalProcess", "Admin");
        }
        public IActionResult AllBlog()
        {
            var values = blogManager.GetList();
            return View(values);
        }
        public IActionResult PublishedBlog()
        {
            var values = blogManager.GetListSelected(filter: x => x.BlogStatus == true);
            return View(values);
        }
        public IActionResult UnpublishedBlog()
        {
            var values = blogManager.GetListSelected(filter: x => x.BlogStatus == false);
            return View(values);
        }
      
    }
}
