using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
