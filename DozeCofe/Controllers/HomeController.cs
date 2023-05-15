using Microsoft.AspNetCore.Mvc;

namespace DozeCofe.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
