using Microsoft.AspNetCore.Mvc;
using PracticeWebApp.Logics;
using PracticeWebApp.Models;

namespace PracticeWebApp.Controllers
{
    public class OrderDetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int orderId)
        {
            Manager manager = new Manager();
            List<OrderDetail> ods = manager.GetOrderDetails(orderId);
            Order o = new Order();

            o = manager.GetOrder(orderId);
            if (o == null)
            {
                return null;
            }
            ViewBag.orderId = o.OrderId;
            ViewBag.customerName = o.Customer.CompanyName;
            ViewBag.employeeName = o.Employee.FirstName;
            return View(ods);
        }

        public IActionResult Create(int id)
        {
            Manager manager = new Manager();
            ViewBag.Categories = manager.GetCategories();
            ViewBag.Suppliers = manager.GetSuppliers();

            if (id == 0)
            {
                return View();
            }
            else
            {
                Product p = manager.GetProduct(id);
                return View(p);
            }
        }

        public IActionResult DoCreate(Product product)
        {
            Manager manager = new Manager();
            if (product.ProductId == 0)
            {
                manager.InsertProduct(product);
                return RedirectToAction("Detail");
            }
            else
            {
                manager.EditProduct(product);
                return RedirectToAction("Detail");
            }
        }

        public IActionResult DoDelete(int id, int cid)
        {
            Manager manager = new Manager();
            manager.DeleteProduct(id);
            return RedirectToAction("List", new { cid });
        }


    }
}
