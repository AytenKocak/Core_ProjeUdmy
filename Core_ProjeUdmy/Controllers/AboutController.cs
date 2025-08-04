
using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new(new EfAboutDal());
        [HttpGet]
        public IActionResult Index()
        {
            
            var values = aboutManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUpdate(about);
            return RedirectToAction("Index", "Default");

        }
    }
}
