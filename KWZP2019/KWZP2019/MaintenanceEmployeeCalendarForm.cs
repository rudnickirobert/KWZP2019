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
    public partial class MaintenanceEmployeeCalendarForm : Form
    {
        RoofingCompanyEntities db;
       
        public MaintenanceEmployeeCalendarForm(RoofingCompanyEntities db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void populateDataGridView()
        {
            this.dgvEmployeeMaintenanceCalendar.AutoGenerateColumns = false;
            this.dgvEmployeeMaintenanceCalendar.DataSource = this.db.vMaintenanceEmployeesCalendars.ToList<vMaintenanceEmployeesCalendar>();

        }
        private void clear()
        {
            this.txtSearch.Text = String.Empty;
        }

        private void MaintenanceEmployeeCalendarForm_Load(object sender, EventArgs e)
        {
            clear();
            populateDataGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String searchQuery = this.txtSearch.Text.Trim();
            this.dgvEmployeeMaintenanceCalendar.DataSource = this.db.vMaintenanceEmployeesCalendars
                .Where(employee => employee.EmployeeSurname.Contains(searchQuery)).ToList<vMaintenanceEmployeesCalendar>();
        }
    }
}
