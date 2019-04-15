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
    public partial class SupplierForm : Form
        
    {
        AddNewSupplierForm addnewsupplierForm = new AddNewSupplierForm(); 
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void Dostawcapolfabrykatu_rb_CheckedChanged(object sender, EventArgs e)
        {
            Dostawcapolfabrykatu_tb.Visible = true;
            Szczegolydostawcypolfabrykatu_btn.Visible = true;
            Szczegolydostawcypolfabrykatu_lv.Visible = true;

            Dostawcaczesci_tb.Visible = false;
            Szczegolydostawcyczesci_btn.Visible = false;
            Szczegolydostawcyczesci_lv.Visible = false;
      
        }

        private void DOstawcaczesci_rb_CheckedChanged(object sender, EventArgs e)
        {
            Dostawcaczesci_tb.Visible = true;
            Szczegolydostawcyczesci_btn.Visible = true;
            Szczegolydostawcyczesci_lv.Visible = true;

            Dostawcapolfabrykatu_tb.Visible = false;
            Szczegolydostawcypolfabrykatu_btn.Visible = false;
            Szczegolydostawcypolfabrykatu_lv.Visible = false;
        }

        private void Dodajnowegodostawce_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
           addnewsupplierForm.ShowDialog();
            this.Close();
        }
    }
}
