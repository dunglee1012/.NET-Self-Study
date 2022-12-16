using Microsoft.AspNetCore.Mvc;

namespace DemoFilterAndPaging.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
