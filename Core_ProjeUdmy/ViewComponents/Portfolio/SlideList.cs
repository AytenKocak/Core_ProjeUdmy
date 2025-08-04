
using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.ViewComponents.Portfolio
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfolioManager = new(new EFPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            return View(values);


        }
    }
   
}
