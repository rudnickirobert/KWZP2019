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
    public partial class HR : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        FinancesAndHR finanseIHR;
        public HR(RoofingCompanyEntities db, StartForm startForm, FinancesAndHR finanseIHR)
        {
            this.db = db;
            this.startForm = startForm;
            this.finanseIHR = finanseIHR;
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(db, startForm, this);
            addEmployee.Show();
            this.Hide();
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            Examination examination = new Examination(db, startForm, this);
            examination.Show();
            this.Hide();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
                int id = int.Parse(dgvEmloyees.SelectedRows[0].Cells[5].Value.ToString());
                EmployeeDetails employeeDetails = new EmployeeDetails(db, startForm, this, id);
                employeeDetails.Show();
                this.Hide();
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            Absences absences = new Absences(db, startForm, this);
            absences.Show();
            this.Hide();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            AddTraining addTraining = new AddTraining(db, startForm, this);
            addTraining.Show();
            this.Hide();
        }

        private void HR_Load(object sender, EventArgs e)
        {
            dgvEmloyees.DataSource = db.vHRs.
                Select (employeesSelect => new {
                        employeesSelect.EmployeeSurname,
                        employeesSelect.EmployeeName,
                        employeesSelect.Workplace,
                        employeesSelect.PhoneNumber,
                        employeesSelect.PESEL,
                        employeesSelect.IdEmployee }).
                OrderBy (EmployeeOrderBy => EmployeeOrderBy.EmployeeSurname).
                ToList();

            dgvEmloyees.Columns[5].Visible = false;

            dgvEmloyees.Columns[0].HeaderText = "Nazwisko";
            dgvEmloyees.Columns[1].HeaderText = "Imię";
            dgvEmloyees.Columns[2].HeaderText = "Stanowisko";
            dgvEmloyees.Columns[3].HeaderText = "Numer";
            dgvEmloyees.Columns[4].HeaderText = "PESEL";

            dgvEmloyees.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmloyees.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmloyees.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmloyees.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmloyees.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            lbWarningsContracts.Items.Add(String.Format("{0, -52} {1, 0}",
                "Kończące się umowy: ", db.vHRContracts.Count()));

            lbWarningsExamination.Items.Add(String.Format("{0, -45} {1, 0}", 
                "Kończące się badania lekarskie: ", db.vHRExaminations.Count()));
        }

        private void tbEmployeeSearching_TextChanged(object sender, EventArgs e)
        {
            dgvEmloyees.DataSource = db.vHRs.
                Where (employees => employees.EmployeeSurname.StartsWith(tbEmployeeSearching.Text)).
                Select (employeesSelect => new {
                        employeesSelect.EmployeeSurname,
                        employeesSelect.EmployeeName,
                        employeesSelect.Workplace,
                        employeesSelect.PhoneNumber,
                        employeesSelect.City,
                        employeesSelect.IdEmployee }).
                OrderBy (EmployeeOrderBy => EmployeeOrderBy.EmployeeSurname).
                ToList();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            Contracts contracts = new Contracts(db, startForm, this);
            contracts.Show();
            this.Hide();
        }

        private void lbWarningsExamination_DoubleClick(object sender, EventArgs e)
        {
            Examination examination = new Examination(db, startForm, this);
            examination.Show();
            this.Hide();
        }

        private void lbWarningsContracts_DoubleClick(object sender, EventArgs e)
        {
            Contracts contracts = new Contracts(db, startForm, this);
            contracts.Show();
            this.Hide();
        }


        private void btnEducationLevel_Click(object sender, EventArgs e)
        {
            EducationForm educationForm = new EducationForm(db, startForm, this);
            educationForm.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.finanseIHR.Show();
            this.Hide();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvEmloyees.SelectedRows[0].Cells[5].Value.ToString());
            EditEmployee editEmployee = new EditEmployee(db, startForm, this, id);
            editEmployee.Show();
            this.Hide();
        }
    }
}
