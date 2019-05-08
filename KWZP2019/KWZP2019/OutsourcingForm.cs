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
    public partial class OutsourcingForm : Form
    {
        private RoofingCompanyEntities db;
        private SalesDepartmentForm previousForm;
        public OutsourcingForm(RoofingCompanyEntities db, SalesDepartmentForm form)
        {
            this.db = db;
            this.previousForm = form;
            InitializeComponent();
        }
        private void OutsourcingForm_Load(object sender, EventArgs e)
        {
            outsourcingTypeDgv.DataSource = db.vOutsourcingTypes.ToList();
            outsourcingTypeDgv.Columns["Numer"].Visible = false;
        }
        private void addNewOutsourcingCompanyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewOutsourcingCompanyForm addnewoutsourcingcompanyForm = new AddNewOutsourcingCompanyForm(db, this);
            addnewoutsourcingcompanyForm.ShowDialog();
        }
        private void returnCancelOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
            this.Close();
        }
        private void txtBSerachOutsourcing_TextChanged(object sender, EventArgs e)
        {
            if (txtBSerachOutsourcing.Text.Trim().Length < 1)

            {
                outsourcingTypeDgv.DataSource = db.vOutsourcingTypes.ToList();
                outsourcingTypeDgv.Columns["Numer"].Visible = false;
                nameOutsourcingDgv.DataSource = db.vOutsourcingCommitments.ToList();
                nameOutsourcingDgv.Columns["Numer"].Visible = false;
                detailsOutsourcingDgv.DataSource = db.vOutsourcings.ToList();
                detailsOutsourcingDgv.Columns["Numer"].Visible = false;
            }
            else
            {
                outsourcingTypeDgv.DataSource = db.vOutsourcingTypes.ToList();
                outsourcingTypeDgv.Columns["Numer"].Visible = false;
                nameOutsourcingDgv.DataSource = (from db in db.vOutsourcingCommitments
                                                 where
                                                 db.Nazwa.Contains(txtBSerachOutsourcing.Text.Trim())
                                                 select db).ToList();
                nameOutsourcingDgv.Columns["Numer"].Visible = false;
                detailsOutsourcingDgv.DataSource = (from db in db.vOutsourcings
                                                    where
                                                    db.Nazwa.Contains(txtBSerachOutsourcing.Text.Trim())
                                                    select db).ToList();
                detailsOutsourcingDgv.Columns["Numer"].Visible = false;
            }
        }

        private void outsourcingTypeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.outsourcingTypeDgv.CurrentRow.Cells["Numer"].Value);

            detailsOutsourcingDgv.DataSource = (from Outsourcing in db.vOutsourcings
                                                where Outsourcing.Numer == id
                                                select Outsourcing).ToList();
            detailsOutsourcingDgv.Columns["Numer"].Visible = false;
            nameOutsourcingDgv.DataSource = (from OutsourcingCommitment in db.vOutsourcingCommitments
                                             where OutsourcingCommitment.Numer == id
                                             select OutsourcingCommitment).ToList();
            nameOutsourcingDgv.Columns["Numer"].Visible = false;
        }
    }
}
