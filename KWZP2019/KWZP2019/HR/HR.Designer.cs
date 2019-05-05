﻿namespace KWZP2019
{
    partial class HR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR));
            this.tbEmployeeSearching = new System.Windows.Forms.TextBox();
            this.dgvEmloyees = new System.Windows.Forms.DataGridView();
            this.lbWarningsExamination = new System.Windows.Forms.ListBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnExamination = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.btnPayChecks = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.lbWarningsContracts = new System.Windows.Forms.ListBox();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.btnEducationLevel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmloyees)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmployeeSearching
            // 
            this.tbEmployeeSearching.Location = new System.Drawing.Point(353, 54);
            this.tbEmployeeSearching.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmployeeSearching.Name = "tbEmployeeSearching";
            this.tbEmployeeSearching.Size = new System.Drawing.Size(578, 20);
            this.tbEmployeeSearching.TabIndex = 0;
            this.tbEmployeeSearching.Text = "Wyszukaj po nazwisku";
            this.tbEmployeeSearching.TextChanged += new System.EventHandler(this.tbEmployeeSearching_TextChanged);
            // 
            // dgvEmloyees
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmloyees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmloyees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvEmloyees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmloyees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmloyees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmloyees.EnableHeadersVisualStyles = false;
            this.dgvEmloyees.Location = new System.Drawing.Point(353, 94);
            this.dgvEmloyees.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmloyees.Name = "dgvEmloyees";
            this.dgvEmloyees.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmloyees.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmloyees.RowTemplate.Height = 24;
            this.dgvEmloyees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmloyees.Size = new System.Drawing.Size(578, 424);
            this.dgvEmloyees.TabIndex = 2;
            // 
            // lbWarningsExamination
            // 
            this.lbWarningsExamination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lbWarningsExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbWarningsExamination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbWarningsExamination.FormattingEnabled = true;
            this.lbWarningsExamination.ItemHeight = 18;
            this.lbWarningsExamination.Location = new System.Drawing.Point(11, 496);
            this.lbWarningsExamination.Margin = new System.Windows.Forms.Padding(2);
            this.lbWarningsExamination.Name = "lbWarningsExamination";
            this.lbWarningsExamination.Size = new System.Drawing.Size(320, 22);
            this.lbWarningsExamination.TabIndex = 3;
            this.lbWarningsExamination.DoubleClick += new System.EventHandler(this.lbWarningsExamination_DoubleClick);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetails.Location = new System.Drawing.Point(946, 54);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(0);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(206, 80);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Szczegóły";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnExamination
            // 
            this.btnExamination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnExamination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnExamination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExamination.Location = new System.Drawing.Point(946, 150);
            this.btnExamination.Margin = new System.Windows.Forms.Padding(0);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(206, 80);
            this.btnExamination.TabIndex = 5;
            this.btnExamination.Text = "Badania";
            this.btnExamination.UseVisualStyleBackColor = false;
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.Location = new System.Drawing.Point(656, 534);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(275, 176);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Dodaj pracownika";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnTraining.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTraining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTraining.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTraining.Location = new System.Drawing.Point(946, 246);
            this.btnTraining.Margin = new System.Windows.Forms.Padding(0);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(206, 80);
            this.btnTraining.TabIndex = 7;
            this.btnTraining.Text = "Szkolenia";
            this.btnTraining.UseVisualStyleBackColor = false;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAbsences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbsences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbsences.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAbsences.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbsences.Location = new System.Drawing.Point(946, 342);
            this.btnAbsences.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(206, 80);
            this.btnAbsences.TabIndex = 8;
            this.btnAbsences.Text = "Nieobecności";
            this.btnAbsences.UseVisualStyleBackColor = false;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // btnPayChecks
            // 
            this.btnPayChecks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnPayChecks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayChecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayChecks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPayChecks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPayChecks.Location = new System.Drawing.Point(946, 438);
            this.btnPayChecks.Margin = new System.Windows.Forms.Padding(0);
            this.btnPayChecks.Name = "btnPayChecks";
            this.btnPayChecks.Size = new System.Drawing.Size(206, 80);
            this.btnPayChecks.TabIndex = 9;
            this.btnPayChecks.Text = "Wypłaty";
            this.btnPayChecks.UseVisualStyleBackColor = false;
            // 
            // btnContracts
            // 
            this.btnContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnContracts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnContracts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContracts.Location = new System.Drawing.Point(946, 534);
            this.btnContracts.Margin = new System.Windows.Forms.Padding(0);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(206, 80);
            this.btnContracts.TabIndex = 10;
            this.btnContracts.Text = "Umowy";
            this.btnContracts.UseVisualStyleBackColor = false;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // lbWarningsContracts
            // 
            this.lbWarningsContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lbWarningsContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbWarningsContracts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbWarningsContracts.FormattingEnabled = true;
            this.lbWarningsContracts.ItemHeight = 18;
            this.lbWarningsContracts.Location = new System.Drawing.Point(11, 453);
            this.lbWarningsContracts.Margin = new System.Windows.Forms.Padding(2);
            this.lbWarningsContracts.Name = "lbWarningsContracts";
            this.lbWarningsContracts.Size = new System.Drawing.Size(320, 22);
            this.lbWarningsContracts.TabIndex = 11;
            this.lbWarningsContracts.DoubleClick += new System.EventHandler(this.lbWarningsContracts_DoubleClick);
            // 
            // btnAddContract
            // 
            this.btnAddContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAddContract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAddContract.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddContract.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContract.Image")));
            this.btnAddContract.Location = new System.Drawing.Point(353, 534);
            this.btnAddContract.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(291, 176);
            this.btnAddContract.TabIndex = 12;
            this.btnAddContract.Text = "Dodaj umowę";
            this.btnAddContract.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddContract.UseVisualStyleBackColor = false;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // btnEducationLevel
            // 
            this.btnEducationLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnEducationLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEducationLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEducationLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnEducationLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEducationLevel.Location = new System.Drawing.Point(946, 630);
            this.btnEducationLevel.Margin = new System.Windows.Forms.Padding(0);
            this.btnEducationLevel.Name = "btnEducationLevel";
            this.btnEducationLevel.Size = new System.Drawing.Size(206, 80);
            this.btnEducationLevel.TabIndex = 13;
            this.btnEducationLevel.Text = "Wykształcenie";
            this.btnEducationLevel.UseVisualStyleBackColor = false;
            this.btnEducationLevel.Click += new System.EventHandler(this.btnEducationLevel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(21, 54);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(262, 156);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.Location = new System.Drawing.Point(21, 246);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(262, 160);
            this.btnReturnMain.TabIndex = 15;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnEducationLevel);
            this.Controls.Add(this.btnAddContract);
            this.Controls.Add(this.lbWarningsContracts);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnPayChecks);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnTraining);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnExamination);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lbWarningsExamination);
            this.Controls.Add(this.dgvEmloyees);
            this.Controls.Add(this.tbEmployeeSearching);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kadry";
            this.Load += new System.EventHandler(this.HR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmloyees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmployeeSearching;
        private System.Windows.Forms.DataGridView dgvEmloyees;
        private System.Windows.Forms.ListBox lbWarningsExamination;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnExamination;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Button btnPayChecks;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.ListBox lbWarningsContracts;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.Button btnEducationLevel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
    }
}