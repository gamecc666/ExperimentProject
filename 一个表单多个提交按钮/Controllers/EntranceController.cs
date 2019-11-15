using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace 一个表单多个提交按钮.Controllers
{
    public class EntranceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        ///前台提交数据函数处理
        [HttpPost]
        public IActionResult DealData()
        {
            //FormCollection:表单集合；参考网址：https://docs.microsoft.com/zh-cn/dotnet/api/microsoft.aspnetcore.http.formcollection?view=aspnetcore-2.0
            FormCollection col = (FormCollection)Request.Form;
            string name = col["username"];
            string age = col["age"].ToString();

            Console.WriteLine("***************表单提交来的数据：");
            return View();
        }
        [HttpPost]
        public IActionResult SaveData()
        {
            FormCollection col = (FormCollection)Request.Form;
            string name = col["username"];
            string age = col["age"].ToString();

            Console.WriteLine("***************表单提交来的数据：");
            return View();
        }
    }
}