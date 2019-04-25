using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class AddInvoices : Form
    {
        RoofingCompanyEntities db;
        public AddInvoices(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
            clear();
        }
        private void InvoiceTypesLoad(object sender, EventArgs e)
        {
            List<InvoiceType> invoiceList = db.InvoiceTypes.ToList();
            foreach (InvoiceType inv in invoiceList)
            {
                InvoiceTypes.Items.Add(inv.Type);
            }
        }
void clear()
        {
            tbCompanyName.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            tbCity.Text = "";
            tbPostalCode.Text = "";
            tbHouseNumber.Text = "";
            tbStreet.Text = "";
            tbLocalNumber.Text = "";
            tbNIP.Text = "";
            tbKRS.Text = "";
            tbDescription.Text = "";
            tbInvoiceValue.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbCompanyName.Text.Trim() == "" || tbNIP.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa i NIP s¹ wymagane");
            }
            Contractor newContractor = new Contractor();
            newContractor.ContractorName = tbCompanyName.Text.Trim();
            newContractor.Phone = int.Parse(tbPhone.Text.Trim());
            newContractor.Email = tbEmail.Text.Trim();
            newContractor.City = tbCity.Text.Trim();
            newContractor.PostalCode = tbPostalCode.Text.Trim();
            newContractor.Street = tbStreet.Text.Trim();
            newContractor.HouseNumber = tbHouseNumber.Text.Trim();
            newContractor.ApartmentNumber = tbLocalNumber.Text.Trim();
            newContractor.NIP = long.Parse(tbNIP.Text.Trim());
            newContractor.KRS = long.Parse(tbKRS.Text.Trim());
            newContractor.Description = tbDescription.Text.Trim();
            Invoice newInvoiceValue = new Invoice();
            newInvoiceValue.Sum = decimal.Parse(tbInvoiceValue.Text.Trim());

            

        db.Invoices.Add(newInvoiceValue);
            db.Contractors.Add(newContractor);
            db.SaveChanges();
        }


    }
}