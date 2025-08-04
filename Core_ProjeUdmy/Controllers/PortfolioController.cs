
using BusinesLayer.Concrete;
using BusinesLayer.ValidationRules;
using DataAcsessLayer.EntityFramework;

using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new(new EFPortfolioDal());
        public IActionResult Index()
        {
          
         
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult  AddPortfolio()
        {
        
            return View();

        }
        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
          
            PortfolioValidator validations = new();
            FluentValidation.Results.ValidationResult validationResult = validations.Validate(p);

            if (validationResult.IsValid)
            {
                portfolioManager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                // Hata mesajlarını ModelState'e ekleyin
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }

                // Aynı view'a geri dönerek hataları gösterin
                return View(p);
            }
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            portfolioManager.TDelete(values);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
           
            var values = portfolioManager.TGetByID(id);
            return View(values);



        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new();
            var validationResult = validations.Validate(portfolio);

            if (validationResult.IsValid)
            {
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }

            else
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }


            }

            return View(portfolio);
        }   

    }
}
