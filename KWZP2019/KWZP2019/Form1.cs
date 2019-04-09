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
    public partial class startForm : Form
    {
        RoofingCompanyEntities db;

        public startForm()
        {
            InitializeComponent();
            db = new RoofingCompanyEntities();
        }

        private void btnQA_Click(object sender, EventArgs e)
        {
            QualityControl qc = new QualityControl(db, this);
            qc.Show();
            this.Hide();
        }
    }
}
