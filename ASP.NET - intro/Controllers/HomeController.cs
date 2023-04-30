using Microsoft.AspNetCore.Mvc;

namespace ASP.NET___intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
