using Microsoft.AspNetCore.Mvc;

namespace SpecialTestProject.Controllers
{
    public class MainRightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}