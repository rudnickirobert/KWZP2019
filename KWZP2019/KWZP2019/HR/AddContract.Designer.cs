﻿namespace KWZP2019
{
    partial class AddContract
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbEmployeeList = new System.Windows.Forms.ComboBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.dtpWorkplaceTrainingDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(56, 119);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(273, 22);
            this.dtpStartDate.TabIndex = 0;
            // 
            // cbEmployeeList
            // 
            this.cbEmployeeList.FormattingEnabled = true;
            this.cbEmployeeList.Location = new System.Drawing.Point(172, 55);
            this.cbEmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmployeeList.Name = "cbEmployeeList";
            this.cbEmployeeList.Size = new System.Drawing.Size(121, 24);
            this.cbEmployeeList.TabIndex = 1;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(268, 215);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 22);
            this.tbSalary.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(395, 122);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(297, 22);
            this.dtpEndDate.TabIndex = 3;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(427, 214);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(160, 24);
            this.cbPosition.TabIndex = 4;
            // 
            // dtpWorkplaceTrainingDate
            // 
            this.dtpWorkplaceTrainingDate.Location = new System.Drawing.Point(427, 288);
            this.dtpWorkplaceTrainingDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpWorkplaceTrainingDate.Name = "dtpWorkplaceTrainingDate";
            this.dtpWorkplaceTrainingDate.Size = new System.Drawing.Size(265, 22);
            this.dtpWorkplaceTrainingDate.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 372);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 38);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpWorkplaceTrainingDate);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.cbEmployeeList);
            this.Controls.Add(this.dtpStartDate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddContract";
            this.Text = "Dodaj umowę";
            this.Load += new System.EventHandler(this.AddContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cbEmployeeList;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.DateTimePicker dtpWorkplaceTrainingDate;
        private System.Windows.Forms.Button btnAdd;
    }
}