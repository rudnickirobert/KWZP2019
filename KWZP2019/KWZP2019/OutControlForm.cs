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
    public partial class OutControlForm : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private QualityControl qualityControlForm;

        public OutControlForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            InitializeComponent();
            ComponentsDataInitialize();
        }

        private void ComponentsDataInitialize()
        {
            cbProcessNumber.DataSource = db.vUnfinishedProcess.ToList();
            cbProcessNumber.DisplayMember = "IdProces";
            cbProcessNumber.ValueMember = "IdProces";
            cbControlerId.DataSource = db.Employees.ToList();
            cbControlerId.ValueMember = "IdEmployee";
            stpStartDate.Value = DateTime.Today;
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void OutControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }

        private void btnSMeasures_Click(object sender, EventArgs e)
        {
            int procesNumber = Int32.Parse(cbProcessNumber.SelectedValue.ToString());

            OutMeasures outControlForm = new OutMeasures(db, startForm, qualityControlForm, this, procesNumber);
            outControlForm.Show();
        }

        private void cbControlerId_Format(object sender, ListControlConvertEventArgs e)
        {
            int id = ((Employee)e.ListItem).IdEmployee;
            string lastname = ((Employee)e.ListItem).EmployeeName;
            string firstname = ((Employee)e.ListItem).EmployeeSurname;
            e.Value = id +" "+ lastname + " " + firstname;
        }
    }
}
