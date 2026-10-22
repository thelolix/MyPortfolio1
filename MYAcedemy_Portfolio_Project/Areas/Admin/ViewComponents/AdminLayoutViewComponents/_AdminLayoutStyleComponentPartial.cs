using Microsoft.AspNetCore.Mvc;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutStyleComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }


    }
}
