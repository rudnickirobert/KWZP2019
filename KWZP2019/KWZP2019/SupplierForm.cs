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

        private void addNewSupplierBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addnewsupplierForm.ShowDialog();
            this.Close();
        }
    }
}
