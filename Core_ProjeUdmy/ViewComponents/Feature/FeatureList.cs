
using BusinesLayer.Concrete;
using DataAcsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {

        FeatureManager featuremanager = new(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featuremanager.TGetList();
            return View(values);


        }
    }
}
