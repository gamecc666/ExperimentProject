using Microsoft.AspNetCore.Mvc;

namespace ClientStorage.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}