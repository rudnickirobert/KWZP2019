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
        private DataGridViewRow selectedRow;
        private bool doSelectedRow = false;

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
            foreach (Department department in departmentList)
            {
                domainUpDownDepartmentName.Items.Add(department.DepartmentName);
            }
            datePickerControlDate.Value = DateTime.Now;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGVOshTraining.DataSource = db.ViewOshTrainings.
                Where(vOsh => vOsh.Dział == domainUpDownDepartmentName.Text).ToList();
            dataGVOshTraining.AutoResizeColumns();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(doSelectedRow)
            {
                string pesel = selectedRow.Cells["PESEL"].Value.ToString();
                int idEmployee = db.Employees
                    .First(check => check.PESEL == pesel).IdEmployee;
                SafetyTraining safetyTraining = db.SafetyTrainings
                    .First(check => check.IdEmployee == idEmployee);
                safetyTraining.TrainingDate = datePickerControlDate.Value;
                db.SaveChanges();
                doSelectedRow = false;
                MessageBox.Show("Zmiany zostały zapisane!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGVOshTraining.DataSource = db.ViewOshTrainings
                    .Where(vOsh => vOsh.Dział == domainUpDownDepartmentName.Text).ToList();
            }
            else
            {
                MessageBox.Show("Zaznacz wiersz wybranego pracownika!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGVOshTraining_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dataGVOshTraining.SelectedRows.Count == 0)
            {
                doSelectedRow = false;
            }
            else
            {
                selectedRow = dataGVOshTraining.SelectedRows[0];
                doSelectedRow = true;
            }
        }

        private void dataGVOshTraining_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            doSelectedRow = false;
        }

        private void btnNewTraining_Click(object sender, EventArgs e)
        {
            OshTrainingNewEmployeeForm oshTrainingNewEmployeeForm = new OshTrainingNewEmployeeForm(db, startForm, this);
            oshTrainingNewEmployeeForm.Show();
            this.Hide();
        }
    }
};