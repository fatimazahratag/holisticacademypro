using Microsoft.AspNetCore.Mvc;

namespace HolesticAcademyProject.Controllers
{
    public class AccueilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
