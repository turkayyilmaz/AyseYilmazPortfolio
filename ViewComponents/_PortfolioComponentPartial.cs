﻿using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
