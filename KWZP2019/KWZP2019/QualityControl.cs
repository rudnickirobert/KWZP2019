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

        public QualityControl(RoofingCompanyEntities dbQC)
        {
            db = dbQC;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void btnEntranceControl_Click(object sender, EventArgs e)
        {
            EntranceControlForm ec = new EntranceControlForm(db);
            ec.Show();
        }
    }
}
