﻿using System;
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
                Where (contracts => contracts.Nazwisko.StartsWith(tbSearchContract.Text)
                                 && contracts.Imię.StartsWith(tbSearchContractName.Text)).
                OrderByDescending(ContractsOrderBy => ContractsOrderBy.Początek).
                ToList();
        }

        private void tbSearchContractName_TextChanged(object sender, EventArgs e)
        {
            dgvContracts.DataSource = db.vContracts.
                Where(contracts => contracts.Nazwisko.StartsWith(tbSearchContract.Text)
                                && contracts.Imię.StartsWith(tbSearchContractName.Text)).
                OrderByDescending(ContractsOrderBy => ContractsOrderBy.Początek).
                ToList();
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
            Contract contractsToRemove = new Contract { IdContract = int.Parse(dgvContracts.SelectedRows[0].Cells[0].Value.ToString()) };
            db.Contracts.Attach(contractsToRemove);
            db.Contracts.Remove(contractsToRemove);
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
                OrderByDescending(ContractsOrderBy => ContractsOrderBy.Początek).
                ToList();

            dgvContracts.Columns[0].Visible = false;

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
