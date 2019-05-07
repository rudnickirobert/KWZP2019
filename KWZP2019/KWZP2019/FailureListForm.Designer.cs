namespace KWZP2019
{
    partial class FailureListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FailureListForm));
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.comEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.comMachine = new System.Windows.Forms.ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblFailures = new System.Windows.Forms.Label();
            this.lblNewFailures = new System.Windows.Forms.Label();
            this.btnNewMaintenance = new System.Windows.Forms.Button();
            this.dgvFailures = new System.Windows.Forms.DataGridView();
            this.dgvNewFailures = new System.Windows.Forms.DataGridView();
            this.IdFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFailures)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.Location = new System.Drawing.Point(900, 335);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(75, 23);
            this.btnFilterDate.TabIndex = 76;
            this.btnFilterDate.Text = "Filtruj";
            this.btnFilterDate.UseVisualStyleBackColor = true;
            // 
            // comEmployee
            // 
            this.comEmployee.FormattingEnabled = true;
            this.comEmployee.Location = new System.Drawing.Point(675, 459);
            this.comEmployee.Name = "comEmployee";
            this.comEmployee.Size = new System.Drawing.Size(200, 21);
            this.comEmployee.TabIndex = 75;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(540, 462);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(60, 13);
            this.lblEmployee.TabIndex = 74;
            this.lblEmployee.Text = "Pracownik:";
            // 
            // comMachine
            // 
            this.comMachine.FormattingEnabled = true;
            this.comMachine.Location = new System.Drawing.Point(675, 413);
            this.comMachine.Name = "comMachine";
            this.comMachine.Size = new System.Drawing.Size(200, 21);
            this.comMachine.TabIndex = 73;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(540, 416);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(52, 13);
            this.lblMachine.TabIndex = 72;
            this.lblMachine.Text = "Maszyna:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Location = new System.Drawing.Point(675, 361);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTo.TabIndex = 70;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(540, 368);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(48, 13);
            this.lblDateTo.TabIndex = 68;
            this.lblDateTo.Text = "Data do:";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Location = new System.Drawing.Point(675, 309);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFrom.TabIndex = 71;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(540, 316);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(48, 13);
            this.lblDateFrom.TabIndex = 69;
            this.lblDateFrom.Text = "Data od:";
            // 
            // lblFailures
            // 
            this.lblFailures.AutoSize = true;
            this.lblFailures.Location = new System.Drawing.Point(19, 283);
            this.lblFailures.Name = "lblFailures";
            this.lblFailures.Size = new System.Drawing.Size(534, 13);
            this.lblFailures.TabIndex = 67;
            this.lblFailures.Text = "Tu awarie które czekają na naprawę (EndDatePlan<Data.dziś); Awarie naprawione będ" +
    "ą na podstawie realizacji";
            // 
            // lblNewFailures
            // 
            this.lblNewFailures.AutoSize = true;
            this.lblNewFailures.Location = new System.Drawing.Point(19, 21);
            this.lblNewFailures.Name = "lblNewFailures";
            this.lblNewFailures.Size = new System.Drawing.Size(122, 13);
            this.lblNewFailures.TabIndex = 66;
            this.lblNewFailures.Text = "Nowe zgłoszenia awarii:";
            // 
            // btnNewMaintenance
            // 
            this.btnNewMaintenance.Location = new System.Drawing.Point(554, 42);
            this.btnNewMaintenance.Name = "btnNewMaintenance";
            this.btnNewMaintenance.Size = new System.Drawing.Size(193, 41);
            this.btnNewMaintenance.TabIndex = 65;
            this.btnNewMaintenance.Text = "Dodaj nową obsługę awarii";
            this.btnNewMaintenance.UseVisualStyleBackColor = true;
            this.btnNewMaintenance.Click += new System.EventHandler(this.btnNewMaintenance_Click_1);
            // 
            // dgvFailures
            // 
            this.dgvFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFailures.Location = new System.Drawing.Point(22, 309);
            this.dgvFailures.Name = "dgvFailures";
            this.dgvFailures.Size = new System.Drawing.Size(482, 202);
            this.dgvFailures.TabIndex = 64;
            // 
            // dgvNewFailures
            // 
            this.dgvNewFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewFailures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFailure,
            this.Specification,
            this.FailureDate,
            this.MachineName});
            this.dgvNewFailures.Location = new System.Drawing.Point(22, 42);
            this.dgvNewFailures.Name = "dgvNewFailures";
            this.dgvNewFailures.Size = new System.Drawing.Size(482, 202);
            this.dgvNewFailures.TabIndex = 63;
            // 
            // IdFailure
            // 
            this.IdFailure.HeaderText = "IdFailure";
            this.IdFailure.Name = "IdFailure";
            this.IdFailure.Visible = false;
            // 
            // Specification
            // 
            this.Specification.DataPropertyName = "Specification";
            this.Specification.HeaderText = "Opis";
            this.Specification.Name = "Specification";
            // 
            // FailureDate
            // 
            this.FailureDate.DataPropertyName = "FailureDate";
            this.FailureDate.HeaderText = "Data zgłoszenia";
            this.FailureDate.Name = "FailureDate";
            // 
            // MachineName
            // 
            this.MachineName.DataPropertyName = "MachineName";
            this.MachineName.HeaderText = "Nazwa maszyny";
            this.MachineName.Name = "MachineName";
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.AutoSize = true;
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReturnMain.Location = new System.Drawing.Point(972, 507);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(194, 153);
            this.btnReturnMain.TabIndex = 62;
            this.btnReturnMain.Text = "Powrót ";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click_1);
            // 
            // FailureListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.btnFilterDate);
            this.Controls.Add(this.comEmployee);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.comMachine);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.lblFailures);
            this.Controls.Add(this.lblNewFailures);
            this.Controls.Add(this.btnNewMaintenance);
            this.Controls.Add(this.dgvFailures);
            this.Controls.Add(this.dgvNewFailures);
            this.Controls.Add(this.btnReturnMain);
            this.Name = "FailureListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista awarii";
            this.Load += new System.EventHandler(this.FailureListForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFailures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFailures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.ComboBox comEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox comMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblFailures;
        private System.Windows.Forms.Label lblNewFailures;
        private System.Windows.Forms.Button btnNewMaintenance;
        private System.Windows.Forms.DataGridView dgvFailures;
        private System.Windows.Forms.DataGridView dgvNewFailures;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.Button btnReturnMain;
    }
}