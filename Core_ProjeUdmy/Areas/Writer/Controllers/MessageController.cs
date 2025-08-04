using BusinesLayer.Abstract;
using DataAcsessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core_ProjeUdmy.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class MessageController : Controller
    {
        private readonly IWriterMessageService _writerMessageManager;
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(IWriterMessageService writerMessageManager, UserManager<WriterUser> userManager)
        {
            _writerMessageManager = writerMessageManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> RecieverMessage()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var messageList = _writerMessageManager.GetListRecieverMessage(user.Email);
            return View(messageList);
        }

        public async Task<IActionResult> SenderMessage()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var messageList = _writerMessageManager.GetListSenderMessager(user.Email);
            return View(messageList);
        }

        
        public IActionResult MessageDetails(int id)
        {
            var writerMessage = _writerMessageManager.TGetByID(id);
            return View("MessageDetails", writerMessage);
        }
     
        public IActionResult RecieverMessageDetails(int id)
        {
            var writerMessage = _writerMessageManager.TGetByID(id);
            return View("RecieverMessageDetails", writerMessage);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View(new WriterMessage());
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(WriterMessage p)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }

            var sender = await _userManager.FindByNameAsync(User.Identity.Name);
            p.Sender = sender.Email;
            p.SenderName = sender.Name + " " + sender.Surname;
            p.Date = DateTime.Now;

            var receiver = await _userManager.FindByEmailAsync(p.Recevier);
            if (receiver == null)
            {
                ModelState.AddModelError("", "Alıcı e-posta bulunamadı.");
                return View(p);
            }

            p.RecevierName = receiver.Name + " " + receiver.Surname;

            _writerMessageManager.TAdd(p);

            return RedirectToAction("SenderMessage");
        }
    }
}