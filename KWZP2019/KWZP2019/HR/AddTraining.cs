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
    public partial class AddTraining : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        HR hr;

        public AddTraining(RoofingCompanyEntities db, StartForm startForm, HR hr)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
        }

        private void AddTraining_Load(object sender, EventArgs e)
        {
            display();
            clear();
            List<vEmployeeList> employeeList = db.vEmployeeLists.ToList();
            foreach (vEmployeeList employee in employeeList)
            {
                cbEmployeeList.Items.Add(String.Format("{0, -20} {1, -20}",
                    employee.EmployeeSurname, employee.EmployeeName));
            }
        }

        private void tbSearchTraining_TextChanged(object sender, EventArgs e)
        {
            dgvTrainings.DataSource = db.vAddTrainings.
                Where (addtraining => addtraining.EmployeeName.StartsWith(tbSearchTrainingName.Text)
                                   && addtraining.EmployeeSurname.StartsWith(tbSearchTraining.Text)).
                Select (addtrainigSelect => new {
                        addtrainigSelect.EmployeeSurname,
                        addtrainigSelect.EmployeeName,
                        addtrainigSelect.TrainingName,
                        addtrainigSelect.TrainingStartDate,
                        addtrainigSelect.TrainingEndDate,
                        addtrainigSelect.TrainingPrice
                }).ToList();
        }

        private void tbSearchTrainingName_TextChanged(object sender, EventArgs e)
        {
            dgvTrainings.DataSource = db.vAddTrainings.
                Where (addtraining => addtraining.EmployeeName.StartsWith(tbSearchTrainingName.Text)
                                   && addtraining.EmployeeSurname.StartsWith(tbSearchTraining.Text)).
                Select (addtrainigSelect => new {
                        addtrainigSelect.EmployeeSurname,
                        addtrainigSelect.EmployeeName,
                        addtrainigSelect.TrainingName,
                        addtrainigSelect.TrainingStartDate,
                        addtrainigSelect.TrainingEndDate,
                        addtrainigSelect.TrainingPrice
                }).ToList();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.hr.Show();
            this.Hide();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        void clear()
        {
            tbTrainingName.Text = "";
            dtpTrainingStartDate.Value = DateTime.Today;
            dtpTrainingEndDate.Value = DateTime.Today;
            cbEmployeeList.SelectedIndex = -1;
            tbTrainingPrice.Text = "";
        }

        void display()
        {
            dgvTrainings.DataSource = db.vAddTrainings.
                Select(addtrainigSelect => new {
                    addtrainigSelect.EmployeeSurname,
                    addtrainigSelect.EmployeeName,
                    addtrainigSelect.TrainingName,
                    addtrainigSelect.TrainingStartDate,
                    addtrainigSelect.TrainingEndDate,
                    addtrainigSelect.TrainingPrice
                }).ToList();

            dgvTrainings.Columns[0].HeaderText = "Nazwisko";
            dgvTrainings.Columns[1].HeaderText = "Imię";
            dgvTrainings.Columns[2].HeaderText = "Nazwa";
            dgvTrainings.Columns[3].HeaderText = "Początek";
            dgvTrainings.Columns[4].HeaderText = "Koniec";
            dgvTrainings.Columns[5].HeaderText = "Cena";

            dgvTrainings.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTrainings.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTrainings.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTrainings.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTrainings.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTrainings.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbTrainingName.Text.Trim() == "" || tbTrainingPrice.Text.Trim() == "" || cbEmployeeList.SelectedIndex == -1)
            {
                MessageBox.Show("Pola nazwa, cena oraz pracownik muszą być wypełnione");
            }
            else
            {
                bool condition1 = int.TryParse(tbTrainingPrice.Text.Trim(), out int number);
                if (condition1 == false)
                {
                    MessageBox.Show("W polu cena muszą znajdować się wyłącznie cyfry");
                }
                else
                {
                    if (dtpTrainingStartDate.Value > dtpTrainingEndDate.Value)
                    {
                        MessageBox.Show("Data końca szkolenia nie może być wcześniej niż data początku szkolenia");
                    }
                    else
                    { 
                        Training newTraining = new Training();
                        newTraining.TrainingName = tbTrainingName.Text.Trim();
                        newTraining.TrainingStartDate = dtpTrainingStartDate.Value;
                        newTraining.TrainingEndDate = dtpTrainingEndDate.Value;
                        newTraining.IdEmployee = cbEmployeeList.SelectedIndex + 1;
                        newTraining.TrainingPrice = int.Parse(tbTrainingPrice.Text.Trim());
                        db.Trainings.Add(newTraining);
                        db.SaveChanges();
                        clear();
                        if (tbSearchTraining.Text.Trim() == "" || tbSearchTrainingName.Text.Trim() =="")
                        {
                            display();
                        }
                        else
                        {
                            tbSearchTrainingName_TextChanged(sender, e);
                        }
                        MessageBox.Show("Poprawnie dodano szkolenie");
                    }
                }
            }
        }
    }
}
