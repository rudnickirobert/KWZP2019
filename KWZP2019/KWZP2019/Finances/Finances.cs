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
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private FinancesAndHR finanseIHR;
        public Finances(RoofingCompanyEntities db, StartForm startForm, FinancesAndHR finanseIHR)
        {
            this.db = db;
            this.startForm = startForm;
            this.finanseIHR = finanseIHR;
            InitializeComponent();
        }
        private void btnPayments_Click(object sender, EventArgs e)
        {
            Salaries salaries = new Salaries(db, startForm, this);
            salaries.ShowDialog();
            this.Hide();
        }
        private void btnCountPayments_Click(object sender, EventArgs e)
        {
            SalariesSummary salariesSummary = new SalariesSummary(db, startForm, this);
            salariesSummary.ShowDialog();
            this.Hide();
        }
        private void btnCosts_Click(object sender, EventArgs e)
        {
            AllExpenses costs = new AllExpenses(db, startForm, this);
            costs.ShowDialog();
        }
        private void btnEarnings_Click(object sender, EventArgs e)
        {
            AllIncomes allCosts = new AllIncomes(db, startForm, this);
            allCosts.ShowDialog();
        }
        private void btnFinancialStatement_Click(object sender, EventArgs e)
        {
            Profits profits = new Profits(db, startForm, this);
            profits.ShowDialog();

        }
        private void Finances_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
        }
        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            AddInvoices addInvoices = new AddInvoices(db, startForm, this);
            addInvoices.ShowDialog();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.startForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.finanseIHR.Show();
            this.Hide();
        }
    }
}