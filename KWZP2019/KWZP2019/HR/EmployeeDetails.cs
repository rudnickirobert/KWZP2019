using System;
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
    public partial class EmployeeDetails : Form
    {
        RoofingCompanyEntities db;
        SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public EmployeeDetails(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {   
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Employee.ZipCode, dbo.Employee.City, dbo.Employee.Street," +
                " dbo.Employee.HouseNumber, dbo.Employee.ApartmentNum, dbo.Employee.PhoneNumber, dbo.Employee.PESEL, dbo.EducationLevel.EducationLevel," +
                " dbo.EducationLevel.DegreeShort, dbo.Education.GraduationDate, dbo.Position.Workplace, dbo.Contract.StartDate, dbo.Contract.EndDate," +
                " dbo.Contract.Salary, dbo.Contract.HealTestDate, dbo.Contract.WorkplaceTrainingDate, dbo.MedicalExamination.Date " +
                "FROM dbo.Contract " +
                "INNER JOIN dbo.Employee ON dbo.Contract.IdEmployee = dbo.Employee.IdEmployee " +
                "INNER JOIN dbo.MedicalExamination ON dbo.Employee.IdEmployee = dbo.MedicalExamination.IdEmployee " +
                "INNER JOIN dbo.Position ON dbo.Contract.IdPosition = dbo.Position.IdPosition " +
                "INNER JOIN dbo.Education ON dbo.Employee.IdEmployee = dbo.Education.IdEmployee " +
                "INNER JOIN dbo.EducationLevel ON dbo.Education.IdEducationLevel = dbo.EducationLevel.IdEducationLevel " +
                "ORDER BY dbo.Employee.EmployeeSurname", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Numer telefonu", typeof(string));
            dtEmployees.Columns.Add("Miasto zamieszkania", typeof(string));
            dtEmployees.Columns.Add("Kod pocztowy", typeof(string));
            dtEmployees.Columns.Add("Ulica", typeof(string));
            dtEmployees.Columns.Add("Numer domu", typeof(string));
            dtEmployees.Columns.Add("Numer mieszkania", typeof(string));
            dtEmployees.Columns.Add("PESEL", typeof(string));
            dtEmployees.Columns.Add("Poziom wykształcenia", typeof(string));
            dtEmployees.Columns.Add("Tytuły naukowe", typeof(string));
            dtEmployees.Columns.Add("Data uzyskania dyplomu", typeof(string));
            dtEmployees.Columns.Add("Pozycja", typeof(string));
            dtEmployees.Columns.Add("Początek umowy", typeof(string));
            dtEmployees.Columns.Add("Koniec umowy", typeof(string));
            dtEmployees.Columns.Add("Pensja", typeof(string));
            dtEmployees.Columns.Add("Jakieś badania", typeof(string));
            dtEmployees.Columns.Add("Szkolenie stanowiskowe", typeof(string));
            dtEmployees.Columns.Add("Ostatnie badanie lekarskie", typeof(string));

            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"],
                    sqlDataReader["PhoneNumber"], sqlDataReader["City"], sqlDataReader["ZipCode"], sqlDataReader["Street"],
                    sqlDataReader["HouseNumber"], sqlDataReader["ApartmentNum"], sqlDataReader["PESEL"], sqlDataReader["EducationLevel"],
                    sqlDataReader["DegreeShort"], sqlDataReader["GraduationDate"], sqlDataReader["Workplace"], sqlDataReader["StartDate"],
                    sqlDataReader["EndDate"], sqlDataReader["Salary"], sqlDataReader["HealTestDate"], sqlDataReader["WorkplaceTrainingDate"],
                    sqlDataReader["Date"]);
            }
            sqlConnection.Close();
            dgvEmployeeDetails.DataSource = dtEmployees;
        }

        private void tbSearchEmployeeDetails_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Employee.ZipCode, dbo.Employee.City, dbo.Employee.Street," +
                " dbo.Employee.HouseNumber, dbo.Employee.ApartmentNum, dbo.Employee.PhoneNumber, dbo.Employee.PESEL, dbo.EducationLevel.EducationLevel," +
                " dbo.EducationLevel.DegreeShort, dbo.Education.GraduationDate, dbo.Position.Workplace, dbo.Contract.StartDate, dbo.Contract.EndDate," +
                " dbo.Contract.Salary, dbo.Contract.HealTestDate, dbo.Contract.WorkplaceTrainingDate, dbo.MedicalExamination.Date " +
                "FROM dbo.Contract " +
                "INNER JOIN dbo.Employee ON dbo.Contract.IdEmployee = dbo.Employee.IdEmployee " +
                "INNER JOIN dbo.MedicalExamination ON dbo.Employee.IdEmployee = dbo.MedicalExamination.IdEmployee " +
                "INNER JOIN dbo.Position ON dbo.Contract.IdPosition = dbo.Position.IdPosition " +
                "INNER JOIN dbo.Education ON dbo.Employee.IdEmployee = dbo.Education.IdEmployee " +
                "INNER JOIN dbo.EducationLevel ON dbo.Education.IdEducationLevel = dbo.EducationLevel.IdEducationLevel " +
                "WHERE(dbo.Employee.EmployeeSurname LIKE '" + tbSearchEmployeeDetails.Text + "%') " +
                "ORDER BY dbo.Employee.EmployeeSurname", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Numer telefonu", typeof(string));
            dtEmployees.Columns.Add("Miasto zamieszkania", typeof(string));
            dtEmployees.Columns.Add("Kod pocztowy", typeof(string));
            dtEmployees.Columns.Add("Ulica", typeof(string));
            dtEmployees.Columns.Add("Numer domu", typeof(string));
            dtEmployees.Columns.Add("Numer mieszkania", typeof(string));
            dtEmployees.Columns.Add("PESEL", typeof(string));
            dtEmployees.Columns.Add("Poziom wykształcenia", typeof(string));
            dtEmployees.Columns.Add("Tytuły naukowe", typeof(string));
            dtEmployees.Columns.Add("Data uzyskania dyplomu", typeof(string));
            dtEmployees.Columns.Add("Pozycja", typeof(string));
            dtEmployees.Columns.Add("Początek umowy", typeof(string));
            dtEmployees.Columns.Add("Koniec umowy", typeof(string));
            dtEmployees.Columns.Add("Pensja", typeof(string));
            dtEmployees.Columns.Add("Jakieś badania", typeof(string));
            dtEmployees.Columns.Add("Szkolenie stanowiskowe", typeof(string));
            dtEmployees.Columns.Add("Ostatnie badanie lekarskie", typeof(string));

            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], 
                    sqlDataReader["PhoneNumber"], sqlDataReader["City"], sqlDataReader["ZipCode"], sqlDataReader["Street"],
                    sqlDataReader["HouseNumber"], sqlDataReader["ApartmentNum"], sqlDataReader["PESEL"], sqlDataReader["EducationLevel"],
                    sqlDataReader["DegreeShort"], sqlDataReader["GraduationDate"], sqlDataReader["Workplace"], sqlDataReader["StartDate"], 
                    sqlDataReader["EndDate"], sqlDataReader["Salary"], sqlDataReader["HealTestDate"], sqlDataReader["WorkplaceTrainingDate"], 
                    sqlDataReader["Date"]);
            }
            sqlConnection.Close();
            dgvEmployeeDetails.DataSource = dtEmployees;
        }
    }
}
