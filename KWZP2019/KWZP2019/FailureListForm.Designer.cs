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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.comMachine = new System.Windows.Forms.ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblFailures = new System.Windows.Forms.Label();
            this.lblNewFailures = new System.Windows.Forms.Label();
            this.btnNewMaintenance = new System.Windows.Forms.Button();
            this.dgvMaintenances = new System.Windows.Forms.DataGridView();
            this.dgvNewFailures = new System.Windows.Forms.DataGridView();
            this.IdFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FailureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.IdMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintenanceNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDatePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDatePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFailures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnFilterDate.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnFilterDate.FlatAppearance.BorderSize = 3;
            this.btnFilterDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFilterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilterDate.ForeColor = System.Drawing.Color.White;
            this.btnFilterDate.Location = new System.Drawing.Point(850, 309);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(132, 59);
            this.btnFilterDate.TabIndex = 76;
            this.btnFilterDate.Text = "Filtruj";
            this.btnFilterDate.UseVisualStyleBackColor = false;
            this.btnFilterDate.Click += new System.EventHandler(this.btnFilterDate_Click);
            // 
            // comMachine
            // 
            this.comMachine.FormattingEnabled = true;
            this.comMachine.Location = new System.Drawing.Point(605, 430);
            this.comMachine.Name = "comMachine";
            this.comMachine.Size = new System.Drawing.Size(200, 21);
            this.comMachine.TabIndex = 73;
            this.comMachine.SelectedIndexChanged += new System.EventHandler(this.comMachine_SelectedIndexChanged);
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMachine.ForeColor = System.Drawing.Color.White;
            this.lblMachine.Location = new System.Drawing.Point(506, 435);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(73, 16);
            this.lblMachine.TabIndex = 72;
            this.lblMachine.Text = "Maszyna:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(605, 382);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpToDate.TabIndex = 70;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateTo.ForeColor = System.Drawing.Color.White;
            this.lblDateTo.Location = new System.Drawing.Point(506, 386);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(67, 16);
            this.lblDateTo.TabIndex = 68;
            this.lblDateTo.Text = "Data do:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(605, 330);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromDate.TabIndex = 71;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateFrom.ForeColor = System.Drawing.Color.White;
            this.lblDateFrom.Location = new System.Drawing.Point(506, 335);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(67, 16);
            this.lblDateFrom.TabIndex = 69;
            this.lblDateFrom.Text = "Data od:";
            // 
            // lblFailures
            // 
            this.lblFailures.AutoSize = true;
            this.lblFailures.BackColor = System.Drawing.Color.Transparent;
            this.lblFailures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFailures.ForeColor = System.Drawing.Color.White;
            this.lblFailures.Location = new System.Drawing.Point(18, 282);
            this.lblFailures.Name = "lblFailures";
            this.lblFailures.Size = new System.Drawing.Size(181, 24);
            this.lblFailures.TabIndex = 67;
            this.lblFailures.Text = "Zlecenia naprawy:";
            // 
            // lblNewFailures
            // 
            this.lblNewFailures.AutoSize = true;
            this.lblNewFailures.BackColor = System.Drawing.Color.Transparent;
            this.lblNewFailures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNewFailures.ForeColor = System.Drawing.Color.White;
            this.lblNewFailures.Location = new System.Drawing.Point(27, 15);
            this.lblNewFailures.Name = "lblNewFailures";
            this.lblNewFailures.Size = new System.Drawing.Size(137, 24);
            this.lblNewFailures.TabIndex = 66;
            this.lblNewFailures.Text = "Nowe awarie:";
            // 
            // btnNewMaintenance
            // 
            this.btnNewMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnNewMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNewMaintenance.FlatAppearance.BorderSize = 3;
            this.btnNewMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNewMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnNewMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btnNewMaintenance.Image")));
            this.btnNewMaintenance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewMaintenance.Location = new System.Drawing.Point(475, 42);
            this.btnNewMaintenance.Name = "btnNewMaintenance";
            this.btnNewMaintenance.Size = new System.Drawing.Size(158, 119);
            this.btnNewMaintenance.TabIndex = 65;
            this.btnNewMaintenance.Text = "Dodaj nowe zlecenie naprawy";
            this.btnNewMaintenance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewMaintenance.UseVisualStyleBackColor = false;
            this.btnNewMaintenance.Click += new System.EventHandler(this.btnNewMaintenance_Click_1);
            // 
            // dgvMaintenances
            // 
            this.dgvMaintenances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMaintenance,
            this.MaintenanceNr,
            this.StartDatePlan,
            this.EndDatePlan});
            this.dgvMaintenances.Location = new System.Drawing.Point(22, 309);
            this.dgvMaintenances.Name = "dgvMaintenances";
            this.dgvMaintenances.Size = new System.Drawing.Size(434, 165);
            this.dgvMaintenances.TabIndex = 64;
            // 
            // dgvNewFailures
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvNewFailures.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewFailures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNewFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewFailures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFailure,
            this.Specification,
            this.FailureDate,
            this.MachineName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNewFailures.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNewFailures.EnableHeadersVisualStyles = false;
            this.dgvNewFailures.Location = new System.Drawing.Point(22, 42);
            this.dgvNewFailures.Name = "dgvNewFailures";
            this.dgvNewFailures.Size = new System.Drawing.Size(434, 202);
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
            this.Specification.Width = 150;
            // 
            // FailureDate
            // 
            this.FailureDate.DataPropertyName = "FailureDate";
            this.FailureDate.HeaderText = "Data zgłoszenia";
            this.FailureDate.Name = "FailureDate";
            this.FailureDate.Width = 120;
            // 
            // MachineName
            // 
            this.MachineName.DataPropertyName = "MachineName";
            this.MachineName.HeaderText = "Nazwa maszyny";
            this.MachineName.Name = "MachineName";
            this.MachineName.Width = 120;
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.AutoSize = true;
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.BackgroundImage")));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReturnMain.Location = new System.Drawing.Point(850, 371);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(132, 103);
            this.btnReturnMain.TabIndex = 62;
            this.btnReturnMain.Text = "Powrót ";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(485, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 165);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 3;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.Location = new System.Drawing.Point(475, 169);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 75);
            this.btnRefresh.TabIndex = 78;
            this.btnRefresh.Text = "Odśwież listę";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // IdMaintenance
            // 
            this.IdMaintenance.DataPropertyName = "IdMaintenance";
            this.IdMaintenance.HeaderText = "IdMaintenance";
            this.IdMaintenance.Name = "IdMaintenance";
            this.IdMaintenance.Visible = false;
            // 
            // MaintenanceNr
            // 
            this.MaintenanceNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaintenanceNr.DataPropertyName = "MaintenanceNr";
            this.MaintenanceNr.HeaderText = "Numer zlecenia";
            this.MaintenanceNr.Name = "MaintenanceNr";
            // 
            // StartDatePlan
            // 
            this.StartDatePlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartDatePlan.DataPropertyName = "StartDatePlan";
            this.StartDatePlan.HeaderText = "Data rozpoczęcia";
            this.StartDatePlan.Name = "StartDatePlan";
            // 
            // EndDatePlan
            // 
            this.EndDatePlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndDatePlan.DataPropertyName = "EndDatePlan";
            this.EndDatePlan.HeaderText = "Data zakończenia";
            this.EndDatePlan.Name = "EndDatePlan";
            // 
            // FailureListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 504);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFilterDate);
            this.Controls.Add(this.comMachine);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.lblFailures);
            this.Controls.Add(this.lblNewFailures);
            this.Controls.Add(this.btnNewMaintenance);
            this.Controls.Add(this.dgvMaintenances);
            this.Controls.Add(this.dgvNewFailures);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FailureListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista awarii";
            this.Load += new System.EventHandler(this.FailureListForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewFailures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.ComboBox comMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblFailures;
        private System.Windows.Forms.Label lblNewFailures;
        private System.Windows.Forms.Button btnNewMaintenance;
        private System.Windows.Forms.DataGridView dgvMaintenances;
        private System.Windows.Forms.DataGridView dgvNewFailures;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn FailureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaintenanceNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDatePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDatePlan;
    }
}