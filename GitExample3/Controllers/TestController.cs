using Microsoft.AspNetCore.Mvc;

namespace GitExample3.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome....");
        }

        public IActionResult HomePage()
        {
            return Content("Home Page - Version3");
        }

        public IActionResult Career()
        {
            return Content("Careers Page - updated in central repo");
        }


    }
}
