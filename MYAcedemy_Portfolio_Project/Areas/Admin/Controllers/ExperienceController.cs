using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;

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
    }
}
