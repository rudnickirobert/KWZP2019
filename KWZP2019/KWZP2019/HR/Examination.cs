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
    public partial class Examination : Form
    {
        RoofingCompanyEntities db;
        SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public Examination(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Examination_Load(object sender, EventArgs e)
        {
            
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT RoofingCompany.dbo.Employee.EmployeeSurname, RoofingCompany.dbo.Employee.EmployeeName, RoofingCompany.dbo.MedicalExamination.Date " +
                "FROM RoofingCompany.dbo.Employee " +
                "INNER JOIN RoofingCompany.dbo.MedicalExamination " +
                "ON RoofingCompany.dbo.Employee.IdEmployee = RoofingCompany.dbo.MedicalExamination.IdEmployee " +
                "ORDER BY RoofingCompany.dbo.MedicalExamination.Date", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtMedicalExamination = new DataTable();
            dtMedicalExamination.Columns.Add("Nazwisko", typeof(string));
            dtMedicalExamination.Columns.Add("Imię", typeof(string));
            dtMedicalExamination.Columns.Add("Data badania", typeof(string));
            while (sqlDataReader.Read())
            {
                dtMedicalExamination.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["Date"]);
            }
            sqlConnection.Close();
            dgvExamination.DataSource = dtMedicalExamination;
        }

        private void btnAddExamination_Click(object sender, EventArgs e)
        {
            AddExamination addExamination = new AddExamination(db);
            addExamination.Show();
        }

        private void tbSearchEmployeeExamination_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT RoofingCompany.dbo.Employee.EmployeeSurname, RoofingCompany.dbo.Employee.EmployeeName, RoofingCompany.dbo.MedicalExamination.Date " +
                 "FROM RoofingCompany.dbo.Employee " +
                 "INNER JOIN RoofingCompany.dbo.MedicalExamination " +
                 "ON RoofingCompany.dbo.Employee.IdEmployee = RoofingCompany.dbo.MedicalExamination.IdEmployee " +
                 "WHERE (dbo.Employee.EmployeeSurname LIKE '" + tbSearchEmployeeExamination.Text + "%') " +
                 "AND (dbo.Employee.EmployeeName LIKE '" + tbSearchEmployeeExaminationName.Text + "%') " +
                 "ORDER BY RoofingCompany.dbo.MedicalExamination.Date", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtMedicalExamination = new DataTable();
            dtMedicalExamination.Columns.Add("Nazwisko", typeof(string));
            dtMedicalExamination.Columns.Add("Imię", typeof(string));
            dtMedicalExamination.Columns.Add("Data badania", typeof(string));
            while (sqlDataReader.Read())
            {
                dtMedicalExamination.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["Date"]);
            }
            sqlConnection.Close();
            dgvExamination.DataSource = dtMedicalExamination;
        }

        private void tbSearchEmployeeExaminationName_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT RoofingCompany.dbo.Employee.EmployeeSurname, RoofingCompany.dbo.Employee.EmployeeName, RoofingCompany.dbo.MedicalExamination.Date " +
                 "FROM RoofingCompany.dbo.Employee " +
                 "INNER JOIN RoofingCompany.dbo.MedicalExamination " +
                 "ON RoofingCompany.dbo.Employee.IdEmployee = RoofingCompany.dbo.MedicalExamination.IdEmployee " +
                 "WHERE (dbo.Employee.EmployeeSurname LIKE '" + tbSearchEmployeeExamination.Text + "%') " +
                 "AND (dbo.Employee.EmployeeName LIKE '" + tbSearchEmployeeExaminationName.Text + "%') " +
                 "ORDER BY RoofingCompany.dbo.MedicalExamination.Date", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtMedicalExamination = new DataTable();
            dtMedicalExamination.Columns.Add("Nazwisko", typeof(string));
            dtMedicalExamination.Columns.Add("Imię", typeof(string));
            dtMedicalExamination.Columns.Add("Data badania", typeof(string));
            while (sqlDataReader.Read())
            {
                dtMedicalExamination.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["Date"]);
            }
            sqlConnection.Close();
            dgvExamination.DataSource = dtMedicalExamination;
        }
    }
}
