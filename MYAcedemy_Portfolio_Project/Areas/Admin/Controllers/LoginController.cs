using Microsoft.AspNetCore.Mvc;

namespace MYAcedemy_Portfolio_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public IActionResult Logout()
        {
            
            return RedirectToAction("Index", "Default");
        }
    }
}