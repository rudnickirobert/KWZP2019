namespace KWZP2019
{
    partial class EmployeeDetails
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
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.btnEducation = new System.Windows.Forms.Button();
            this.btnTrainings = new System.Windows.Forms.Button();
            this.tbSearchEmployeeDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeDetails
            // 
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(9, 40);
            this.dgvEmployeeDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.RowHeadersVisible = false;
            this.dgvEmployeeDetails.RowTemplate.Height = 24;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(651, 399);
            this.dgvEmployeeDetails.TabIndex = 0;
            // 
            // btnEducation
            // 
            this.btnEducation.Location = new System.Drawing.Point(665, 365);
            this.btnEducation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEducation.Name = "btnEducation";
            this.btnEducation.Size = new System.Drawing.Size(123, 74);
            this.btnEducation.TabIndex = 4;
            this.btnEducation.Text = "Wykształcenie";
            this.btnEducation.UseVisualStyleBackColor = true;
            // 
            // btnTrainings
            // 
            this.btnTrainings.Location = new System.Drawing.Point(667, 287);
            this.btnTrainings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrainings.Name = "btnTrainings";
            this.btnTrainings.Size = new System.Drawing.Size(121, 74);
            this.btnTrainings.TabIndex = 5;
            this.btnTrainings.Text = "Szkolenia";
            this.btnTrainings.UseVisualStyleBackColor = true;
            // 
            // tbSearchEmployeeDetails
            // 
            this.tbSearchEmployeeDetails.Location = new System.Drawing.Point(9, 13);
            this.tbSearchEmployeeDetails.Name = "tbSearchEmployeeDetails";
            this.tbSearchEmployeeDetails.Size = new System.Drawing.Size(651, 22);
            this.tbSearchEmployeeDetails.TabIndex = 6;
            this.tbSearchEmployeeDetails.TextChanged += new System.EventHandler(this.tbSearchEmployeeDetails_TextChanged);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSearchEmployeeDetails);
            this.Controls.Add(this.btnTrainings);
            this.Controls.Add(this.btnEducation);
            this.Controls.Add(this.dgvEmployeeDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeDetails";
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
        private System.Windows.Forms.Button btnEducation;
        private System.Windows.Forms.Button btnTrainings;
        private System.Windows.Forms.TextBox tbSearchEmployeeDetails;
    }
}