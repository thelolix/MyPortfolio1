using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;

namespace MYAcedemy_Portfolio_Project.ViewComponents.DefaultViewComponents
{
    public class _DefaultCertifikaComponentPartial : ViewComponent
    {

        private readonly PortfolioContext _context;

        public _DefaultCertifikaComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Certifikas.ToList();
            return View(values);
        }
    }
}
