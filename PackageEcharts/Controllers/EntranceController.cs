using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PackageEcharts.Controllers
{
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //按钮响应事件
        public IActionResult LineChartBtnEvent()
        {
            string[] xdatatype = new[] {"Mon","Tue","Wed","Thu","Fri","Sat","Sun" };
            int[] xdata = new[] {120,200,150,80,70,110,65 };

            return Json(new { xdatatype,xdata});
        }
        public IActionResult BarChartBtnEvent()
        {
            string[] xdatatype = new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            int[] xdata = new[] { 120, 200, 150, 80, 70, 110, 65 };

            return Json(new { xdatatype, xdata });
        }
        public IActionResult AreaChartBtnEvent()
        {
            string[] xdatatype = new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            int[] xdata = new[] { 120, 200, 150, 80, 70, 110, 65 };

            return Json(new { xdatatype, xdata });
        }
        public IActionResult BreadChartBtnEvent()
        {
            string[] xdatatype = new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            int[] xdata = new[] { 120, 200, 150, 80, 70, 110, 65 };

            return Json(new { xdatatype, xdata });
        }
    }
}