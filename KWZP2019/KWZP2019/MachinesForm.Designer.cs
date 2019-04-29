namespace KWZP2019
{
    partial class MachinesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MachinesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.comMachineType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMetersPerHour = new System.Windows.Forms.Label();
            this.lblCatalogMachineNr = new System.Windows.Forms.Label();
            this.lblPowerMachine = new System.Windows.Forms.Label();
            this.txtMetersPerHour = new System.Windows.Forms.TextBox();
            this.txtCatalogMachineNr = new System.Windows.Forms.TextBox();
            this.txtPowerMachine = new System.Windows.Forms.TextBox();
            this.lblWorkingArea = new System.Windows.Forms.Label();
            this.lblProductionYear = new System.Windows.Forms.Label();
            this.txtWorkingArea = new System.Windows.Forms.TextBox();
            this.txtProductionYear = new System.Windows.Forms.TextBox();
            this.lblProducerMachine = new System.Windows.Forms.Label();
            this.txtProducerMachine = new System.Windows.Forms.TextBox();
            this.lblMachineType = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvMachine = new System.Windows.Forms.DataGridView();
            this.IdMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMachineType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProducerMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PowerMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatalogMachineNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetersPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).BeginInit();
            this.SuspendLayout();
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
            this.btnReturnMain.Location = new System.Drawing.Point(950, 500);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(194, 153);
            this.btnReturnMain.TabIndex = 6;
            this.btnReturnMain.Text = "Powrót ";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // comMachineType
            // 
            this.comMachineType.FormattingEnabled = true;
            this.comMachineType.Location = new System.Drawing.Point(144, 478);
            this.comMachineType.Name = "comMachineType";
            this.comMachineType.Size = new System.Drawing.Size(131, 21);
            this.comMachineType.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(673, 609);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 40);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(457, 609);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 40);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMetersPerHour
            // 
            this.lblMetersPerHour.AutoSize = true;
            this.lblMetersPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMetersPerHour.Location = new System.Drawing.Point(781, 525);
            this.lblMetersPerHour.Name = "lblMetersPerHour";
            this.lblMetersPerHour.Size = new System.Drawing.Size(124, 20);
            this.lblMetersPerHour.TabIndex = 34;
            this.lblMetersPerHour.Text = "Wydajność [m/h]";
            // 
            // lblCatalogMachineNr
            // 
            this.lblCatalogMachineNr.AutoSize = true;
            this.lblCatalogMachineNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCatalogMachineNr.Location = new System.Drawing.Point(765, 443);
            this.lblCatalogMachineNr.Name = "lblCatalogMachineNr";
            this.lblCatalogMachineNr.Size = new System.Drawing.Size(141, 20);
            this.lblCatalogMachineNr.TabIndex = 33;
            this.lblCatalogMachineNr.Text = "Numer Katalogowy";
            // 
            // lblPowerMachine
            // 
            this.lblPowerMachine.AutoSize = true;
            this.lblPowerMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPowerMachine.Location = new System.Drawing.Point(586, 443);
            this.lblPowerMachine.Name = "lblPowerMachine";
            this.lblPowerMachine.Size = new System.Drawing.Size(74, 20);
            this.lblPowerMachine.TabIndex = 32;
            this.lblPowerMachine.Text = "Moc [kW]";
            // 
            // txtMetersPerHour
            // 
            this.txtMetersPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMetersPerHour.Location = new System.Drawing.Point(769, 562);
            this.txtMetersPerHour.Name = "txtMetersPerHour";
            this.txtMetersPerHour.Size = new System.Drawing.Size(153, 26);
            this.txtMetersPerHour.TabIndex = 30;
            // 
            // txtCatalogMachineNr
            // 
            this.txtCatalogMachineNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCatalogMachineNr.Location = new System.Drawing.Point(754, 478);
            this.txtCatalogMachineNr.Name = "txtCatalogMachineNr";
            this.txtCatalogMachineNr.Size = new System.Drawing.Size(180, 26);
            this.txtCatalogMachineNr.TabIndex = 29;
            // 
            // txtPowerMachine
            // 
            this.txtPowerMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPowerMachine.Location = new System.Drawing.Point(544, 478);
            this.txtPowerMachine.Name = "txtPowerMachine";
            this.txtPowerMachine.Size = new System.Drawing.Size(165, 26);
            this.txtPowerMachine.TabIndex = 31;
            // 
            // lblWorkingArea
            // 
            this.lblWorkingArea.AutoSize = true;
            this.lblWorkingArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWorkingArea.Location = new System.Drawing.Point(565, 525);
            this.lblWorkingArea.Name = "lblWorkingArea";
            this.lblWorkingArea.Size = new System.Drawing.Size(119, 20);
            this.lblWorkingArea.TabIndex = 28;
            this.lblWorkingArea.Text = "Obszar roboczy";
            // 
            // lblProductionYear
            // 
            this.lblProductionYear.AutoSize = true;
            this.lblProductionYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProductionYear.Location = new System.Drawing.Point(351, 525);
            this.lblProductionYear.Name = "lblProductionYear";
            this.lblProductionYear.Size = new System.Drawing.Size(105, 20);
            this.lblProductionYear.TabIndex = 27;
            this.lblProductionYear.Text = "Rok produkcji";
            // 
            // txtWorkingArea
            // 
            this.txtWorkingArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtWorkingArea.Location = new System.Drawing.Point(544, 562);
            this.txtWorkingArea.Name = "txtWorkingArea";
            this.txtWorkingArea.Size = new System.Drawing.Size(168, 26);
            this.txtWorkingArea.TabIndex = 26;
            // 
            // txtProductionYear
            // 
            this.txtProductionYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProductionYear.Location = new System.Drawing.Point(339, 562);
            this.txtProductionYear.Name = "txtProductionYear";
            this.txtProductionYear.Size = new System.Drawing.Size(126, 26);
            this.txtProductionYear.TabIndex = 25;
            // 
            // lblProducerMachine
            // 
            this.lblProducerMachine.AutoSize = true;
            this.lblProducerMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProducerMachine.Location = new System.Drawing.Point(361, 443);
            this.lblProducerMachine.Name = "lblProducerMachine";
            this.lblProducerMachine.Size = new System.Drawing.Size(82, 20);
            this.lblProducerMachine.TabIndex = 24;
            this.lblProducerMachine.Text = "Producent";
            // 
            // txtProducerMachine
            // 
            this.txtProducerMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtProducerMachine.Location = new System.Drawing.Point(333, 478);
            this.txtProducerMachine.Name = "txtProducerMachine";
            this.txtProducerMachine.Size = new System.Drawing.Size(145, 26);
            this.txtProducerMachine.TabIndex = 23;
            // 
            // lblMachineType
            // 
            this.lblMachineType.AutoSize = true;
            this.lblMachineType.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMachineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMachineType.Location = new System.Drawing.Point(159, 443);
            this.lblMachineType.Name = "lblMachineType";
            this.lblMachineType.Size = new System.Drawing.Size(99, 20);
            this.lblMachineType.TabIndex = 22;
            this.lblMachineType.Text = "Typ maszyny";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMachineName.Location = new System.Drawing.Point(153, 525);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(122, 20);
            this.lblMachineName.TabIndex = 21;
            this.lblMachineName.Text = "Nazwa maszyny";
            // 
            // txtMachineName
            // 
            this.txtMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMachineName.Location = new System.Drawing.Point(144, 562);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.Size = new System.Drawing.Size(151, 26);
            this.txtMachineName.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 609);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 40);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvMachine
            // 
            this.dgvMachine.AllowUserToDeleteRows = false;
            this.dgvMachine.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMachine,
            this.IdMachineType,
            this.MachineTypeName,
            this.MachineName,
            this.ProducerMachine,
            this.ProductionYear,
            this.PowerMachine,
            this.WorkingArea,
            this.CatalogMachineNr,
            this.MetersPerHour});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMachine.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMachine.Location = new System.Drawing.Point(129, 4);
            this.dgvMachine.Name = "dgvMachine";
            this.dgvMachine.ReadOnly = true;
            this.dgvMachine.RowTemplate.Height = 35;
            this.dgvMachine.Size = new System.Drawing.Size(1015, 436);
            this.dgvMachine.TabIndex = 38;
            this.dgvMachine.DoubleClick += new System.EventHandler(this.dgvMachine_DoubleClick);
            // 
            // IdMachine
            // 
            this.IdMachine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdMachine.DataPropertyName = "IdMachine";
            this.IdMachine.HeaderText = "IdMachine";
            this.IdMachine.Name = "IdMachine";
            this.IdMachine.ReadOnly = true;
            this.IdMachine.Width = 82;
            // 
            // IdMachineType
            // 
            this.IdMachineType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdMachineType.DataPropertyName = "IdMachineType";
            this.IdMachineType.HeaderText = "IdMachineType";
            this.IdMachineType.Name = "IdMachineType";
            this.IdMachineType.ReadOnly = true;
            this.IdMachineType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdMachineType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdMachineType.Width = 87;
            // 
            // MachineTypeName
            // 
            this.MachineTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineTypeName.DataPropertyName = "MachineTypeName";
            this.MachineTypeName.HeaderText = "Typ maszyny";
            this.MachineTypeName.Name = "MachineTypeName";
            this.MachineTypeName.ReadOnly = true;
            this.MachineTypeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MachineTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MachineName
            // 
            this.MachineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineName.DataPropertyName = "MachineName";
            this.MachineName.HeaderText = "Nazwa maszyny";
            this.MachineName.Name = "MachineName";
            this.MachineName.ReadOnly = true;
            // 
            // ProducerMachine
            // 
            this.ProducerMachine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProducerMachine.DataPropertyName = "ProducerMachine";
            this.ProducerMachine.HeaderText = "Producent";
            this.ProducerMachine.Name = "ProducerMachine";
            this.ProducerMachine.ReadOnly = true;
            // 
            // ProductionYear
            // 
            this.ProductionYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductionYear.DataPropertyName = "ProductionYear";
            this.ProductionYear.HeaderText = "Rok produkcji";
            this.ProductionYear.Name = "ProductionYear";
            this.ProductionYear.ReadOnly = true;
            // 
            // PowerMachine
            // 
            this.PowerMachine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PowerMachine.DataPropertyName = "PowerMachine";
            this.PowerMachine.HeaderText = "Moc";
            this.PowerMachine.Name = "PowerMachine";
            this.PowerMachine.ReadOnly = true;
            // 
            // WorkingArea
            // 
            this.WorkingArea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkingArea.DataPropertyName = "WorkingArea";
            this.WorkingArea.HeaderText = "Obszar roboczy";
            this.WorkingArea.Name = "WorkingArea";
            this.WorkingArea.ReadOnly = true;
            // 
            // CatalogMachineNr
            // 
            this.CatalogMachineNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CatalogMachineNr.DataPropertyName = "CatalogMachineNr";
            this.CatalogMachineNr.HeaderText = "Numer katalogowy";
            this.CatalogMachineNr.Name = "CatalogMachineNr";
            this.CatalogMachineNr.ReadOnly = true;
            // 
            // MetersPerHour
            // 
            this.MetersPerHour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MetersPerHour.DataPropertyName = "MetersPerHour";
            this.MetersPerHour.HeaderText = "Wydajność";
            this.MetersPerHour.Name = "MetersPerHour";
            this.MetersPerHour.ReadOnly = true;
            // 
            // MachinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.dgvMachine);
            this.Controls.Add(this.comMachineType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblMetersPerHour);
            this.Controls.Add(this.lblCatalogMachineNr);
            this.Controls.Add(this.lblPowerMachine);
            this.Controls.Add(this.txtMetersPerHour);
            this.Controls.Add(this.txtCatalogMachineNr);
            this.Controls.Add(this.txtPowerMachine);
            this.Controls.Add(this.lblWorkingArea);
            this.Controls.Add(this.lblProductionYear);
            this.Controls.Add(this.txtWorkingArea);
            this.Controls.Add(this.txtProductionYear);
            this.Controls.Add(this.lblProducerMachine);
            this.Controls.Add(this.txtProducerMachine);
            this.Controls.Add(this.lblMachineType);
            this.Controls.Add(this.lblMachineName);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReturnMain);
            this.Name = "MachinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maszyny";
            this.Load += new System.EventHandler(this.MachinesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.ComboBox comMachineType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMetersPerHour;
        private System.Windows.Forms.Label lblCatalogMachineNr;
        private System.Windows.Forms.Label lblPowerMachine;
        private System.Windows.Forms.TextBox txtMetersPerHour;
        private System.Windows.Forms.TextBox txtCatalogMachineNr;
        private System.Windows.Forms.TextBox txtPowerMachine;
        private System.Windows.Forms.Label lblWorkingArea;
        private System.Windows.Forms.Label lblProductionYear;
        private System.Windows.Forms.TextBox txtWorkingArea;
        private System.Windows.Forms.TextBox txtProductionYear;
        private System.Windows.Forms.Label lblProducerMachine;
        private System.Windows.Forms.TextBox txtProducerMachine;
        private System.Windows.Forms.Label lblMachineType;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMachineType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProducerMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn PowerMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogMachineNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetersPerHour;
    }
}