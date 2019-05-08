using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class OshTrainingNewEmployeeForm : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private OshTrainingForm oshTrainingForm;
        private Employee employee;


        public OshTrainingNewEmployeeForm(RoofingCompanyEntities db, StartForm startForm, OshTrainingForm oshTrainingForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.oshTrainingForm = oshTrainingForm;
            InitializeComponent();
        }

        private void OshTrainingNewEmployeeForm_Load(object sender, EventArgs e)
        {
            dateTimePickerNewTraining.Value = DateTime.Now;
            txtBoxPesel.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.oshTrainingForm.Show();
            this.Hide();
        }

        private void btnAddTraining_Click(object sender, EventArgs e)
        {
            if (txtBoxPesel.Text == "")
            {
                MessageBox.Show("Wpisz nr PESEL nowego pracownika!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Employee employee = db.Employees
                    .FirstOrDefault(check => check.PESEL == txtBoxPesel.Text);
                if (employee == null)
                {
                    MessageBox.Show("Pracownik o takim nr PESEL nie istnieje!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int idEmployee = employee.IdEmployee;
                    SafetyTraining safetyTraining = db.SafetyTrainings
                        .FirstOrDefault(check => check.IdEmployee == idEmployee);
                    if (safetyTraining != null)
                    {
                        MessageBox.Show("Pracownik o takim nr PESEL nie jest nowym pracownikiem!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SafetyTraining newSafetyTraining = new SafetyTraining();
                        newSafetyTraining.IdEmployee = idEmployee;
                        newSafetyTraining.TrainingDate = dateTimePickerNewTraining.Value;
                        db.SafetyTrainings.Add(newSafetyTraining);
                        MessageBox.Show("Pomyślnie dodano szkolenie dla pracownika!", "Wiadomość", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.SaveChanges();
                        txtBoxPesel.Text = " ";
                    }
                }
            }
        }
    }
}
