using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Moderator")]
    public class BlogController : Controller
    {
        private readonly BlogManager blogManager = new(new EfBlogRepository());
        private readonly SubsCategoryManager subsCategoryManager = new(new EfSubsCategoryRepository());
        private readonly BlogValidator blogValidator = new();

        private readonly DateTime date = DateTime.Now;
        private readonly int dayOfWeek = DateTime.Today.DayOfWeek == DayOfWeek.Sunday
             ? 7
             : (int)DateTime.Today.DayOfWeek;
        
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
                ViewBag.published = "Blog Yayında ";
                ViewBag.buton = "Yayından Kaldır";
            }
            else
            {
                ViewBag.unpublished = "Blog Yayında Değil";
                ViewBag.buton = "Yayınla";

            }
            return View(result);
        }
        [HttpPost]
        public IActionResult BlogApprovalProcess(Blog blog)
        {
            Context db = new ();
            var update = db.Blogs.Where(w => w.BlogId == blog.BlogId).FirstOrDefault();
            if (update.BlogStatus == false)
            {
                update.BlogStatus = true;
            }
            else
            {
                update.BlogStatus = false;
            }
            db.SaveChanges();
            return RedirectToAction("BlogApprovalProcess", "Blog");
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
        public IActionResult WeeklyBlog()
        {
            

            var weekly = blogManager.GetListSelected(x => x.CreateDate > date.AddDays(-dayOfWeek));
            if (weekly.Count == 0)
            {
                ViewBag.week = "Bu Hafta Blog Yayınlanmamıştır.";

            }

            return View(weekly);
        }
        public IActionResult MonthlyBlog()
        {
            ViewBag.DayOfWeek = dayOfWeek;
            DateTime firstdayofthemonth = new(DateTime.Now.Year, DateTime.Now.Month, 1);
            var monthly = blogManager.GetListSelected(x => x.CreateDate > firstdayofthemonth);
            if (monthly.Count == 0)
            {
                ViewBag.month = "Bu Ay Blog Yayınlanmamıştır.";

            }

            return View(monthly);
        }
        public IActionResult Dailyblog()
        {
            var daily = blogManager.GetListSelected(x => x.CreateDate >= date.AddDays(-1));
            if (daily.Count == 0)
            {
                ViewBag.day = "Son 24 Saatte Blog Yayınlanmamıştır.";

            }

            return View(daily);
        }
        [HttpGet]
        public IActionResult BroadcastCategory(int id)
        {
            DropList();
            var result = blogManager.GetItem(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult BroadcastCategory(Blog blog)
        {
          
                blog.CreateDate = DateTime.Now;
                blog.BlogStatus = true;
            DropList();
            blogManager.Update(blog);
            ViewBag.msg = "Blog Seçtiğiniz Yayın Kategorisine Başarıyla Atandı";
            return View();
           
           
           
        }
        private void DropList()
        {
            List<SelectListItem> categories = (from x in subsCategoryManager.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.SubCategoryName,
                                                   Value = x.SubCategory.ToString(),
                                               }).ToList();

            ViewBag.categories = categories;

        }
    }
        
    }

