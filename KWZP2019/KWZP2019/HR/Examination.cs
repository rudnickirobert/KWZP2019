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
    public partial class Examination : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        HR hr;
        public Examination(RoofingCompanyEntities db, StartForm startForm, HR hr)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
        }

        private void Examination_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnAddExamination_Click(object sender, EventArgs e)
        {
            AddExamination addExamination = new AddExamination(db,startForm, this);
            addExamination.Show();
            this.Hide();
        }

        private void tbSearchEmployeeExamination_TextChanged(object sender, EventArgs e)
        {
            dgvExamination.DataSource = db.vExaminations.
                Where (examination => examination.Nazwisko.StartsWith(tbSearchEmployeeExamination.Text)
                                   && examination.Imię.StartsWith(tbSearchEmployeeExaminationName.Text)).
                OrderByDescending (ExaminationOrderBy => ExaminationOrderBy.Data_badania_lekarskiego).
                ToList();
        }

        private void tbSearchEmployeeExaminationName_TextChanged(object sender, EventArgs e)
        {
            dgvExamination.DataSource = db.vExaminations.
                   Where (examination => examination.Nazwisko.StartsWith(tbSearchEmployeeExamination.Text)
                                      && examination.Imię.StartsWith(tbSearchEmployeeExaminationName.Text)).
                    OrderByDescending(ExaminationOrderBy => ExaminationOrderBy.Data_badania_lekarskiego).
                    ToList();
        }

        void display()
        {
            dgvExamination.DataSource = db.vExaminations.
                OrderByDescending(ExaminationOrderBy => ExaminationOrderBy.Data_badania_lekarskiego).
                ToList();

            dgvExamination.Columns[0].Visible = false;
            dgvExamination.Columns[4].Visible = false;

            dgvExamination.Columns[3].HeaderText = "Data_badania";

            dgvExamination.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExamination.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExamination.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.hr.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MedicalExamination ExaminationToRemove = new MedicalExamination
            { IdMedicalExamination = int.Parse(dgvExamination.SelectedRows[0].Cells[0].Value.ToString()) };
            db.MedicalExaminations.Attach(ExaminationToRemove);
            db.MedicalExaminations.Remove(ExaminationToRemove);
            db.SaveChanges();
            if (tbSearchEmployeeExamination.Text.Trim() == "" || tbSearchEmployeeExaminationName.Text.Trim() == "")
            {
                display();
            }
            else
            {
                tbSearchEmployeeExamination_TextChanged(sender, e);
            }
            MessageBox.Show("Rekord został usunięty");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (tbSearchEmployeeExamination.Text.Trim() == "" || tbSearchEmployeeExaminationName.Text.Trim() == "")
            {
                display();
            }
            else
            {
                tbSearchEmployeeExamination_TextChanged(sender, e);
            }
        }
    }
}
