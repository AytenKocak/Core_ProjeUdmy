
using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.ViewComponents.Service
{
    public class ServiceList :ViewComponent
    {
        ServiceManager serviceManager = new(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var values = serviceManager.TGetList();
            return View(values);


        }
    }
}
