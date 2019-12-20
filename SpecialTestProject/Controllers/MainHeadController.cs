using Microsoft.AspNetCore.Mvc;

namespace SpecialTestProject.Controllers
{
    public class MainHeadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}