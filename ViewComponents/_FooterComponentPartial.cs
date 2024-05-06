using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
