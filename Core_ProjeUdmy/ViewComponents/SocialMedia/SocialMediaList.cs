using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.ViewComponents.SocialMedia
{
    public class SocialMediaList :ViewComponent
    {   
        public IViewComponentResult Invoke ()
             
        { SocialMediaManager socialMediaManager = new(new EfSocialMediaDal());
            var values = socialMediaManager.TGetList();
            return View(values);
        }



    }
}
