using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class AddNewOrderDetailForm : Form
    {
        private RoofingCompanyEntities db;
        private SalesDepartmentForm salesForm;
        private  int orderNumber;
        public AddNewOrderDetailForm(RoofingCompanyEntities db, object idOrder, SalesDepartmentForm form)
        {
            InitializeComponent();
            this.db = db;
            this.salesForm = form;
            orderNumber = int.Parse(idOrder.ToString());
            this.orderTb.Text = orderNumber.ToString();
        }
        private void AddNewOrderDetailForm_Load(object sender, EventArgs e)
        {
            List<Product> productsList = db.Products.ToList();
            productCb.BeginUpdate();
            foreach (Product prod in productsList)
            {
                productCb.Items.Add(prod.ProductCode);
            }
            productCb.EndUpdate();
        }
        //BUTTONS       //Return
        private void detailReturnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerForm = new CustomerForm(db, salesForm);
            customerForm.ShowDialog();
            this.Close();
        }
        //Accept
        private void detailAcceptBtn_Click(object sender, EventArgs e)
        {
            OrderDetail newOrderDetail = new OrderDetail();
            if (productCb.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz Produkt");
                productCb.BackColor = Color.Red;
                return;
            }
            else
            {
                foreach (Product prod in db.Products)
                {
                    if (prod.ProductCode.ToString() == productCb.Text.ToString())
                    {
                        newOrderDetail.IdProduct = prod.IdProduct;
                    }
                }
            }
            if (int.TryParse(quantityTb.Text.Trim(), out int isQuantityInteger))
            {
                if (int.Parse(quantityTb.Text.Trim()) < 1)
                {
                    MessageBox.Show("Wprowadź poprawną wartość");
                    quantityTb.BackColor = Color.Red;
                    return;
                }
                else
                {
                    newOrderDetail.Quantity = int.Parse(quantityTb.Text.Trim());
                }
            }
            else
            {
                MessageBox.Show("Wprowadź poprawną wartość");
                quantityTb.BackColor = Color.Red;
                return;
            }
            newOrderDetail.IdOrderCustomer = orderNumber;
            db.OrderDetails.Add(newOrderDetail);
            db.SaveChanges();
            this.Hide();
            MessageBox.Show("Dodano szczegół zamówienia");
            CustomerForm customerForm = new CustomerForm(db, salesForm);
            customerForm.ShowDialog();
            this.Close();
        }
    }
}
