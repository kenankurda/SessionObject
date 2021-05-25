using Microsoft.AspNetCore.Mvc;
using SessionObject.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace SessionObject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var userInfo = new UserInfo()
            {
                Id=10023,
                Name="Timmi"
            };
            HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(userInfo));
            return View();
        }

        public IActionResult WrongData()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
