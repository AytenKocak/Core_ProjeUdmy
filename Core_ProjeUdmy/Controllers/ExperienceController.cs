
using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.Controllers
{
    //[/*Authorize(Roles="Admin")]//Bu Sayfaya sadece rolü Admin olan erişim sağlayacak*/
    public class ExperienceController : Controller
    {
        ExperienceManager experienceManager = new(new EfExperienceDal());
   
        public IActionResult Index()
        {
           
            var values = experienceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {


            return View();
        }
       [ HttpPost]
         public IActionResult AddExperience(Experience experience)
         {
            experienceManager.TAdd(experience);
            return RedirectToAction("Index");
         }
 
        [HttpGet]
        public IActionResult DeleteExperience(int id)
        {
            var values = experienceManager.TGetByID(id);
            experienceManager.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {  
            var values = experienceManager.TGetByID(id);
            return View(values);

        
        }
        [HttpPost]
        public IActionResult EditExperience(Experience experience)
        {
            experienceManager.TUpdate(experience);
            return RedirectToAction("Index");


        }

    }
}
