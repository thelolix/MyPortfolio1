using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MYAcedemy_Portfolio_Project.Context;
using MYAcedemy_Portfolio_Project.Entites;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectsController : Controller
    {
        private readonly PortfolioContext _context;

        public ProjectsController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult ProjectsList()
        {
            var values = _context.Projects.ToList();
            return View(values);
        }


        [HttpGet]
        public IActionResult CreateProjects()
        {
            List<SelectListItem> valueCategory = (from x in _context.Categories.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString(),
                                                  }).ToList();
            ViewBag.v1 = valueCategory;
            return View();
        }

        [HttpPost]
        public IActionResult CreateProjects(Project p)
        {
            _context.Projects.Add(p);
            _context.SaveChanges();
            return RedirectToAction("ProjectsList");
            
        }

        [HttpGet]
        public IActionResult UpdateProjects(int id)
        {
            List<SelectListItem> valueCategories = (from x in _context.Categories.ToList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.CategoryName,
                                                        Value = x.CategoryID.ToString()
                                                    }).ToList();




            ViewBag.v2 = valueCategories;

            var varlues = _context.Projects.Find(id);
            return View(varlues);

        }

        [HttpPost]
        public IActionResult UpdateProjects(Project p)
        {
            _context.Projects.Update(p);
            _context.SaveChanges();
            return RedirectToAction("ProjectsList");
        }


        public IActionResult DeleteProjects(int id)
        {
            var values = _context.Projects.Find(id);
            _context.Projects.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("ProjectsList");
        }

    }
}
