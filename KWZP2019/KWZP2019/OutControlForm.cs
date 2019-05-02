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
    public partial class OutControlForm : Form
    {
        private RoofingCompanyEntities db;
        private StartForm startForm;
        private QualityControl qualityControlForm;
        public Dictionary<int, String> processStatus = new Dictionary<int, string>();
        public enum OutControlStatus  { Oczekuje_na_kontrolę, W_takcie_realizacji, Proces_kontroli_zakończony};
        public int procesNumber;

        public OutControlForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            InitializeComponent();
            ComponentsDataInitialize();
        }

        private void ComponentsDataInitialize()
        {
            cbProcessNumber.DataSource = db.ProductionProcesses.ToList();
            cbProcessNumber.DisplayMember = "IdProces";
            cbProcessNumber.ValueMember = "IdProces";
            cbProcessNumber.SelectedIndex = -1;
            cbProcessNumber.Text = "Proszę wybrać numer procesu";
            cbControlerId.DataSource = db.Employees.ToList();
            cbControlerId.ValueMember = "IdEmployee";
            btnSMeasures.Visible = false;
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void OutControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }

        private void btnSMeasures_Click(object sender, EventArgs e)
        {
            if(processStatus[procesNumber].Equals(OutControlStatus.Oczekuje_na_kontrolę.ToString()))
            {
                OutControl outControl = new OutControl();
                outControl.IdEmployee = Int16.Parse(cbControlerId.SelectedValue.ToString());
                outControl.IdProcess = procesNumber;
                outControl.LenghtAcceptableDeviation = Int16.Parse(txtbAcceptableLenghtDeviation.Text);
                outControl.WidthAcceptableDeviation = Int16.Parse(txtbAcceptableWidthDeviation.Text);
                outControl.StartControlDate = DateTime.Now;
                outControl.EndControlDate = null;
                db.OutControls.Add(outControl);
                db.SaveChanges();
            }

            using (OutMeasures outControlForm = new OutMeasures(db, startForm, qualityControlForm, this))
            {
                outControlForm.ShowDialog();
                refreshingData(procesNumber);
            }
        }

        private void cbControlerId_Format(object sender, ListControlConvertEventArgs e)
        {
            int id = ((Employee)e.ListItem).IdEmployee;
            string lastname = ((Employee)e.ListItem).EmployeeName;
            string firstname = ((Employee)e.ListItem).EmployeeSurname;
            e.Value = lastname + " " + firstname + " | NumerID: " + id;
        }

        private void processStatusDictionaryRefresh()
        {
            foreach (ProductionProcess process in db.ProductionProcesses.ToList())
            {
                processStatus[process.IdProces] = OutControlStatus.Oczekuje_na_kontrolę.ToString();
            }
            foreach (OutControl process in db.OutControls.ToList())
            {
                processStatus[process.IdProcess] = OutControlStatus.W_takcie_realizacji.ToString();
            }
            foreach (vSuccesfullyProcess process in db.vSuccesfullyProcesses.ToList())
            {
                processStatus[process.IdProcess] = OutControlStatus.Proces_kontroli_zakończony.ToString();
            }
        }

        public void handleTextBoxes(int processNumber, bool existing)
        {
            if (existing)
            {
                OutControl outControl = db.OutControls.First(e => e.IdProcess == processNumber);
                txtbAcceptableWidthDeviation.Text = outControl.WidthAcceptableDeviation.ToString();
                txtbAcceptableLenghtDeviation.Text = outControl.LenghtAcceptableDeviation.ToString();
                txtbStartDate.Text = outControl.StartControlDate.ToString();
                txtbEndDate.Text = outControl.EndControlDate.ToString();
                
            }
            else
            {
                txtbAcceptableWidthDeviation.Text = null;
                txtbAcceptableLenghtDeviation.Text = null;
                txtbStartDate.Text = null;
                txtbEndDate.Text = null;
            }
            txtbAcceptableWidthDeviation.ReadOnly = existing;
            txtbAcceptableLenghtDeviation.ReadOnly = existing;
        }

        private void refreshingData(int processNumber)
        {
            if (cbProcessNumber.SelectedIndex != -1)
            {
                processStatusDictionaryRefresh();
                procesNumber = Int16.Parse(cbProcessNumber.SelectedValue.ToString());
                txtbOutControlStatus.Text = processStatus[procesNumber].ToString().Replace('_', ' ');
                txtbToProduceNumber.Text = db.vTechnicalProductDataPerProcesses.First(i => i.IdProcess == procesNumber).Quantity.ToString();
                switch (txtbOutControlStatus.Text)
                {
                    case "Oczekuje na kontrolę":
                        {
                            txtbOutControlStatus.BackColor = Color.Yellow;
                            btnSMeasures.Visible = true;
                            handleTextBoxes(procesNumber, false);
                            break;
                        }
                    case "W takcie realizacji":
                        {
                            txtbOutControlStatus.BackColor = Color.YellowGreen;
                            btnSMeasures.Visible = true;
                            handleTextBoxes(procesNumber, true);
                            break;
                        }
                    case "Proces kontroli zakończony":
                        {
                            btnSMeasures.Visible = false;
                            handleTextBoxes(procesNumber, true);
                            txtbOutControlStatus.BackColor = Color.Green;
                            break;
                        }
                }
            }
        }
       

        private void cbProcessNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refreshingData(Int16.Parse(cbProcessNumber.SelectedValue.ToString()));
        }
    }
}
