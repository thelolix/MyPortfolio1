using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;
using MYAcedemy_Portfolio_Project.Entites;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExperienceController : Controller
    {
        private readonly PortfolioContext _context;

        public ExperienceController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult ExperienceList()
        {
            var value = _context.Experiences.ToList();
            return View(value);
        }


        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience e)
        {
            _context.Add(e);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }  

        public IActionResult DeleteExperience(int id)
        {
            var value = _context.Experiences.Find(id);
            _context.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult UpdateExperience(int id)
        {
            var values = _context.Experiences.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience e)
        {
            _context.Experiences.Update(e);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }






    }
}
