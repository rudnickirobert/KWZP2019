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
    public partial class OutsourcingForm : Form
    {
        AddNewOutsourcingCompanyForm addnewoutsourcingcompanyForm = new AddNewOutsourcingCompanyForm();
        public OutsourcingForm()
        {
            InitializeComponent();
        }

        private void addNewOutsourcingCompanyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addnewoutsourcingcompanyForm.ShowDialog();
            this.Close();
        }
    }
}
