﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace MvcMovie.Controllers
{
	public class HelloWorldController : Controller
	{
		// GET: /HelloWorld/
		public IActionResult Index()
		{
			return View();
		}

		// GET: /HelloWorld/Welcome/ 
		public IActionResult Welcome(string name, int numTimes=1)
		{
			//HtmlEncoder.Default.Encode to protect the app from malicious input
			//return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

			ViewData["Message"] = "Hello" + name;
			ViewData["NumTimes"] = numTimes;
			return View();
		}
	}
}
