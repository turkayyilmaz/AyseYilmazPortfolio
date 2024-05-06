using AyseYilmazPortfolio.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        private readonly AppDbContext _appDbContext;
		public _SkillComponentPartial(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public IViewComponentResult Invoke()
        {
            var values = _appDbContext.Skills.ToList();
            return View(values);
        }
    }
}
