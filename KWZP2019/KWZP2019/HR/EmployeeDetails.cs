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
    public partial class EmployeeDetails : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        HR hr;
        public EmployeeDetails(RoofingCompanyEntities db, StartForm startForm, HR hr)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            display();
        }

        private void tbSearchEmployeeDetails_TextChanged(object sender, EventArgs e)
        {
            dgvEmployeeDetails.DataSource = db.vEmployeeDetails.
                Where (employeeDetails => employeeDetails.EmployeeSurname.StartsWith(tbSearchEmployeeDetails.Text)).
                Select (employeeDetailsSelect => new {
                        employeeDetailsSelect.EmployeeSurname,
                        employeeDetailsSelect.EmployeeName,
                        employeeDetailsSelect.PhoneNumber,
                        employeeDetailsSelect.City,
                        employeeDetailsSelect.ZipCode,
                        employeeDetailsSelect.Street,
                        employeeDetailsSelect.HouseNumber,
                        employeeDetailsSelect.ApartmentNum,
                        employeeDetailsSelect.PESEL,
                        employeeDetailsSelect.EducationLevel,
                        employeeDetailsSelect.DegreeShort,
                        employeeDetailsSelect.GraduationDate,
                        employeeDetailsSelect.Workplace,
                        employeeDetailsSelect.StartDate,
                        employeeDetailsSelect.EndDate,
                        employeeDetailsSelect.Salary,
                        employeeDetailsSelect.WorkplaceTrainingDate,
                        employeeDetailsSelect.Date
            }).ToList();
        }
        void display()
        {
            dgvEmployeeDetails.DataSource = db.vEmployeeDetails.
                    Select(employeeDetailsSelect => new {
                        employeeDetailsSelect.EmployeeSurname,
                        employeeDetailsSelect.EmployeeName,
                        employeeDetailsSelect.PhoneNumber,
                        employeeDetailsSelect.City,
                        employeeDetailsSelect.ZipCode,
                        employeeDetailsSelect.Street,
                        employeeDetailsSelect.HouseNumber,
                        employeeDetailsSelect.ApartmentNum,
                        employeeDetailsSelect.PESEL,
                        employeeDetailsSelect.EducationLevel,
                        employeeDetailsSelect.DegreeShort,
                        employeeDetailsSelect.GraduationDate,
                        employeeDetailsSelect.Workplace,
                        employeeDetailsSelect.StartDate,
                        employeeDetailsSelect.EndDate,
                        employeeDetailsSelect.Salary,
                        employeeDetailsSelect.WorkplaceTrainingDate,
                        employeeDetailsSelect.Date
                    }).ToList();

            dgvEmployeeDetails.Columns[0].HeaderText = "Nazwisko";
            dgvEmployeeDetails.Columns[1].HeaderText = "Imię";
            dgvEmployeeDetails.Columns[2].HeaderText = "Nr telefonu";
            dgvEmployeeDetails.Columns[3].HeaderText = "Miasto";
            dgvEmployeeDetails.Columns[4].HeaderText = "Kod pocztowy";
            dgvEmployeeDetails.Columns[5].HeaderText = "Ulica";
            dgvEmployeeDetails.Columns[6].HeaderText = "Nr domu";
            dgvEmployeeDetails.Columns[7].HeaderText = "Nr lokalu";
            dgvEmployeeDetails.Columns[8].HeaderText = "PESEL";
            dgvEmployeeDetails.Columns[9].HeaderText = "Stopień wykształcenia";
            dgvEmployeeDetails.Columns[10].HeaderText = "Tytuły naukowe";
            dgvEmployeeDetails.Columns[11].HeaderText = "Data ukończenia studiów";
            dgvEmployeeDetails.Columns[12].HeaderText = "Stanowisko";
            dgvEmployeeDetails.Columns[13].HeaderText = "Początek umowy";
            dgvEmployeeDetails.Columns[14].HeaderText = "Koniec umowy";
            dgvEmployeeDetails.Columns[15].HeaderText = "Pensja";
            dgvEmployeeDetails.Columns[16].HeaderText = "Badanie";
            dgvEmployeeDetails.Columns[17].HeaderText = "Data treningu stanowiskowego";
            dgvEmployeeDetails.Columns[18].HeaderText = "Termin ważności badań lekarskich";

            dgvEmployeeDetails.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[13].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[14].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[15].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[16].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[17].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployeeDetails.Columns[18].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.hr.Show();
            this.Hide();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }
    }
}
