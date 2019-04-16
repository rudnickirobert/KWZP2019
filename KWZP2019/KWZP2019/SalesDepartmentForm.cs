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

        private void SDF_Klient_btn_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void SDF_Zamowienie_btn_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void SDF_Dostawcy_btn_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void SDF_Magazyn_btn_Click(object sender, EventArgs e)
        {
            WarehouseForm warehouseForm = new WarehouseForm();
            warehouseForm.ShowDialog();
        }

        private void SDF_Outsourcing_btn_Click(object sender, EventArgs e)
        {
            OutsourcingForm outsourcingForm = new OutsourcingForm();
            outsourcingForm.ShowDialog();
        }
    }
}
