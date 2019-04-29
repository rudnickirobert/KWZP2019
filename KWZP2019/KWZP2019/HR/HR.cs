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
    public partial class HR : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        FinancesAndHR finanseIHR;
        public HR(RoofingCompanyEntities db, StartForm startForm, FinancesAndHR finanseIHR)
        {
            this.db = db;
            this.startForm = startForm;
            this.finanseIHR = finanseIHR;
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(db);
            addEmployee.Show();
            this.Hide();
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            Examination examination = new Examination(db);
            examination.Show();
            this.Hide();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails(db);
            employeeDetails.Show();
            this.Hide();
        }
        private void btnAbsences_Click(object sender, EventArgs e)
        {
            Absences absences = new Absences(db);
            absences.Show();
            this.Hide();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            AddTraining addTraining = new AddTraining(db);
            addTraining.Show();
            this.Hide();
        }

        private void HR_Load(object sender, EventArgs e)
        {

            //dgvEmployees Part - innitial data
            SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeSurname, dbo.Employee.EmployeeName, dbo.Employee.City, dbo.Employee.PhoneNumber, dbo.Position.Workplace " +
                "FROM dbo.Employee " +
                "INNER JOIN dbo.Contract " +
                "ON dbo.Employee.IdEmployee = dbo.Contract.IdEmployee " +
                "INNER JOIN dbo.Position " +
                "ON dbo.Contract.IdPosition = dbo.Position.IdPosition " +
                "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Pozycja", typeof(string));
            dtEmployees.Columns.Add("Numer telefonu", typeof(string));
            dtEmployees.Columns.Add("Miejsce zamieszkania", typeof(string));
            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["Workplace"], 
                    sqlDataReader["PhoneNumber"], sqlDataReader["City"]);
            }
            sqlConnection.Close();
            dgvEmloyees.DataSource = dtEmployees;

            //lbWarnings contract Part
           
            SqlCommand sqlCommandWarninngs = new SqlCommand
                ("SELECT COUNT(RoofingCompany.dbo.Contract.EndDate) " +
                "FROM RoofingCompany.dbo.Contract " +
                "WHERE  RoofingCompany.dbo.Contract.EndDate < '" + DateTime.Today.AddMonths(-3).ToString("yyyy-MM-dd") + "'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderWarnings = sqlCommandWarninngs.ExecuteReader();
            sqlDataReaderWarnings.Read();
            String stddetails = "{0, -40}{1, 00}";
            lbWarningsExamination.Items.Add(String.Format(stddetails, "Prcownicy którym kończy się umowa:", sqlDataReaderWarnings[""]));
            sqlConnection.Close();

            //lbWarnings examination Part

            SqlCommand sqlCommandWarninngsExamination = new SqlCommand
                ("SELECT COUNT(RoofingCompany.dbo.MedicalExamination.Date) " +
                "FROM RoofingCompany.dbo.MedicalExamination " +
                "WHERE  RoofingCompany.dbo.MedicalExamination.Date < '" + DateTime.Today.AddMonths(12).ToString("yyyy-MM-dd") + "'", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReaderWarningsExamination = sqlCommandWarninngsExamination.ExecuteReader();
            sqlDataReaderWarningsExamination.Read();
            lbWarningsContracts .Items.Add(String.Format(stddetails, "Prcownicy którym kończą się badania:", sqlDataReaderWarningsExamination[""]));
            sqlConnection.Close();
        }

        private void tbEmployeeSearching_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
            SqlCommand sqlCommand = new SqlCommand
                ("SELECT dbo.Employee.EmployeeSurname, dbo.Employee.EmployeeName, " +
                "dbo.Position.Workplace, dbo.Employee.PhoneNumber, dbo.Employee.City FROM dbo.Employee " +
                "INNER JOIN dbo.Contract " +
                "ON dbo.Employee.IdEmployee = dbo.Contract.IdEmployee " +
                "INNER JOIN dbo.Position " +
                "ON dbo.Contract.IdPosition = dbo.Position.IdPosition " +
                "WHERE(dbo.Employee.EmployeeSurname LIKE '" + tbEmployeeSearching.Text + "%') " +
                "ORDER BY (dbo.Employee.EmployeeSurname)", sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dtEmployees = new DataTable();
            dtEmployees.Columns.Add("Nazwisko", typeof(string));
            dtEmployees.Columns.Add("Imię", typeof(string));
            dtEmployees.Columns.Add("Pozycja", typeof(string));
            dtEmployees.Columns.Add("Numer telefonu", typeof(string));
            dtEmployees.Columns.Add("Miejsce zamieszkania", typeof(string));
            while (sqlDataReader.Read())
            {
                dtEmployees.Rows.Add(sqlDataReader["EmployeeSurname"], sqlDataReader["EmployeeName"], sqlDataReader["Workplace"], 
                    sqlDataReader["PhoneNumber"], sqlDataReader["City"]);
            }
            sqlConnection.Close();
            dgvEmloyees.DataSource = dtEmployees;
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            Contracts contracts = new Contracts(db);
            contracts.Show();
        }

        private void lbWarningsExamination_DoubleClick(object sender, EventArgs e)
        {
            Examination examination = new Examination(db);
            examination.Show();
        }

        private void lbWarningsContracts_DoubleClick(object sender, EventArgs e)
        {
            Contracts contracts = new Contracts(db);
            contracts.Show();
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            AddContract addContract = new AddContract();
            addContract.Show();
        }

        private void btnEducationLevel_Click(object sender, EventArgs e)
        {
            EducationForm educationForm = new EducationForm(db);
            educationForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.finanseIHR.Show();
            this.Hide();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }
    }
}
