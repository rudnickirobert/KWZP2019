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
    public partial class AddAbsenceType : Form
    {
        RoofingCompanyEntities db;

        public AddAbsenceType(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbAbsenceReason.Text.Trim() == "" || tbMultiplier.Text.Trim() == "")
            {
                MessageBox.Show("Pola musza być wypełnione");
            }
            else
            {
                bool numbersInTbMultipier = float.TryParse(tbMultiplier.Text.Trim(), out float number);
                if (numbersInTbMultipier == false)
                {
                    MessageBox.Show("W polu współczynnik nieobecności mogą znajdować się tylko cyfry");
                }
                else
                {
                    if (float.Parse(tbMultiplier.Text.Trim()) < 0 || float.Parse(tbMultiplier.Text.Trim()) > 1)
                    {
                        MessageBox.Show("Współczynnik może przyjmować wartości od 0 do 1");
                    }
                    else
                    {
                        AbsenceType newabsenceType = new AbsenceType();
                        newabsenceType.AbscenceReason = tbAbsenceReason.Text.Trim();
                        newabsenceType.Multiplier = float.Parse(tbMultiplier.Text.Trim());
                        db.AbsenceTypes.Add(newabsenceType);
                        db.SaveChanges();
                        MessageBox.Show("Prawidłowo dodano typ nieobecności");
                        clear();
                        dgvAbsencesTypes.DataSource = db.AbsenceTypes.ToList();
                        dgvAbsencesTypes.Columns[0].Visible = false;
                    }
                }
            }
        }

        void clear()
        {
            tbAbsenceReason.Text = "";
            tbMultiplier.Text = "";
        }

        private void AddAbsenceType_Load(object sender, EventArgs e)
        {
            clear();

            dgvAbsencesTypes.DataSource = db.AbsenceTypes.ToList();
            dgvAbsencesTypes.Columns[0].Visible = false;
            dgvAbsencesTypes.Columns[1].HeaderText = "Powód nieobecności";
            dgvAbsencesTypes.Columns[2].HeaderText = "Współczynnik mnożenia pensji";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AbsenceType absenceTypeToRemove = new AbsenceType { IdAbsenceType = int.Parse(dgvAbsencesTypes.SelectedRows[0].Cells[0].Value.ToString()) };
            db.AbsenceTypes.Attach(absenceTypeToRemove);
            db.AbsenceTypes.Remove(absenceTypeToRemove);
            db.SaveChanges();
            //dgvAbsencesTypes.DataSource = db.AbsenceTypes.ToList();
            //dgvAbsencesTypes.Columns[0].Visible = false;
            MessageBox.Show("Rekord został usunięty");
        }
    }
}
