using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace 前台调用后台方法扩展.Controllers
{
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.classInstance = this;
            return View();
        }        

        public string GetUserName(int num)
        {
            return "gameccc666";
        }
    }
}