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
    public partial class AddExamination : Form
    {
        RoofingCompanyEntities db;
        SqlConnection conn = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public AddExamination(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Examination_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand
                ("SELECT dbo.Employee.EmployeeSurname, dbo.Employee.EmployeeName FROM dbo.Employee", conn);
            conn.Open();           
            String stddetails = "{0, -30}{1, 00}";
            lbEmployeeList.Items.Add(String.Format(stddetails, "Nazwisko", "Imię"));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbEmployeeList.Items.Add(String.Format(stddetails, reader["EmployeeSurname"], reader["EmployeeName"]));
            }
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MedicalExamination newMedicalExamination = new MedicalExamination();
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            lbEmployeeList.Items.Clear();
            SqlCommand cmd = new SqlCommand 
                ("SELECT dbo.Employee.EmployeeSurname, dbo.Employee.EmployeeName FROM dbo.Employee " +
                "WHERE dbo.Employee.EmployeeSurname LIKE '" + tbSearchEmployee.Text + "%'", conn);
            conn.Open();
            String stddetails = "{0, -30}{1, 00}";
            lbEmployeeList.Items.Add(String.Format(stddetails, "Nazwisko", "Imię"));
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbEmployeeList.Items.Add(String.Format(stddetails, reader["EmployeeSurname"], reader["EmployeeName"]));
            }
            conn.Close();
        }
    }
}