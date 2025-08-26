using Microsoft.AspNetCore.Mvc;

namespace HolesticAcademyProject.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            var newsList = new List<string>
            {
                "Lancement du site officiel Holestic Academy",
                "Atelier d’orientation prévu le 15 septembre"
            };

            return View(newsList);
        }

        public IActionResult Details(int id)
        {
            // phase 2 : détails d’une actualité
            return View();
        }
    }
}
