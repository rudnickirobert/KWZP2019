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
    public partial class WarehouseForm : Form
    {
        private SalesDepartmentForm previousForm;
        private RoofingCompanyEntities db;
        public WarehouseForm(RoofingCompanyEntities db, SalesDepartmentForm form)
        {
            this.db = db;
            this.previousForm = form;
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
            this.Close();
        }
    }
}
