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
    public partial class MaintenanceDescriptionForm : Form
    {
        RoofingCompanyEntities db;
        MaintDescription maintenanceDescription;

        public MaintenanceDescriptionForm(RoofingCompanyEntities db, int tIdMaintDescription)
        {      
            this.maintenanceDescription = db.MaintDescriptions.Where(maintenanceDescription => maintenanceDescription.IdMaintDesc == tIdMaintDescription).First();
            this.txtShortDescription.Text = maintenanceDescription.MaintDescName;
            this.txtDetailDescription.Text = maintenanceDescription.MaintDescription1;
            tIdMaintDescription = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
