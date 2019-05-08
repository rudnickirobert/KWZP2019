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
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            supplierDgv.DataSource = db.Suppliers.ToList();
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
            this.Close();
        }
        private void sfSupplierRb_CheckedChanged_1(object sender, EventArgs e)
        {
            if (sfSupplierRb.Checked)
            {
                supplierDgv.DataSource = db.vSupplierSemis.
                Where(semis => semis.Typ == "Półfabrykaty").ToList();
                supplierDgv.Columns[0].Visible = false;
            }
            if (partsSupplierRb.Checked)
            {
                supplierDgv.DataSource = db.vSupplierParts.
                Where(parts => parts.Typ == "Części").ToList();
                supplierDgv.Columns[0].Visible = false;
            }
        }
        private void sfSupplierRb_Enter(object sender, EventArgs e)
        {
            if (sfSupplierRb.Checked)
            {
                supplierDgv.DataSource = db.vSupplierSemis.
                Where(semis => semis.Typ == "Półfabrykaty").ToList();
                supplierDgv.Columns[0].Visible = false;
            }
            if (partsSupplierRb.Checked)
            {
                supplierDgv.DataSource = db.vSupplierParts.
                Where(parts => parts.Typ == "Części").ToList();
                supplierDgv.Columns[0].Visible = false;
            }
        }
    }
}
