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
            AddEmployee addEmployee = new AddEmployee(db, startForm, this);
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
            pbAbsences absences = new pbAbsences(db, startForm, this);
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
            dgvEmloyees.DataSource = db.vHR.Select(employeesSelect => new {
                employeesSelect.EmployeeSurname,
                employeesSelect.EmployeeName,
                employeesSelect.Workplace,
                employeesSelect.PhoneNumber,
                employeesSelect.City
            }).ToList();
            String stddetails = "{0, -40}{1, 0}";

            lbWarningsContracts.Items.Add(String.Format(stddetails,
                "Pracownicy, którym kończy się umowa: ", db.vHRContracts.Count()));

            lbWarningsExamination.Items.Add(String.Format(stddetails, 
                "Pracownicy, którym kończą się badania lekarskie: " , db.vHRExaminations.Count().ToString()));
        }

        private void tbEmployeeSearching_TextChanged(object sender, EventArgs e)
        {
            dgvEmloyees.DataSource = db.vHR.
                Where(employees => employees.EmployeeSurname.StartsWith(tbEmployeeSearching.Text)).
                Select(employeesSelect => new {
                    employeesSelect.EmployeeSurname,
                    employeesSelect.EmployeeName,
                    employeesSelect.Workplace,
                    employeesSelect.PhoneNumber,
                    employeesSelect.City
                }).ToList();
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
