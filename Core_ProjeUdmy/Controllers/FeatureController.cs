using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.Controllers
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new(new EfFeatureDal());
        [HttpGet]
        public IActionResult Index()
        {
           
            var values = featureManager.TGetByID(1);
            return View(values);
        }
       
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.TUpdate(feature);
            return RedirectToAction("Index", "Default");


        }
    }
}
