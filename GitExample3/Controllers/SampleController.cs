using Microsoft.AspNetCore.Mvc;

namespace GitExample3.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return Content("Index from Sample controller");
        }
    }
}
