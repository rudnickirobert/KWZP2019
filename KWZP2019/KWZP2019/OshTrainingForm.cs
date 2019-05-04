using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class OshTrainingForm : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private QualityControl qualityControlForm;
        private int selectedEmployee;
        private SafetyTraining safetyTraining;

        public OshTrainingForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }

        private void OshTrainingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
        }

        private void OshTrainingForm_Load(object sender, EventArgs e)
        {
            List<Department> departmentList = db.Departments.ToList();
            foreach (Department dep in departmentList)
            {
                domainUpDownDepartmentName.Items.Add(dep.DepartmentName);
            }
            datePickerControlDate.Value = DateTime.Now;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGVOshTraining.DataSource = db.ViewOshTrainings.
                Where(vOsh => vOsh.Dział == domainUpDownDepartmentName.Text).ToList();
        }

        private void textBoxEmployeeId_TextChanged(object sender, EventArgs e)
        {
            Employee employee = db.Employees
                .FirstOrDefault(check =>
                check.IdEmployee.ToString() == textBoxEmployeeId.Text);

            lblEmployeeFullName.Text = employee != null ?
                $"{employee.EmployeeName} {employee.EmployeeSurname}" :
                "Brak pracownika o takim numerze!";
        }

        void clear()
        {
            textBoxEmployeeId.Text = "";
            dataGVOshTraining.DataSource = "";
            datePickerControlDate.Value = DateTime.Now;
            domainUpDownDepartmentName.Text = "Wybierz dział";
            lblEmployeeFullName.Text = "_____________________________________________";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            selectedEmployee = Convert.ToInt32(textBoxEmployeeId.Text);
            if (textBoxEmployeeId.Text == "")
            {
                MessageBox.Show("Uzupełnij numer pracownika!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                safetyTraining = db.SafetyTrainings.Where(s => s.IdEmployee == selectedEmployee).First();
                safetyTraining.IdEmployee = selectedEmployee;
                safetyTraining.TrainingDate = datePickerControlDate.Value;

                db.SaveChanges();
                MessageBox.Show("Zmieniono termin wygaśnięcia szkolenia pracownika!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGVOshTraining.DataSource = db.ViewOshTrainings.ToList();
                textBoxEmployeeId.Text = "";
                datePickerControlDate.Value = DateTime.Now;
                lblEmployeeFullName.Text = "_____________________________________________";

                dataGVOshTraining.DataSource = db.ViewOshTrainings.
                    Where(vOsh => vOsh.Dział == domainUpDownDepartmentName.Text).ToList();
            }
        }
    }
};