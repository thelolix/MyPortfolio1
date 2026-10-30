using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly PortfolioContext _context;

        public MessageController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            var value = _context.Messages.ToList();
            return View(value);
        }
    }
}
