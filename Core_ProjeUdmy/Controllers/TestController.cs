using BusinesLayer.Concrete;
using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.Controllers
{
    public class TestController : Controller
    {
        ExperienceManager experienceManager = new(new EfExperienceDal());
 
        public IActionResult Index()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }
    }
}
