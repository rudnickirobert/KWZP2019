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
    public partial class EducationForm : Form
    {
        RoofingCompanyEntities db;
        public EducationForm(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void EducationForm_Load(object sender, EventArgs e)
        {
            dgvEducation.DataSource = db.vEducationForms.
                Select (educationFormSelect => new {
                        educationFormSelect.EmployeeSurname,
                        educationFormSelect.EmployeeName,
                        educationFormSelect.EducationLevel,
                        educationFormSelect.Degree,
                        educationFormSelect.DegreeShort,
                        educationFormSelect.GraduationDate
                }).ToList();
        }

        private void tbEducationSearch_TextChanged(object sender, EventArgs e)
        {
            dgvEducation.DataSource = db.vEducationForms.
                Where (educationform => educationform.EmployeeSurname.StartsWith(tbEducationSearch.Text)).
                Select (educationFormSelect => new {
                        educationFormSelect.EmployeeSurname,
                        educationFormSelect.EmployeeName,
                        educationFormSelect.EducationLevel,
                        educationFormSelect.Degree,
                        educationFormSelect.DegreeShort,
                        educationFormSelect.GraduationDate
                }).ToList();
        }
    }
}
