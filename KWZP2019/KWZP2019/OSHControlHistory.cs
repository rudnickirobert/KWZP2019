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
    public partial class OSHControlHistory : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private OSHControl oSHControl;

        public OSHControlHistory(RoofingCompanyEntities db, StartForm startForm, OSHControl oSHControl)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.oSHControl = oSHControl;
        }

        private void OSHControlHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.oSHControl.Show();
        }

        private void OSHControlHistory_Load(object sender, EventArgs e)
        {
            dGVControlHistory.DataSource = db.SafetyControlHistoryViews.ToList();
            dGVControlHistory.Columns[0].HeaderText = "Numer kontroli";
            dGVControlHistory.Columns[1].HeaderText = "Nazwa firmy";
            dGVControlHistory.Columns[2].HeaderText = "Kontroler";
            dGVControlHistory.Columns[3].HeaderText = "Data";
            dGVControlHistory.Columns[4].HeaderText = "Pracownik";
            dGVControlHistory.Columns[5].HeaderText = "Opis";
        }
    }
}
