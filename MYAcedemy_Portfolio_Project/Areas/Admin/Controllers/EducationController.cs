using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;
using MYAcedemy_Portfolio_Project.Entites;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EducationController : Controller
    {
        private readonly PortfolioContext _context;

        public EducationController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult EducationList()
        {
            var value = _context.Educations.OrderByDescending(x => x.Duration).ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEducation(Education e)
        {
            _context.Educations.Add(e);
            _context.SaveChanges();
            return RedirectToAction("EducationList");
            
        }

        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var values = _context.Educations.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateEducation(Education e)
        {
            _context.Educations.Update(e);
            _context.SaveChanges();
            return RedirectToAction("EducationList");
        }

        public IActionResult DeleteEducation(int id)
        {
            var values = _context.Educations.Find(id);
            _context.Educations.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("EducationList");
        }







    }
}
