using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;
using MYAcedemy_Portfolio_Project.Entites;

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




        public IActionResult MessageList(string search)
        {
            var value = _context.Messages.OrderByDescending(x => x.SendDate).ToList();
            
            if (search != null)
            {
                value = value.Where(x => x.NameSurname.Contains(search) || x.Subject.Contains(search)).ToList();
                    
            }

            //Okunmamış msjlar sayısı
            var value2 = _context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.unreadCount = value2;


            return View(value);
        }

        [HttpGet]
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(Message e)
        {
            e.SendDate = DateTime.Now;
            e.IsRead = false;
            _context.Messages.Add(e);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = _context.Messages.Find(id);
            _context.Messages.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        


        [HttpGet]
        public IActionResult MessageDetail(int id)
        {
            var values = _context.Messages.Find(id);
            return View(values);
            
        }

        public IActionResult trueIsRead(int id)
        {
            var value = _context.Messages.Find(id);
            value.IsRead = true;
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        public IActionResult falseIsRead(int id)
        {
            var value = _context.Messages.Find(id);
            value.IsRead = false;
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }




    }
}
