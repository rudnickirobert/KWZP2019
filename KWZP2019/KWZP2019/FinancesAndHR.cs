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
    public partial class FinancesAndHR : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        public FinancesAndHR(RoofingCompanyEntities db, StartForm startform)
        {
            this.db = db;
            this.startForm = startform;
            InitializeComponent();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            HR hr = new HR(db, startForm, this);
            this.Hide();
            hr.Show();
        }

        private void btnFinances_Click(object sender, EventArgs e)
        {
            Finances finances = new Finances(db, startForm, this);
            this.Hide();
            finances.Show();
        }
        
        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }
    }
}
