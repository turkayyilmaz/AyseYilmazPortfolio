using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
