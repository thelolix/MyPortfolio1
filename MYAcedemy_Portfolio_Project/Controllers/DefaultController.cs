using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context; // Context namespace'inin ekli olduğundan emin ol
using MYAcedemy_Portfolio_Project.Entites; // Entity namespace'i

namespace MYAcedemy_Portfolio_Project.Controllers
{
    public class DefaultController : Controller
    {
        private readonly PortfolioContext _context;


        public DefaultController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
       
        public IActionResult SendMessage(Message p)
        {


            p.SendDate = DateTime.Now;
            p.IsRead = false;

            _context.Messages.Add(p);
            _context.SaveChanges();

            return RedirectToAction("Index", "Default");

        }
    }
}