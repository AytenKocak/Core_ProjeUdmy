using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Core_ProjeUdmy.Areas.Writer.NewComponents
{
    public class Notification : ViewComponent
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());



        public IViewComponentResult Invoke()
        {
            var values = announcementManager.TGetList();

            return View(values);
        }

        
    }

    

}
