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
    public partial class CustomerForm : Form
    {
        RoofingCompanyEntities db;
        public CustomerForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm(db);
            orderForm.ShowDialog();
            this.Close();
        }

        private void addNewCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewCustomerForm addnewcustomerForm = new AddNewCustomerForm();
            addnewcustomerForm.ShowDialog();
            this.Close();
        }
    }
}
