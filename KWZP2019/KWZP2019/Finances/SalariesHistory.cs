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
    public partial class SalariesHistory : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private Finances Finances;
        public SalariesHistory(RoofingCompanyEntities db, StartForm startForm, Finances Finances)
        {
            this.db = db;
            this.startForm = startForm;
            this.Finances = Finances;
            InitializeComponent();
        }
        private void SalariesHistory_Load(object sender, EventArgs e)
        {
            dgvHistory.DataSource = db.vPaymentHistories.ToList();
            this.dgvHistory.Columns["IdEmployee"].Visible = false;
            dgvHistory.Columns[0].HeaderText = "Imię";
            dgvHistory.Columns[1].HeaderText = "Nazwisko";
            dgvHistory.Columns[2].HeaderText = "PESEL";
            dgvHistory.Columns[3].HeaderText = "Premia";
            dgvHistory.Columns[4].HeaderText = "Podstawa wynagrodzenia";
            dgvHistory.Columns[5].HeaderText = "Data wypłaty";
            dgvHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
        private void tbSurname_TextChanged(object sender, EventArgs e)
        {
        dgvHistory.DataSource = db.vPaymentHistories.ToList().Where(vPaymentHistory =>
        vPaymentHistory.EmployeeSurname.StartsWith(tbSurname.Text, StringComparison.OrdinalIgnoreCase))
        .Select(vPaymentHistory => new { vPaymentHistory.EmployeeName, vPaymentHistory.EmployeeSurname, vPaymentHistory.PESEL, vPaymentHistory.Bonus, vPaymentHistory.Sum, vPaymentHistory.Date })
        .ToList();
        dgvHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
    }
}
