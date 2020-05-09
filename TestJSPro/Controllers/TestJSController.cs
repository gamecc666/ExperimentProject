using System;
using Microsoft.AspNetCore.Mvc;

namespace TestJSFuncPro.Controllers
{
	public class TestJSController:Controller{
		public IActionResult index()
		{
			return View();
		}
	}
}