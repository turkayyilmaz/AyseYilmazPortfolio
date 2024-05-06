using AyseYilmazPortfolio.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;
		public _ExperienceComponentPartial(AppDbContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }
    }
}
