using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
