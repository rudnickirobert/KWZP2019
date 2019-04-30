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
    public partial class AddNewOrderForm : Form

    {
        RoofingCompanyEntities db;
        public AddNewOrderForm(RoofingCompanyEntities db, object customerName)
        {
            InitializeComponent();
            this.db = db;
            this.customerNameTb.Text = customerName.ToString();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
