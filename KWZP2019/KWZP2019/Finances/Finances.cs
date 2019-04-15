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
    public partial class Finances : Form
    {
        public Finances()
        {
            InitializeComponent();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Salaries obecnosci = new Salaries();
            obecnosci.ShowDialog();
        }

        private void btnCountpayments_Click(object sender, EventArgs e)
        {
            Salariessummary urlopy = new Salariessummary();
            urlopy.ShowDialog();
        }

        private void btnCosts_Click(object sender, EventArgs e)
        {
            Costs faktury = new Costs();
            faktury.ShowDialog();
        }

        private void btnEarnings_Click(object sender, EventArgs e)
        {
            Profits kadry = new Profits();
            kadry.ShowDialog();
        }

        private void btnFinancialstatement_Click(object sender, EventArgs e)
        {
            Allcosts wyplaty = new Allcosts();
            wyplaty.ShowDialog();
        }

        private void btnAddinvoice_Click(object sender, EventArgs e)
        {
            Addfvat raporty = new Addfvat();
            raporty.ShowDialog();
        }
    }
}
