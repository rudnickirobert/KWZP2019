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
        private void PopulateDataGridView()
        {
            this.dgvEmployeeMaintenanceCalendar.AutoGenerateColumns = false;
            using (RoofingCompanyEntities db = new RoofingCompanyEntities())
            {
                this.dgvEmployeeMaintenanceCalendar.DataSource = this.db.vMaintenanceEmployeesCalendar.ToList<vMaintenanceEmployeesCalendar>();
            }
        }

        private void Clear()
        {
            this.txtSearch.Text = String.Empty;
        }

        private void MaintenanceEmployeeCalendarForm_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }
    }
}
