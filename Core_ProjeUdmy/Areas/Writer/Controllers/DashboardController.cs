using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Xml.Linq;
using DataAcsessLayer.Concrete;
using System.Reflection.Metadata;
using System.Net.Http;

namespace Core_ProjeUdmy.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {

        private readonly UserManager<WriterUser> userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            // Kullanıcı adıyla kullanıcıyı bul
            var values = await userManager.FindByNameAsync(User.Identity.Name);

          
            if (values == null)
            {
                return RedirectToAction("Index", "Login", new { area = "" });
            }

        
            ViewBag.V = values.Name + " " + values.Surname;

            // OpenWeatherMap API anahtarı ve URL'si
            string api = "ab31d645568804eadb1a08428da4dd21";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q=Ankara&appid={api}&units=metric";

            using (HttpClient client = new HttpClient())
            {
                // API'den hava durumu verisini çek
                var response = await client.GetStringAsync(url);

                // JSON verisini ayrıştır
                JObject json = JObject.Parse(response);

                // Sıcaklığı al (main objesi altındaki temp alanı)
                double temperature = json["main"]["temp"].Value<double>();

                // ViewBag'a aktar
                ViewBag.V5 = temperature.ToString();
            }

            // İstersen burada veri tabanı işlemleri de yapılabilir
            Context c = new Context();

            // Gelen mesaj sayısı
            ViewBag.V1 = c.WriterMessages.Where(x => x.Recevier == values.Email).Count();

            // Duyuru sayısı
            ViewBag.V2 = c.Announcements.Count();

            // Kullanıcı sayısı
            ViewBag.V3 = c.Users.Count();

            // Yetenek sayısı
            ViewBag.V4 = c.Skills.Count();

            return View();
        }
    }
}