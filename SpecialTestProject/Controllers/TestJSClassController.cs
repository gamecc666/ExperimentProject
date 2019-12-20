using Microsoft.AspNetCore.Mvc;

namespace SpecialTestProject.Controllers
{
    public class TestJSClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}