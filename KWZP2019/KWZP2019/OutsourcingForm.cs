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
            outsourcingTypeDgv.DataSource = db.OutsourcingTypes.ToList();
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
        private void txtBSerachOutsourcing_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (txtBSerachOutsourcing.Text.Trim().Length < 1)
            
            {
                outsourcingTypeDgv.DataSource = db.Outsourcings.ToList();
                nameOutsourcingDgv.DataSource = db.OutsourcingCommitments.ToList();
                detailsOutsourcingDgv.DataSource = db.Outsourcings.ToList();
            }
            else
            {
                outsourcingTypeDgv.DataSource =  db.vOutsourcingTypes.ToList();
                outsourcingTypeDgv.Columns[0].Visible = false;
            }
        }

        private void outsourcingTypeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.outsourcingTypeDgv.CurrentRow.Cells[0].Value);

            detailsOutsourcingDgv.DataSource = (from Outsourcing in db.Outsourcings
                                                where Outsourcing.IdOutsourcing == id
                                                select Outsourcing).ToList();
            detailsOutsourcingDgv.Columns[0].Visible = false;
            nameOutsourcingDgv.DataSource = (from OutsourcingCommitment in db.OutsourcingCommitments
                                             where OutsourcingCommitment.IdOutsourcing == id
                                             select OutsourcingCommitment).ToList();
            nameOutsourcingDgv.Columns[0].Visible = false;
        }
    }
}
