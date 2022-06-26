using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Moderator")]
    public class AboutController : Controller
    {
        private readonly AboutManager aboutManager = new(new EfAboutRepository());
        private readonly AboutValidator aboutValidator = new();


        public IActionResult Edit()
        {
            var values = aboutManager.GetItem(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(About about)
        {
            ValidationResult result = aboutValidator.Validate(about);
            if (result.IsValid)
            {
                about.Id = 1;
                aboutManager.Update(about);
                ViewBag.msg = "Bilgiler Başarıyla Güncellendi";
                return View();
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
    }
}
