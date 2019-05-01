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
    public partial class pbAbsences : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        HR hr;
        SqlConnection sqlConnection = new SqlConnection("server =.\\SQLEXPRESS;Database=RoofingCompany;Integrated Security=true");
        public pbAbsences(RoofingCompanyEntities db, StartForm startForm, HR hr)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
        }

        private void Absences_Load(object sender, EventArgs e)
        {
            dgvAbsences.DataSource = db.vAbsences.Select(absencesSelect => new {
                absencesSelect.EmployeeSurname,
                absencesSelect.EmployeeName,
                absencesSelect.AbscenceReason,
                absencesSelect.StartOfAbsence,
                absencesSelect.EndOfAbsence
            }).ToList();
        }

        private void tbSearchAbsence_TextChanged(object sender, EventArgs e)
        {
            dgvAbsences.DataSource = db.vAbsences.
                Where(absences => absences.EmployeeSurname.StartsWith(tbSearchAbsence.Text)).
                Select(absencesSelect => new {
                    absencesSelect.EmployeeSurname,
                    absencesSelect.EmployeeName,
                    absencesSelect.AbscenceReason,
                    absencesSelect.StartOfAbsence,
                    absencesSelect.EndOfAbsence
                }).ToList();
        }

        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            dgvAbsences.DataSource = db.vAbsences.
                Where(absences => absences.EmployeeSurname.StartsWith(tbSearchName.Text)).
                Select(absencesSelect => new {
                    absencesSelect.EmployeeSurname,
                    absencesSelect.EmployeeName,
                    absencesSelect.AbscenceReason,
                    absencesSelect.StartOfAbsence,
                    absencesSelect.EndOfAbsence
                }).ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Absence newAbsence = new Absence();
            newAbsence.StartOfAbsence = dateTimePickerFirstDay.Value;
            newAbsence.EndOfAbsence = dateTimePickerLastDay.Value;
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
    }
}
