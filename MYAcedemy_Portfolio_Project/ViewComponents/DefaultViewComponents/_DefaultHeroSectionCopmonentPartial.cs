using Microsoft.AspNetCore.Mvc;
using MYAcedemy_Portfolio_Project.Context;

namespace MYAcedemy_Portfolio_Project.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeroSectionCopmonentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;
        public _DefaultHeroSectionCopmonentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.HeroSections.FirstOrDefault();
            ViewBag.v1 = values.HeroTitle;
            ViewBag.v2 = values.SubTitle;
            ViewBag.v3 = values.Description;
            ViewBag.v4 = values.ImageUrl;
            return View();
        }
    }
}
