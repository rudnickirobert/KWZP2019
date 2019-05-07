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
        StartForm startForm;
        HR hr;
        public Contracts(RoofingCompanyEntities db, StartForm startForm, HR hr)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.hr = hr;
        }

        private void Contracts_Load(object sender, EventArgs e)
        {
            display();
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
                        contractsSelect.IdContract
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
                    contractsSelect.IdContract
                }).ToList();
        }

        private void btnAddTraining_Click(object sender, EventArgs e)
        {
            AddContract addContract = new AddContract(db);
            addContract.Show();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Contract ContractsToRemove = new Contract { IdContract = int.Parse(dgvContracts.SelectedRows[0].Cells[7].Value.ToString()) };
            db.Contracts.Attach(ContractsToRemove);
            db.Contracts.Remove(ContractsToRemove);
            db.SaveChanges();
            if (tbSearchContract.Text.Trim() == "" || tbSearchContractName.Text.Trim() == "")
            {
                display();
            }
            else
            {
                tbSearchContract_TextChanged(sender, e);
            }
            MessageBox.Show("Rekord został usunięty");
        }
        
        void display()
        {
            dgvContracts.DataSource = db.vContracts.
                Select(contractsSelect => new {
                    contractsSelect.EmployeeSurname,
                    contractsSelect.EmployeeName,
                    contractsSelect.Workplace,
                    contractsSelect.StartDate,
                    contractsSelect.EndDate,
                    contractsSelect.Salary,
                    contractsSelect.WorkplaceTrainingDate,
                    contractsSelect.IdContract
                }).ToList();

            dgvContracts.Columns[7].Visible = false;

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
    }
}
