using PracticeCreateOrder.Logics;
using PracticeCreateOrder.Models;
using System.Net;
using System.Xml.Linq;

namespace PracticeCreateOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            cbCustomer.DisplayMember = "CompanyName";
            cbCustomer.ValueMember = "CustomerId";
            cbCustomer.DataSource = manager.GetCustomers();

            cbEmployee.DisplayMember = "Lastname";
            cbEmployee.ValueMember = "EmployeeId";
            cbEmployee.DataSource = manager.GetEmployees()
                .Select(x => new
                {
                    Fullname = x.FirstName + " " + x.LastName,
                    x.EmployeeId
                }).ToList();

            cbShipCompanyName.DisplayMember = "CompanyName";
            cbShipCompanyName.ValueMember = "ShipperId";
            cbShipCompanyName.DataSource = manager.GetShippers();

            lbProducts.DisplayMember = "ProductName";
            lbProducts.ValueMember = "ProductId";
            lbProducts.DataSource = manager.GetProducts();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            dynamic products = lbProducts.SelectedItems;
            Order order = new Order();
            order.EmployeeId = Convert.ToInt32(cbEmployee.SelectedValue);
            order.CustomerId = cbCustomer.SelectedValue.ToString();
            order.ShipVia = Convert.ToInt32(cbShipCompanyName.SelectedValue);
            order.OrderDate = DateTime.Now;
            order.RequiredDate = dtpShipDate.Value;
            order.ShipName = tbShipName.Text;
            order.ShipAddress = tbShipAddress.Text;

            try
            {
                Manager manager = new Manager();
                manager.AddOrder(order, products);
                MessageBox.Show("Adding Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error. {Environment.NewLine} {ex.Message}");
            }
        }
    }
}