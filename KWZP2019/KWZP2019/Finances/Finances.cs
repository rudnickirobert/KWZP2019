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
            Salaries Salaries = new Salaries();
            salaries.ShowDialog();
        }

        private void btnCountPayments_Click(object sender, EventArgs e)
        {
            SalariesSummary SalariesSummary = new Salariessummary();
            SalariesSummary.ShowDialog();
        }

        private void btnCosts_Click(object sender, EventArgs e)
        {
            Costs Costs = new Costs();
            Costs.ShowDialog();
        }

        private void btnEarnings_Click(object sender, EventArgs e)
        {
            Profits Profits = new Profits();
            Profits.ShowDialog();
        }

        private void btnFinancialStatement_Click(object sender, EventArgs e)
        {
            AllCosts AllCosts = new Allcosts();
            Allcosts.ShowDialog();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            AddInvoices AddInvoices = new Addfvat();
            AddInvoices.ShowDialog();
        }
    }
}
