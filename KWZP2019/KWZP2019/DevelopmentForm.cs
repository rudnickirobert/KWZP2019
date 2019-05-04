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
    public partial class DevelopmentForm : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private QualityControl qualityControlForm;

        public DevelopmentForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.qualityControlForm.Close();
            this.Close();
        }

        private void DevelopmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
            this.qualityControlForm.Close();
        }
    }
}
