using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KWZP2019
{
    public partial class SalariesSummary : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private Finances finances;
        public SalariesSummary(RoofingCompanyEntities db, StartForm startForm, Finances finances)
        {
            this.db = db;
            this.startForm = startForm;
            this.finances = finances;
            InitializeComponent();
        }
        private void SalariesSummary_Load(object sender, EventArgs e)
        {
            dgvSalariesData.DataSource = db.vSalariesSummaries.ToList();
            this.dgvSalariesData.Columns["IdEmployee"].Visible = false;
            this.dgvSalariesData.Columns["DailyWage"].Visible = false;
            this.dgvSalariesData.Columns["Date"].Visible = false;
            this.dgvSalariesData.Columns["L4Pay"].Visible = false;
            this.dgvSalariesData.Columns["PAPay"].Visible = false;
            this.dgvSalariesData.Columns["NPAPay"].Visible = false;
            this.dgvSalariesData.Columns["NPAay"].Visible = false;
            this.dgvSalariesData.Columns["ODPay"].Visible = false;
            dgvSalariesData.Columns[3].HeaderText = "Imię";
            dgvSalariesData.Columns[4].HeaderText = "Nazwisko";
            dgvSalariesData.Columns[5].HeaderText = "PESEL";
            dgvSalariesData.Columns[8].HeaderText = "Dni L4";
            dgvSalariesData.Columns[10].HeaderText = "Dni urlopu płatnego";
            dgvSalariesData.Columns[12].HeaderText = "Liczba dni bezpłatnego urlopu";
            dgvSalariesData.Columns[14].HeaderText = "Dni NU";
            dgvSalariesData.Columns[16].HeaderText = "Dni NŻ";
            dgvSalariesData.Columns[18].HeaderText = "Pensja bez premii";
            dgvSalariesData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            tbCurrentDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void btnAcceptChanges_Click(object sender, EventArgs e)
        {
            if (tbBonus.Text.Trim() == "")
            {
            MessageBox.Show("Wartość premii jest wymagana!");
            return;
            }
            dgvSalariesData.CurrentRow.Cells[1].Value = Convert.ToDecimal(tbBonus.Text);
            dgvSalariesData.CurrentRow.Cells[0].Value = Convert.ToDecimal(dgvSalariesData.CurrentRow.Cells[1].Value) + Convert.ToDecimal(dgvSalariesData.CurrentRow.Cells[18].Value);
            Payment newPayment = new Payment();
            newPayment.Bonus = int.Parse(tbBonus.Text.Trim());
            newPayment.IdEmployee = Convert.ToInt16(dgvSalariesData.CurrentRow.Cells[2].Value);
            newPayment.Date = Convert.ToDateTime(tbCurrentDate.Text);
            newPayment.Sum = Convert.ToDecimal(dgvSalariesData.CurrentRow.Cells[0].Value);
            db.Payments.Add(newPayment);
            db.SaveChanges();
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
