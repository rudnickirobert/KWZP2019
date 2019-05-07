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
    public partial class EducationForm : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        HR hr;
        public EducationForm(RoofingCompanyEntities db, StartForm startForm, HR hr)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
        }

        private void EducationForm_Load(object sender, EventArgs e)
        {
            display();
            clear();
            List<vEmployeeList> employeeList = db.vEmployeeLists.ToList();
            foreach (vEmployeeList employee in employeeList)
            {
                cbEmployeeList.Items.Add(String.Format("{0, -20} {1, -20}",
                    employee.EmployeeSurname, employee.EmployeeName));
            }

            List<vEducationLevel> educationLevels = db.vEducationLevels.ToList();
            foreach (vEducationLevel ecucationL in educationLevels)
            {
                cbEducationLevel.Items.Add(ecucationL.EducationLevel);
            }
        }

        private void tbEducationSearch_TextChanged(object sender, EventArgs e)
        {
            dgvEducation.DataSource = db.vEducationForms.
                Where (educationform => educationform.EmployeeSurname.StartsWith(tbEducationSearch.Text)).
                Select (educationFormSelect => new {
                        educationFormSelect.EmployeeSurname,
                        educationFormSelect.EmployeeName,
                        educationFormSelect.EducationLevel,
                        educationFormSelect.Degree,
                        educationFormSelect.DegreeShort,
                        educationFormSelect.GraduationDate,
                        educationFormSelect.IdEducation
                }).ToList();
        }
        
        void display()
        {
            dgvEducation.DataSource = db.vEducationForms.
                Select(educationFormSelect => new {
                    educationFormSelect.EmployeeSurname,
                    educationFormSelect.EmployeeName,
                    educationFormSelect.EducationLevel,
                    educationFormSelect.Degree,
                    educationFormSelect.DegreeShort,
                    educationFormSelect.GraduationDate,
                    educationFormSelect.IdEducation
                }).ToList();

            dgvEducation.Columns[6].Visible = false;

            dgvEducation.Columns[0].HeaderText = "Nazwisko";
            dgvEducation.Columns[1].HeaderText = "Imię";
            dgvEducation.Columns[2].HeaderText = "Stopień wykształcenia";
            dgvEducation.Columns[3].HeaderText = "Dyplom";
            dgvEducation.Columns[4].HeaderText = "Tytuły naukowe";
            dgvEducation.Columns[5].HeaderText = "Data ukończenia";

            dgvEducation.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEducation.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEducation.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEducation.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEducation.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEducation.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbEmployeeList.SelectedIndex == -1 || cbEducationLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione");
            }
            else
            {
                Education newEducation = new Education();
                newEducation.IdEmployee = cbEmployeeList.SelectedIndex + 1;
                newEducation.IdEducationLevel = cbEducationLevel.SelectedIndex + 1;
                newEducation.GraduationDate = dtpGraduationDate.Value;
                db.Educations.Add(newEducation);
                db.SaveChanges();
                if(tbEducationSearch.Text.Trim() == "")
                {
                    display();
                }
                else
                {
                    tbEducationSearch_TextChanged(sender, e);
                }
                MessageBox.Show("Prawidłowo dodano pracownika");
                clear();
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Education EducationsToRemove = new Education { IdEducation = int.Parse(dgvEducation.SelectedRows[0].Cells[6].Value.ToString()) };
            db.Educations.Attach(EducationsToRemove);
            db.Educations.Remove(EducationsToRemove);
            db.SaveChanges();
            if (tbEducationSearch.Text.Trim() == "" )
            {
                display();
            }
            else
            {
                tbEducationSearch_TextChanged(sender, e);
            }
            MessageBox.Show("Rekord został usunięty");
            clear();
        }
        
        void clear()
        {
            cbEmployeeList.SelectedIndex = -1;
            cbEducationLevel.SelectedIndex = -1;
            dtpGraduationDate.Value = DateTime.Today;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
