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
    public partial class SalesDepartmentForm : Form
    {
        private RoofingCompanyEntities db;
        public SalesDepartmentForm(RoofingCompanyEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(db);
            customerForm.ShowDialog();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(db);
            orderForm.ShowDialog();
        }

        private void warehouseBtn_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm();
            warehouseForm.ShowDialog();
        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void outsourcingBtn_Click(object sender, EventArgs e)
        {
            OutsourcingForm outsourcingForm = new OutsourcingForm(db);
            outsourcingForm.ShowDialog();
        }

        private void returnToMainBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
