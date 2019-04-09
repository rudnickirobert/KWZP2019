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
    public partial class QualityControl : Form
    {
        RoofingCompanyEntities db;
        startForm sf;

        public QualityControl(RoofingCompanyEntities db, startForm sf)
        {
            this.db = db;
            this.sf = sf;
            InitializeComponent();
        }

        private void btnEntranceControl_Click(object sender, EventArgs e)
        {
            EntranceControlForm ec = new EntranceControlForm(db, sf, this);
            this.Hide();
            ec.Show();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.sf.Show();
            this.Hide();
        }

        private void btnOutControl_Click(object sender, EventArgs e)
        {
            OutControlForm oc = new OutControlForm(db, sf, this);
            oc.Show();
            this.Hide();
        }

        private void QualityControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.sf.Show();
        }
    }
}
