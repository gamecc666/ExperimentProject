using Microsoft.AspNetCore.Mvc;

namespace SpecialTestProject.Controllers
{
    public class MainLeftController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}