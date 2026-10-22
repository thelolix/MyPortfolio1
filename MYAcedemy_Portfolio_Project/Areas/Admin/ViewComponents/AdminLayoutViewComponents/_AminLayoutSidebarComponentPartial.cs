using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }   
    }
}
