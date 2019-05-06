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
                        contractsSelect.WorkplaceTrainingDate
                }).ToList();

            dgvContracts.Columns[0].HeaderText = "Nazwisko";
            dgvContracts.Columns[1].HeaderText = "Imię";
            dgvContracts.Columns[2].HeaderText = "Pozycja";
            dgvContracts.Columns[3].HeaderText = "Początek";
            dgvContracts.Columns[4].HeaderText = "Koniec";
            dgvContracts.Columns[5].HeaderText = "Pensja";
            dgvContracts.Columns[6].HeaderText = "Data szkolenia";

            dgvContracts.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvContracts.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvContracts.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvContracts.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvContracts.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvContracts.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvContracts.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void tbSearchContract_TextChanged(object sender, EventArgs e)
        {
            dgvContracts.DataSource = db.vContracts.
                Where (contracts => contracts.EmployeeSurname.StartsWith(tbSearchContract.Text)
                                 && contracts.EmployeeName.StartsWith(tbSearchContractName.Text)).
                Select (contractsSelect => new {
                        contractsSelect.EmployeeSurname,
                        contractsSelect.EmployeeName,
                        contractsSelect.Workplace,
                        contractsSelect.StartDate,
                        contractsSelect.EndDate,
                        contractsSelect.Salary,
                        contractsSelect.WorkplaceTrainingDate,
                }).ToList();
        }

        private void tbSearchContractName_TextChanged(object sender, EventArgs e)
        {
            dgvContracts.DataSource = db.vContracts.
                Where(contracts => contracts.EmployeeSurname.StartsWith(tbSearchContract.Text)
                                && contracts.EmployeeName.StartsWith(tbSearchContractName.Text)).
                Select(contractsSelect => new {
                    contractsSelect.EmployeeSurname,
                    contractsSelect.EmployeeName,
                    contractsSelect.Workplace,
                    contractsSelect.StartDate,
                    contractsSelect.EndDate,
                    contractsSelect.Salary,
                    contractsSelect.WorkplaceTrainingDate,
                }).ToList();
        }

        private void btnAddTraining_Click(object sender, EventArgs e)
        {
            AddContract addContract = new AddContract();
            addContract.Show();
        }
    }
}
