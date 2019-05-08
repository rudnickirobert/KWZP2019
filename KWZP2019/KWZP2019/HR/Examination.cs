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
            dgvExamination.DataSource = db.vHRExaminations.
                Where (examination => examination.EmployeeSurname.StartsWith(tbSearchEmployeeExamination.Text)
                                   && examination.EmployeeName.StartsWith(tbSearchEmployeeExaminationName.Text)).
                OrderByDescending (ExaminationOrderBy => ExaminationOrderBy.NextExamination).
                ToList();
        }

        private void tbSearchEmployeeExaminationName_TextChanged(object sender, EventArgs e)
        {
            dgvExamination.DataSource = db.vHRExaminations.
                   Where (examination => examination.EmployeeSurname.StartsWith(tbSearchEmployeeExamination.Text)
                                      && examination.EmployeeName.StartsWith(tbSearchEmployeeExaminationName.Text)).
                    OrderByDescending(ExaminationOrderBy => ExaminationOrderBy.NextExamination).
                    ToList();
        }

        void display()
        {
            dgvExamination.DataSource = db.vHRExaminations.
                OrderByDescending(ExaminationOrderBy => ExaminationOrderBy.NextExamination).
                ToList();

            dgvExamination.Columns[0].Visible = false;
            dgvExamination.Columns[4].Visible = false;
            dgvExamination.Columns[5].Visible = false;
            dgvExamination.Columns[6].Visible = false;
            dgvExamination.Columns[8].Visible = false;

            dgvExamination.Columns[1].HeaderText = "Nazwisko";
            dgvExamination.Columns[2].HeaderText = "Imię";
            dgvExamination.Columns[2].HeaderText = "PESEL";
            dgvExamination.Columns[7].HeaderText = "Ważność_badania";

            dgvExamination.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExamination.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExamination.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvExamination.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (DataGridViewRow row in dgvExamination.Rows)
            {
                DateTime expirationDate = DateTime.Parse(row.Cells[7].Value.ToString());
                DateTime now = DateTime.Now;
                DateTime twoWeeksBefore = expirationDate.AddDays(-14);
                if (twoWeeksBefore < now && expirationDate > now)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(102,179,255);
                }
                else if (expirationDate < now)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(82, 82, 122);
                }
            }
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
            MedicalExamination examinationToRemove = new MedicalExamination();
            examinationToRemove.IdMedicalExamination = int.Parse(dgvExamination.SelectedRows[0].Cells[8].Value.ToString());
            db.MedicalExaminations.Attach(examinationToRemove);
            db.MedicalExaminations.Remove(examinationToRemove);
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
