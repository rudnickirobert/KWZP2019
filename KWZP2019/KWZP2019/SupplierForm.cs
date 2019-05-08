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
        private RoofingCompanyEntities db;
        private SalesDepartmentForm previousForm;
        public SupplierForm(RoofingCompanyEntities db, SalesDepartmentForm form)
        {
            InitializeComponent();
            this.db = db;
            this.previousForm = form;
        }

        private void addNewSupplierBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewSupplierForm addnewsupplierForm = new AddNewSupplierForm(db, this);
            addnewsupplierForm.ShowDialog();
        }
        private void SupplierForm_Load_1(object sender, EventArgs e)
        {
            supplierDgv.DataSource = db.Suppliers.ToList();
        
        }
        
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
            this.Close();
        }

        private void sfSupplierRb_CheckedChanged(object sender, EventArgs e)
        {
            
            if (sfSupplierRb.Checked)
            {
                supplierDgv.DataSource = (from db in db.vSupplierSemis
                                          where
                                          db.Typ.Contains("Półfabrykaty")
                                          select db).ToList();
            }

            if (partsSupplierRb.Checked)
            {
                supplierDgv.DataSource = (from db in db.vSupplierParts
                                          where
                                          db.Typ.Contains("Części")
                                          select db).ToList();
            }
        }
    }
}
