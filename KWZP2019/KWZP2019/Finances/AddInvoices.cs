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
    public partial class AddInvoices : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private Finances finances;
        public AddInvoices(RoofingCompanyEntities db, StartForm startForm, Finances finances)
        {
            this.db = db;
            this.startForm = startForm;
            this.finances = finances;
            InitializeComponent();
        }
        private void AddInvoices_Load(object sender, EventArgs e)
        {
            List<InvoiceType> invoice = db.InvoiceTypes.ToList();
            foreach (InvoiceType typeList in invoice)
            {
                cbInvoiceType.Items.Add(typeList.Type);
            }
        }
        private void btnAddNewInvoice_Click(object sender, EventArgs e)
        {
            Invoice newInvoiceValue = new Invoice();
            int indexInvoice = cbInvoiceType.SelectedIndex;
            int indexContractor = cbContractors.SelectedIndex;
            newInvoiceValue.IdInvoiceType = indexInvoice+1;
            newInvoiceValue.IdContractor = indexContractor+1;
            newInvoiceValue.Sum = decimal.Parse(tbInvoiceValue.Text.Trim());
            newInvoiceValue.Date = DateTime.Parse(dtpDateAdded.Value.ToString("yyyy-MM-dd"));
            db.Invoices.Add(newInvoiceValue);
            db.SaveChanges();
        }
        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {
            AddNewCompany addNewCompany = new AddNewCompany(db, startForm, this);
            addNewCompany.Show();
            this.Hide();
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
        private void cbContractors_Click(object sender, EventArgs e)
        {
            List<Contractor> contractorList = db.Contractors.ToList();
            cbContractors.Items.Clear();
            foreach (Contractor contractor in contractorList)
            {
                cbContractors.Items.Add(contractor.ContractorName);
            } 
        }
    }
}
