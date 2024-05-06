using AyseYilmazPortfolio.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;
		public _AboutComponentPartial(AppDbContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
