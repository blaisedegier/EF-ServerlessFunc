using Microsoft.AspNetCore.Mvc;

namespace Part3.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
