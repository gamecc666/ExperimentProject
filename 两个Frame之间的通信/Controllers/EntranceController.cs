using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace 两个Frame之间的通信.Controllers
{
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FirstFrame()
        {
            return View();
        }
        public IActionResult SecondFrame()
        {
            return View();
        }
    }
}