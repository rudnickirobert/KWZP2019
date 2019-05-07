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
        int id;
        public EmployeeDetails(RoofingCompanyEntities db, StartForm startForm, HR hr, int id)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
            this.id = id;
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            display();
        }

        void display()
        {
            dgvEmployeeDetails.DataSource = db.vEmployeeDetails.
                    Where (employeeWhere => employeeWhere.IdEmployee == id).
                    ToList();

            dgvEmployeeDetails.Columns[0].Visible = false;

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

            dgvAbsences.DataSource = db.vAbsences.
                Where(employeeAbsenceWhere => employeeAbsenceWhere.IdEmployee == id).
                OrderByDescending(absenceOrderBy => absenceOrderBy.Początek).
                ToList();

            dgvAbsences.Columns[0].Visible = false;

            dgvAbsences.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAbsences.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAbsences.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAbsences.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvAbsences.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTrainings.DataSource = db.vAddTrainings.
                Where(employeeTrainingWhere => employeeTrainingWhere.IdEmployee == id).
                ToList();

            dgvTrainings.Columns[0].Visible = false;

            dgvTrainings.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTrainings.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTrainings.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTrainings.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTrainings.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvTrainings.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
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
