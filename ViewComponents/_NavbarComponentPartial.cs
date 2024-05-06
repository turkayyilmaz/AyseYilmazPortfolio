using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
