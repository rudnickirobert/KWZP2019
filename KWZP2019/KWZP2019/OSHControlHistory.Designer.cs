namespace KWZP2019
{
    partial class OSHControlHistory
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
            this.components = new System.ComponentModel.Container();
            this.dGVControlHistory = new System.Windows.Forms.DataGridView();
            this.safetyControlHistoryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idInspectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSafetyEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saftyControlDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectedEmpolyeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safetyControlDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVControlHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetyControlHistoryViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVControlHistory
            // 
            this.dGVControlHistory.AutoGenerateColumns = false;
            this.dGVControlHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVControlHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInspectionDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.idSafetyEmployeeDataGridViewTextBoxColumn,
            this.saftyControlDateDataGridViewTextBoxColumn,
            this.inspectedEmpolyeeDataGridViewTextBoxColumn,
            this.safetyControlDescriptionDataGridViewTextBoxColumn});
            this.dGVControlHistory.DataSource = this.safetyControlHistoryViewBindingSource;
            this.dGVControlHistory.Location = new System.Drawing.Point(1, 0);
            this.dGVControlHistory.Name = "dGVControlHistory";
            this.dGVControlHistory.Size = new System.Drawing.Size(884, 566);
            this.dGVControlHistory.TabIndex = 0;
            // 
            // safetyControlHistoryViewBindingSource
            // 
            this.safetyControlHistoryViewBindingSource.DataSource = typeof(KWZP2019.SafetyControlHistoryView);
            // 
            // idInspectionDataGridViewTextBoxColumn
            // 
            this.idInspectionDataGridViewTextBoxColumn.DataPropertyName = "IdInspection";
            this.idInspectionDataGridViewTextBoxColumn.HeaderText = "IdInspection";
            this.idInspectionDataGridViewTextBoxColumn.Name = "idInspectionDataGridViewTextBoxColumn";
            this.idInspectionDataGridViewTextBoxColumn.Width = 120;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // idSafetyEmployeeDataGridViewTextBoxColumn
            // 
            this.idSafetyEmployeeDataGridViewTextBoxColumn.DataPropertyName = "IdSafetyEmployee";
            this.idSafetyEmployeeDataGridViewTextBoxColumn.HeaderText = "IdSafetyEmployee";
            this.idSafetyEmployeeDataGridViewTextBoxColumn.Name = "idSafetyEmployeeDataGridViewTextBoxColumn";
            this.idSafetyEmployeeDataGridViewTextBoxColumn.Width = 120;
            // 
            // saftyControlDateDataGridViewTextBoxColumn
            // 
            this.saftyControlDateDataGridViewTextBoxColumn.DataPropertyName = "SaftyControlDate";
            this.saftyControlDateDataGridViewTextBoxColumn.HeaderText = "SaftyControlDate";
            this.saftyControlDateDataGridViewTextBoxColumn.Name = "saftyControlDateDataGridViewTextBoxColumn";
            this.saftyControlDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // inspectedEmpolyeeDataGridViewTextBoxColumn
            // 
            this.inspectedEmpolyeeDataGridViewTextBoxColumn.DataPropertyName = "InspectedEmpolyee";
            this.inspectedEmpolyeeDataGridViewTextBoxColumn.HeaderText = "InspectedEmpolyee";
            this.inspectedEmpolyeeDataGridViewTextBoxColumn.Name = "inspectedEmpolyeeDataGridViewTextBoxColumn";
            this.inspectedEmpolyeeDataGridViewTextBoxColumn.Width = 120;
            // 
            // safetyControlDescriptionDataGridViewTextBoxColumn
            // 
            this.safetyControlDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SafetyControlDescription";
            this.safetyControlDescriptionDataGridViewTextBoxColumn.HeaderText = "SafetyControlDescription";
            this.safetyControlDescriptionDataGridViewTextBoxColumn.Name = "safetyControlDescriptionDataGridViewTextBoxColumn";
            this.safetyControlDescriptionDataGridViewTextBoxColumn.Width = 240;
            // 
            // OSHControlHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dGVControlHistory);
            this.Name = "OSHControlHistory";
            this.Text = "OSHControlHistory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OSHControlHistory_FormClosed);
            this.Load += new System.EventHandler(this.OSHControlHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVControlHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safetyControlHistoryViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVControlHistory;
        private System.Windows.Forms.BindingSource safetyControlHistoryViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInspectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSafetyEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saftyControlDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectedEmpolyeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn safetyControlDescriptionDataGridViewTextBoxColumn;
    }
}