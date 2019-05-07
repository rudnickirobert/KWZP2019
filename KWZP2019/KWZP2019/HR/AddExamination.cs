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
            if (cbEmployeeList.SelectedIndex == -1 || cbPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione");
            }
            else
            {
                MedicalExamination newMedicalExamination = new MedicalExamination();
                newMedicalExamination.IdEmployee = cbEmployeeList.SelectedIndex + 1;
                MessageBox.Show(cbPosition.SelectedIndex.ToString());
                int validity = int.Parse(db.Positions.
                    Where(validityWhere => validityWhere.IdPosition.Equals(cbPosition.SelectedIndex +1)).
                    Select (validitySelect => new {
                            validitySelect.VailidityOfMedicalExam
                    }).ToString());
                
                newMedicalExamination.Date = dtpExaminationDate.Value.AddDays(validity);
                db.MedicalExaminations.Add(newMedicalExamination);
                db.SaveChanges();
                clear();
                MessageBox.Show("Prawidłowo wprowadzono badanie");
            }
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

            List<vPosition> positionList = db.vPositions.ToList();
            foreach (vPosition positionL in positionList)
            {
                cbPosition.Items.Add(positionL.Workplace);
            }

            clear();
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

        void clear()
        {
            cbEmployeeList.SelectedIndex = -1;
            cbPosition.SelectedIndex = -1;
            dtpExaminationDate.Value = DateTime.Today;
        }
    }
}
