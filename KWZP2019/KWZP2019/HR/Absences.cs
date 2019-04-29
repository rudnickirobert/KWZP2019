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
    public partial class Absences : Form
    {
        RoofingCompanyEntities db;
        SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public Absences(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Absences_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Absence.StartOfAbsence, " +
                "dbo.Absence.EndOfAbsence, dbo.AbsenceType.AbscenceReason " +
                "FROM dbo.Absence " +
                "INNER JOIN dbo.AbsenceType ON dbo.Absence.IdAbsenceType = dbo.AbsenceType.IdAbsenceType " +
                "INNER JOIN dbo.Employee ON dbo.Absence.IdEmployee = dbo.Employee.IdEmployee " +
                "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Powód nieobecności", typeof(string));
            dtEmployees.Columns.Add("Początek nieobecności", typeof(string));
            dtEmployees.Columns.Add("Koniec nieobecności", typeof(string));
            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["AbscenceReason"],
                    sqlDataReader["StartOfAbsence"], sqlDataReader["EndOfAbsence"]);
            }
            sqlConnection.Close();
            dgvAbsences.DataSource = dtEmployees;
        }

        private void tbSearchAbsence_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
               ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Absence.StartOfAbsence, " +
               "dbo.Absence.EndOfAbsence, dbo.AbsenceType.AbscenceReason " +
               "FROM dbo.Absence " +
               "INNER JOIN dbo.AbsenceType ON dbo.Absence.IdAbsenceType = dbo.AbsenceType.IdAbsenceType " +
               "INNER JOIN dbo.Employee ON dbo.Absence.IdEmployee = dbo.Employee.IdEmployee " +
               "WHERE (dbo.Employee.EmployeeSurname LIKE '" + tbSearchAbsence.Text + "%') " +
               "AND (dbo.Employee.EmployeeName LIKE '" + tbSearchName.Text + "%') " +
               "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Powód nieobecności", typeof(string));
            dtEmployees.Columns.Add("Początek nieobecności", typeof(string));
            dtEmployees.Columns.Add("Koniec nieobecności", typeof(string));
            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["AbscenceReason"],
                    sqlDataReader["StartOfAbsence"], sqlDataReader["EndOfAbsence"]);
            }
            sqlConnection.Close();
            dgvAbsences.DataSource = dtEmployees;
        }

        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
               ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Absence.StartOfAbsence, " +
               "dbo.Absence.EndOfAbsence, dbo.AbsenceType.AbscenceReason " +
               "FROM dbo.Absence " +
               "INNER JOIN dbo.AbsenceType ON dbo.Absence.IdAbsenceType = dbo.AbsenceType.IdAbsenceType " +
               "INNER JOIN dbo.Employee ON dbo.Absence.IdEmployee = dbo.Employee.IdEmployee " +
               "WHERE (dbo.Employee.EmployeeSurname LIKE '" + tbSearchAbsence.Text + "%') " +
               "AND (dbo.Employee.EmployeeName LIKE '" + tbSearchName.Text + "%') " +
               "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Powód nieobecności", typeof(string));
            dtEmployees.Columns.Add("Początek nieobecności", typeof(string));
            dtEmployees.Columns.Add("Koniec nieobecności", typeof(string));
            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["AbscenceReason"],
                    sqlDataReader["StartOfAbsence"], sqlDataReader["EndOfAbsence"]);
            }
            sqlConnection.Close();
            dgvAbsences.DataSource = dtEmployees;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Absence newAbsence = new Absence();
            newAbsence.StartOfAbsence = dateTimePickerFirstDay.Value;
            newAbsence.EndOfAbsence = dateTimePickerLastDay.Value;
        }
    }
}
