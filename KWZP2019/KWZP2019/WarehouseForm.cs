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
    public partial class WarehouseForm : Form
    {
        private SalesDepartmentForm salesForm;
        private RoofingCompanyEntities db;
        private CustomerForm customerForm;
        private bool isPreviousForm = false;
        public WarehouseForm(RoofingCompanyEntities db, SalesDepartmentForm salesForm)
        {
            this.db = db;
            this.salesForm= salesForm;
            isPreviousForm = false;
            InitializeComponent();
        }
        public WarehouseForm(RoofingCompanyEntities db, SalesDepartmentForm salesForm, CustomerForm previousForm)
        {
            this.db = db;
            this.salesForm = salesForm;
            this.customerForm = previousForm;
            isPreviousForm = true;
            InitializeComponent();
        }
        private void WarehouseForm_Load(object sender, EventArgs e)
        {
            entraceWarehouseDgv.DataSource = db.vInputMagazines.ToList();
            entraceWarehouseDgv.Columns["Numer"].Visible = false;
            outWarehouseDgv.DataSource = db.vOutputMagazines.ToList();
            outWarehouseDgv.Columns["Numer"].Visible = false;
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            salesForm.Show();
            this.Close();
        }
        private void orderReturnBtn_Click(object sender, EventArgs e)
        {
            if (isPreviousForm)
            {
                this.Hide();
                customerForm.Show();
                this.Close();
            }
            else
            {
                salesForm.Show();
            }
            
        }
        private void sfOrderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SfOrdersForm newSfOrdersForm = new SfOrdersForm(db, salesForm);
            newSfOrdersForm.ShowDialog();
            this.Close();
        }
        private void semiFinishedCodeTb_TextChanged(object sender, EventArgs e)
        {
            if (semiFinishedCodeTb.Text.Trim() == "")
            {
                entraceWarehouseDgv.DataSource = db.vInputMagazines.ToList();
                entraceWarehouseDgv.Columns["Numer"].Visible = false;
            }
            else
            {
                entraceWarehouseDgv.DataSource = (from db in db.vInputMagazines
                                                  where
                                                   db.Kod_Produktu.Contains(semiFinishedCodeTb.Text.Trim())
                                                  select db).ToList();
                entraceWarehouseDgv.Columns["Numer"].Visible = false;
            }
        }
        private void productCodeTb_TextChanged(object sender, EventArgs e)
        {
            if (productCodeTb.Text.Trim() == "")
            {
                outWarehouseDgv.DataSource = db.vOutputMagazines.ToList();
                outWarehouseDgv.Columns["Numer"].Visible = false;
            }
            else
            {
                outWarehouseDgv.DataSource = (from db in db.vOutputMagazines
                                              where
                                               db.Kod_produktu.Contains(productCodeTb.Text.Trim())
                                              select db).ToList();
                outWarehouseDgv.Columns["Numer"].Visible = false;
            }
        }
    }
}
