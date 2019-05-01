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
    public partial class Absences : Form
    {
        RoofingCompanyEntities db;

        public Absences(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
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
    }
}
