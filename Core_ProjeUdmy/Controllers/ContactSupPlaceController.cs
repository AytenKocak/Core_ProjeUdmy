using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.Controllers
{
    public class ContactSupPlaceController : Controller
    {
        ContactManager contactManager = new(new EfContactDal());
        [HttpGet]
        public IActionResult Index()
        {

            var values = contactManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contactManager.TUpdate(contact);
            return RedirectToAction("Index", "Default");

        }
    }
}
