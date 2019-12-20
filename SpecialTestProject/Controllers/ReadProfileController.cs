using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
 
namespace SpecialTestProject.Controllers
{
    public class ReadProfileController : Controller
    {
        private readonly IConfiguration _configuration;
        public ReadProfileController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            string name = _configuration["name"];
            string message = _configuration["message"];
            string identity = _configuration["identity"];
            string str = "从配置文件读取的数据：name is : " + name + "||message : " + message + "||identity is : " + identity;
            Console.WriteLine(str);
            return Content(str);
        }
    }
}