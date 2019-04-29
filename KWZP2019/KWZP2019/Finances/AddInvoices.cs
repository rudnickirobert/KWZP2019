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
    public partial class AddInvoices : Form
    {
        SqlConnection con = new SqlConnection("server = .\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        SqlCommand cmd;

        RoofingCompanyEntities db;
        public AddInvoices(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
        private void btnAddNewCompany_Click(object sender, EventArgs e)
        {
            AddNewCompany addnewcompany = new AddNewCompany(db);
            addnewcompany.Show();
            this.Hide();
        }
        void clear()
        {
            tbInvoiceValue.Text = "";
        }
            private void btnAddNewInvoice_Click(object sender, EventArgs e)
        {
            Invoice newInvoiceValue = new Invoice();
            newInvoiceValue.Sum = decimal.Parse(tbInvoiceValue.Text.Trim());
            int selectedIndex = comboBox1.SelectedIndex + 1;
            newInvoiceValue.IdInvoiceType = selectedIndex;
            newInvoiceValue.Date = DateTime.Parse(dtpDateadded.Value.ToString("yyyy-MM-dd"));
            db.Invoices.Add(newInvoiceValue);
            db.SaveChanges();
        }
    }
}
