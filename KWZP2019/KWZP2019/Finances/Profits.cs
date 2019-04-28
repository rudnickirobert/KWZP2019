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
    public partial class Profits : Form
    {
        RoofingCompanyEntities db;
        SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public Profits(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Profits_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
       ("SELECT dbo.Customer.CustomerName, dbo.OrderCustomer.OrderDate, dbo.OrderCustomer.Cost " +
       "FROM dbo.OrderCustomer " +
       "INNER JOIN dbo.Customer ON dbo.Customer.IdCustomer = dbo.OrderCustomer.IdCustomer " +
       "ORDER BY (dbo.Customer.CustomerName)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtCustomer = new DataTable();
            dtCustomer.Columns.Add("Nazwa klienta", typeof(string));
            dtCustomer.Columns.Add("Wartość zamówienia", typeof(string));
            dtCustomer.Columns.Add("Data zamówienia", typeof(string));
            while (sqlDataReader.Read())
            {
                dtCustomer.Rows.Add(sqlDataReader["CustomerName"], sqlDataReader["Cost"], sqlDataReader["OrderDate"]);
            }
            sqlConnection.Close();
            dgvProfits.DataSource = dtCustomer;
        }

        private void btnAcceptselectedtime_Click(object sender, EventArgs e)
        {
            dtpEndDate.CustomFormat = "yyyy-MM-dd 00:00:00.000";
            dtpStartDate.CustomFormat = "yyyy-MM-dd 00:00:00.000";
            SqlCommand sqlCommand = new SqlCommand
            ("SELECT dbo.Customer.CustomerName, dbo.OrderCustomer.OrderDate, dbo.OrderCustomer.Cost " +
  "FROM dbo.OrderCustomer " +
  "WHERE (dbo.OrderCustomer.OrderDate < '" + dtpEndDate + 
  "' AND " +
  "dbo.OrderCustomer.OrderDate > '" + dtpStartDate +
  "') " +
  "INNER JOIN dbo.Customer ON dbo.Customer.IdCustomer = dbo.OrderCustomer.IdCustomer " +
  "ORDER BY (dbo.Customer.CustomerName)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtCustomer = new DataTable();
            dtCustomer.Columns.Add("Nazwa klienta", typeof(string));
            dtCustomer.Columns.Add("Wartość zamówienia", typeof(string));
            dtCustomer.Columns.Add("Data zamówienia", typeof(string));
            while (sqlDataReader.Read())
            {
                dtCustomer.Rows.Add(sqlDataReader["CustomerName"], sqlDataReader["Cost"], sqlDataReader["OrderDate"]);
            }
            sqlConnection.Close();
            dgvProfits.DataSource = dtCustomer;
        }
    }
}
