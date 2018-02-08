using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebApp_OpenIDConnect_DotNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var claims = ((ClaimsIdentity)User.Identity).Claims;
            return View(claims);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error(string message)
        {
            ViewBag.Message = message;
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
