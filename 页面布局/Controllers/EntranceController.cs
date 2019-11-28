using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace 页面布局.Controllers
{
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}