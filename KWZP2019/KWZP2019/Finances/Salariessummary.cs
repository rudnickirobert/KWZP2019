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
        public SalariesSummary(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server = .\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
            SqlCommand sqlCommand = new SqlCommand
            ("SELECT dbo.Employee.EmployeeSurname, dbo.Employee.EmployeeName FROM dbo.Employee" +
                 //  ", dbo.Payment.Sum FROM dbo.Employee" +
                 //  " INNER JOIN dbo.Payment" +
                 //  " ON dbo.Employee.IdEmployee = dbo.Payment.IdEmployee" +
                 " WHERE (dbo.Employee.EmployeeSurname LIKE '" + textBox1.Text + "%')" +
                 " ORDER BY dbo.Employee.EmployeeSurname", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            while (sqlDataReader.Read())
            {
                checkedListBox1.DisplayMember = "EmployeeSurname";
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"]);
            }
            sqlConnection.Close();
            checkedListBox1.DataSource = dtEmployees;
        }
    }
}
