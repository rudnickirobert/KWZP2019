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
    public partial class SfOrdersForm : Form
    {
        private RoofingCompanyEntities db;
        private SalesDepartmentForm salesForm;
        public SfOrdersForm(RoofingCompanyEntities db, SalesDepartmentForm salesForm)
        {
            InitializeComponent();
            this.db = db;
            this.salesForm = salesForm;
        }
        private void SfOrdersForm_Load(object sender, EventArgs e)
        {

        }
        private void sfOrderDetailBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderNewSemiProductForm OrderNewSemiProductForm = new OrderNewSemiProductForm(db, salesForm);
            OrderNewSemiProductForm.ShowDialog();
            this.Close();
        }
        private void sfOrderBtn_Click(object sender, EventArgs e)
        {

        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            salesForm.Show();
            this.Close();
        }
    }
}
