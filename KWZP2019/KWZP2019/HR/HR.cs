using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class HR : Form
    {
        RoofingCompanyEntities db = new RoofingCompanyEntities();
        public HR()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void HR_Load(object sender, EventArgs e)
        {
            dataGridViewEmloyees.AutoGenerateColumns = false;
            dataGridViewEmloyees.DataSource = db.Employees.ToList<Employee>();
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            Examination examination = new Examination();
            examination.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.Show();
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            Absences absences = new Absences();
            absences.Show();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            AddTraining addTraining = new AddTraining();
            addTraining.Show();
        }
    }
}
