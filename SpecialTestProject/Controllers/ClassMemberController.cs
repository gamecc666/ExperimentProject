using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SpecialTestProject.Models;

namespace SpecialTestProject.Controllers
{
    public class ClassMemberController : Controller
    {
        private readonly ILogger _logger;
        public ClassMemberController(ILogger<ClassMemberController> logger)
        {
            _logger = logger;
        }

        //目的测试怎样获得一个类的所有成员名字
        public IActionResult Index()
        {
            Persion ob = new Persion();
            GetClassMemberName(ob);
            return View();
        }

        public List<string> GetClassMemberName(Persion sb)
        {
            List<string> _memberlist = new List<string>();
            Type t = sb.GetType();
            foreach(PropertyInfo pi in t.GetProperties())
            {
                //var st = pi.GetValue(sb, null);可以获得对应的值
                string name = pi.Name;
            }
            
            return _memberlist;
        }
    }
}