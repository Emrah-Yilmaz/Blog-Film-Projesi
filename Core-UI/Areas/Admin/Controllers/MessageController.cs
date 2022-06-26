using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Core_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Moderator")]
    public class MessageController : Controller
    {

        private readonly MessageManager messageManager = new(new EfMessageRepository());
        private readonly UserManager<AppUser> _userManager;

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        private Task<AppUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        public async Task< IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = messageManager.GetListSelected(
            x => x.ReceiverUsername == user.UserName);
            return View(result);
        }
        public async Task<IActionResult> Inbox(int id)
        {

            var user = await GetCurrentUserAsync();

            var result = messageManager.GetListSelected(x => x.ReceiverUsername == user.UserName && x.MessageId == id);

            return View(result);
        }
        [HttpGet]
        public IActionResult ReplyMessage(int id)
        {
            var result = messageManager.GetItem(id);
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

            messageManager.AddT(message);

            return RedirectToAction("Index","Dashboard");
        }
    }
}
