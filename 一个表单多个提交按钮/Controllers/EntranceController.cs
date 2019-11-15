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