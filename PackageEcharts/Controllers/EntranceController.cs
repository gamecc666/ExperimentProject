using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace PackageEcharts.Controllers
{
    public class MLineModel {
        public string name = "";
        public string type = "line";
        public string stack = "总量";
        public object label = new { };
        public double[] data = new double[] { };
    }
    public class MAreaModel
    {
        public string name = "";
        public string type = "line";
        public string stack = "总量";
        public object areaStyle = new { };
        public object label = new { };
        public double[] data = new double[] { };
    }
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //单变量折线图
        public IActionResult LineChartBtnEvent()
        {
            string[] xdatatype = new[] {"Mon","Tue","Wed","Thu","Fri","Sat","Sun" };
            int[] xdata = new[] {120,200,150,80,70,110,65 };

            return Json(new { xdatatype,xdata});
        }
        //单变量柱状图
        public IActionResult BarChartBtnEvent()
        {
            string[] xdatatype = new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            int[] xdata = new[] { 120, 200, 150, 80, 70, 110, 65 };

            return Json(new { xdatatype, xdata });
        }
        //单变量面积图
        public IActionResult AreaChartBtnEvent()
        {
            string[] xdatatype = new[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            int[] xdata = new[] { 120, 200, 150, 80, 70, 110, 65 };

            return Json(new { xdatatype, xdata });
        }
        //多变量折线图&&多变量面积图（Stacked area chart/Stacked Line Chart）
        public IActionResult MoreVarChartBtnEvent(string id)
        {
            List<double[]> ddata = new List<double[]>();
            double[] d = new double[] { 120, 465, 132, 91, 23 };
            ddata.Add(d);
            double[] e = new double[] { 180, 45, 133, 921, 13 };
            ddata.Add(e);
            double[] g = new double[] { 12, 365, 13, 931, 233 };
            ddata.Add(g);

            string ctitle = "测试多元堆叠图";
            string[] ldata =new string[]{"邮件销售","联盟广告","视频广告"};
            string[] xdata = new string[] {"周一","周二","周三","周四","周五" };
            List<object> sobjarr = new List<object>();
            for (int i = 0; i < ldata.Length; i++)
            {
                if (string.Compare("area", id) == 0)
                {
                    MAreaModel obj = new MAreaModel();
                    obj.name = ldata[i];
                    obj.type = "line";
                    obj.stack = "总量";
                    obj.label = new
                    {
                        normal = new
                        {
                            show = true,
                            position = "top"
                        }
                    };
                    obj.data = ddata[i];
                    sobjarr.Add(obj);
                }
                else if(string.Compare("line",id)==0)
                {
                    MLineModel obj = new MLineModel();
                    obj.name = ldata[i];
                    obj.type = "line";
                    obj.stack = "总量";
                    obj.label = new
                    {
                        normal = new
                        {
                            show = true,
                            position = "top"
                        }
                    };
                    obj.data = ddata[i];
                    sobjarr.Add(obj);
                }                
            }
                       
            return Json(new { ctitle, ldata , xdata , sobjarr });
        }
    }
}