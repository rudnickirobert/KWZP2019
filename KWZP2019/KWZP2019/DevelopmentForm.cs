using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class DevelopmentForm : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private QualityControl qualityControlForm;
        private int selectedEmployee;
        private byte[] newPatternImage;

        public DevelopmentForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            InitializeComponent();
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.qualityControlForm.Close();
            this.Close();
        }

        private void DevelopmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
            this.qualityControlForm.Close();
        }

        private void DevelopmentForm_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
            picboxNewPattern.Image = picboxNewPattern.InitialImage;
        }

        private void textBoxEmployeeId_TextChanged(object sender, EventArgs e)
        {
            if(textBoxEmployeeId.Text != "")
            {
                int employeeQuantity = db.Employees.Count();
                int IdEmpTextBoxValue = int.Parse(textBoxEmployeeId.Text);
                if(employeeQuantity >= IdEmpTextBoxValue)
                {
                    Employee employee = db.Employees.First(emp => emp.IdEmployee.ToString() == textBoxEmployeeId.Text);
                    textBoxName.Text = $"{employee.EmployeeName}";
                    textBoxSurname.Text = $"{employee.EmployeeSurname}";
                    selectedEmployee = Convert.ToInt32(textBoxEmployeeId.Text);
                }
                else
                {
                    MessageBox.Show("Pracownik o tym numerze nie istnieje", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (textBoxDescription.Text == "" || textBoxEmployeeId.Text == "" || dateTimePicker.Text == "" || newPatternImage == null )
            {
                MessageBox.Show("Nie można zatwierdzić wyników!\nUzupełnij wszystkie pola!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FEMAnalysis fEMAnalysis = new FEMAnalysis();

                fEMAnalysis.AnalysisResults = textBoxDescription.Text;
                fEMAnalysis.IdEmployee = int.Parse(textBoxEmployeeId.Text);
                fEMAnalysis.NewPattern = newPatternImage;
                fEMAnalysis.AnalysisDate = dateTimePicker.Value;

                db.FEMAnalysis.Add(fEMAnalysis);
                db.SaveChanges();

                textBoxDescription.Clear();
                textBoxEmployeeId.Clear();
                dateTimePicker.Value = DateTime.UtcNow;
                dateTimePicker.ResetText();
                picboxNewPattern.Image = picboxNewPattern.InitialImage;
            }
        }

        private void btnImportPicture_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if(fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = fileDialog.FileName;
                    picboxNewPattern.ImageLocation = imgLocation;
                    FileStream fileStream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    newPatternImage = binaryReader.ReadBytes((int)fileStream.Length);
                }

            }
            catch
            {
                MessageBox.Show("Nie można zatwierdzić tego pliku!\nDokonaj właściwego wyboru", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevelopmentHistory_Click(object sender, EventArgs e)
        {
            DevelopmentHistoryForm developmentHistoryForm = new DevelopmentHistoryForm(db, startForm, this);
            this.Hide();
            developmentHistoryForm.Show();
        }
    }
}
