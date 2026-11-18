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
            ViewBag.lastMessages = _context.Messages.OrderByDescending(x => x.SendDate).Take(5).ToList();
            ViewBag.lastProjects = _context.Projects.OrderByDescending(x => x.ProjectID).Take(3).ToList();

            //Burası Proje Kartları
            ViewBag.allProject = _context.Projects.Count();
            ViewBag.activeProject = _context.Projects.Where(x => x.IsActive == true).Count();

            //Yetenek Kartları
            ViewBag.allSkills = _context.Skills.Count();
            //Deneyim
            ViewBag.allExperience = _context.Experiences.Count();
            //Education
            ViewBag.allEducation = _context.Educations.Count();

            //Kategori özeti
            ViewBag.categorySummary = _context.Projects.GroupBy(x => x.Category.CategoryName).Select(x => new
            {
                CategoryName = x.Key,
                ProjectCount = x.Count()
            }).ToList();



            return View();
        
            
        }
    }
}
