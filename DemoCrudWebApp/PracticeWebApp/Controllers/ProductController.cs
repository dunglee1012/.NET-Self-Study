using Microsoft.AspNetCore.Mvc;

namespace PracticeWebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()

        {
            return View();
        }

    }
}

