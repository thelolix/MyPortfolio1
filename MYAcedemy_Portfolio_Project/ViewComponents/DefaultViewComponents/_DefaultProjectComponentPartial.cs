using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYAcedemy_Portfolio_Project.Context;

namespace MYAcedemy_Portfolio_Project.ViewComponents.DefaultViewComponents
{
    public class _DefaultProjectComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultProjectComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
        
        public IViewComponentResult Invoke()
        {
            var values = _context.Projects.Include(x=>x.Category).ToList();
            return View(values);
        }
    
    
    
    }
}
