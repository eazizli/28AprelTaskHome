using Microsoft.AspNetCore.Mvc;

namespace FrontBackMVD.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
