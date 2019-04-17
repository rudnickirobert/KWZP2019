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

        private void BtnParts_Click(object sender, EventArgs e)
        {
            PartsForm partsForm = new PartsForm(db, startForm, this);
            this.Hide();
            partsForm.Show();
        }

        private void BtnMachines_Click(object sender, EventArgs e)
        {
            MachinesForm machinesForm = new MachinesForm(db, startForm, this);
            this.Hide();
            machinesForm.Show();
        }

        private void BtnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void btnNewMaintenance_Click(object sender, EventArgs e)
        {
            NewMaintenanceForm newMaintenanceForm = new NewMaintenanceForm(db, startForm, this);
            this.Hide();
            newMaintenanceForm.Show();
        }
    }
}
