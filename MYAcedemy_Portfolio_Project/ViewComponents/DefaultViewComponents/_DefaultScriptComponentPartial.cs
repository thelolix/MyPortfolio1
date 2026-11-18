using Microsoft.AspNetCore.Mvc;

namespace MYAcedemy_Portfolio_Project.ViewComponents.DefaultViewComponents
{

    public class _DefaultScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
