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
    public partial class PartsForm : Form
    {
        RoofingCompanyEntities db;
        MaintenanceManagement maintenanceManagementForm;
        private bool hidden;
        private bool updatePanel;
        private bool deletePanel;
        private int selectedRow;
        private string selectedName;
        private bool selectedEditPart;


        public PartsForm(RoofingCompanyEntities db, MaintenanceManagement maintenanceManagementForm)
        {
            this.db = db;
            this.maintenanceManagementForm = maintenanceManagementForm;
            hidden = true;
            updatePanel = false;
            deletePanel = false;
            InitializeComponent();
            panelPartsList.Show();
            panelSearch.Hide();
            panelAdd.Hide();
            panelDelete.Hide();
            panelUpdate.Hide();
        }


        // ==========================================


        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.maintenanceManagementForm.Show();
            this.Hide();
        }

        // ==========================================

        private void pictureMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        // ==========================================


        // ==========================================

        public void ReloadData()
        {
            dataPartsView.DataSource = db.vPartsViews.ToList();
        }

        // ==========================================

        private void PartsForm_Load(object sender, EventArgs e)
        {
            ReloadData();

            List<PartType> partTypes = db.PartTypes.ToList();
            Dictionary<int, string> partTypesSource = new Dictionary<int, string>();
            foreach (PartType partType in partTypes)
            {
                partTypesSource.Add(partType.IdPartType, partType.PartType1);
            }

            cbPartType.DataSource = new BindingSource(partTypesSource, null);
            cbPartType.DisplayMember = "Value";
            cbPartType.ValueMember = "Key";


            List<Unit> units = db.Units.ToList();
            Dictionary<int, string> unitsSource = new Dictionary<int, string>();
            foreach (Unit unit in units)
            {
                unitsSource.Add(unit.IdUnit, unit.UnitName);
            }

            cbUnit.DataSource = new BindingSource(unitsSource, null);
            cbUnit.DisplayMember = "Value";
            cbUnit.ValueMember = "Key";

        }

        // ==========================================

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ReloadData();
            panelAdd.Hide();
            panelDelete.Hide();
            panelUpdate.Hide();
            panelSearch.Show();
            updatePanel = false;
            deletePanel = false;
        }

        // ==========================================

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            ReloadData();
            dataPartsView.DataSource = db.vPartsViews.ToList();
            panelSearch.Hide();
            panelDelete.Hide();
            panelUpdate.Hide();
            panelAdd.Show();
            clear_AddPart();
            updatePanel = false;
            deletePanel = false;
        }

        // ==========================================

        private void btnUpdatePart_Click(object sender, EventArgs e)
        {
            ReloadData();
            panelSearch.Hide();
            panelAdd.Hide();
            panelDelete.Hide();
            panelUpdate.Show();
            clear_UpdatePart();
            updatePanel = true;
            deletePanel = false;
            selectedEditPart = false;
        }

        // ==========================================

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            panelSearch.Hide();
            panelAdd.Hide();
            panelDelete.Show();
            panelUpdate.Hide();
            clear_DelPart();
            updatePanel = false;
            deletePanel = true;
        }

        // ==========================================

        private void btnPanelSearchReset_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        // ==========================================

        private void btnPanelSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "")
            {
                MessageBox.Show("Pole wyszukiwania nie może być puste!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            if (cbSearch.Text == "Nazwa części")
            {
                dataPartsView.DataSource = db.vPartsViews
                .Where(selectedpart => selectedpart.PartName.Contains(txtBoxSearch.Text)).ToList();

                if (dataPartsView.RowCount == 0)
                {
                    MessageBox.Show("Nie znaleziono pasujących wyników", "Wynik wyszukiwania",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ReloadData();
                }
            }

            else if (cbSearch.Text == "Typ części")
            {
                dataPartsView.DataSource = db.vPartsViews
                .Where(selectedpart => selectedpart.partType.Contains(txtBoxSearch.Text)).ToList();

                if (dataPartsView.RowCount == 0)
                {
                    MessageBox.Show("Nie znaleziono pasujących wyników", "Wynik wyszukiwania",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ReloadData();
                }
            }

            else if (cbSearch.Text == "Producent")
            {
                dataPartsView.DataSource = db.vPartsViews
                .Where(selectedpart => selectedpart.Producer.Contains(txtBoxSearch.Text)).ToList();

                if (dataPartsView.RowCount == 0)
                {
                    MessageBox.Show("Nie znaleziono pasujących wyników", "Wynik wyszukiwania",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ReloadData();
                }
            }

            else
            {
                MessageBox.Show("Pole 'Wyszukaj wg' nie może być puste!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==========================================

        private void dataPartsView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex==6)
            {
                int val = Convert.ToInt32(dataPartsView.Rows[e.RowIndex].Cells[4].Value);

                if (val < 5)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.Red;
                    e.CellStyle.SelectionForeColor = Color.Red;
                }

                else if (val >= 5 && val <= 10)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Yellow;
                    e.CellStyle.SelectionBackColor = Color.Yellow;
                    e.CellStyle.SelectionForeColor = Color.Yellow;
                }

                else
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.Green;
                    e.CellStyle.SelectionBackColor = Color.Green;
                    e.CellStyle.SelectionForeColor = Color.Green;
                }
            }
        }

        // ==========================================

        private void clear_AddPart()
        {
            tbName.Text = cbPartType.Text = tbProducer.Text = tbCatalogNr.Text = tbAmount.Text = cbUnit.Text = "";
        }

        // ==========================================

        private void clear_DelPart()
        {
            tbDeleteName.Text = tbDeleteType.Text = tbDeleteProducer.Text =
                tbDeleteCatNr.Text = tbDeleteAmount.Text = tbDeleteUnit.Text = "";
        }

        private void clear_UpdatePart()
        {
            tbUpdateName.Text = tbUpdateType.Text = tbUpdateProd.Text =
                tbUpdateCatalNr.Text = tbUpdateAmount.Text = tbUpdateUnit.Text = "";
            selectedEditPart = false;
            tbUpdateName.Enabled = false;
            tbUpdateProd.Enabled = false;
            tbUpdateCatalNr.Enabled = false;
        }

        // ==========================================

        private void buttonAddPart_Clear_Click(object sender, EventArgs e)
        {
            clear_AddPart();
        }

        // ==========================================

        private void buttonAddPart_Add_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataPartsView.Rows)
            {
                if (Convert.ToString(row.Cells[0].Value) == tbName.Text)
                {
                    MessageBox.Show("Podana nazwa części już istnieje!\nUpewnij się, że nazwa została wpisana prawidłowo!",
                        "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbName.BackColor = Color.Red;
                    return;
                }

                else if (Convert.ToString(row.Cells[3].Value) == tbCatalogNr.Text)
                {
                    MessageBox.Show("Podany numer katalogowy jest przypisany do istniejącej części!\nUpewnij się, że podany numer została wpisana prawidłowo!", 
                        "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbCatalogNr.BackColor = Color.Red;
                    return;
                }
            }

            if (tbName.Text == "" || cbPartType.Text == "" || tbProducer.Text == "" || tbCatalogNr.Text == ""
                        || tbAmount.Text == "" || cbUnit.Text == "")
            {
                MessageBox.Show("Nie można dodać nowej części!\nUzupełnij wszystkie pola!", 
                    "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult result = MessageBox.Show("Czy zatwierdzasz wprowadzoną część?", "Dodawanie części",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Part part = new Part();
                    part.PartName = tbName.Text.Trim();
                    part.IdPartType = int.Parse(cbPartType.SelectedValue.ToString());
                    part.Producer = tbProducer.Text.Trim();
                    part.CatalogPartNr = int.Parse(tbCatalogNr.Text.ToString());
                    part.QuantityWarehouse = int.Parse(tbAmount.Text.ToString());
                    part.IdUnit = int.Parse(cbUnit.SelectedValue.ToString());

                    db.Parts.Add(part);
                    db.SaveChanges();
                    ReloadData();

                    clear_AddPart();
                    MessageBox.Show("Dodano prawidłowo", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ==========================================

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            tbName.BackColor = Color.White;
        }

        // ==========================================

        private void tbCatalogNr_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCatalogNr.Text, "[^0-9]"))
            {
                MessageBox.Show("Proszę wprowadzić wartości numeryczne!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCatalogNr.Text = tbCatalogNr.Text.Remove(tbCatalogNr.Text.Length - 1);
                tbCatalogNr.BackColor = Color.Red;
            }
            
            else
            {
                tbCatalogNr.BackColor = Color.White;
            }
        }

        // ==========================================

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Proszę wprowadzić wartości numeryczne!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbAmount.Text = tbAmount.Text.Remove(tbAmount.Text.Length - 1);
                tbAmount.BackColor = Color.Red;
            }

            else
            {
                tbAmount.BackColor = Color.White;
            }
        }

        // ==========================================

        private void dataPartsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataPartsView.Rows[selectedRow];

                if (updatePanel)
                {
                    selectedName = row.Cells[0].Value.ToString();
                    tbUpdateName.Text = row.Cells[0].Value.ToString();
                    tbUpdateType.Text = row.Cells[1].Value.ToString();
                    tbUpdateProd.Text = row.Cells[2].Value.ToString();
                    tbUpdateCatalNr.Text = row.Cells[3].Value.ToString();
                    tbUpdateAmount.Text = row.Cells[4].Value.ToString();
                    tbUpdateUnit.Text = row.Cells[5].Value.ToString();
                    selectedEditPart = true;
                    tbUpdateName.Enabled = true;
                    tbUpdateProd.Enabled = true;
                    tbUpdateCatalNr.Enabled = true;
                }

                else if (deletePanel)
                {
                    selectedName = row.Cells[0].Value.ToString();
                    tbDeleteName.Text = row.Cells[0].Value.ToString();
                    tbDeleteType.Text = row.Cells[1].Value.ToString();
                    tbDeleteProducer.Text = row.Cells[2].Value.ToString();
                    tbDeleteCatNr.Text = row.Cells[3].Value.ToString();
                    tbDeleteAmount.Text = row.Cells[4].Value.ToString();
                    tbDeleteUnit.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        // ==========================================

        private void tbUpdateAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbUpdateAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Proszę wprowadzić wartości numeryczne!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUpdateAmount.Text = tbUpdateAmount.Text.Remove(tbUpdateAmount.Text.Length - 1);
                tbUpdateAmount.BackColor = Color.Red;
            }
            else
            {
                tbUpdateAmount.BackColor = Color.White;
            }
        }

        // ==========================================

        private void btnDeletePart_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbDeleteName.Text == "")
                    return;

                if (MessageBox.Show("Czy na pewno chcesz usunąć tę pozycję?", "Usuwanie części", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Part part = new Part();
                    part = db.Parts.Where(selectedpart => selectedpart.PartName == selectedName).First();
                    db.Parts.Remove(part);

                    db.SaveChanges();
                    ReloadData();
                    clear_DelPart();

                    MessageBox.Show("Usunięto prawidłowo","Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Wybrana część jest wykorzystywana i nie może zostać usunięta!", "Błąd", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear_DelPart();
            }
        }

        // ==========================================

        private void btnUpdatePart_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!selectedEditPart)
                    return;

                if (tbUpdateAmount.Text == "" || tbUpdateProd.Text == "" || tbUpdateCatalNr.Text == "")
                {
                    MessageBox.Show("Nie można edytować części!\nPola nie mogą być puste!", "Ostrzeżenie",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    DialogResult result = MessageBox.Show("Czy zatwierdzasz wprowadzone zmiany?", "Informacja",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Part part = new Part();
                        part = db.Parts.Where(selectedpart => selectedpart.PartName == selectedName).First();
                        part.PartName = tbUpdateName.Text.ToString();
                        part.Producer = tbUpdateProd.Text.ToString();
                        part.CatalogPartNr = int.Parse(tbUpdateCatalNr.Text.ToString());

                        db.SaveChanges();
                        ReloadData();
                        clear_UpdatePart();

                        MessageBox.Show("Edytowano prawidłowo", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Wybrana część jest wykorzystywana i nie można jej edytować!", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear_UpdatePart();
            }
        }

        // ==========================================

        private void tbUpdateCatalNr_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Proszę wprowadzić wartości numeryczne!", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUpdateAmount.Text = tbUpdateAmount.Text.Remove(tbUpdateAmount.Text.Length - 1);
                tbUpdateAmount.BackColor = Color.Red;
            }
       
            else
            {
                tbUpdateAmount.BackColor = Color.White;
            }
        }

        // ==========================================

        private void btnUpdatePart_Clear_Click(object sender, EventArgs e)
        {
            clear_UpdatePart();
        }

        // ==========================================

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            PartsRequest partsRequestForm = new PartsRequest(db, this);

            partsRequestForm.ShowDialog();
        }

        // ==========================================
    }
}
