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
        RoofingCompanyEntities db;
        StartForm startForm;
        FinancesAndHR finanseIHR;
        public Finances(RoofingCompanyEntities db, StartForm startForm, FinancesAndHR finanseIHR)
        {
            this.db = db;
            this.startForm = startForm;
            this.finanseIHR = finanseIHR;
            InitializeComponent();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Salaries salaries = new Salaries(db);
            salaries.ShowDialog();
            this.Hide();
        }

        private void btnCountPayments_Click(object sender, EventArgs e)
        {
            SalariesSummary salariesSummary = new SalariesSummary(db);
            salariesSummary.ShowDialog();
            this.Hide();
        }

        private void btnCosts_Click(object sender, EventArgs e)
        {
            Costs costs = new Costs(db);
            costs.ShowDialog();
            this.Hide();
        }

        private void btnEarnings_Click(object sender, EventArgs e)
        {
            Profits profits = new Profits(db);
            profits.ShowDialog();
            this.Hide();
        }

        private void btnFinancialStatement_Click(object sender, EventArgs e)
        {
            AllCosts allCosts = new AllCosts(db);
            allCosts.ShowDialog();
            this.Hide();
        }
        private void Finances_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
        }
        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            AddInvoices addInvoices = new AddInvoices(db);
            addInvoices.ShowDialog();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.finanseIHR.Show();
            this.Hide();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }
    }
}
