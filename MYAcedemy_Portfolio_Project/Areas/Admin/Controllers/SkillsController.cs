using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;
using MYAcedemy_Portfolio_Project.Entites;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SkillsController : Controller
    {
        
        private readonly PortfolioContext _context;

        public SkillsController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult SkillList()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult SkillCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SkillCreate(Skill s)
        {
            _context.Skills.Add(s);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public IActionResult SkillUpdate(int id)
        {
            var values = _context.Skills.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult SkillUpdate(Skill s)
        {
            _context.Skills.Update(s);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        public IActionResult SkillDelete(int id)
        {
            var values = _context.Skills.Find(id);
            _context.Skills.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}
