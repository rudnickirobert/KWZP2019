namespace KWZP2019
{
    partial class Examination
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
            this.dgvExamination = new System.Windows.Forms.DataGridView();
            this.tbSearchEmployeeExamination = new System.Windows.Forms.TextBox();
            this.btnAddExamination = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbSearchEmployeeExaminationName = new System.Windows.Forms.TextBox();
            this.lblSearchEmployeeExaminationName = new System.Windows.Forms.Label();
            this.lblSearchEmployeeExamination = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamination)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExamination
            // 
            this.dgvExamination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamination.Location = new System.Drawing.Point(12, 61);
            this.dgvExamination.Name = "dgvExamination";
            this.dgvExamination.RowHeadersVisible = false;
            this.dgvExamination.RowTemplate.Height = 24;
            this.dgvExamination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamination.Size = new System.Drawing.Size(600, 366);
            this.dgvExamination.TabIndex = 0;
            // 
            // tbSearchEmployeeExamination
            // 
            this.tbSearchEmployeeExamination.Location = new System.Drawing.Point(12, 33);
            this.tbSearchEmployeeExamination.Name = "tbSearchEmployeeExamination";
            this.tbSearchEmployeeExamination.Size = new System.Drawing.Size(237, 22);
            this.tbSearchEmployeeExamination.TabIndex = 1;
            this.tbSearchEmployeeExamination.TextChanged += new System.EventHandler(this.tbSearchEmployeeExamination_TextChanged);
            // 
            // btnAddExamination
            // 
            this.btnAddExamination.Location = new System.Drawing.Point(641, 244);
            this.btnAddExamination.Name = "btnAddExamination";
            this.btnAddExamination.Size = new System.Drawing.Size(106, 55);
            this.btnAddExamination.TabIndex = 2;
            this.btnAddExamination.Text = "Dodaj badanie";
            this.btnAddExamination.UseVisualStyleBackColor = true;
            this.btnAddExamination.Click += new System.EventHandler(this.btnAddExamination_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(641, 176);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 62);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // tbSearchEmployeeExaminationName
            // 
            this.tbSearchEmployeeExaminationName.Location = new System.Drawing.Point(375, 33);
            this.tbSearchEmployeeExaminationName.Name = "tbSearchEmployeeExaminationName";
            this.tbSearchEmployeeExaminationName.Size = new System.Drawing.Size(237, 22);
            this.tbSearchEmployeeExaminationName.TabIndex = 4;
            this.tbSearchEmployeeExaminationName.TextChanged += new System.EventHandler(this.tbSearchEmployeeExaminationName_TextChanged);
            // 
            // lblSearchEmployeeExaminationName
            // 
            this.lblSearchEmployeeExaminationName.AutoSize = true;
            this.lblSearchEmployeeExaminationName.Location = new System.Drawing.Point(375, 10);
            this.lblSearchEmployeeExaminationName.Name = "lblSearchEmployeeExaminationName";
            this.lblSearchEmployeeExaminationName.Size = new System.Drawing.Size(33, 17);
            this.lblSearchEmployeeExaminationName.TabIndex = 5;
            this.lblSearchEmployeeExaminationName.Text = "Imię";
            // 
            // lblSearchEmployeeExamination
            // 
            this.lblSearchEmployeeExamination.AutoSize = true;
            this.lblSearchEmployeeExamination.Location = new System.Drawing.Point(12, 9);
            this.lblSearchEmployeeExamination.Name = "lblSearchEmployeeExamination";
            this.lblSearchEmployeeExamination.Size = new System.Drawing.Size(67, 17);
            this.lblSearchEmployeeExamination.TabIndex = 6;
            this.lblSearchEmployeeExamination.Text = "Nazwisko";
            // 
            // Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearchEmployeeExamination);
            this.Controls.Add(this.lblSearchEmployeeExaminationName);
            this.Controls.Add(this.tbSearchEmployeeExaminationName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddExamination);
            this.Controls.Add(this.tbSearchEmployeeExamination);
            this.Controls.Add(this.dgvExamination);
            this.Name = "Examination";
            this.Text = "Examination";
            this.Load += new System.EventHandler(this.Examination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamination;
        private System.Windows.Forms.TextBox tbSearchEmployeeExamination;
        private System.Windows.Forms.Button btnAddExamination;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbSearchEmployeeExaminationName;
        private System.Windows.Forms.Label lblSearchEmployeeExaminationName;
        private System.Windows.Forms.Label lblSearchEmployeeExamination;
    }
}