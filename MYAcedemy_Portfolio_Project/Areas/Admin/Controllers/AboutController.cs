using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;
using MYAcedemy_Portfolio_Project.Entites;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        
        private readonly PortfolioContext _context;

        public AboutController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult AboutList()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AboutCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AboutCreate(About a)
        {
            _context.Abouts.Add(a);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }
        
        [HttpGet]
        public IActionResult AboutUpdate(int id)
        {
            var values = _context.Abouts.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult AboutUpdate(About a)
        { 
            _context.Abouts.Update(a);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public IActionResult AboutDelete(int id)
        {
            var values = _context.Abouts.Find(id);
            _context.Abouts.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("AboutList");

        }

    }
}
