using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using Core_UI.MyMethods;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BlogProject_Emrah_Yilmaz.Controllers
{
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private Task<AppUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        readonly BlogManager blogManager = new(new EfBlogRepository());
        readonly CategoryManager categoryManager = new(new EfCategoryRepository());
        private readonly BlogValidator blogValidator = new();


        public BlogController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [AllowAnonymous]
        public IActionResult Index(int page = 1)
        {
            var values = blogManager.GetList().ToPagedList(page, 3);
            return View(values);
        }
        [AllowAnonymous]
        public IActionResult SingleBlog(int id)
        {
            ViewBag.id = id;
            var values = blogManager.GetListItem(id);

            return View(values);
        }
        public IActionResult PopularFilms()
        {
            var values = blogManager.GetListSelected(x => x.SubCategory == 4);
            return View(values);
        }
        public IActionResult NewReleases()
        {
            var values = blogManager.GetListSelected(x => x.SubCategory == 1);
            return View(values);
        }
        private void DropList()
        {
            List<SelectListItem> categories = (from x in categoryManager.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString(),
                                               }).ToList();

            ViewBag.categories = categories;
        }
        [Authorize(Roles = "Admin, Moderator, Writer")]

        [HttpGet]
        public IActionResult DashboardCreateBlog()
        {
            
            DropList();
            return View();
        }
        [Authorize(Roles = "Admin, Moderator, Writer")]
        [HttpPost]
        public async Task<IActionResult> DashboardCreateBlog(Blog blog)
        {
            var user = await GetCurrentUserAsync();
            ValidationResult result = blogValidator.Validate(blog);
            if (result.IsValid)
            {
                if (Methods.IsThereBlog(blog.BlogTitle)==0)
                {
                    blog.BlogStatus = false;
                    blog.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    blog.UserID = user.Id;
                    blogManager.AddT(blog);

                    ViewBag.added = "Ekleme işlemi başarılı bir şekilde gerçekleşti ";
                    DropList();
                    return View();
                }
                else
                {
                    ViewBag.err = "Bu İsimde Bir Blog Zaten Var";
                }
               
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }


            }
            DropList();
            return View();


        }
        [Authorize(Roles = "Admin, Moderator, Writer")]
        public async Task<IActionResult> DashboardMyBlog()
        {
            var user = await GetCurrentUserAsync();
            var bloglist = blogManager.GetListSelected(x => x.UserID == user.Id).ToList();
            return View(bloglist);
        }

        [Authorize(Roles = "Admin, Moderator, Writer")]
        public IActionResult DashboardEditBlog(int id)
        {

            List<SelectListItem> categories = (from x in categoryManager.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString(),
                                               }).ToList();

            ViewBag.categories = categories;
            var result = blogManager.GetItem(id);
            return View(result);
        }
        [Authorize(Roles = "Admin, Moderator, Writer")]
        [HttpPost]
        public async Task<IActionResult> DashboardEditBlog(Blog blog)
        {
            var user = await GetCurrentUserAsync();
            //if (user == null)
            //{
            //    return RedirectToAction("Index", new { Message = "Hata ile karşılaşıldı" });
            //}
            ValidationResult result = blogValidator.Validate(blog);
            if (result.IsValid)
            {
                blog.UserID = user.Id;
                blog.CreateDate = DateTime.Now;
                blog.BlogStatus = true;
                blogManager.Update(blog);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            DropList();
            return View();



        }

        [Authorize(Roles = "Admin, Moderator, Writer")]
        public IActionResult DeleteBlog(int id)
        {
            var result = blogManager.GetItem(id);
            result.BlogStatus = false;
            blogManager.Update(result);
            return RedirectToAction("DashboardMyBlog", "Blog");
        }
        public IActionResult ReloadBlog(int id)
        {
            var result = blogManager.GetItem(id);
            result.BlogStatus = true;
            blogManager.Update(result);
            return RedirectToAction("DashboardMyBlog", "Blog");
        }

        [Authorize(Roles = "Admin, Moderator, Writer")]
        [HttpPost]
        public IActionResult Search(Blog blog)
        {
            Context db = new();
            var result = db.Blogs.Where(c => c.BlogTitle.Contains(blog.BlogTitle)).ToList();

            return View(result);
        }

    }

}
