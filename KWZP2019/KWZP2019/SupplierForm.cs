using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class SupplierForm : Form
    {
        RoofingCompanyEntities db;
        public SupplierForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void addNewSupplierBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewSupplierForm addnewsupplierForm = new AddNewSupplierForm(db);
            addnewsupplierForm.ShowDialog();
            this.Close();
        }
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            supplierDgv.DataSource = db.Suppliers.ToList();
        }
        private void buttonreturnSupplierForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dostawcapolfabrykatu_rb_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Dostawcapolfabrykatu_rb.Checked)
            {
                supplierDgv.DataSource = (from db in db.vSupplierSemis
                                          where
                                          db.Typ.Contains("Półfabrykaty")
                                          select db).ToList();
            }

            if (DOstawcaczesci_rb.Checked)
            {
                supplierDgv.DataSource = (from db in db.vSupplierParts
                                          where
                                          db.Typ.Contains("Części")
                                          select db).ToList();
            }
        }
    }
}
