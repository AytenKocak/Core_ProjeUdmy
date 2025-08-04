
using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {

        ContactManager contactManager = new(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetList();
            return View(values);


        }
    }
}
