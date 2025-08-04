using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            //var values = featuremanager.TGetList();
            return View();


        }
    }
}
