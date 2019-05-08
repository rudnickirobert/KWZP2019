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
        private StartForm previousForm;
        private RoofingCompanyEntities db;
        public SalesDepartmentForm(RoofingCompanyEntities db, StartForm form)
        {
            this.db = db;
            this.previousForm = form;
            InitializeComponent();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerForm = new CustomerForm(db, this);
            customerForm.ShowDialog();
        }

        private void warehouseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarehouseForm warehouseForm = new WarehouseForm(db, this);
            warehouseForm.ShowDialog();
        }

        private void suppliersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierForm supplierForm = new SupplierForm(db, this);
            supplierForm.ShowDialog();
        }

        private void outsourcingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OutsourcingForm outsourcingForm = new OutsourcingForm(db, this);
            outsourcingForm.ShowDialog();
        }
        private void ordersSfBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SfOrdersForm newSfOrdersForm= new SfOrdersForm(db, this);
            newSfOrdersForm.ShowDialog();
        }

        private void returnToMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
            this.Close();
        }
    }
}
