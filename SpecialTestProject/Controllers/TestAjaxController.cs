using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;

namespace SpecialTestProject.Controllers
{
    public class TestAjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string GetXMLFromClient()
        {
            Stream stream= HttpContext.Request.Body;
            byte[] buffer = new byte[HttpContext.Request.ContentLength.Value];
            stream.Read(buffer, 0, buffer.Length);
            string content = Encoding.UTF8.GetString(buffer);
            var _str = content;
            string numstr = "Hello Gamecc666";
            return  numstr;
        }
    }
}