using BusinesLayer.Concrete;
using DataAcsessLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core_ProjeUdmy.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            // Admine mesaj atılacak
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListRecieverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            // Admine mesaj atılacak
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessager(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)

        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);

        }
        public IActionResult AdminMessageDeletei (int id)
        {
            var values = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(values);
            return RedirectToAction("SenderMessageList");

        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {

            return View();
        }
        [HttpPost]
        public  IActionResult  AdminMessageSend(WriterMessage p)
        {
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Recevier).Select(y => y.Name + "" + y.Surname).FirstOrDefault();
            p.RecevierName = usernamesurname;
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");


        }
    }
}
