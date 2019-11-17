using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace 模型绑定扩展_各种类型_.Controllers
{
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {

            //int num = 2;
            List<string> list = new List<string> { "gamecc666", "gamecc777", "gameccgo" };
            
            /*  从JsonResult对象中解析数据
             int[] nums = new int[] { 1, 2, 3, 4, 9 };
             JsonResult json = new JsonResult(nums);
             var obj1 = json.Value;
             var ss = JsonConvert.SerializeObject(obj1);
             var sss = JsonConvert.DeserializeObject<int[]>(ss);
             var ssss = sss[1];
             */
          
            return View(list);
        }
    }
}
