using AyseYilmazPortfolio.DataAccessLayer.Context;
using AyseYilmazPortfolio.DataAccessLayer.Entites;
using Microsoft.AspNetCore.Mvc;

namespace AyseYilmazPortfolio.Controllers
{
	public class ExperienceController : Controller
	{
		private readonly AppDbContext _context;
		public ExperienceController(AppDbContext context)
		{
			_context = context;
		}
		public IActionResult ExperienceList()
		{
			var values = _context.Experiences.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Experience model)
		{
			_context.Experiences.Add(model);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		public IActionResult Delete(int id)
		{
			var value = _context.Experiences.FirstOrDefault(x => x.ExperienceId == id);
			_context.Remove(value);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		[HttpGet]
		public IActionResult Update(int id)
		{
            var value = _context.Experiences.FirstOrDefault(x => x.ExperienceId == id);
            return View(value);
		}
		[HttpPost]
		public IActionResult Update(Experience model)
		{
			_context.Experiences.Update(model);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
