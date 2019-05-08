﻿namespace KWZP2019
{
    partial class MaintenanceCalendarForm
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
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDescription = new System.Windows.Forms.Button();
            this.comType = new System.Windows.Forms.ComboBox();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.IdMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAcceptOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMaintType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMaintDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintenanceNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDatePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDatePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comMachine = new System.Windows.Forms.ComboBox();
            this.btnFilterDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
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
            this.btnReturnMain.Image = global::KWZP2019.Properties.Resources.icons8_home_40;
            this.btnReturnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReturnMain.Location = new System.Drawing.Point(950, 500);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(194, 153);
            this.btnReturnMain.TabIndex = 7;
            this.btnReturnMain.Text = "Powrót ";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Typ";
            // 
            // btnDescription
            // 
            this.btnDescription.Location = new System.Drawing.Point(64, 598);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(75, 23);
            this.btnDescription.TabIndex = 11;
            this.btnDescription.Text = "Pokaż opis";
            this.btnDescription.UseVisualStyleBackColor = true;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            // 
            // comType
            // 
            this.comType.FormattingEnabled = true;
            this.comType.Location = new System.Drawing.Point(859, 61);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(121, 21);
            this.comType.TabIndex = 9;
            this.comType.SelectedIndexChanged += new System.EventHandler(this.comType_SelectedIndexChanged);
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMaintenance,
            this.DateAcceptOrder,
            this.IdMaintType,
            this.IdMaintDesc,
            this.MaintTypeName,
            this.MaintenanceNr,
            this.IdMachine,
            this.MachineName,
            this.StartDatePlan,
            this.EndDatePlan});
            this.dgvMaintenance.Location = new System.Drawing.Point(64, 46);
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.ReadOnly = true;
            this.dgvMaintenance.Size = new System.Drawing.Size(622, 494);
            this.dgvMaintenance.TabIndex = 8;
            this.dgvMaintenance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaintenance_CellClick);
            // 
            // IdMaintenance
            // 
            this.IdMaintenance.DataPropertyName = "IdMaintenance";
            this.IdMaintenance.HeaderText = "IdMaintenance";
            this.IdMaintenance.Name = "IdMaintenance";
            this.IdMaintenance.ReadOnly = true;
            this.IdMaintenance.Visible = false;
            // 
            // DateAcceptOrder
            // 
            this.DateAcceptOrder.DataPropertyName = "DateAcceptOrder";
            this.DateAcceptOrder.HeaderText = "DateAcceptOrder";
            this.DateAcceptOrder.Name = "DateAcceptOrder";
            this.DateAcceptOrder.ReadOnly = true;
            this.DateAcceptOrder.Visible = false;
            // 
            // IdMaintType
            // 
            this.IdMaintType.DataPropertyName = "IdMaintType";
            this.IdMaintType.HeaderText = "IdMaintType";
            this.IdMaintType.Name = "IdMaintType";
            this.IdMaintType.ReadOnly = true;
            this.IdMaintType.Visible = false;
            // 
            // IdMaintDesc
            // 
            this.IdMaintDesc.DataPropertyName = "IdMaintDesc";
            this.IdMaintDesc.HeaderText = "IdMaintDesc";
            this.IdMaintDesc.Name = "IdMaintDesc";
            this.IdMaintDesc.ReadOnly = true;
            this.IdMaintDesc.Visible = false;
            // 
            // MaintTypeName
            // 
            this.MaintTypeName.HeaderText = "Typ obsługi";
            this.MaintTypeName.Name = "MaintTypeName";
            this.MaintTypeName.ReadOnly = true;
            // 
            // MaintenanceNr
            // 
            this.MaintenanceNr.DataPropertyName = "MaintenanceNr";
            this.MaintenanceNr.HeaderText = "Numer obsługi";
            this.MaintenanceNr.Name = "MaintenanceNr";
            this.MaintenanceNr.ReadOnly = true;
            // 
            // IdMachine
            // 
            this.IdMachine.DataPropertyName = "IdMachine";
            this.IdMachine.HeaderText = "IdMachine";
            this.IdMachine.Name = "IdMachine";
            this.IdMachine.ReadOnly = true;
            this.IdMachine.Visible = false;
            // 
            // MachineName
            // 
            this.MachineName.HeaderText = "Nazwa maszyny";
            this.MachineName.Name = "MachineName";
            this.MachineName.ReadOnly = true;
            // 
            // StartDatePlan
            // 
            this.StartDatePlan.DataPropertyName = "StartDatePlan";
            this.StartDatePlan.HeaderText = "Data rozpoczęcia";
            this.StartDatePlan.Name = "StartDatePlan";
            this.StartDatePlan.ReadOnly = true;
            // 
            // EndDatePlan
            // 
            this.EndDatePlan.DataPropertyName = "EndDatePlan";
            this.EndDatePlan.HeaderText = "Data zakończenia";
            this.EndDatePlan.Name = "EndDatePlan";
            this.EndDatePlan.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filtruj według:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data od:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(859, 104);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromDate.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data do:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(859, 156);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpToDate.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(724, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Maszyna:";
            // 
            // comMachine
            // 
            this.comMachine.FormattingEnabled = true;
            this.comMachine.Location = new System.Drawing.Point(859, 208);
            this.comMachine.Name = "comMachine";
            this.comMachine.Size = new System.Drawing.Size(200, 21);
            this.comMachine.TabIndex = 17;
            this.comMachine.SelectedIndexChanged += new System.EventHandler(this.comMachine_SelectedIndexChanged);
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.Location = new System.Drawing.Point(1084, 130);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(75, 23);
            this.btnFilterDate.TabIndex = 23;
            this.btnFilterDate.Text = "Filtruj";
            this.btnFilterDate.UseVisualStyleBackColor = true;
            this.btnFilterDate.Click += new System.EventHandler(this.btnFilterDate_Click);
            // 
            // MaintenanceCalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.btnFilterDate);
            this.Controls.Add(this.comMachine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.comType);
            this.Controls.Add(this.dgvMaintenance);
            this.Controls.Add(this.btnReturnMain);
            this.Name = "MaintenanceCalendarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalendarz zleceń";
            this.Load += new System.EventHandler(this.MaintenanceCalendarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAcceptOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaintType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaintDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaintTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaintenanceNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDatePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDatePlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.ComboBox comMachine;
    }
}