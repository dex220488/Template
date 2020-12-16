using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}