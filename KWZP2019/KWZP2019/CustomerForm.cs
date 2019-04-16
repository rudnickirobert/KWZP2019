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
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void dodajKlientaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewCustomerForm addnewcustomerForm = new AddNewCustomerForm();
            addnewcustomerForm.ShowDialog();
            this.Close();
        }
        private void CF_Zamówienie_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
            this.Close();
        }
    }
}
