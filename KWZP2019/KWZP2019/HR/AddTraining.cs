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
    public partial class AddTraining : Form
    {
        RoofingCompanyEntities db;

        public AddTraining(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void AddTraining_Load(object sender, EventArgs e)
        {
            dgvTrainings.DataSource = db.vAddTraining.
                Select(addtrainigSelect => new {
                       addtrainigSelect.EmployeeSurname,
                       addtrainigSelect.EmployeeName,
                       addtrainigSelect.TrainingName,
                       addtrainigSelect.TrainingStartDate,
                       addtrainigSelect.TrainingEndDate,
                       addtrainigSelect.TrainingPrice
                }).ToList();
        }

        private void tbSearchTraining_TextChanged(object sender, EventArgs e)
        {
            dgvTrainings.DataSource = db.vAddTraining.
                Where(addtraining => addtraining.EmployeeName.StartsWith(tbSearchTrainingName.Text)
                                  && addtraining.EmployeeSurname.StartsWith(tbSearchTraining.Text)).
                Select(addtrainigSelect => new {
                       addtrainigSelect.EmployeeSurname,
                       addtrainigSelect.EmployeeName,
                       addtrainigSelect.TrainingName,
                       addtrainigSelect.TrainingStartDate,
                       addtrainigSelect.TrainingEndDate,
                       addtrainigSelect.TrainingPrice
                }).ToList();
        }

        private void tbSearchTrainingName_TextChanged(object sender, EventArgs e)
        {
            dgvTrainings.DataSource = db.vAddTraining.
                Where(addtraining => addtraining.EmployeeName.StartsWith(tbSearchTrainingName.Text)
                                  && addtraining.EmployeeSurname.StartsWith(tbSearchTraining.Text)).
                Select(addtrainigSelect => new {
                       addtrainigSelect.EmployeeSurname,
                       addtrainigSelect.EmployeeName,
                       addtrainigSelect.TrainingName,
                       addtrainigSelect.TrainingStartDate,
                       addtrainigSelect.TrainingEndDate,
                       addtrainigSelect.TrainingPrice
                }).ToList();
        }
    }
}
