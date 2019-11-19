using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace 界面局部刷新.Controllers
{
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //前台局部刷新函数加载的页面
        public IActionResult NeedPage()
        {
            return View();
        }
        public string getData()
        {
            return "{name:'张三'，age:25}";
        }
    }
}