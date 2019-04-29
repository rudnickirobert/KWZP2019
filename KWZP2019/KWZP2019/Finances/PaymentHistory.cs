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
    public partial class Salaries : Form
    {
        RoofingCompanyEntities db;
        SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public Salaries(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
        private void Salaries_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            ("SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Employee.PESEL, " +
            "dbo.Payment.Bonus, dbo.Payment.Sum, dbo.Payment.Date " +
            "FROM dbo.Employee " +
            "INNER JOIN dbo.Payment ON dbo.Employee.IdEmployee = dbo.Payment.IdEmployee " +
            "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtBonus = new DataTable();
            dtBonus.Columns.Add("Imię");
            dtBonus.Columns.Add("Nazwisko");
            dtBonus.Columns.Add("PESEL");
            dtBonus.Columns.Add("Bonus");
            dtBonus.Columns.Add("Całkowita wypłata");
            dtBonus.Columns.Add("Data");
            while (sqlDataReader.Read())
            {
                dtBonus.Rows.Add(sqlDataReader["EmployeeName"], sqlDataReader["EmployeeSurname"], sqlDataReader["PESEL"], sqlDataReader["Bonus"], sqlDataReader["Sum"], sqlDataReader["Date"]);
            }
            sqlConnection.Close();
            dgvBonus.DataSource = dtBonus;
        }

        private void tbSurname_KeyUp(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
            "SELECT dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname, dbo.Employee.PESEL, " +
            "dbo.Payment.Bonus, dbo.Payment.Sum, dbo.Payment.Date " +
            "FROM dbo.Employee " +
            "INNER JOIN dbo.Payment ON dbo.Employee.IdEmployee = dbo.Payment.IdEmployee " +
            "WHERE dbo.Employee.EmployeeSurname LIKE '%" + tbSurname.Text + "%' " +
            "ORDER BY (dbo.Employee.EmployeeSurname)";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtBonus = new DataTable();
            dtBonus.Columns.Add("Imię");
            dtBonus.Columns.Add("Nazwisko");
            dtBonus.Columns.Add("PESEL");
            dtBonus.Columns.Add("Bonus");
            dtBonus.Columns.Add("Całkowita wypłata");
            dtBonus.Columns.Add("Data");
            while (sqlDataReader.Read())
            {
                dtBonus.Rows.Add(sqlDataReader["EmployeeName"], sqlDataReader["EmployeeSurname"], sqlDataReader["PESEL"], sqlDataReader["Bonus"], sqlDataReader["Sum"], sqlDataReader["Date"]);
            }
            sqlConnection.Close();
            dgvBonus.DataSource = dtBonus;
        }
    }
}