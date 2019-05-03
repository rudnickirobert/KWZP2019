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
    public partial class Contracts : Form
    {
        RoofingCompanyEntities db;
        public Contracts(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db; 
        }

        private void Contracts_Load(object sender, EventArgs e)
        {
            dgvContracts.DataSource = db.vContracts.
                Select (contractsSelect => new {
                        contractsSelect.EmployeeSurname,
                        contractsSelect.EmployeeName,
                        contractsSelect.Workplace,
                        contractsSelect.StartDate,
                        contractsSelect.EndDate,
                        contractsSelect.Salary,
                        contractsSelect.WorkplaceTrainingDate,
                        contractsSelect.HealTestDate
                }).ToList();
        }

        private void tbSearchContract_TextChanged(object sender, EventArgs e)
        {
            dgvContracts.DataSource = db.vContracts.
                Where (contracts => contracts.EmployeeSurname.StartsWith(tbSearchContract.Text)).
                Select (contractsSelect => new {
                        contractsSelect.EmployeeSurname,
                        contractsSelect.EmployeeName,
                        contractsSelect.Workplace,
                        contractsSelect.StartDate,
                        contractsSelect.EndDate,
                        contractsSelect.Salary,
                        contractsSelect.WorkplaceTrainingDate,
                        contractsSelect.HealTestDate
                }).ToList();
        }
    }
}
