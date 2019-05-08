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
    public partial class MaintenanceManagement : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        public MaintenanceManagement(RoofingCompanyEntities db, StartForm startForm)
        {
            this.db = db;
            this.startForm = startForm;
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void btnNewMaintenance_Click(object sender, EventArgs e)
        {
            FailureListForm failureListForm = new FailureListForm(this.db, startForm, this);
            this.Hide();
            failureListForm.Show();
        }

        private void btnMachines_Click(object sender, EventArgs e)
        {
            MachinesForm machinesForm = new MachinesForm(db, startForm, this);
            this.Hide();
            machinesForm.Show();
        }

        private void btnParts_Click(object sender, EventArgs e)
        {
            PartsForm partsForm = new PartsForm(db, this);
            this.Hide();
            partsForm.Show();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            MaintenanceCalendarForm maintenanceCalendarForm = new MaintenanceCalendarForm(db, startForm, this);
            this.Hide();
            maintenanceCalendarForm.Show();
        }

        private void btnNewInspection_Click(object sender, EventArgs e)
        {
            InspectionListForm inspectionListForm = new InspectionListForm(db, startForm, this);
            this.Hide();
            inspectionListForm.Show();
        }

        private void btnDescList_Click(object sender, EventArgs e)
        {
            DescriptionList descriptionList = new DescriptionList(db, startForm, this);
            this.Hide();
            descriptionList.Show();
        }
    }
}
