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
        public FinancesAndHR()
        {
            InitializeComponent();

        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            HR hr = new HR();
            hr.Show();
            this.Hide();
        }

        private void btnFinances_Click(object sender, EventArgs e)
        {
            Finances finances = new Finances();
            finances.Show();
            this.Hide();
        }
    }
}
