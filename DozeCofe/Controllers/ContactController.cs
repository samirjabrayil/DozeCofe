using Microsoft.AspNetCore.Mvc;

namespace DozeCofe.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
