using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APIMovies.Controllers
{
	[ApiController]
	[Route("demo")]
	public class HomeController : Controller
	{
		[HttpGet]
		public String Get()
		{
			return "Hello World";
		}
		/*public IActionResult Index()
		{
			return View();
		}*/
	}
}
