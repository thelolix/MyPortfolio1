using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly PortfolioContext _context;

        public DashboardController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.messageCount = _context.Messages.Count();
            ViewBag.messageReadeByTrueCount = _context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.messageReadeByFalseCount = _context.Messages.Where(x => x.IsRead == false).Count();
            return View();
        }
    }
}
