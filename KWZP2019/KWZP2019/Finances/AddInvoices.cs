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
        private Finances Finances;
        public AddInvoices(RoofingCompanyEntities db, StartForm startForm, Finances Finances)
        {
            this.db = db;
            this.startForm = startForm;
            this.Finances = Finances;
            InitializeComponent();
        }
        private void AddInvoices_Load(object sender, EventArgs e)
        {
            List<InvoiceType> invoice = db.InvoiceTypes.ToList();
            foreach (InvoiceType typeList in invoice)
            {
                cbInvoiceType.Items.Add(typeList.Type);
            }
            List<Contractor> contractorList = db.Contractors.ToList();
            foreach (Contractor contractor in contractorList)
            {
                cbContractors.Items.Add(contractor.ContractorName);
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
            AddNewCompany addNewCompany = new AddNewCompany(db);
            addNewCompany.ShowDialog();
        }
    }
}
