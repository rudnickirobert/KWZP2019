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
    public partial class Contracts : Form
    {
        RoofingCompanyEntities db;
        SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public Contracts(RoofingCompanyEntities db)
        {
            InitializeComponent();
        }

        private void Contracts_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Contract.StartDate, dbo.Contract.EndDate," +
                " dbo.Contract.Salary, dbo.Contract.WorkplaceTrainingDate, dbo.Contract.HealTestDate, dbo.Position.Workplace " +
                "FROM dbo.Employee " +
                "INNER JOIN dbo.Contract ON dbo.Employee.IdEmployee = dbo.Contract.IdEmployee " +
                "INNER JOIN dbo.Position ON dbo.Contract.IdPosition = dbo.Position.IdPosition " +
                "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Pozycja", typeof(string));
            dtEmployees.Columns.Add("Początek kontraktu", typeof(string));
            dtEmployees.Columns.Add("Koniec kontraktu", typeof(string));
            dtEmployees.Columns.Add("Pensja podstawowa", typeof(string));
            dtEmployees.Columns.Add("Data szkolenia na stanowisko", typeof(string));
            dtEmployees.Columns.Add("Data jakiegos badania", typeof(string));

            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["Workplace"],
                    sqlDataReader["StartDate"], sqlDataReader["EndDate"], sqlDataReader["Salary"], sqlDataReader["WorkplaceTrainingDate"],
                    sqlDataReader["HealTestDate"]);
            }
            sqlConnection.Close();
            dgvContracts.DataSource = dtEmployees;
        }

        private void tbSearchContract_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Contract.StartDate, dbo.Contract.EndDate," +
                " dbo.Contract.Salary, dbo.Contract.WorkplaceTrainingDate, dbo.Contract.HealTestDate, dbo.Position.Workplace " +
                "FROM dbo.Employee " +
                "INNER JOIN dbo.Contract ON dbo.Employee.IdEmployee = dbo.Contract.IdEmployee " +
                "INNER JOIN dbo.Position ON dbo.Contract.IdPosition = dbo.Position.IdPosition " +
                "WHERE(dbo.Employee.EmployeeSurname LIKE '" + tbSearchContract.Text + "%') " +
                "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Pozycja", typeof(string));
            dtEmployees.Columns.Add("Początek kontraktu", typeof(string));
            dtEmployees.Columns.Add("Koniec kontraktu", typeof(string));
            dtEmployees.Columns.Add("Pensja podstawowa", typeof(string));
            dtEmployees.Columns.Add("Data szkolenia na stanowisko", typeof(string));
            dtEmployees.Columns.Add("Data jakiegos badania", typeof(string));

            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["Workplace"],
                    sqlDataReader["StartDate"], sqlDataReader["EndDate"], sqlDataReader["Salary"], sqlDataReader["WorkplaceTrainingDate"],
                    sqlDataReader["HealTestDate"]);
            }
            sqlConnection.Close();
            dgvContracts.DataSource = dtEmployees;
        }
    }
}
