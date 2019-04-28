namespace KWZP2019
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmloyees)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmployeeSearching
            // 
            this.tbEmployeeSearching.Location = new System.Drawing.Point(11, 11);
            this.tbEmployeeSearching.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeeSearching.Name = "tbEmployeeSearching";
            this.tbEmployeeSearching.Size = new System.Drawing.Size(692, 22);
            this.tbEmployeeSearching.TabIndex = 0;
            this.tbEmployeeSearching.TextChanged += new System.EventHandler(this.tbEmployeeSearching_TextChanged);
            // 
            // dgvEmloyees
            // 
            this.dgvEmloyees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmloyees.Location = new System.Drawing.Point(12, 43);
            this.dgvEmloyees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmloyees.Name = "dgvEmloyees";
            this.dgvEmloyees.RowHeadersVisible = false;
            this.dgvEmloyees.RowTemplate.Height = 24;
            this.dgvEmloyees.Size = new System.Drawing.Size(691, 327);
            this.dgvEmloyees.TabIndex = 2;
            // 
            // lbWarningsExamination
            // 
            this.lbWarningsExamination.FormattingEnabled = true;
            this.lbWarningsExamination.ItemHeight = 16;
            this.lbWarningsExamination.Location = new System.Drawing.Point(11, 374);
            this.lbWarningsExamination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbWarningsExamination.Name = "lbWarningsExamination";
            this.lbWarningsExamination.Size = new System.Drawing.Size(466, 36);
            this.lbWarningsExamination.TabIndex = 3;
            this.lbWarningsExamination.DoubleClick += new System.EventHandler(this.lbWarningsExamination_DoubleClick);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(749, 11);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(120, 32);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Szczegóły";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnExamination
            // 
            this.btnExamination.Location = new System.Drawing.Point(749, 47);
            this.btnExamination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(120, 37);
            this.btnExamination.TabIndex = 5;
            this.btnExamination.Text = "Badania";
            this.btnExamination.UseVisualStyleBackColor = true;
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(614, 389);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 50);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Dodaj pracownika";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.Location = new System.Drawing.Point(749, 88);
            this.btnTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(120, 37);
            this.btnTraining.TabIndex = 7;
            this.btnTraining.Text = "Szkolenia";
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(749, 129);
            this.btnAbsences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(120, 58);
            this.btnAbsences.TabIndex = 8;
            this.btnAbsences.Text = "Nieobecności";
            this.btnAbsences.UseVisualStyleBackColor = true;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // btnPayChecks
            // 
            this.btnPayChecks.Location = new System.Drawing.Point(749, 191);
            this.btnPayChecks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayChecks.Name = "btnPayChecks";
            this.btnPayChecks.Size = new System.Drawing.Size(120, 37);
            this.btnPayChecks.TabIndex = 9;
            this.btnPayChecks.Text = "Wypłaty";
            this.btnPayChecks.UseVisualStyleBackColor = true;
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(749, 233);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(120, 37);
            this.btnContracts.TabIndex = 10;
            this.btnContracts.Text = "Umowy";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // lbWarningsContracts
            // 
            this.lbWarningsContracts.FormattingEnabled = true;
            this.lbWarningsContracts.ItemHeight = 16;
            this.lbWarningsContracts.Location = new System.Drawing.Point(11, 414);
            this.lbWarningsContracts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbWarningsContracts.Name = "lbWarningsContracts";
            this.lbWarningsContracts.Size = new System.Drawing.Size(466, 36);
            this.lbWarningsContracts.TabIndex = 11;
            this.lbWarningsContracts.DoubleClick += new System.EventHandler(this.lbWarningsContracts_DoubleClick);
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(749, 389);
            this.btnAddContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(120, 50);
            this.btnAddContract.TabIndex = 12;
            this.btnAddContract.Text = "Dodaj umowę";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // btnEducationLevel
            // 
            this.btnEducationLevel.Location = new System.Drawing.Point(749, 276);
            this.btnEducationLevel.Name = "btnEducationLevel";
            this.btnEducationLevel.Size = new System.Drawing.Size(120, 37);
            this.btnEducationLevel.TabIndex = 13;
            this.btnEducationLevel.Text = "Wykształcenie";
            this.btnEducationLevel.UseVisualStyleBackColor = true;
            this.btnEducationLevel.Click += new System.EventHandler(this.btnEducationLevel_Click);
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HR";
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
    }
}