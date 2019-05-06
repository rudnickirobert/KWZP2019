﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KWZP2019
{
    public partial class Examination : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        HR hr;
        public Examination(RoofingCompanyEntities db, StartForm startForm, HR hr)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
        }

        private void Examination_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnAddExamination_Click(object sender, EventArgs e)
        {
            AddExamination addExamination = new AddExamination(db,startForm, this);
            addExamination.Show();
            this.Hide();
        }

        private void tbSearchEmployeeExamination_TextChanged(object sender, EventArgs e)
        {
            dgvExamination.DataSource = db.vExaminations.
                Where (examination => examination.EmployeeSurname.StartsWith(tbSearchEmployeeExamination.Text)
                                   && examination.EmployeeName.StartsWith(tbSearchEmployeeExaminationName.Text)).
                Select (examinationSource => new {
                        examinationSource.EmployeeSurname,
                        examinationSource.EmployeeName,
                        examinationSource.Date
                }).ToList();
        }

        private void tbSearchEmployeeExaminationName_TextChanged(object sender, EventArgs e)
        {
            dgvExamination.DataSource = db.vExaminations.
                   Where (examination => examination.EmployeeSurname.StartsWith(tbSearchEmployeeExamination.Text)
                                      && examination.EmployeeName.StartsWith(tbSearchEmployeeExaminationName.Text)).
                   Select (examinationSource => new {
                           examinationSource.EmployeeSurname,
                           examinationSource.EmployeeName,
                           examinationSource.Date
                   }).ToList();
        }

        void display()
        {
            dgvExamination.DataSource = db.vExaminations.
                Select(examinationSource => new {
                    examinationSource.EmployeeSurname,
                    examinationSource.EmployeeName,
                    examinationSource.Date
                }).ToList();

            dgvExamination.Columns[0].HeaderText = "Nazwisko";
            dgvExamination.Columns[1].HeaderText = "Imię";
            dgvExamination.Columns[2].HeaderText = "Data ważności badań lekarskich";

            dgvExamination.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExamination.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExamination.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.hr.Show();
            this.Hide();
        }
    }
}
