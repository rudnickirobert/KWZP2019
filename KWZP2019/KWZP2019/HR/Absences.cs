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
            clear();

            List<vEmployeeList> employeeList = db.vEmployeeLists.ToList();
            foreach (vEmployeeList employee in employeeList)
            {
                cbEmployeeList.Items.Add(String.Format("{0, -10} {1, 0}",
                    employee.EmployeeSurname, employee.EmployeeName));
            }

            List<vAbsenceType> absenceType = db.vAbsenceTypes.ToList();
            foreach (vAbsenceType absenceT in absenceType)
            {
                cbAbsenceType.Items.Add(absenceT.AbscenceReason);
            }
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
                    absencesSelect.EndOfAbsence,
                    absencesSelect.IdAbsence }).
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
                    absencesSelect.EndOfAbsence,
                    absencesSelect.IdAbsence }).
                OrderByDescending(absenceOrderBy => absenceOrderBy.StartOfAbsence).
                ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Absence newAbsence = new Absence();
            if (cbEmployeeList.SelectedIndex == -1 || cbAbsenceType.SelectedIndex == -1)
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione");
            }
            else
            {
                if (dateTimePickerFirstDay.Value > dateTimePickerLastDay.Value)
                {
                    MessageBox.Show("Data końca nieobecności nie może być wcześniejsza niż data początku");
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
            Absence AbsenceToRemove = new Absence {IdAbsence = int.Parse(dgvAbsences.SelectedRows[0].Cells[5].Value.ToString())};
            db.Absences.Attach(AbsenceToRemove);
            db.Absences.Remove(AbsenceToRemove);
            db.SaveChanges();
            if (tbSearchAbsence.Text.Trim() == "" || tbSearchName.Text.Trim() == "")
            {
                display();
            }
            else
            {
                tbSearchAbsence_TextChanged(sender, e);
            }
            MessageBox.Show("Rekord został usunięty");
        }

        void display()
        {
            dgvAbsences.DataSource = db.vAbsences.
                Select(absencesSelect => new {
                    absencesSelect.EmployeeSurname,
                    absencesSelect.EmployeeName,
                    absencesSelect.AbscenceReason,
                    absencesSelect.StartOfAbsence,
                    absencesSelect.EndOfAbsence,
                    absencesSelect.IdAbsence
                }).
                OrderByDescending(absenceOrderBy => absenceOrderBy.StartOfAbsence).
                ToList();

            dgvAbsences.Columns[5].Visible = false;

            dgvAbsences.Columns[0].HeaderText = "Nazwisko";
            dgvAbsences.Columns[1].HeaderText = "Imię";
            dgvAbsences.Columns[2].HeaderText = "Powód";
            dgvAbsences.Columns[3].HeaderText = "Początek";
            dgvAbsences.Columns[4].HeaderText = "Koniec";

            dgvAbsences.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAbsences.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAbsences.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAbsences.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAbsences.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string number = cbEmployeeList.SelectedItem.ToString();
            MessageBox.Show(number.Substring(0, 41));
        }

        private void btnAddAbsenceType_Click(object sender, EventArgs e)
        {
            AddAbsenceType addAbsenceType = new AddAbsenceType(db);
            addAbsenceType.Show();
            this.Close();
        }
    }
}
