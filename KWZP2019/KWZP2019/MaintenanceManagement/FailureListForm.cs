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
    public partial class FailureListForm : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        MaintenanceManagement maintenanceManagementForm;

        public FailureListForm(RoofingCompanyEntities db, StartForm startForm, MaintenanceManagement maintenanceManagementForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.maintenanceManagementForm = maintenanceManagementForm;
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.maintenanceManagementForm.Show();
            this.Hide();
        }

        private void btnNewMaintenance_Click(object sender, EventArgs e)
        {
            NewMaintenanceForm newMaintenanceForm = new NewMaintenanceForm(this.db, startForm, this);
            this.Hide();
            newMaintenanceForm.Show();
        }

        void PopulateDataGridView()
        {
            this.dgvNewFailures.AutoGenerateColumns = false;
            using (RoofingCompanyEntities db = new RoofingCompanyEntities())
            {
                this.dgvNewFailures.DataSource = db.vNewFailures.ToList<vNewFailures>();
            }
        }

        private void FailureListForm_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}