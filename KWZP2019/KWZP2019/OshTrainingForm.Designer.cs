namespace KWZP2019
{
    partial class OshTrainingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OshTrainingForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.dataGVOshTraining = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.domainUpDownDepartmentName = new System.Windows.Forms.DomainUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.lblTrainingDate = new System.Windows.Forms.Label();
            this.datePickerControlDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOshTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.btnReturn, "btnReturn");
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.btnReturnMain, "btnReturnMain");
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // dataGVOshTraining
            // 
            this.dataGVOshTraining.AllowUserToAddRows = false;
            this.dataGVOshTraining.AllowUserToDeleteRows = false;
            this.dataGVOshTraining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGVOshTraining.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVOshTraining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVOshTraining.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGVOshTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGVOshTraining, "dataGVOshTraining");
            this.dataGVOshTraining.Name = "dataGVOshTraining";
            this.dataGVOshTraining.ReadOnly = true;
            this.dataGVOshTraining.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.btnShow, "btnShow");
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnShow.FlatAppearance.BorderSize = 3;
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShow.Name = "btnShow";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblDepartmentName
            // 
            resources.ApplyResources(this.lblDepartmentName, "lblDepartmentName");
            this.lblDepartmentName.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDepartmentName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDepartmentName.Name = "lblDepartmentName";
            // 
            // domainUpDownDepartmentName
            // 
            this.domainUpDownDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.domainUpDownDepartmentName, "domainUpDownDepartmentName");
            this.domainUpDownDepartmentName.Name = "domainUpDownDepartmentName";
            this.domainUpDownDepartmentName.Sorted = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.btnDone, "btnDone");
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDone.FlatAppearance.BorderSize = 3;
            this.btnDone.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDone.Name = "btnDone";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // pictureBoxForm
            // 
            this.pictureBoxForm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBoxForm, "pictureBoxForm");
            this.pictureBoxForm.Name = "pictureBoxForm";
            this.pictureBoxForm.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblFormTitle, "lblFormTitle");
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Name = "lblFormTitle";
            // 
            // lblEmployeeId
            // 
            resources.ApplyResources(this.lblEmployeeId, "lblEmployeeId");
            this.lblEmployeeId.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmployeeId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmployeeId.Name = "lblEmployeeId";
            // 
            // textBoxEmployeeId
            // 
            resources.ApplyResources(this.textBoxEmployeeId, "textBoxEmployeeId");
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            // 
            // lblTrainingDate
            // 
            this.lblTrainingDate.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblTrainingDate, "lblTrainingDate");
            this.lblTrainingDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrainingDate.Name = "lblTrainingDate";
            // 
            // datePickerControlDate
            // 
            resources.ApplyResources(this.datePickerControlDate, "datePickerControlDate");
            this.datePickerControlDate.Name = "datePickerControlDate";
            this.datePickerControlDate.Value = new System.DateTime(2019, 4, 16, 20, 35, 51, 0);
            // 
            // OshTrainingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datePickerControlDate);
            this.Controls.Add(this.lblTrainingDate);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.domainUpDownDepartmentName);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGVOshTraining);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.pictureBoxForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OshTrainingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OshTrainingForm_FormClosed);
            this.Load += new System.EventHandler(this.OshTrainingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOshTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.DataGridView dataGVOshTraining;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.DomainUpDown domainUpDownDepartmentName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Label lblTrainingDate;
        private System.Windows.Forms.DateTimePicker datePickerControlDate;
    }
}