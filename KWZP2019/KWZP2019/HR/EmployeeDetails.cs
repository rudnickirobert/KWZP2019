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
        public EmployeeDetails(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {   
                dgvEmployeeDetails.DataSource = db.vEmployeeDetails.
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
                            employeeDetailsSelect.HealTestDate,
                            employeeDetailsSelect.WorkplaceTrainingDate,
                            employeeDetailsSelect.Date
                    }).ToList();
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
                        employeeDetailsSelect.HealTestDate,
                        employeeDetailsSelect.WorkplaceTrainingDate,
                        employeeDetailsSelect.Date
            }).ToList();
        }
    }
}
