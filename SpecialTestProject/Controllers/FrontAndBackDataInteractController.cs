﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpecialTestProject.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

//参考：cnblogs.com/holly8/p/11507634.html(.net)
namespace SpecialTestProject.Controllers
{
    public class FrontAndBackDataInteractController : Controller
    {
        private IHttpContextAccessor _accessor;
        public FrontAndBackDataInteractController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        //传递基本数据类型
        public IActionResult BaseDataClass(int parm1, string parm2, bool parm3, double parm4)
        {
            string _backdata = string.Format("int={0},string={1},bool={2},double={3}", parm1, parm2, parm3, parm4);

            return Json(_backdata);
        }
        //传递单个对象(Josn对象！=Json字符串)
        public IActionResult SingleObject(Persion per)
        {
            string _res = Newtonsoft.Json.JsonConvert.SerializeObject(per);
            return Json(_res);
        }
        //传递数据通过Json
        public IActionResult TransferDataByJson([FromBody] Dog dog)
        {
            Console.WriteLine($"*传递数据通过Json*输出小狗信息：名字：{dog.Name}||年龄：{dog.Age}||叫声：{dog.Sound}");

            string _res = JsonConvert.SerializeObject(dog);
            return Json(_res);
        }            
        //传递单个Json对象
        public IActionResult SingleJsonObject([FromBody] ModelClass model)
        {
            string _str = JsonConvert.SerializeObject(model.dogobj);
            Dog _dogobj = JsonConvert.DeserializeObject<Dog>(_str);
            Console.WriteLine($"*传递单个Json对象*输出小狗信息：{_dogobj.Name}||{_dogobj.Age}||{_dogobj.Sound}");
            return Json(_str);
        }
        //传递多个Json对象
        public IActionResult MoreJsonObject([FromBody]MoreModelClass model)
        {
            string _dogstr = JsonConvert.SerializeObject(model.dogobj);
            string _pigstr = JsonConvert.SerializeObject(model.pigobj);

            Dog _dogobj = JsonConvert.DeserializeObject<Dog>(_dogstr);
            Pig _pigobj = JsonConvert.DeserializeObject<Pig>(_pigstr);

            string _res = string.Format("*传递多个Json对象*两个动物的名字是{0}和{1}", _dogobj.Name, _pigobj.Name);
            Console.WriteLine(_res);
            return Json(_res);
        }     
        //传递Json对象集合(解析Json数组参考：cnblogs.com/chenyanbin/p/11200415.html)
        public IActionResult JsonObjectList([FromBody]JsonObjectListClass model)
        {
            string _objstr = JsonConvert.SerializeObject(model.objlist);
            JArray _jsonarr = JsonConvert.DeserializeObject<JArray>(_objstr);

            var _dogstr= _jsonarr[0];
            var _pigstr = _jsonarr[1];
            Dog _dogobj = JsonConvert.DeserializeObject<Dog>(_dogstr.ToString());
            Pig _pigobj = JsonConvert.DeserializeObject<Pig>(_pigstr.ToString());

            string _res = string.Format("*传递Json对象集合*两个动物的年龄分别是：{0}和{1}；",_dogobj.Age,_pigobj.P_Age);
            Console.WriteLine(_res);
            return Json(_res);
        }
        [HttpPost]
        //使用数组传数据
        public IActionResult ArrayData(string[] arr)
        {
            foreach(var item in arr)
            {
                Console.WriteLine("输出数组中的信息");
                Console.WriteLine($"{item}");
            }
            return Json(arr);
        }
        //异步Json代传数据  该方法未添加服务不能运行，详细请看SignalRChat项目代码
        [HttpPost]
        public async Task<JsonResult> Login_Post()
        {
            var username = Request.Form["username"];
            var userpwd = Request.Form["userpwd"];

            string userId = Guid.NewGuid().ToString().Replace("-", "");
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,username),   //储存用户name
                new Claim(ClaimTypes.NameIdentifier,userId)  //储存用户id
            };
            //身份【似身份证，多个声明（姓名，民族等）构成】
            var indentity = new ClaimsIdentity(claims, "formlogin");
            //证件所有者【类似身份证所有者】
            var claimPrincipal = new ClaimsPrincipal(indentity);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal);
            if (claimPrincipal.Identity.IsAuthenticated)
            {
                return Json(new { code = "success", msg = "登陆成功" });
            }
            else
                return Json(new { code = "failed", msg = "登陆失败" });

        }
    }
   
}