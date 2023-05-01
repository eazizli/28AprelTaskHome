using Microsoft.AspNetCore.Mvc;

namespace FrontBackMVD.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
