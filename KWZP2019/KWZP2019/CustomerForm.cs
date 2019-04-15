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
        //CF_PESEL_lbl cF_PESEL_lbl = new CF_PESEL_lbl();
        //CustomerForm customerForm = new CustomerForm();
        AddNewCustomerForm addnewcustomerForm = new AddNewCustomerForm();
        OrderForm orderForm = new OrderForm();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
        private void CF_Klientindywidualny_rbtn_CheckedChanged(object sender, EventArgs e)
        {
          
        }
 
        private void CF_Firma_rbtn_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void CF_Nazwa_lbl_Click(object sender, EventArgs e)
        {

        }

        private void CF_Nazwa_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void CF_WyszukajklientaFirma_btn_Click(object sender, EventArgs e)
        {
            
        }
        private void CF_WyszukajklientaIndywidualnego_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void CF_Dodajklienta_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addnewcustomerForm.ShowDialog();
            this.Close();
        }

        private void CF_Zamówienie_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderForm.ShowDialog();
            this.Close();
            
        }
    }
}
