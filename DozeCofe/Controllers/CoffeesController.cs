using Microsoft.AspNetCore.Mvc;

namespace DozeCofe.Controllers
{
	public class CoffeesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
