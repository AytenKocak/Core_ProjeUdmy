using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.Controllers
{
    public class SkillController : Controller
    {
        SkillManager skillManager = new(new EfSkillDal());
        public IActionResult Index()
        {
           
            var values = skillManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
                   
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.TAdd(skill); 
            return RedirectToAction("Index");
        }
        //[HttpPost]
        public IActionResult DeleteSkill( int id)
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditSkill(int id )
        {
            var values = skillManager.TGetByID(id);
            return View (values);
         
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
        
    }
}
