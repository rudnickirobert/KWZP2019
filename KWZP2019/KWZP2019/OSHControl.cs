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
    public partial class OSHControl : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private QualityControl qualityControlForm;
        private int selectedEmployee;

        public OSHControl(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.qualityControlForm.Close();
            this.Close();
        }

        private void OSHControl_Load(object sender, EventArgs e)
        {
            dateTimeOSHControl.Value = DateTime.Now;
            List<Employee> employeeList = db.Employees.ToList();
            foreach (Employee employee in employeeList)
            {
                domainUpDownEmployee.Items.Add(employee.IdEmployee);
            }
        }

        private void OSHControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
            this.qualityControlForm.Close();
        }

        private void domainUpDownEmployee_SelectedItemChanged(object sender, EventArgs e)
        {
            Employee employee = db.Employees.First(emp => emp.IdEmployee.ToString() == domainUpDownEmployee.Text);
            lblEmployeeFullName.Text = $"{employee.EmployeeName} {employee.EmployeeSurname}";
            selectedEmployee = Convert.ToInt32(domainUpDownEmployee.Text);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (textBoxDescription.Text == "" || domainUpDownEmployee.Text == "" || txtBoxControlingCompany.Text == "" || txtBoxControlerId.Text == "" )
            {
                MessageBox.Show("Nie można zatwierdzić wyników!\nUzupełnij wszystkie pola!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {       
                SafetyControl safetyControl = new SafetyControl();

                safetyControl.IdSafetyEmployee = txtBoxControlerId.Text;
                safetyControl.CompanyName = txtBoxControlingCompany.Text;
                safetyControl.IdInspectedEmployee = selectedEmployee;
                safetyControl.SaftyControlDate = dateTimeOSHControl.Value;
                safetyControl.SafetyControlDescription = textBoxDescription.Text;

                db.SafetyControls.Add(safetyControl);
                db.SaveChanges();

                txtBoxControlerId.Text = "";
                txtBoxControlingCompany.Text = "";
                textBoxDescription.Text = "";
                lblEmployeeFullName.Text = "------------------------";
                domainUpDownEmployee.Text = "1";


            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OSHControlHistory oSHControlHistory = new OSHControlHistory(db, startForm, this);
            oSHControlHistory.Show();
            this.Hide();
        }


    }
}
