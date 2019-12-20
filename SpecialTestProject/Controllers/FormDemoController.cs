using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpecialTestProject.Models;
using SpecialTestProject.PublicClass;
using PER = SpecialTestProject.Models.Persion;

namespace SpecialTestProject.Controllers
{
    public class FormDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([ModelBinder]PER str)
        {
            return RedirectToAction("Index");
        }
        public IActionResult GetPersionData()
        {
            LogHelper.Logger.Trace("gamecc----打印Trace日志！");
            LogHelper.Logger.Debug("gamecc----打印Debug日志");
            LogHelper.Logger.Info("gamecc----打印Info日志");
            LogHelper.Logger.Warn("gamecc----打印Warn日志");
            LogHelper.Logger.Error("gamecc----打印Error测试日志");
            LogHelper.Logger.Fatal("gamecc----打印Fatal测试日志");
            return View();
        }        
        [HttpPost]
        public IActionResult GetPersionData([ModelBinder] PER obj)
        {
            return Content("Hello gamecc666");
        }

        //解决从视图传递参数的时候不需要绑定即可实现
        [HttpPost]
        public async  Task<IActionResult> GetPersion()
        {
            var _per = new PER();
            bool update = await TryUpdateModelAsync(_per);


            if (update)
            {
                return Content("**********************************************************\n测试成功");
            }
            else
            {
                
                return Content("**********************************************************\n测试失败，请重新测试！！！");
            }               
        }
        [HttpPost]
        public void TestFormData([ModelBinder] Animation anim)
        {
            if(ModelState.IsValid)
            {
                Console.WriteLine("------------------模型无效");
            }
            else
            {
                Console.WriteLine("------------------模型有效");
            }
            string _name = anim.A_Name;
            string _sex = anim.A_Sex;
            int _age = Convert.ToInt32(anim.A_Age);
            string _eat = anim.A_Eat;
        }
        [HttpPost]
        public void TestHttpRequest()
        {
            var _count = Request.Form.Count;
            List<string> listvalue = new List<string>();
            List<string> listkey = new List<string>();

            foreach(var key in Request.Form.Keys)
            {
                var s= Request.Form[key];
                listvalue.Add(s);
                listkey.Add(key);
            }

            var ss = listvalue;
            var dd = listkey;
            //var _bodydata = Request.Body;            

            var _ga = Request.IsHttps;
            var _tt = Request.Host.ToString();
        }
    }
}