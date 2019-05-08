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
    public partial class AllIncomes : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private Finances finances;
        public AllIncomes(RoofingCompanyEntities db, StartForm startForm, Finances finances)
        {
            this.db = db;
            this.startForm = startForm;
            this.finances = finances;
            InitializeComponent();
        }
        private void AllCosts_Load(object sender, EventArgs e)
        {
            dgvProfits.DataSource = db.vIncomesProfits.ToList();
            this.dgvProfits.Columns["IdCustomer"].Visible = false;
            dgvProfits.Columns[1].HeaderText = "Nazwa klienta";
            dgvProfits.Columns[2].HeaderText = "Data zamówienia";
            dgvProfits.Columns[3].HeaderText = "Wartość zamówienia";
            dgvProfits.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void btnAcceptSelectedTime_Click(object sender, EventArgs e)
        {
            dgvProfits.DataSource = db.vIncomesProfits.ToList().Where(vIncomesProfits =>
            vIncomesProfits.OrderDate > dtpStartDate.Value && vIncomesProfits.OrderDate < dtpEndDate.Value).ToList();
            dgvProfits.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void btSum_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            for (int i = 0; i < dgvProfits.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dgvProfits.Rows[i].Cells[3].Value);
            }
            tbSumIncome.Text = sum.ToString("0,##");
        }
        private void btnGenerateGeneralReport_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dgvProfits.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            foreach (DataGridViewColumn column in dgvProfits.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgvProfits.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
            string folderPath = @"C:\Users\mbrominski\Desktop\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "RaportPrzychodyRoofingCompany.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Pomyślnie wygenerowano raport.");
        }
        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.finances.Show();
            this.Hide();
        }
    }
}