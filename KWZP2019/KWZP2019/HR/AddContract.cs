﻿using System;
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
    public partial class AddContract : Form
    {
        RoofingCompanyEntities db;

        public AddContract(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbEmployeeList.SelectedIndex == -1 || cbPosition.SelectedIndex == -1 ||
                tbSalary.Text.Trim() == "" || cbDepartmentList.SelectedIndex == -1)
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione");
            }
            else
            {
                if (dtpStartDate.Value > dtpEndDate.Value)
                {
                    MessageBox.Show("Data końca umowy nie może być wcześniejsza niż data początku");
                }
                else
                {
                    bool condition1 = long.TryParse(tbSalary.Text.Trim(), out long number);
                    if (condition1 == false)
                    {
                        MessageBox.Show("W polu Salaris mogą znajdować się tylko cyfry");
                    }
                    else
                    {
                        Allocation newAllocation = new Allocation();
                        newAllocation.IdEmployee = cbEmployeeList.SelectedIndex + 1;
                        newAllocation.IdDepartment = cbDepartmentList.SelectedIndex + 1;
                        newAllocation.StartDate = dtpStartDate.Value;
                        newAllocation.EndDate = dtpEndDate.Value;
                        db.Allocations.Add(newAllocation);
                        Contract newContract = new Contract();
                        newContract.IdEmployee = cbEmployeeList.SelectedIndex + 1;
                        newContract.IdPosition = cbPosition.SelectedIndex + 1;
                        newContract.StartDate = dtpStartDate.Value;
                        newContract.EndDate = dtpEndDate.Value;
                        newContract.Salary = long.Parse(tbSalary.Text.Trim());
                        newContract.WorkplaceTrainingDate = dtpWorkplaceTrainingDate.Value;
                        db.Contracts.Add(newContract);
                        db.SaveChanges();
                        clear();
                    }
                }
            }
        }

        void clear ()
        {
            cbEmployeeList.SelectedIndex = -1;
            cbPosition.SelectedIndex = -1;
            dtpEndDate.Value = DateTime.Today;
            dtpStartDate.Value = DateTime.Today;
            dtpWorkplaceTrainingDate.Value = DateTime.Today;
            tbSalary.Text = "";

            cbDepartmentList.SelectedIndex = -1;
        }

        private void AddContract_Load(object sender, EventArgs e)
        {
            clear();

            List<vEmployeeList> employeeList = db.vEmployeeLists.ToList();
            foreach (vEmployeeList employee in employeeList)
            {
                cbEmployeeList.Items.Add(String.Format("{0, -10} {1, 0}",
                    employee.EmployeeSurname, employee.EmployeeName));
            }

            List<vPosition> positionList = db.vPositions.ToList();
            foreach (vPosition positionL in positionList)
            {
                cbPosition.Items.Add(positionL.Workplace);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
