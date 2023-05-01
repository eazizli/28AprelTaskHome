using Microsoft.AspNetCore.Mvc;

namespace FrontBackMVD.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
