using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;
using MYAcedemy_Portfolio_Project.Entites;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediaController : Controller
    {
        private readonly PortfolioContext _context;

        public SocialMediaController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult SocialList()
        {
            var value = _context.SocialMedias.ToList();
            return View(value);
            
        }

        [HttpGet]
        public IActionResult SocialMediaCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SocialMediaCreate(SocialMedia p)
        {
            _context.SocialMedias.Add(p);
            _context.SaveChanges();
            return RedirectToAction("SocialList");
        }

        [HttpGet]
        public IActionResult SocialMediaUpdate(int id)
        {
            var values = _context.SocialMedias.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult SocialMediaUpdate(SocialMedia p)
        {
            _context.SocialMedias.Update(p);
            _context.SaveChanges();
            return RedirectToAction("SocialList");
        }

        public IActionResult SocialMediaDelete(int id)
        {
            var values = _context.SocialMedias.Find(id);
            _context.SocialMedias.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("SocialList");
        }





    }
}
