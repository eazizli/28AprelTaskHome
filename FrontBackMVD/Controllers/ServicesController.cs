using Microsoft.AspNetCore.Mvc;

namespace FrontBackMVD.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
