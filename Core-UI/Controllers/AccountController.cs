using Core_UI.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Core_UI.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {


        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }



        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserSignUpViewModel userSignUpViewModel)
        {
            if (!ModelState.IsValid)
            {
                AppUser user = new()
                {

                    Email = userSignUpViewModel.MailAdress,
                    UserName = userSignUpViewModel.Username,
                    NameSurname = userSignUpViewModel.NameSurname,
                    ImageUrl = "/Theme/writer/assets/images/faces/icon-account.png"


                };

                var result = await _userManager.CreateAsync(user, userSignUpViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }


            }
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserSignInViewModel userSignInViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userSignInViewModel.Username, userSignInViewModel.Password, false, true);
                if (result.Succeeded)
                {
                    HttpContext.Session.SetString("Username", userSignInViewModel.Username);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ViewBag.ErrorMessage = "Kullanıcı Adı ya da Şifre Hatalı";
                    return View();
                }
            }
            return View();
        }
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IActionResult> UserEditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new();
            model.NameSurname = values.NameSurname;
            model.Email = values.Email;
            model.ImageUrl = values.ImageUrl;
            
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> UserEditProfile(UserUpdateViewModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.Email = model.Email; 
            values.ImageUrl = model.ImageUrl;
            values.NameSurname = model.NameSurname;
            values.ImageUrl = model.ImageUrl;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.Password);
            var result = await _userManager.UpdateAsync(values);


            return RedirectToAction("Index","Dashboard");   
        }
       
    }
}
