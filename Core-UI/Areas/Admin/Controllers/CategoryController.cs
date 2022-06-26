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
using System.Linq;


namespace Core_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Moderator")]
    public class CategoryController : Controller
    {
        private readonly CategoryManager categoryManager = new(new EfCategoryRepository());
        private readonly BlogManager blogManager = new(new EfBlogRepository());
        private readonly CategoryValidator categoryValidator = new();

        public IActionResult AllCategories()
        {

            var db = new Context();
            var categoryVmList = db.Categories.Select(x => new CategoryVm
            {
                Id = x.CategoryId,
                Name = x.CategoryName,
                ItemCount = x.Blogs.Count
            }
                                                     ).ToList();
            return View(categoryVmList);
        }
        public IActionResult CategoryDetails(int id)
        {
            var values2 = categoryManager.GetItem(id);
            ViewBag.CategoryName = values2.CategoryName;
            var values = blogManager.GetListSelected(x => x.CategoryId == id);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
           ValidationResult result = categoryValidator.Validate(category);
            if (result.IsValid)
            {
                if (Methods.IsThereCategory(category.CategoryName) == 0)
                {
                    category.CategoryStatus = true;
                    categoryManager.AddT(category);
                    ViewBag.success = "Kategori Ekleme İşlemi Başarılı Bir Şekilde Gerçekleşti";
                    
                }
                else
                {
                    ViewBag.err = "Kayıt zaten var";

                }

            }
            else
            {

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
           
            return View();
        }
        

         public ActionResult DeleteCategory(int id, Category category)
        {
            category.CategoryId = id;
            categoryManager.RemoveT(category);
          
            return RedirectToAction("AllCategories");
        }

    }
}
