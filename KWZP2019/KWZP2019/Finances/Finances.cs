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
            Salaries salaries = new Salaries();
            salaries.ShowDialog();
        }

        private void btnCountpayments_Click(object sender, EventArgs e)
        {
            Salariessummary salariessummary = new Salariessummary();
            salariessummary.ShowDialog();
        }

        private void btnCosts_Click(object sender, EventArgs e)
        {
            Costs costs = new Costs();
            costs.ShowDialog();
        }

        private void btnEarnings_Click(object sender, EventArgs e)
        {
            Profits profits = new Profits();
            profits.ShowDialog();
        }

        private void btnFinancialstatement_Click(object sender, EventArgs e)
        {
            Allcosts allcosts = new Allcosts();
            allcosts.ShowDialog();
        }

        private void btnAddinvoice_Click(object sender, EventArgs e)
        {
            AddInvoices addinvoices = new Addfvat();
            addinvoices.ShowDialog();
        }
    }
}
