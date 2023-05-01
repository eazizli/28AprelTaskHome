using Microsoft.AspNetCore.Mvc;

namespace FrontBackMVD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
