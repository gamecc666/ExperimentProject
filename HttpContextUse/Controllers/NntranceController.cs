using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpContextUse.Controllers
{
    public class NntranceController : Controller
    {
        public IHttpContextAccessor _accessor;

        public NntranceController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public IActionResult Index()
        {
            //设置响应的头成员
            if (Response.Headers.ContainsKey("Header001"))
            {
                Response.Headers.Add("Header001", "1000");
            }
            else
            {
                Response.Headers["Header001"] = "1000";
            }

            var hcontext = _accessor.HttpContext;            
            return View(hcontext);
        }
    }
}