using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
        [HttpGet]
       public IActionResult AddTestimonial()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial p)
        {
            testimonialManager.TAdd(p);

            return RedirectToAction("Index");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var value = testimonialManager.TGetByID(id);
            if (value == null)
            {
                return NotFound();
            }

            testimonialManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditTestimonial(int id)
        {
            var values = testimonialManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditTestimonial(Testimonial testimonial)
        {
            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");
        }
    }
}
