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
    public partial class OutsourcingForm : Form
    {
        RoofingCompanyEntities db;
        public OutsourcingForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void OutsourcingForm_Load(object sender, EventArgs e)
        {
            outsourcingTypeDgv.DataSource = db.OutsourcingTypes.ToList();
        }

        private void addNewOutsourcingCompanyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewOutsourcingCompanyForm addnewoutsourcingcompanyForm = new AddNewOutsourcingCompanyForm();
            addnewoutsourcingcompanyForm.ShowDialog();
            this.Close();
        }

        private void returnCancelOutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBSerachOutsourcing_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (txtBSerachOutsourcing.Text.Trim().Length< 1)
            
            {
                outsourcingTypeDgv.DataSource = db.Outsourcings.ToList();
            }
            else
            {
                outsourcingTypeDgv.DataSource = (from db in db.vOutsourcingWithType
                                           where
                                            db.CompanyName.Contains(txtBSerachOutsourcing.Text.Trim())
                                            || db.OutsourcingType.Contains(txtBSerachOutsourcing.Text.Trim())
                                           select db).ToList();
            }
        }

        private void outsourcingTypeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(this.outsourcingTypeDgv.CurrentRow.Cells[0].Value);

            outsourcingDgv.DataSource = (from Outsourcing in db.Outsourcings
                                     where Outsourcing.IdOutsourcing == id
                                     select Outsourcing).ToList();
        }
    }
}
