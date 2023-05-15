using Microsoft.AspNetCore.Mvc;

namespace DozeCofe.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
