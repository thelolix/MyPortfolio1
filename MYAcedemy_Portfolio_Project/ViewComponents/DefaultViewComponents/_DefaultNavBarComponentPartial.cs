using Microsoft.AspNetCore.Mvc;

namespace MYAcedemy_Portfolio_Project.ViewComponents.DefaultViewComponents
{
    public class _DefaultNavBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
