using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYAcedemy_Portfolio_Project.Context;

namespace MYAcedemy_Portfolio_Project.ViewComponents.DefaultViewComponents
{
    public class _DefaultSkillComponentPartial :ViewComponent
    {
        private readonly PortfolioContext _contex;
        public _DefaultSkillComponentPartial(PortfolioContext contex)
        {
            _contex = contex;
        }
        public IViewComponentResult Invoke()
        {
            var values = _contex.Skills.Include(x => x.SkillYüzde).ToList();
            return View(values);
        }
    
    }
}
