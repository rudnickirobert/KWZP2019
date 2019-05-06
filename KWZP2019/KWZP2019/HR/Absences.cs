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
        StartForm startForm;
        HR hr;

        public Absences(RoofingCompanyEntities db, StartForm startForm, HR hr)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
        }

        private void Absences_Load(object sender, EventArgs e)
        {
            display();

            List<vEmployeeList> employeeList = db.vEmployeeLists.
                OrderBy(employeeListOrderBy => employeeListOrderBy.EmployeeSurname).ToList();
            foreach (vEmployeeList employee in employeeList)
            {
                cbEmployeeList.Items.Add(String.Format("{0, -20} {1, -20}",
                    employee.EmployeeSurname, employee.EmployeeName));
            }

            List<vAbsenceType> absenceType = db.vAbsenceTypes.ToList();
            foreach (vAbsenceType absenceT in absenceType)
            {
                cbAbsenceType.Items.Add(absenceT.AbscenceReason);
            }

            clear();
        }

        private void tbSearchAbsence_TextChanged(object sender, EventArgs e)
        {
            dgvAbsences.DataSource = db.vAbsences.
                Where(absences => absences.EmployeeSurname.StartsWith(tbSearchAbsence.Text)
                               && absences.EmployeeName.StartsWith(tbSearchName.Text)).
                Select(absencesSelect => new {
                    absencesSelect.EmployeeSurname,
                    absencesSelect.EmployeeName,
                    absencesSelect.AbscenceReason,
                    absencesSelect.StartOfAbsence,
                    absencesSelect.EndOfAbsence }).
                OrderByDescending(absenceOrderBy => absenceOrderBy.StartOfAbsence).
                ToList();
        }

        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            dgvAbsences.DataSource = db.vAbsences.
                Where(absences => absences.EmployeeSurname.StartsWith(tbSearchAbsence.Text)
                               && absences.EmployeeName.StartsWith(tbSearchName.Text)).
                Select(absencesSelect => new {
                    absencesSelect.EmployeeSurname,
                    absencesSelect.EmployeeName,
                    absencesSelect.AbscenceReason,
                    absencesSelect.StartOfAbsence,
                    absencesSelect.EndOfAbsence }).
                OrderByDescending(absenceOrderBy => absenceOrderBy.StartOfAbsence).
                ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Absence newAbsence = new Absence();
            if (cbEmployeeList.SelectedIndex == -1 ||
                cbAbsenceType.SelectedIndex == -1 ||
                dateTimePickerFirstDay.Value > dateTimePickerLastDay.Value)
            {
                MessageBox.Show("Pola Pracownik oraz typ nieobecności nie mogą być puste, " +
                    "oraz data końca nieobecności nie może być wcześniejsza od daty początku nieobecności");
            }
            else
            {
                newAbsence.IdEmployee = cbEmployeeList.SelectedIndex + 1;
                newAbsence.IdAbsenceType = cbAbsenceType.SelectedIndex + 1;
                newAbsence.StartOfAbsence = dateTimePickerFirstDay.Value;
                newAbsence.EndOfAbsence = dateTimePickerLastDay.Value;
                db.Absences.Add(newAbsence);
                db.SaveChanges();
                if (tbSearchAbsence.Text.Trim() == "" || tbSearchName.Text.Trim() == "")
                {
                    display();
                }
                else
                {
                    tbSearchAbsence_TextChanged(sender, e);
                }
                clear();
                MessageBox.Show("Nieobecność dodana prawidłowo");
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

        void clear()
        {
            cbAbsenceType.SelectedIndex = -1;
            cbEmployeeList.SelectedIndex = -1;
            dateTimePickerFirstDay.Value = DateTime.Today;
            dateTimePickerLastDay.Value = DateTime.Today;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*Absence AbsenceToRemove = new Absence {IdAbsence = dgvAbsences.SelectedRows[0].Index + 1};
            db.Absences.Attach(AbsenceToRemove);
            db.Absences.Remove(AbsenceToRemove);
            MessageBox.Show("Rekord został usunięty");
            display();*/
        }

        void display()
        {
            dgvAbsences.DataSource = db.vAbsences.
                Select(absencesSelect => new {
                    absencesSelect.EmployeeSurname,
                    absencesSelect.EmployeeName,
                    absencesSelect.AbscenceReason,
                    absencesSelect.StartOfAbsence,
                    absencesSelect.EndOfAbsence
                }).
                OrderByDescending(absenceOrderBy => absenceOrderBy.StartOfAbsence).
                ToList();

            dgvAbsences.Columns[0].HeaderText = "Nazwisko";
            dgvAbsences.Columns[1].HeaderText = "Imię";
            dgvAbsences.Columns[2].HeaderText = "Powód";
            dgvAbsences.Columns[3].HeaderText = "Początek";
            dgvAbsences.Columns[4].HeaderText = "Koniec";

            dgvAbsences.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAbsences.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAbsences.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAbsences.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvAbsences.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
