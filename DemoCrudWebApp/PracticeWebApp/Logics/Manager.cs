using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PracticeWebApp.Models;

namespace PracticeWebApp.Logics
{
    public class Manager
    {
        NorthwindContext context;

        public Manager()
        {
            context = new NorthwindContext();
        }

        public List<OrderDetail> GetOrderDetails(int orderId)
        {
            var list = context.OrderDetails
                .Include(x => x.Order)
                .Include(x => x.Product);
            if (orderId == 0)
            {
                return list.ToList();

            }
            else
            {
                return list.Where(x => x.OrderId == orderId).ToList();
            }
        }

        public Order GetOrder(int orderId)
        {
            var list = context.Orders
                .Include(x => x.Customer)
                .Include(x => x.Employee)
                .FirstOrDefault(x => x.OrderId == orderId);
            if (list == null)
            {
                return null;
            }
            else
            {
                return list;
            }
        }

        public Product GetProduct(int productid)
        {
            return context.Products
                .Include(x => x.Category)
                .Include(x => x.Supplier)
                .FirstOrDefault(x => x.ProductId == productid);
        }

        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public List<Supplier> GetSuppliers()
        {
            return context.Suppliers.ToList();
        }

        public void InsertProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void EditProduct(Product product)
        {
            Product p = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (p != null)
            {
                p.CategoryId = product.CategoryId;
                p.SupplierId = product.SupplierId;
                p.ProductName = product.ProductName;
                p.UnitPrice = product.UnitPrice;
                p.Discontinued = product.Discontinued;
                context.SaveChanges();
            }
        }

        public void DeleteProduct(int id)
        {
            Product p = context.Products.FirstOrDefault(x => x.ProductId == id);
            if(p != null)
            {
                List<OrderDetail> od = context.OrderDetails.Where(x => x.ProductId == id).ToList();
                context.OrderDetails.RemoveRange(od);
                context.Products.Remove(p);
                context.SaveChanges();
            }
        }
    }
}
