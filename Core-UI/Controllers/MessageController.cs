using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UI.Controllers
{
    [Authorize(Roles = "Admin, Moderator, Writer")]

    public class MessageController : Controller
    {
        private readonly MessageManager messages = new(new EfMessageRepository());
        private readonly UserManager<AppUser> _userManager;
        private Task<AppUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }



        public async Task<IActionResult> Index()
        {


            var user = await GetCurrentUserAsync();
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = messages.GetListSelected(
            x => x.ReceiverUsername == user.UserName);

            return View(result.OrderByDescending(x => x.MessageDate));

        }

        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMessage(Message message)
        {
            var user = await GetCurrentUserAsync();
            Context context = new();
            var checkUser = context.Users.FirstOrDefault(x => x.UserName == message.ReceiverUsername);

            MessageValidator messaageValidator = new();
            ValidationResult result = messaageValidator.Validate(message);

            if (result.IsValid)
            {
                if (checkUser != null)
                {
                    message.SenderUsername = user.UserName;
                    message.SenderId = user.Id;
                    message.MessageStatus = true;
                    message.MessageDate = DateTime.Now;
                    messages.AddT(message);
                    ViewBag.success = "Mesajınızı Başarıyla Gönderildi.";
                }
                else
                {
                    ViewBag.error = "Mesaj Gönderme İşlemi Başarısız. Kullanıcı Bulunamadı";
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

        [HttpGet]
        public async Task<IActionResult> Inbox(int id)
        {
            var user = await GetCurrentUserAsync();

            var result = messages.GetListSelected(x => x.ReceiverUsername == user.UserName && x.MessageId == id);

            return View(result);
        }


        [HttpPost]
        public IActionResult Inbox(Message message, int id)
        {

            message.MessageId = id;

            messages.RemoveT(message);
            return RedirectToAction("Inbox", "Message");
        }

        [HttpGet]
        public IActionResult ReplyMessage(int id)
        {
            var result = messages.GetItem(id);
            TempData["Veri"] = result.SenderUsername;
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> ReplyMessage(Message message)
        {
            var deneme = TempData["Veri"];
            var user = await GetCurrentUserAsync();
            message.SenderUsername = user.UserName;
            message.SenderId = user.Id;
            message.MessageDate = DateTime.Now;
            message.MessageStatus = true;
            message.ReceiverUsername = deneme.ToString();

            messages.AddT(message);

            return View();
        }
    }
}
