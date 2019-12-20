using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Web;

namespace SpecialTestProject.Controllers
{
    public class TestHttpContextController : Controller
    {
        private IHttpContextAccessor _accessor;
        public TestHttpContextController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
        [HttpGet]
        public IActionResult Index(int? id)
        {
            var httpcontext = _accessor.HttpContext;
            return View(httpcontext);
            //var httpcontext = _accessor.HttpContext;
            //httpcontext.Response.ContentType = "text/html";
            //httpcontext.Response.WriteAsync("<script>alert('hahaha');</script>");
            //return View();
        }
    }
}