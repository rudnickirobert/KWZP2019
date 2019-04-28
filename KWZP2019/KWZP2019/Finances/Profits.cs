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
            SqlCommand sqlCommandProfits = new SqlCommand
       ("SELECT dbo.Customer.CustomerName, dbo.OrderCustomer.OrderDate, dbo.OrderCustomer.Cost " +
       "FROM dbo.OrderCustomer " +
       "INNER JOIN dbo.Customer ON dbo.Customer.IdCustomer = dbo.OrderCustomer.IdCustomer " +
       "ORDER BY (dbo.Customer.CustomerName)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderProfits = sqlCommandProfits.ExecuteReader();
            DataTable dtCustomer = new DataTable();
            dtCustomer.Columns.Add("Nazwa klienta", typeof(string));
            dtCustomer.Columns.Add("Kwota");
            dtCustomer.Columns.Add("Data zamówienia", typeof(string));
            while (sqlDataReaderProfits.Read())
            {
                dtCustomer.Rows.Add(sqlDataReaderProfits["CustomerName"], sqlDataReaderProfits["Cost"], sqlDataReaderProfits["OrderDate"]);
            }
            sqlConnection.Close();
            dgvProfits.DataSource = dtCustomer;
            SqlCommand sqlCommandInvoices = new SqlCommand
            ("SELECT dbo.Invoice.Sum, dbo.Invoice.Date, dbo.InvoiceType.Type, dbo.Contractor.ContractorName " +
            "FROM dbo.Invoice " +
            "INNER JOIN dbo.Contractor ON dbo.Invoice.IdContractor = dbo.Contractor.IdContractor " +
            "INNER JOIN dbo.InvoiceType ON dbo.Invoice.IdInvoiceType = dbo.InvoiceType.IdInvoiceType " +
            "ORDER BY (dbo.Contractor.ContractorName)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderInvoices = sqlCommandInvoices.ExecuteReader();
            DataTable dtInvoice = new DataTable();
            dtInvoice.Columns.Add("Kwota", typeof(string));
            dtInvoice.Columns.Add("Data", typeof(string));
            dtInvoice.Columns.Add("Typ faktury", typeof(string));
            dtInvoice.Columns.Add("Nazwa podmiotu", typeof(string));
            while (sqlDataReaderInvoices.Read())
            {
                dtInvoice.Rows.Add(sqlDataReaderInvoices["Sum"], sqlDataReaderInvoices["Date"], sqlDataReaderInvoices["Type"], sqlDataReaderInvoices["ContractorName"]);
            }
            sqlConnection.Close();
            dgvInvoices.DataSource = dtInvoice;
            SqlCommand sqlCommandPayment = new SqlCommand
            ("SELECT dbo.Payment.Sum, dbo.Payment.Date, dbo.Payment.Bonus, dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname " +
            "FROM dbo.Payment " +
            "INNER JOIN dbo.Employee ON dbo.Payment.IdEmployee = dbo.Employee.IdEmployee " +
            "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderPayment = sqlCommandPayment.ExecuteReader();
            DataTable dtPayment = new DataTable();
            dtPayment.Columns.Add("Kwota", typeof(string));
            dtPayment.Columns.Add("Data", typeof(string));
            dtPayment.Columns.Add("Bonus", typeof(string));
            dtPayment.Columns.Add("Imię", typeof(string));
            dtPayment.Columns.Add("Nazwisko", typeof(string));
            while (sqlDataReaderPayment.Read())
            {
                dtPayment.Rows.Add(sqlDataReaderPayment["Sum"], sqlDataReaderPayment["Date"], sqlDataReaderPayment["Bonus"], sqlDataReaderPayment["EmployeeName"], sqlDataReaderPayment["EmployeeSurname"]);
            }
            sqlConnection.Close();
            dgvSalaries.DataSource = dtPayment;
            SqlCommand sqlCommandOrders = new SqlCommand
            ("SELECT dbo.SemiFinishedOrder.Cost, dbo.SemiFinishedOrder.SFOrderDate, dbo.Supplier.SupplierName " +
            "FROM dbo.SemiFinishedOrder " +
            "INNER JOIN dbo.Supplier ON dbo.SemiFinishedOrder.IdSupplier = dbo.Supplier.IdSupplier " +
            "ORDER BY (dbo.Supplier.SupplierName)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderOrders = sqlCommandOrders.ExecuteReader();
            DataTable dtOrders = new DataTable();
            dtOrders.Columns.Add("Kwota", typeof(string));
            dtOrders.Columns.Add("Data", typeof(string));
            dtOrders.Columns.Add("Nazwa dostawcy", typeof(string));
            while (sqlDataReaderOrders.Read())
            {
                dtOrders.Rows.Add(sqlDataReaderOrders["Cost"], sqlDataReaderOrders["SFOrderDate"], sqlDataReaderOrders["SupplierName"]);
            }
            sqlConnection.Close();
            dgvOrders.DataSource = dtOrders;
            SqlCommand sqlCommandOS = new SqlCommand
            ("SELECT dbo.OutsourcingCommitment.Cost, dbo.OutsourcingCommitment.EndCommitmentDate, dbo.Outsourcing.CompanyName " +
            "FROM dbo.OutsourcingCommitment " +
            "INNER JOIN dbo.Outsourcing ON dbo.OutsourcingCommitment.IdOutsourcing = dbo.Outsourcing.IdOutsourcing " +
            "ORDER BY (dbo.Outsourcing.CompanyName)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderOS = sqlCommandOS.ExecuteReader();
            DataTable dtOS = new DataTable();
            dtOS.Columns.Add("Kwota", typeof(string));
            dtOS.Columns.Add("Data", typeof(string));
            dtOS.Columns.Add("Nazwa podmiotu", typeof(string));
            while (sqlDataReaderOS.Read())
            {
                dtOS.Rows.Add(sqlDataReaderOS["Cost"], sqlDataReaderOS["EndCommitmentDate"], sqlDataReaderOS["CompanyName"]);
            }
            sqlConnection.Close();
            dgvOutsourcing.DataSource = dtOS;
        }
        private void btnAcceptselectedtime_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            ("SELECT dbo.Customer.CustomerName, Cast(dbo.OrderCustomer.OrderDate as DATE) as OrderDate, dbo.OrderCustomer.Cost " +
             "FROM dbo.OrderCustomer " +
             "INNER JOIN dbo.Customer ON dbo.Customer.IdCustomer = dbo.OrderCustomer.IdCustomer " +
             "WHERE OrderDate BETWEEN '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' " +
             "ORDER BY (dbo.Customer.CustomerName)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtCustomer = new DataTable();
            dtCustomer.Columns.Add("Nazwa klienta", typeof(string));
            dtCustomer.Columns.Add("Wartość zamówienia", typeof(string));
            dtCustomer.Columns.Add("Data zamówienia", typeof(DateTime));
            while (sqlDataReader.Read())
            {
            dtCustomer.Rows.Add(sqlDataReader["CustomerName"], sqlDataReader["Cost"], sqlDataReader["OrderDate"]);
            }
            sqlConnection.Close();
            dgvProfits.DataSource = dtCustomer;
            SqlCommand sqlCommandInvoices = new SqlCommand
            ("SELECT dbo.Invoice.Sum, dbo.Invoice.Date, dbo.InvoiceType.Type, dbo.Contractor.ContractorName " +
            "FROM dbo.Invoice " +
            "INNER JOIN dbo.Contractor ON dbo.Invoice.IdContractor = dbo.Contractor.IdContractor " +
            "INNER JOIN dbo.InvoiceType ON dbo.Invoice.IdInvoiceType = dbo.InvoiceType.IdInvoiceType " +
            "WHERE Date BETWEEN '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' " +
            "ORDER BY (dbo.Contractor.ContractorName)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderInvoices = sqlCommandInvoices.ExecuteReader();
            DataTable dtInvoice = new DataTable();
            dtInvoice.Columns.Add("Kwota", typeof(string));
            dtInvoice.Columns.Add("Data", typeof(string));
            dtInvoice.Columns.Add("Typ faktury", typeof(string));
            dtInvoice.Columns.Add("Nazwa podmiotu", typeof(string));
            while (sqlDataReaderInvoices.Read())
            {
                dtInvoice.Rows.Add(sqlDataReaderInvoices["Sum"], sqlDataReaderInvoices["Date"], sqlDataReaderInvoices["Type"], sqlDataReaderInvoices["ContractorName"]);
            }
            sqlConnection.Close();
            dgvInvoices.DataSource = dtInvoice;
            SqlCommand sqlCommandPayment = new SqlCommand
           ("SELECT dbo.Payment.Sum, dbo.Payment.Date, dbo.Payment.Bonus, dbo.Employee.EmployeeName, dbo.Employee.EmployeeSurname " +
           "FROM dbo.Payment " +
           "INNER JOIN dbo.Employee ON dbo.Payment.IdEmployee = dbo.Employee.IdEmployee " +
           "WHERE Date BETWEEN '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' " +
           "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderPayment = sqlCommandPayment.ExecuteReader();
            DataTable dtPayment = new DataTable();
            dtPayment.Columns.Add("Kwota", typeof(string));
            dtPayment.Columns.Add("Data", typeof(string));
            dtPayment.Columns.Add("Bonus", typeof(string));
            dtPayment.Columns.Add("Imię", typeof(string));
            dtPayment.Columns.Add("Nazwisko", typeof(string));
            while (sqlDataReaderPayment.Read())
            {
                dtPayment.Rows.Add(sqlDataReaderPayment["Sum"], sqlDataReaderPayment["Date"], sqlDataReaderPayment["Bonus"], sqlDataReaderPayment["EmployeeName"], sqlDataReaderPayment["EmployeeSurname"]);
            }
            sqlConnection.Close();
            dgvSalaries.DataSource = dtPayment;
            SqlCommand sqlCommandOrders = new SqlCommand
           ("SELECT dbo.SemiFinishedOrder.Cost, Cast(dbo.SemiFinishedOrder.SFOrderDate as DATE) as SFOrderDate, dbo.Supplier.SupplierName " +
           "FROM dbo.SemiFinishedOrder " +
           "INNER JOIN dbo.Supplier ON dbo.SemiFinishedOrder.IdSupplier = dbo.Supplier.IdSupplier " +
           "WHERE SFOrderDate BETWEEN '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' " +
           "ORDER BY (dbo.Supplier.SupplierName)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderOrders = sqlCommandOrders.ExecuteReader();
            DataTable dtOrders = new DataTable();
            dtOrders.Columns.Add("Kwota", typeof(string));
            dtOrders.Columns.Add("Data", typeof(string));
            dtOrders.Columns.Add("Nazwa dostawcy", typeof(string));
            while (sqlDataReaderOrders.Read())
            {
                dtOrders.Rows.Add(sqlDataReaderOrders["Cost"], sqlDataReaderOrders["SFOrderDate"], sqlDataReaderOrders["SupplierName"]);
            }
            sqlConnection.Close();
            dgvOrders.DataSource = dtOrders;
            SqlCommand sqlCommandOS = new SqlCommand
            ("SELECT dbo.OutsourcingCommitment.Cost, Cast(dbo.OutsourcingCommitment.EndCommitmentDate as DATE) as EndCommitmentDate, dbo.Outsourcing.CompanyName " +
            "FROM dbo.OutsourcingCommitment " +
            "INNER JOIN dbo.Outsourcing ON dbo.OutsourcingCommitment.IdOutsourcing = dbo.Outsourcing.IdOutsourcing " +
            "WHERE EndCommitmentDate BETWEEN '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' " +
            "ORDER BY (dbo.Outsourcing.CompanyName)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderOS = sqlCommandOS.ExecuteReader();
            DataTable dtOS = new DataTable();
            dtOS.Columns.Add("Kwota", typeof(string));
            dtOS.Columns.Add("Data", typeof(string));
            dtOS.Columns.Add("Nazwa podmiotu", typeof(string));
            while (sqlDataReaderOS.Read())
            {
                dtOS.Rows.Add(sqlDataReaderOS["Cost"], sqlDataReaderOS["EndCommitmentDate"], sqlDataReaderOS["CompanyName"]);
            }
            sqlConnection.Close();
            dgvOutsourcing.DataSource = dtOS;
        }
        private void btSum_Click(object sender, EventArgs e)
        {
            decimal valIncome = 0, valInvoice = 0, valPayment = 0, valOS = 0, valOrder = 0;
            const int cellIndex1 = 1;
            foreach (DataGridViewRow item in dgvProfits.Rows)
            {
                if (item.Cells[cellIndex1] != null
                && item.Cells[cellIndex1].Value != null && item.Cells[cellIndex1].Value != System.DBNull.Value)
                    valIncome += Convert.ToDecimal(item.Cells[cellIndex1].Value);
            }
            const int cellIndex = 0;
            foreach (DataGridViewRow item in dgvInvoices.Rows)
            {
                if (item.Cells[cellIndex] != null
                && item.Cells[cellIndex].Value != null && item.Cells[cellIndex].Value != System.DBNull.Value)
                    valInvoice += Convert.ToDecimal(item.Cells[cellIndex].Value);
            }
            foreach (DataGridViewRow item in dgvOrders.Rows)
            {
                if (item.Cells[cellIndex] != null
                && item.Cells[cellIndex].Value != null && item.Cells[cellIndex].Value != System.DBNull.Value)
                    valOrder += Convert.ToDecimal(item.Cells[cellIndex].Value);
            }
            foreach (DataGridViewRow item in dgvOutsourcing.Rows)
            {
                if (item.Cells[cellIndex] != null
                && item.Cells[cellIndex].Value != null && item.Cells[cellIndex].Value != System.DBNull.Value)
                    valOS += Convert.ToDecimal(item.Cells[cellIndex].Value);
            }
            foreach (DataGridViewRow item in dgvSalaries.Rows)
            {
                if (item.Cells[cellIndex] != null
                && item.Cells[cellIndex].Value != null && item.Cells[cellIndex].Value != System.DBNull.Value)
                    valPayment += Convert.ToDecimal(item.Cells[cellIndex].Value);
            }
            decimal pureMoney = valIncome - valInvoice - valOrder - valOS - valPayment;
            tbSumIncome.Text = valIncome.ToString();
            tbSumInvoices.Text = valInvoice.ToString();
            tbSumOrders.Text = valOrder.ToString();
            tbSumPayment.Text = valPayment.ToString();
            tbSumOS.Text = valOS.ToString();
            tbPureMoney.Text = pureMoney.ToString();
        }
    }
}
