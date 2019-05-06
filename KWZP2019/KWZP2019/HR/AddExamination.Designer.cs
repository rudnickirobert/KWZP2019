namespace KWZP2019
{
    partial class AddExamination
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
            this.dtpExaminationDate = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbEmployeeList = new System.Windows.Forms.ComboBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpExaminationDate
            // 
            this.dtpExaminationDate.Location = new System.Drawing.Point(436, 112);
            this.dtpExaminationDate.Name = "dtpExaminationDate";
            this.dtpExaminationDate.Size = new System.Drawing.Size(205, 22);
            this.dtpExaminationDate.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(585, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbEmployeeList
            // 
            this.cbEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cbEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbEmployeeList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbEmployeeList.FormattingEnabled = true;
            this.cbEmployeeList.Location = new System.Drawing.Point(13, 104);
            this.cbEmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmployeeList.Name = "cbEmployeeList";
            this.cbEmployeeList.Size = new System.Drawing.Size(344, 30);
            this.cbEmployeeList.TabIndex = 37;
            // 
            // cbPosition
            // 
            this.cbPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbPosition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(13, 213);
            this.cbPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(344, 30);
            this.cbPosition.TabIndex = 38;
            // 
            // AddExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.cbEmployeeList);
            this.Controls.Add(this.dtpExaminationDate);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddExamination";
            this.Text = "Dodaj badanie";
            this.Load += new System.EventHandler(this.AddExamination_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpExaminationDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbEmployeeList;
        private System.Windows.Forms.ComboBox cbPosition;
    }
}