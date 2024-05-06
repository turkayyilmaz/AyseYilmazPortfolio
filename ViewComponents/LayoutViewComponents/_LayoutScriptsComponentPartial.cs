using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptsComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
