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
    public partial class OrderForm : Form
    {
        RoofingCompanyEntities db;
        public OrderForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
        private void transportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OutsourcingForm outsourcingForm = new OutsourcingForm(db);
            outsourcingForm.ShowDialog();
            this.Close();
        }

        private void warehouseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WarehouseForm warehouseForm = new WarehouseForm();
            warehouseForm.ShowDialog();
            this.Close();
        }

        private void addOrderGb_Enter(object sender, EventArgs e)
        {
            addOrderGb.Visible = true;
        }

        private void searchOrderBtn_Click(object sender, EventArgs e)
        {
            searchOrderGb.Visible = true;
        }
    }
}
