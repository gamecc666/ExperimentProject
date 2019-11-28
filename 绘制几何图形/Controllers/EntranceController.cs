using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace 绘制几何图形.Controllers
{
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}