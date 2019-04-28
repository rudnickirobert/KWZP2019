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
    public partial class EducationForm : Form
    {
        RoofingCompanyEntities db;
        SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public EducationForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void EducationForm_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.EducationLevel.EducationLevel, " +
                "dbo.EducationLevel.Degree, dbo.EducationLevel.DegreeShort, dbo.Education.GraduationDate " +
                "FROM dbo.Employee " +
                "INNER JOIN dbo.Education ON dbo.Employee.IdEmployee = dbo.Education.IdEmployee " +
                "INNER JOIN dbo.EducationLevel ON dbo.Education.IdEducationLevel = dbo.EducationLevel.IdEducationLevel " +
                "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Poziom Wykształcenia", typeof(string));
            dtEmployees.Columns.Add("Dyplom", typeof(string));
            dtEmployees.Columns.Add("Tytuły Naukowe", typeof(string));
            dtEmployees.Columns.Add("Data ukończenia studiów", typeof(string));

            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["EducationLevel"],
                    sqlDataReader["Degree"], sqlDataReader["DegreeShort"], sqlDataReader["GraduationDate"]);
            }
            sqlConnection.Close();
            dgvEducation.DataSource = dtEmployees;
        }

        private void tbEducationSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.EducationLevel.EducationLevel, " +
                "dbo.EducationLevel.Degree, dbo.EducationLevel.DegreeShort, dbo.Education.GraduationDate " +
                "FROM dbo.Employee " +
                "INNER JOIN dbo.Education ON dbo.Employee.IdEmployee = dbo.Education.IdEmployee " +
                "INNER JOIN dbo.EducationLevel ON dbo.Education.IdEducationLevel = dbo.EducationLevel.IdEducationLevel " +
                "WHERE(dbo.Employee.EmployeeSurname LIKE '" + tbEducationSearch.Text + "%') " +
                "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Poziom Wykształcenia", typeof(string));
            dtEmployees.Columns.Add("Dyplom", typeof(string));
            dtEmployees.Columns.Add("Tytuły Naukowe", typeof(string));
            dtEmployees.Columns.Add("Data ukończenia studiów", typeof(string));

            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["EducationLevel"],
                    sqlDataReader["Degree"], sqlDataReader["DegreeShort"], sqlDataReader["GraduationDate"]);
            }
            sqlConnection.Close();
            dgvEducation.DataSource = dtEmployees;
        }
    }
}
