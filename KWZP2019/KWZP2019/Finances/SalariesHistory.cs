using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace KWZP2019
{
    public partial class Salaries : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private Finances finances;
        public Salaries(RoofingCompanyEntities db, StartForm startForm, Finances finances)
        {
            this.db = db;
            this.startForm = startForm;
            this.finances = finances;
            InitializeComponent();
        }
        private void Salaries_Load(object sender, EventArgs e)
        {
            dgvHistory.DataSource = db.vPaymentHistories.ToList();
            this.dgvHistory.Columns["IdEmployee"].Visible = false;
            dgvHistory.Columns[0].HeaderText = "Imię";
            dgvHistory.Columns[1].HeaderText = "Nazwisko";
            dgvHistory.Columns[2].HeaderText = "PESEL";
            dgvHistory.Columns[3].HeaderText = "Premia";
            dgvHistory.Columns[4].HeaderText = "Podstawa wynagrodzenia";
            dgvHistory.Columns[5].HeaderText = "Data wypłaty";
            dgvHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void tbSurname_KeyUp(object sender, EventArgs e)
        {
        dgvHistory.DataSource = db.vPaymentHistories.ToList().Where(vPaymentHistory =>
        vPaymentHistory.EmployeeSurname.StartsWith(tbSurname.Text, StringComparison.OrdinalIgnoreCase)).ToList();
        dgvHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.finances.Show();
            this.Hide();
        }
        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }
    }
}