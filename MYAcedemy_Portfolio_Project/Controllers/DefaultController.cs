using Microsoft.AspNetCore.Mvc;

namespace MYAcedemy_Portfolio_Project.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
