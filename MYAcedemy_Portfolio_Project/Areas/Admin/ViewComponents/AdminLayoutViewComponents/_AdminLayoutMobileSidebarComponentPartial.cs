using Microsoft.AspNetCore.Mvc;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutMobileSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
