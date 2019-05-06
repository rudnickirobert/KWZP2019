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
        public EducationForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void EducationForm_Load(object sender, EventArgs e)
        {
            display();
            List<vEmployeeList> employeeList = db.vEmployeeLists.
                OrderBy(employeeListOrderBy => employeeListOrderBy.EmployeeSurname).ToList();
            foreach (vEmployeeList employee in employeeList)
            {
                cbEmployeeList.Items.Add(String.Format("{0, -20} {1, -20}",
                    employee.EmployeeSurname, employee.EmployeeName));
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
                        educationFormSelect.GraduationDate
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
                    educationFormSelect.GraduationDate
                }).ToList();
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
            }
        }
    }
}
