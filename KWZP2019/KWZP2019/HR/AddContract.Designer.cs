namespace KWZP2019
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(42, 97);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(206, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // cbEmployeeList
            // 
            this.cbEmployeeList.FormattingEnabled = true;
            this.cbEmployeeList.Location = new System.Drawing.Point(129, 45);
            this.cbEmployeeList.Margin = new System.Windows.Forms.Padding(2);
            this.cbEmployeeList.Name = "cbEmployeeList";
            this.cbEmployeeList.Size = new System.Drawing.Size(92, 21);
            this.cbEmployeeList.TabIndex = 1;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(201, 175);
            this.tbSalary.Margin = new System.Windows.Forms.Padding(2);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(76, 20);
            this.tbSalary.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(296, 99);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(224, 20);
            this.dtpEndDate.TabIndex = 3;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(320, 174);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(121, 21);
            this.cbPosition.TabIndex = 4;
            // 
            // dtpWorkplaceTrainingDate
            // 
            this.dtpWorkplaceTrainingDate.Location = new System.Drawing.Point(320, 234);
            this.dtpWorkplaceTrainingDate.Name = "dtpWorkplaceTrainingDate";
            this.dtpWorkplaceTrainingDate.Size = new System.Drawing.Size(200, 20);
            this.dtpWorkplaceTrainingDate.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpWorkplaceTrainingDate);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.cbEmployeeList);
            this.Controls.Add(this.dtpStartDate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddContract";
            this.Text = "AddContract";
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
        private System.Windows.Forms.Button button1;
    }
}