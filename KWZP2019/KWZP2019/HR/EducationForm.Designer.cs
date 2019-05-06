﻿namespace KWZP2019
{
    partial class EducationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationForm));
            this.dgvEducation = new System.Windows.Forms.DataGridView();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.tbEmployeeSurname = new System.Windows.Forms.TextBox();
            this.cbEducationLevel = new System.Windows.Forms.ComboBox();
            this.dtpGraduationDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmployeeSurname = new System.Windows.Forms.Label();
            this.lblEducationLevel = new System.Windows.Forms.Label();
            this.lblGraduationDate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbEducationSearch = new System.Windows.Forms.TextBox();
            this.pbEducationForm = new System.Windows.Forms.PictureBox();
            this.cbEmployeeList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEducationForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEducation
            // 
            this.dgvEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEducation.Location = new System.Drawing.Point(29, 142);
            this.dgvEducation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEducation.Name = "dgvEducation";
            this.dgvEducation.RowHeadersVisible = false;
            this.dgvEducation.RowTemplate.Height = 24;
            this.dgvEducation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEducation.Size = new System.Drawing.Size(700, 436);
            this.dgvEducation.TabIndex = 0;
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(1060, 283);
            this.tbEmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(100, 22);
            this.tbEmployeeName.TabIndex = 1;
            // 
            // tbEmployeeSurname
            // 
            this.tbEmployeeSurname.Location = new System.Drawing.Point(1060, 329);
            this.tbEmployeeSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeeSurname.Name = "tbEmployeeSurname";
            this.tbEmployeeSurname.Size = new System.Drawing.Size(100, 22);
            this.tbEmployeeSurname.TabIndex = 2;
            // 
            // cbEducationLevel
            // 
            this.cbEducationLevel.FormattingEnabled = true;
            this.cbEducationLevel.Location = new System.Drawing.Point(1060, 374);
            this.cbEducationLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEducationLevel.Name = "cbEducationLevel";
            this.cbEducationLevel.Size = new System.Drawing.Size(121, 24);
            this.cbEducationLevel.TabIndex = 4;
            // 
            // dtpGraduationDate
            // 
            this.dtpGraduationDate.Location = new System.Drawing.Point(1060, 425);
            this.dtpGraduationDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpGraduationDate.Name = "dtpGraduationDate";
            this.dtpGraduationDate.Size = new System.Drawing.Size(268, 22);
            this.dtpGraduationDate.TabIndex = 8;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(876, 292);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(33, 17);
            this.lblEmployeeName.TabIndex = 9;
            this.lblEmployeeName.Text = "Imię";
            // 
            // lblEmployeeSurname
            // 
            this.lblEmployeeSurname.AutoSize = true;
            this.lblEmployeeSurname.Location = new System.Drawing.Point(876, 332);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(67, 17);
            this.lblEmployeeSurname.TabIndex = 10;
            this.lblEmployeeSurname.Text = "Nazwisko";
            // 
            // lblEducationLevel
            // 
            this.lblEducationLevel.AutoSize = true;
            this.lblEducationLevel.Location = new System.Drawing.Point(876, 384);
            this.lblEducationLevel.Name = "lblEducationLevel";
            this.lblEducationLevel.Size = new System.Drawing.Size(146, 17);
            this.lblEducationLevel.TabIndex = 11;
            this.lblEducationLevel.Text = "Stopień wykształcenia";
            // 
            // lblGraduationDate
            // 
            this.lblGraduationDate.AutoSize = true;
            this.lblGraduationDate.Location = new System.Drawing.Point(876, 432);
            this.lblGraduationDate.Name = "lblGraduationDate";
            this.lblGraduationDate.Size = new System.Drawing.Size(165, 17);
            this.lblGraduationDate.TabIndex = 12;
            this.lblGraduationDate.Text = "Data ukończenia studiów";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(84, 666);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 34);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1100, 631);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 34);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(288, 666);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 34);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // tbEducationSearch
            // 
            this.tbEducationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEducationSearch.Location = new System.Drawing.Point(29, 70);
            this.tbEducationSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEducationSearch.Name = "tbEducationSearch";
            this.tbEducationSearch.Size = new System.Drawing.Size(699, 30);
            this.tbEducationSearch.TabIndex = 16;
            this.tbEducationSearch.TextChanged += new System.EventHandler(this.tbEducationSearch_TextChanged);
            // 
            // pbEducationForm
            // 
            this.pbEducationForm.BackColor = System.Drawing.Color.Transparent;
            this.pbEducationForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEducationForm.BackgroundImage")));
            this.pbEducationForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEducationForm.Location = new System.Drawing.Point(768, 21);
            this.pbEducationForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbEducationForm.Name = "pbEducationForm";
            this.pbEducationForm.Size = new System.Drawing.Size(775, 881);
            this.pbEducationForm.TabIndex = 17;
            this.pbEducationForm.TabStop = false;
            // 
            // cbEmployeeList
            // 
            this.cbEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cbEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbEmployeeList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbEmployeeList.FormattingEnabled = true;
            this.cbEmployeeList.Location = new System.Drawing.Point(1060, 295);
            this.cbEmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmployeeList.Name = "cbEmployeeList";
            this.cbEmployeeList.Size = new System.Drawing.Size(344, 30);
            this.cbEmployeeList.TabIndex = 37;
            // 
            // EducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 922);
            this.Controls.Add(this.cbEmployeeList);
            this.Controls.Add(this.tbEducationSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblGraduationDate);
            this.Controls.Add(this.lblEducationLevel);
            this.Controls.Add(this.lblEmployeeSurname);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.dtpGraduationDate);
            this.Controls.Add(this.cbEducationLevel);
            this.Controls.Add(this.tbEmployeeSurname);
            this.Controls.Add(this.tbEmployeeName);
            this.Controls.Add(this.dgvEducation);
            this.Controls.Add(this.pbEducationForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EducationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EducationForm";
            this.Load += new System.EventHandler(this.EducationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEducationForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEducation;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.TextBox tbEmployeeSurname;
        private System.Windows.Forms.ComboBox cbEducationLevel;
        private System.Windows.Forms.DateTimePicker dtpGraduationDate;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.Label lblEducationLevel;
        private System.Windows.Forms.Label lblGraduationDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbEducationSearch;
        private System.Windows.Forms.PictureBox pbEducationForm;
        private System.Windows.Forms.ComboBox cbEmployeeList;
    }
}