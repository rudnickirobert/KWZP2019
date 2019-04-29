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
    public partial class SalariesSummary : Form
    {
        RoofingCompanyEntities db;
        SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public SalariesSummary(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void SalariesSummary_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
("SELECT dbo.Employee.IdEmployee, dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Employee.PESEL, " +
"dbo.Contract.EndDate, (dbo.Contract.Salary/21) AS DailySalary, " +
"dbo.Payment.Bonus, dbo.Payment.Sum, " +
"dbo.AbsenceType.AbscenceReason, dbo.AbsenceType.Multiplier, " +
"DATEDIFF(DAY, dbo.Absence.StartOfAbsence, dbo.Absence.EndOfAbsence)+1 AS AbsentDays " +
"FROM dbo.Absence " +
"INNER JOIN dbo.AbsenceType ON dbo.AbsenceType.IdAbsenceType = dbo.Absence.IdAbsenceType " +
"INNER JOIN dbo.Employee ON dbo.Absence.IdEmployee = dbo.Employee.IdEmployee " +
"INNER JOIN dbo.Contract ON dbo.Employee.IdEmployee = dbo.Contract.IdEmployee " +
"INNER JOIN dbo.Payment ON dbo.Employee.IdEmployee = dbo.Payment.IdEmployee " +
"ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtAbsence = new DataTable();
            dtAbsence.Columns.Add("IdPracownika");
            dtAbsence.Columns.Add("Imię");
            dtAbsence.Columns.Add("Nazwisko");
            dtAbsence.Columns.Add("PESEL");
            dtAbsence.Columns.Add("Koniec umowy");
            dtAbsence.Columns.Add("Stawka dzienna");
            dtAbsence.Columns.Add("Bonus", typeof(string));
            dtAbsence.Columns.Add("Całkowita wypłata", typeof(string));
            dtAbsence.Columns.Add("Powód nieobecności", typeof(string));
            dtAbsence.Columns.Add("Mnożnik");
            dtAbsence.Columns.Add("Liczba dni opuszczonych", typeof(string));
            while (sqlDataReader.Read())
            {
                dtAbsence.Rows.Add(sqlDataReader["IdEmployee"], sqlDataReader["EmployeeName"], sqlDataReader["EmployeeSurname"],
                sqlDataReader["PESEL"], sqlDataReader["EndDate"], sqlDataReader["DailySalary"], sqlDataReader["Bonus"],
                sqlDataReader["Sum"], sqlDataReader["AbscenceReason"], sqlDataReader["Multiplier"], sqlDataReader["AbsentDays"]);
            }
            sqlConnection.Close();
            dgvAllAbsencesData.DataSource = dtAbsence;
        }

        private void btSUM_Click(object sender, EventArgs e)
        {
        
        }
    }
}
