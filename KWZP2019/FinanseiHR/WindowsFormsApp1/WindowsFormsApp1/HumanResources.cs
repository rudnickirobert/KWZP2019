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

namespace WindowsFormsApp1
{
    public partial class HumanResources : Form
    {

        //String stdDetails = "{0, -10}{1, -20}{2,-20}{3, -20}{4, -20}{5, -16}";
        public HumanResources()
        {
            InitializeComponent();
        }

        private void HumanResources_Load(object sender, EventArgs e)
        {
            /*listBoxEmployeeList.Items.Add(String.Format(stdDetails, "ID", "First Name", "Last Name", "Position", "Phone Number", "Address"));
            db = new finanseHREntities();
            listBoxEmployeeList.Items.Add(String.Format(stdDetails, db.Employees.ToList()));
            ShowDataGridView();*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void ShowDataGridView()
        {
            /*using (finanseHREntities db = new finanseHREntities())
            {
                dataGridView1.DataSource = db.Employee.ToList();
            }*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEmployeeDetails_Click(object sender, EventArgs e)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.Show();
        }

        private void buttonExamination_Click(object sender, EventArgs e)
        {
            Examination examination = new Examination();
            examination.Show();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void buttonTraining_Click(object sender, EventArgs e)
        {
            AddTraining addTraining = new AddTraining();
            addTraining.Show();
        }

        private void buttonAbsences_Click(object sender, EventArgs e)
        {
            Absences absences = new Absences();
            absences.Show();
        }

        private void buttonPayChecks_Click(object sender, EventArgs e)
        {
            Paychecks paychecks = new Paychecks();
            paychecks.Show();
        }
    }
}
