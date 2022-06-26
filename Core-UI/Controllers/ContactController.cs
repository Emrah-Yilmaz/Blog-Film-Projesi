using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;


namespace BlogProject_Emrah_Yilmaz.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
      
        readonly ContactManager contactManager = new(new EfContactRepository());
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            contact.ContactStatus = true;
            contactManager.AddT(contact);
        
            return RedirectToAction("Index");
        }
    }
}
