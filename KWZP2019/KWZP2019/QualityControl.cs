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
    public partial class QualityControl : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;

        public QualityControl(RoofingCompanyEntities db, StartForm startForm)
        {
            this.db = db;
            this.startForm = startForm;
            InitializeComponent();
        }

        private void btnEntranceControl_Click(object sender, EventArgs e)
        {
            EntranceControlForm entranceControlForm = new EntranceControlForm(db, startForm, this);
            this.Hide();
            entranceControlForm.Show();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Close();
        }

        private void btnOutControl_Click(object sender, EventArgs e)
        {
            OutControlForm outControlForm = new OutControlForm(db, startForm, this);
            outControlForm.Show();
            this.Hide();
        }

        private void QualityControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
        }

        private void btnOSHTraining_Click(object sender, EventArgs e)
        {
            OshTrainingForm oshTrainingForm = new OshTrainingForm(db, startForm, this);
            this.Hide();
            oshTrainingForm.Show();
        }

        private void btnOSHControl_Click(object sender, EventArgs e)
        {
            OSHControl oshControlForm = new OSHControl(db, startForm, this);
            this.Hide();
            oshControlForm.Show();
        }

        private void btnDevelopment_Click(object sender, EventArgs e)
        {
            DevelopmentForm developmentForm = new DevelopmentForm(db, startForm, this);
            this.Hide();
            developmentForm.Show();
        }
    }
}
