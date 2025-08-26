using Microsoft.AspNetCore.Mvc;

namespace HolesticAcademyProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Mission() => View();
        public IActionResult Vision() => View();
        public IActionResult PresidentWord() => View();
        public IActionResult JoinUs() => View();

        [HttpGet]
        public IActionResult Contact() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(string name, string email, string message)
        {
            // pas de DB, tu peux logguer ou envoyer par mail plus tard
            Console.WriteLine($"Message reçu de {name} ({email}): {message}");
            TempData["MessageSent"] = "Merci, votre message a été envoyé.";
            return RedirectToAction(nameof(Contact));
        }

        public IActionResult FollowUs() => View();
    }
}
