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
    public partial class AddTraining : Form
    {
        RoofingCompanyEntities db;
        SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public AddTraining(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void AddTraining_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                            ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Training.TrainingName, " +
                            "dbo.Training.TrainingStartDate, dbo.Training.TrainingEndDate, dbo.Training.TrainingPrice " +
                            "FROM dbo.Employee INNER JOIN dbo.Training ON dbo.Employee.IdEmployee = dbo.Training.IdEmployee " +
                            "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Nazwa szkolenia", typeof(string));
            dtEmployees.Columns.Add("Początek szkolenia", typeof(string));
            dtEmployees.Columns.Add("Koniec szkolenia", typeof(string));
            dtEmployees.Columns.Add("Cena", typeof(string));

            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["TrainingName"],
                    sqlDataReader["TrainingStartDate"], sqlDataReader["TrainingEndDate"], sqlDataReader["TrainingPrice"]);
            }
            sqlConnection.Close();
            dgvTrainings.DataSource = dtEmployees;
        }

        private void tbSearchTraining_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Training.TrainingName, " +
                "dbo.Training.TrainingStartDate, dbo.Training.TrainingEndDate, dbo.Training.TrainingPrice " +
                "FROM dbo.Employee INNER JOIN dbo.Training ON dbo.Employee.IdEmployee = dbo.Training.IdEmployee " +
                "WHERE (dbo.Employee.EmployeeSurname LIKE '" + tbSearchTraining.Text + "%') " +
                "AND (dbo.Employee.EmployeeName LIKE '" + tbSearchTrainingName.Text + "%') " +
                "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Nazwa szkolenia", typeof(string));
            dtEmployees.Columns.Add("Początek szkolenia", typeof(string));
            dtEmployees.Columns.Add("Koniec szkolenia", typeof(string));
            dtEmployees.Columns.Add("Cena", typeof(string));

            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["TrainingName"],
                    sqlDataReader["TrainingStartDate"], sqlDataReader["TrainingEndDate"], sqlDataReader["TrainingPrice"]);
            }
            sqlConnection.Close();
            dgvTrainings.DataSource = dtEmployees;
        }

        private void tbSearchTrainingName_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Training.TrainingName, " +
                "dbo.Training.TrainingStartDate, dbo.Training.TrainingEndDate, dbo.Training.TrainingPrice " +
                "FROM dbo.Employee INNER JOIN dbo.Training ON dbo.Employee.IdEmployee = dbo.Training.IdEmployee " +
                "WHERE (dbo.Employee.EmployeeSurname LIKE '" + tbSearchTraining.Text + "%') " +
                "AND (dbo.Employee.EmployeeName LIKE '" + tbSearchTrainingName.Text + "%') " +
                "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Nazwa szkolenia", typeof(string));
            dtEmployees.Columns.Add("Początek szkolenia", typeof(string));
            dtEmployees.Columns.Add("Koniec szkolenia", typeof(string));
            dtEmployees.Columns.Add("Cena", typeof(string));

            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["TrainingName"],
                    sqlDataReader["TrainingStartDate"], sqlDataReader["TrainingEndDate"], sqlDataReader["TrainingPrice"]);
            }
            sqlConnection.Close();
            dgvTrainings.DataSource = dtEmployees;
        }
    }
}
