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
    public partial class PartsRequest_Add : Form
    {
        RoofingCompanyEntities db;
        PartsRequest partsRequestForm;

        public PartsRequest_Add(RoofingCompanyEntities db, PartsRequest partsRequestForm)
        {
            this.db = db;
            this.partsRequestForm = partsRequestForm;
            InitializeComponent();
        }

        // ==========================================

        private void PartsRequest_Add_Load(object sender, EventArgs e)
        {
            dtpRequestAdd_Date.Format = DateTimePickerFormat.Custom;
            dtpRequestAdd_Date.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            List<Part> partNames = db.Parts.ToList();
            Dictionary<int, string> partNamesSource = new Dictionary<int, string>();
            foreach (Part partName in partNames)
            {
                partNamesSource.Add(partName.IdPart, partName.PartName);
            }

            cbRequestAdd_Name.DataSource = new BindingSource(partNamesSource, null);
            cbRequestAdd_Name.DisplayMember = "Value";
            cbRequestAdd_Name.ValueMember = "Key";

            clear_AddRequest();
        }

        // ==========================================

        private void clear_AddRequest()
        {
            tbRequestAdd_Amount.Text = cbRequestAdd_Name.Text = "";
        }

        // ==========================================

        private void btnRequestAdd_Click(object sender, EventArgs e)
        {
            if (cbRequestAdd_Name.SelectedValue == null && cbRequestAdd_Name.Text != "")
            {
                MessageBox.Show("Podana część nie istnieje!\nDodaj nową część w 'UR-Zarządzanie częściami', aby kontynuować!",
                    "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbRequestAdd_Amount.Text == "" || cbRequestAdd_Name.Text == "")
            {
                MessageBox.Show("Nie można dodać nowego zapotrzebowania!\nUzupełnij wszystkie pola!",
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult result = MessageBox.Show("Czy zatwierdzasz wprowadzone zapotrzebowanie?", "Nowe zapotrzebowanie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    PartRequest partrequest = new PartRequest();
                    partrequest.IdPart = int.Parse(cbRequestAdd_Name.SelectedValue.ToString());
                    partrequest.RequestDate = dtpRequestAdd_Date.Value;
                    partrequest.Quantity = int.Parse(tbRequestAdd_Amount.Text.ToString());
                    partrequest.StatusPart = 0;

                    db.PartRequests.Add(partrequest);
                    db.SaveChanges();

                    partsRequestForm.ReloadData();

                    this.Close();
                    MessageBox.Show("Dodano prawidłowo", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
            

        // ==========================================

        private void tbRequestAdd_Amount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbRequestAdd_Amount.Text, "[^0-9]"))
            {
                MessageBox.Show("Proszę wprowadzić wartości numeryczne!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRequestAdd_Amount.Text = tbRequestAdd_Amount.Text.Remove(tbRequestAdd_Amount.Text.Length - 1);
                tbRequestAdd_Amount.BackColor = Color.Red;
            }

            else
            {
                tbRequestAdd_Amount.BackColor = Color.White;
            }
        }

        // ==========================================
    }
}
