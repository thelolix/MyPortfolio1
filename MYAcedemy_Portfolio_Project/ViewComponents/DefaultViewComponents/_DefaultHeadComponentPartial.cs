using Microsoft.AspNetCore.Mvc;

namespace MYAcedemy_Portfolio_Project.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
