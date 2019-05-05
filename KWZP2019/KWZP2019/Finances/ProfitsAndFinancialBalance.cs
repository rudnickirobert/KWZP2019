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
using System.IO;
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace KWZP2019
{
    public partial class Profits : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private Finances finances;
        public Profits(RoofingCompanyEntities db, StartForm startForm, Finances finances)
        {
            this.db = db;
            this.startForm = startForm;
            this.finances = finances;
            InitializeComponent();
        }
        private void Profits_Load(object sender, EventArgs e)
        {
            dgvProfits.DataSource = db.vIncomesProfits.ToList();
            this.dgvProfits.Columns["IdCustomer"].Visible = false;
            dgvProfits.Columns[1].HeaderText = "Nazwa klienta";
            dgvProfits.Columns[2].HeaderText = "Data zamówienia";
            dgvProfits.Columns[3].HeaderText = "Wartość zamówienia";
            dgvProfits.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvInvoices.DataSource = db.vExpencesInvoices.ToList();
            this.dgvInvoices.Columns["IdInvoice"].Visible = false;
            dgvInvoices.Columns[1].HeaderText = "Data wystawienia";
            dgvInvoices.Columns[2].HeaderText = "Wartość faktury";
            dgvInvoices.Columns[3].HeaderText = "Nazwa podmiotu";
            dgvInvoices.Columns[4].HeaderText = "Typ faktury";
            dgvInvoices.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvOrders.DataSource = db.vExpencesOrders.ToList();
            this.dgvOrders.Columns["IdSfOrder"].Visible = false;
            dgvOrders.Columns[1].HeaderText = "Wartość faktury";
            dgvOrders.Columns[2].HeaderText = "Data wystawienia";
            dgvOrders.Columns[3].HeaderText = "Nazwa podmiotu";
            dgvOrders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvOutsourcing.DataSource = db.vExpencesOutsourcings.ToList();
            this.dgvOutsourcing.Columns["IdOutsourcing"].Visible = false;
            dgvOutsourcing.Columns[1].HeaderText = "Wartość";
            dgvOutsourcing.Columns[2].HeaderText = "Data";
            dgvOutsourcing.Columns[3].HeaderText = "Nazwa podmiotu";
            dgvOutsourcing.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvSalaries.DataSource = db.vExpencesPayments.ToList();
            this.dgvSalaries.Columns["IdPayment"].Visible = false;
            dgvSalaries.Columns[1].HeaderText = "Podstawa wynagrodzenia";
            dgvSalaries.Columns[2].HeaderText = "Data wypłaty";
            dgvSalaries.Columns[3].HeaderText = "Premia";
            dgvSalaries.Columns[4].HeaderText = "Imię";
            dgvSalaries.Columns[5].HeaderText = "Nazwisko";
            dgvSalaries.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }
        private void btSum_Click(object sender, EventArgs e)
        {
            dgvProfits.DataSource = db.vIncomesProfits.ToList().Where(vIncomesProfits =>
            vIncomesProfits.OrderDate > dtpStartDate.Value && vIncomesProfits.OrderDate < dtpEndDate.Value)
            .Select(vIncomesProfits => new { vIncomesProfits.IdCustomer, vIncomesProfits.CustomerName, vIncomesProfits.OrderDate, vIncomesProfits.Cost })
            .ToList();
            dgvProfits.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvInvoices.DataSource = db.vExpencesInvoices.ToList().Where(vExpencesInvoices =>
            vExpencesInvoices.Date > dtpStartDate.Value && vExpencesInvoices.Date < dtpEndDate.Value)
            .Select(vExpencesInvoices => new { vExpencesInvoices.IdInvoice, vExpencesInvoices.Date, vExpencesInvoices.Sum, vExpencesInvoices.ContractorName, vExpencesInvoices.Type })
            .ToList();
            dgvInvoices.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvOrders.DataSource = db.vExpencesOrders.ToList().Where(vExpencesOrders =>
            vExpencesOrders.SfOrderDate > dtpStartDate.Value && vExpencesOrders.SfOrderDate < dtpEndDate.Value)
            .Select(vExpencesOrders => new { vExpencesOrders.IdSfOrder, vExpencesOrders.Cost, vExpencesOrders.SfOrderDate, vExpencesOrders.SupplierName })
            .ToList();
            dgvOrders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvOutsourcing.DataSource = db.vExpencesOutsourcings.ToList().Where(vExpencesOutsourcing =>
            vExpencesOutsourcing.EndCommitmentDate > dtpStartDate.Value && vExpencesOutsourcing.EndCommitmentDate < dtpEndDate.Value)
            .Select(vExpencesOutsourcing => new { vExpencesOutsourcing.IdOutsourcing, vExpencesOutsourcing.Cost, vExpencesOutsourcing.EndCommitmentDate, vExpencesOutsourcing.CompanyName })
            .ToList();
            dgvOutsourcing.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dgvSalaries.DataSource = db.vExpencesPayments.ToList().Where(vExpencesPayment =>
            vExpencesPayment.Date > dtpStartDate.Value && vExpencesPayment.Date < dtpEndDate.Value)
            .Select(vExpencesPayment => new { vExpencesPayment.IdPayment, vExpencesPayment.Date, vExpencesPayment.Sum, vExpencesPayment.Bonus, vExpencesPayment.EmployeeName, vExpencesPayment.EmployeeSurname })
            .ToList();
            dgvSalaries.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            decimal sumPayment = 0, sumOutsourcing = 0, sumInvoice = 0, sumOrders = 0, sumProfits = 0;
            for (int i = 0; i < dgvProfits.Rows.Count; i++)
            {
                sumProfits += Convert.ToDecimal(dgvProfits.Rows[i].Cells[3].Value);
            }
            tbSumIncome.Text = sumProfits.ToString("0,##");
            for (int i = 0; i < dgvSalaries.Rows.Count; i++)
            {
                sumPayment += Convert.ToDecimal(dgvSalaries.Rows[i].Cells[1].Value) + Convert.ToDecimal(dgvSalaries.Rows[i].Cells[3].Value);
            }
            for (int i = 0; i < dgvOutsourcing.Rows.Count; i++)
            {
                sumOutsourcing += Convert.ToDecimal(dgvOutsourcing.Rows[i].Cells[1].Value);
            }
            for (int i = 0; i < dgvOrders.Rows.Count; i++)
            {
                sumOrders += Convert.ToDecimal(dgvOrders.Rows[i].Cells[1].Value);
            }
            for (int i = 0; i < dgvInvoices.Rows.Count; i++)
            {
                sumInvoice += Convert.ToDecimal(dgvInvoices.Rows[i].Cells[2].Value);
            }
            decimal sumAll = sumProfits - sumPayment + sumOutsourcing + sumInvoice + sumOrders;
            if (sumPayment>0)  tbSumPayment.BackColor = Color.Green;
            else tbSumPayment.BackColor = Color.Red;
            if (sumAll > 0) tbPureMoney.BackColor = Color.Green;
            else tbPureMoney.BackColor = Color.Red;
            if (sumInvoice > 0) tbSumInvoices.BackColor = Color.Green;
            else tbSumInvoices.BackColor = Color.Red;
            if (sumOrders > 0) tbSumOrders.BackColor = Color.Green;
            else tbSumOrders.BackColor = Color.Red;
            if (sumOutsourcing > 0) tbSumOS.BackColor = Color.Green;
            else tbSumOS.BackColor = Color.Red;
            if (sumProfits > 0) tbSumIncome.BackColor = Color.Green;
            else tbSumIncome.BackColor = Color.Red;
            tbSumOS.Text = sumOutsourcing.ToString("0,##");
            tbSumPayment.Text = sumPayment.ToString("0,##");
            tbSumInvoices.Text = sumInvoice.ToString("0,##");
            tbSumOrders.Text = sumOrders.ToString("0,##");
            tbPureMoney.Text = sumAll.ToString("0,##");
        }
        private void btnGenerateGeneralReport_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTableInvoices = new PdfPTable(dgvInvoices.ColumnCount);
            pdfTableInvoices.DefaultCell.Padding = 3;
            pdfTableInvoices.WidthPercentage = 30;
            pdfTableInvoices.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTableInvoices.DefaultCell.BorderWidth = 1;
            foreach (DataGridViewColumn column in dgvInvoices.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTableInvoices.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgvInvoices.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTableInvoices.AddCell(cell.Value.ToString());
                }
            }
            PdfPTable pdfTableOrders = new PdfPTable(dgvOrders.ColumnCount);
            pdfTableOrders.DefaultCell.Padding = 3;
            pdfTableOrders.WidthPercentage = 30;
            pdfTableOrders.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTableOrders.DefaultCell.BorderWidth = 1;
            foreach (DataGridViewColumn column in dgvOrders.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTableOrders.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgvOrders.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTableOrders.AddCell(cell.Value.ToString());
                }
            }
            PdfPTable pdfTableOutsourcing = new PdfPTable(dgvOutsourcing.ColumnCount);
            pdfTableOutsourcing.DefaultCell.Padding = 3;
            pdfTableOutsourcing.WidthPercentage = 30;
            pdfTableOutsourcing.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTableOutsourcing.DefaultCell.BorderWidth = 1;
            foreach (DataGridViewColumn column in dgvOutsourcing.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTableOutsourcing.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgvOutsourcing.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTableOutsourcing.AddCell(cell.Value.ToString());
                }
            }
            PdfPTable pdfTableSalaries = new PdfPTable(dgvSalaries.ColumnCount);
            pdfTableSalaries.DefaultCell.Padding = 3;
            pdfTableSalaries.WidthPercentage = 30;
            pdfTableSalaries.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTableSalaries.DefaultCell.BorderWidth = 1;
            foreach (DataGridViewColumn column in dgvSalaries.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTableSalaries.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgvSalaries.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTableSalaries.AddCell(cell.Value.ToString());
                }
            }
            PdfPTable pdfTableIncomes = new PdfPTable(dgvProfits.ColumnCount);
            pdfTableIncomes.DefaultCell.Padding = 3;
            pdfTableIncomes.WidthPercentage = 30;
            pdfTableIncomes.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTableIncomes.DefaultCell.BorderWidth = 1;
            foreach (DataGridViewColumn column in dgvProfits.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTableIncomes.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgvProfits.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTableIncomes.AddCell(cell.Value.ToString());
                }
            }
            string folderPath = @"C:\Users\mbrominski\Desktop\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "RaportWydatkiRoofingCompany.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTableInvoices);
                pdfDoc.Add(pdfTableOrders);
                pdfDoc.Add(pdfTableOutsourcing);
                pdfDoc.Add(pdfTableSalaries);
                pdfDoc.Add(pdfTableIncomes);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Pomyślnie wygenerowano raport.");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.finances.Show();
            this.Hide();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.startForm.Show();
        }
    }
}