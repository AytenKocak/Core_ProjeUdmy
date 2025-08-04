using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_ProjeUdmy.Controllers
{  
    public class DashboardController : Controller
    {
        [Authorize (Roles ="Admin")]
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
