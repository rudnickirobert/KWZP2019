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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.dataGVOshTraining = new System.Windows.Forms.DataGridView();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.domainUpDownDepartmentName = new System.Windows.Forms.DomainUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblTrainingDate = new System.Windows.Forms.Label();
            this.datePickerControlDate = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnNewTraining = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOshTraining)).BeginInit();
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
            this.dataGVOshTraining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVOshTraining.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVOshTraining.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dataGVOshTraining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVOshTraining.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVOshTraining.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVOshTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVOshTraining.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVOshTraining.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGVOshTraining.GridColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.dataGVOshTraining, "dataGVOshTraining");
            this.dataGVOshTraining.MultiSelect = false;
            this.dataGVOshTraining.Name = "dataGVOshTraining";
            this.dataGVOshTraining.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVOshTraining.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVOshTraining.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGVOshTraining.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVOshTraining_CellClick);
            this.dataGVOshTraining.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVOshTraining_RowHeaderMouseClick);
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
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 3;
            this.btnUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // btnNewTraining
            // 
            this.btnNewTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.btnNewTraining, "btnNewTraining");
            this.btnNewTraining.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNewTraining.FlatAppearance.BorderSize = 3;
            this.btnNewTraining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnNewTraining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnNewTraining.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewTraining.Name = "btnNewTraining";
            this.btnNewTraining.UseVisualStyleBackColor = false;
            this.btnNewTraining.Click += new System.EventHandler(this.btnNewTraining_Click);
            // 
            // OshTrainingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnNewTraining);
            this.Controls.Add(this.datePickerControlDate);
            this.Controls.Add(this.lblTrainingDate);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.domainUpDownDepartmentName);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGVOshTraining);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReturnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OshTrainingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OshTrainingForm_FormClosed);
            this.Load += new System.EventHandler(this.OshTrainingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOshTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.DataGridView dataGVOshTraining;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.DomainUpDown domainUpDownDepartmentName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblTrainingDate;
        private System.Windows.Forms.DateTimePicker datePickerControlDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnNewTraining;
    }
}