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
        CustomerForm customerForm = new CustomerForm();
        OrderForm orderForm = new OrderForm();
        SupplierForm supplierForm = new SupplierForm();
        WarehouseForm warehouseForm = new WarehouseForm();
        OutsourcingForm outsourcingForm = new OutsourcingForm();
        //SalesDepartmentForm salesDepartmentForm = new SalesDepartmentForm();

        public SalesDepartmentForm()
        {
            InitializeComponent();
        }

        private void SalesDepartmentForm_Load(object sender, EventArgs e)
        {

        }

        private void SDF_Klient_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerForm.ShowDialog();
            this.Close();

        }

        private void SDF_Zamowienie_btn_Click(object sender, EventArgs e)
        {
            orderForm.ShowDialog();
        }

        private void SDF_Dostawcy_btn_Click(object sender, EventArgs e)
        {
            supplierForm.ShowDialog();
        }

        private void SDF_Magazyn_btn_Click(object sender, EventArgs e)
        {
            warehouseForm.ShowDialog();

        }

        private void SDF_Outsourcing_btn_Click(object sender, EventArgs e)
        {
            outsourcingForm.ShowDialog();
        }
    }
}
