namespace KWZP2019
{
    partial class InspectionListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InspectionListForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNewInspection = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblInspections = new System.Windows.Forms.Label();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.IdMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAcceptOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMaintType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMaintDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaintenanceNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDatePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDatePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFilterDate = new System.Windows.Forms.Button();
            this.comMachine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnDescription = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewInspection
            // 
            this.btnNewInspection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnNewInspection.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNewInspection.FlatAppearance.BorderSize = 3;
            this.btnNewInspection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnNewInspection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewInspection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewInspection.Image = ((System.Drawing.Image)(resources.GetObject("btnNewInspection.Image")));
            this.btnNewInspection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewInspection.Location = new System.Drawing.Point(757, 266);
            this.btnNewInspection.Name = "btnNewInspection";
            this.btnNewInspection.Size = new System.Drawing.Size(201, 75);
            this.btnNewInspection.TabIndex = 0;
            this.btnNewInspection.Text = "Dodaj nowy przegląd";
            this.btnNewInspection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewInspection.UseVisualStyleBackColor = false;
            this.btnNewInspection.Click += new System.EventHandler(this.btnNewInspection_Click);
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
            this.btnReturnMain.Location = new System.Drawing.Point(793, 446);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(140, 112);
            this.btnReturnMain.TabIndex = 12;
            this.btnReturnMain.Text = "Powrót ";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(567, 266);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(184, 75);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Odśwież listę";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblInspections
            // 
            this.lblInspections.AutoSize = true;
            this.lblInspections.BackColor = System.Drawing.Color.Transparent;
            this.lblInspections.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInspections.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInspections.Location = new System.Drawing.Point(34, 18);
            this.lblInspections.Name = "lblInspections";
            this.lblInspections.Size = new System.Drawing.Size(218, 29);
            this.lblInspections.TabIndex = 15;
            this.lblInspections.Text = "Lista przeglądów:";
            // 
            // dgvMaintenance
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvMaintenance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaintenance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMaintenance,
            this.DateAcceptOrder,
            this.IdMaintType,
            this.IdMaintDesc,
            this.MaintenanceNr,
            this.IdMachine,
            this.StartDatePlan,
            this.EndDatePlan});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaintenance.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMaintenance.EnableHeadersVisualStyles = false;
            this.dgvMaintenance.Location = new System.Drawing.Point(39, 72);
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.ReadOnly = true;
            this.dgvMaintenance.Size = new System.Drawing.Size(509, 375);
            this.dgvMaintenance.TabIndex = 16;
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
            // MaintenanceNr
            // 
            this.MaintenanceNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // StartDatePlan
            // 
            this.StartDatePlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartDatePlan.DataPropertyName = "StartDatePlan";
            this.StartDatePlan.HeaderText = "Data rozpoczęcia";
            this.StartDatePlan.Name = "StartDatePlan";
            this.StartDatePlan.ReadOnly = true;
            // 
            // EndDatePlan
            // 
            this.EndDatePlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndDatePlan.DataPropertyName = "EndDatePlan";
            this.EndDatePlan.HeaderText = "Data zakończenia";
            this.EndDatePlan.Name = "EndDatePlan";
            this.EndDatePlan.ReadOnly = true;
            // 
            // btnFilterDate
            // 
            this.btnFilterDate.Location = new System.Drawing.Point(1077, 98);
            this.btnFilterDate.Name = "btnFilterDate";
            this.btnFilterDate.Size = new System.Drawing.Size(75, 23);
            this.btnFilterDate.TabIndex = 31;
            this.btnFilterDate.Text = "Filtruj";
            this.btnFilterDate.UseVisualStyleBackColor = true;
            this.btnFilterDate.Click += new System.EventHandler(this.btnFilterDate_Click);
            // 
            // comMachine
            // 
            this.comMachine.FormattingEnabled = true;
            this.comMachine.Location = new System.Drawing.Point(649, 200);
            this.comMachine.Name = "comMachine";
            this.comMachine.Size = new System.Drawing.Size(153, 21);
            this.comMachine.TabIndex = 30;
            this.comMachine.SelectedIndexChanged += new System.EventHandler(this.comMachine_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(575, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Maszyna:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(649, 168);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(153, 20);
            this.dtpToDate.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(579, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Data do:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(649, 136);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(153, 20);
            this.dtpFromDate.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(579, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Data od:";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFilter.Location = new System.Drawing.Point(656, 90);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(146, 24);
            this.lblFilter.TabIndex = 24;
            this.lblFilter.Text = "Filtruj według:";
            // 
            // btnDescription
            // 
            this.btnDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnDescription.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDescription.FlatAppearance.BorderSize = 3;
            this.btnDescription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDescription.Location = new System.Drawing.Point(39, 463);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(181, 37);
            this.btnDescription.TabIndex = 32;
            this.btnDescription.Text = "Pokaż opis";
            this.btnDescription.UseVisualStyleBackColor = false;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(567, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 175);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilter.Location = new System.Drawing.Point(823, 160);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(110, 39);
            this.btnFilter.TabIndex = 34;
            this.btnFilter.Text = "Filtruj";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // InspectionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 568);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.btnFilterDate);
            this.Controls.Add(this.comMachine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dgvMaintenance);
            this.Controls.Add(this.lblInspections);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnNewInspection);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InspectionListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista przeglądów";
            this.Load += new System.EventHandler(this.InspectionListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewInspection;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblInspections;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.Button btnFilterDate;
        private System.Windows.Forms.ComboBox comMachine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAcceptOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaintType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaintDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaintenanceNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDatePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDatePlan;
        private System.Windows.Forms.Button btnFilter;
    }
}