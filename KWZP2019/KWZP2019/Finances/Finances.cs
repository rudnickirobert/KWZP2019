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

        private void btnCountPayments_Click(object sender, EventArgs e)
        {
            SalariesSummary salariesSummary = new SalariesSummary();
            salariesSummary.ShowDialog();
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

        private void btnFinancialStatement_Click(object sender, EventArgs e)
        {
            AllCosts allCosts = new AllCosts();
            allCosts.ShowDialog();
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            AddInvoices addInvoices = new AddInvoices();
            addInvoices.ShowDialog();
        }
    }
}
