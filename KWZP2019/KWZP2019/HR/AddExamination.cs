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
    public partial class AddExamination : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        Examination examination;

        public AddExamination(RoofingCompanyEntities db, StartForm startForm, Examination examination)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.examination = examination;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MedicalExamination newMedicalExamination = new MedicalExamination();
            newMedicalExamination.IdEmployee = 1;
            newMedicalExamination.Date = dtpExaminationDate.Value.AddDays(9999999999);
            db.MedicalExaminations.Add(newMedicalExamination);
            db.SaveChanges();
        }

        private void AddExamination_Load(object sender, EventArgs e)
        {
            List<vEmployeeList> employeeList = db.vEmployeeLists.
                OrderBy(employeeListOrderBy => employeeListOrderBy.EmployeeSurname).ToList();
            foreach (vEmployeeList employee in employeeList)
            {
                cbEmployeeList.Items.Add(String.Format("{0, -20} {1, -20}",
                    employee.EmployeeSurname, employee.EmployeeName));
            }

            /*List<vEmployeeList> employeeList = db.vEmployeeLists.
                OrderBy(employeeListOrderBy => employeeListOrderBy.EmployeeSurname).ToList();
            foreach (vEmployeeList employee in employeeList)
            {
                cbEmployeeList.Items.Add(String.Format("{0, -20} {1, -20}",
                    employee.EmployeeSurname, employee.EmployeeName));
            }*/
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.examination.Show();
            this.Hide();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }
    }
}
