using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;

namespace MYAcedemy_Portfolio_Project.ViewComponents.DefaultViewComponents
{
    public class _DefaultEducationComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultEducationComponentPartial(PortfolioContext context)
        {
            _context = context;
        }
    
        public IViewComponentResult Invoke()
        {
            var values = _context.Educations.Where(x => x.IsActive == true).ToList();
            return View(values);
        }
    
    
    
    }
}
