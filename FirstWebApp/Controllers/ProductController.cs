using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class ProductController : Controller
    {
        public void Index()
        {

        }

        //route:   /Product/List/10/ABC
        public string List(int id, string name)
        {
            return $"Category: {id},name: {name}";
        }
    }
}
