using Microsoft.AspNetCore.Mvc;

namespace ClientStorage.Controllers
{
    public class WebStorageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}