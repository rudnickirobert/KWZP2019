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
    public partial class AddNewCompany : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private AddInvoices addInvoices;
        public AddNewCompany(RoofingCompanyEntities db, StartForm startForm, AddInvoices addInvoices)
        {
            this.db = db;
            this.startForm = startForm;
            this.addInvoices = addInvoices;
            InitializeComponent();
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
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (tbCompanyName.Text.Trim() == "" || tbNIP.Text.Trim() == "" || tbPhone.Text.Trim() == "" || tbKRS.Text.Trim() == "")
            {
                MessageBox.Show("Nazwa, NIP oraz telefon kontaktowy są wymagane!");
                return;
            }
            Contractor newContractor = new Contractor();
            newContractor.ContractorName = tbCompanyName.Text.Trim();
            tbPhone.MaxLength = 9;
            newContractor.Phone = int.Parse(tbPhone.Text.Trim());
            newContractor.Email = tbEmail.Text.Trim();
            newContractor.City = tbCity.Text.Trim();
            newContractor.PostalCode = tbPostalCode.Text.Trim();
            newContractor.Street = tbStreet.Text.Trim();
            newContractor.HouseNumber = tbHouseNumber.Text.Trim();
            newContractor.ApartmentNumber = tbLocalNumber.Text.Trim();
            tbNIP.MaxLength = 10;
            newContractor.NIP = long.Parse(tbNIP.Text.Trim());
            tbKRS.MaxLength = 10;
            newContractor.KRS = long.Parse(tbKRS.Text.Trim());
            newContractor.Description = tbDescription.Text.Trim();
            db.Contractors.Add(newContractor);
            db.SaveChanges();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.addInvoices.Show();
            this.Hide();
        }
        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }
    }
}
