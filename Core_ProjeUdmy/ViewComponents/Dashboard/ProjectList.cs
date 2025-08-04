
using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.ViewComponents.Dashboard
{
    public class ProjectList:ViewComponent
    {
        PortfolioManager portfolioManager = new(new EFPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }

    }
}
