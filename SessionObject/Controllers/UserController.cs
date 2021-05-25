using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SessionObject.Models;

namespace SessionObject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUser")))
            {
                return View("WrongData");
            }
            else
            {
                var user = JsonConvert.DeserializeObject<UserInfo>(HttpContext.Session.GetString("SessionUser"));
                return View(user);
            }
        }
    }
}
