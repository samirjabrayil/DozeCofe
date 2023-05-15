using Microsoft.AspNetCore.Mvc;

namespace DozeCofe.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
