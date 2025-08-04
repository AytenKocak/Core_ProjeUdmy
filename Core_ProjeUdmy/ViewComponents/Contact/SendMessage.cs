
using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.ViewComponents.Contact
{
    public class SendMessage :ViewComponent
    {
        MessageManager messageManager = new(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
          
      
            return View();


        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message p)
        //{
        //    p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.Status = true;
        //    messageManager.TAdd(p);
        //    return View();


        //}

    }
}
