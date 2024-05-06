using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.Controllers
{
	public class LayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
