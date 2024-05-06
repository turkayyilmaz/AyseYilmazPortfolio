using AyseYilmazPortfolio.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.ViewComponents
{
    public class _FeatureComponentsPartial : ViewComponent
    {
        private readonly AppDbContext _context;
        public _FeatureComponentsPartial(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Features.ToList();
            return View(values);
        }
    }
}
