﻿using System;
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
    public partial class EntranceControlForm : Form
    {
        RoofingCompanyEntities db;
        startForm sf;
        QualityControl qc;

        public EntranceControlForm(RoofingCompanyEntities db, startForm sf, QualityControl qc)
        {
            this.db = db;
            this.sf = sf;
            this.qc = qc;
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.sf.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qc.Show();
            this.Hide();
        }

        private void EntranceControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.sf.Show();
        }
    }
}
