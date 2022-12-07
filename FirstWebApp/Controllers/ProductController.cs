using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class ProductController : Controller
    {
        public void Index()
        {

        }

        //route:   /Product/List/0/ABC
        public string List(int id, string name)
        {
            return $"Category: {id},name: {name}";
        }

        public IActionResult Detail(int id, string name)
        {
            ViewData["id"] = id;
            ViewBag.Name = name;
            return View();//tra ve view mac dinh
            //return View("/View/Norule.cshtml");
        }
    }
}
