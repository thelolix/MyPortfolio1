using Microsoft.AspNetCore.Mvc;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayouteScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
