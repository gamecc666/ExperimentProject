﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SignalRChatPage.Controllers
{
    public class PageController : Controller
    {       
        public IActionResult Index()
        {           
            return View();
        }
    }
}