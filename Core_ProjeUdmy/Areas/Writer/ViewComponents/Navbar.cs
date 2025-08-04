using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Threading.Tasks;

namespace Core_ProjeUdmy.Areas.Writer.NewComponents
{
    [Area("Writer")]
    public class Navbar : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public Navbar(UserManager<WriterUser> userManager)
        {
           _userManager = userManager;
        }

        public  async Task <IViewComponentResult> InvokeAsync()

        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.V6 = values.ImageUrl;
            return View(values);
        }

    }
}
