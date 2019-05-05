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
    public partial class Examination : Form
    {
        RoofingCompanyEntities db;
        public Examination(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Examination_Load(object sender, EventArgs e)
        {
            dgvExamination.DataSource = db.vExaminations.
                Select (examinationSource => new {
                        examinationSource.EmployeeSurname,
                        examinationSource.EmployeeName,
                        examinationSource.Date
                }).ToList();
        }

        private void btnAddExamination_Click(object sender, EventArgs e)
        {
            AddExamination addExamination = new AddExamination(db);
            addExamination.Show();
        }

        private void tbSearchEmployeeExamination_TextChanged(object sender, EventArgs e)
        {
            dgvExamination.DataSource = db.vExaminations.
                Where (examination => examination.EmployeeSurname.StartsWith(tbSearchEmployeeExamination.Text)
                                   && examination.EmployeeName.StartsWith(tbSearchEmployeeExaminationName.Text)).
                Select (examinationSource => new {
                        examinationSource.EmployeeSurname,
                        examinationSource.EmployeeName,
                        examinationSource.Date
                }).ToList();
        }

        private void tbSearchEmployeeExaminationName_TextChanged(object sender, EventArgs e)
        {
            dgvExamination.DataSource = db.vExaminations.
                   Where (examination => examination.EmployeeSurname.StartsWith(tbSearchEmployeeExamination.Text)
                                      && examination.EmployeeName.StartsWith(tbSearchEmployeeExaminationName.Text)).
                   Select (examinationSource => new {
                           examinationSource.EmployeeSurname,
                           examinationSource.EmployeeName,
                           examinationSource.Date
                   }).ToList();
        }
    }
}
