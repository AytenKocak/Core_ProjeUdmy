using Core_ProjeUdmy.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace Core_ProjeUdmy.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class LoginController : Controller
    {
        public readonly SignInManager<WriterUser> _signInManager;

        public LoginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
              
                await _signInManager.SignOutAsync();//oturum varsa kapat

             //yeni giriş
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);

                if (result.Succeeded)
                {
                    return Redirect("/Writer/Profile/Index");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kullanıcı Adı veya Şifre");
                }
            }

            return View(p);
        }

        public async Task<IActionResult>LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");

        }


    }
}
