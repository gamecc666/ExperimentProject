using Microsoft.AspNetCore.Mvc;

namespace SpecialTestProject.Controllers
{
    public class MianFrameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}