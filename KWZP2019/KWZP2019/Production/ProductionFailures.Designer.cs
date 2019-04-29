namespace KWZP2019
{
    partial class ProductionFailures
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
            this.btn_return = new System.Windows.Forms.Button();
            this.label_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.dtp_failuredate = new System.Windows.Forms.DateTimePicker();
            this.gridViewFailures = new System.Windows.Forms.DataGridView();
            this.idFailureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failureMaintenancesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionProceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_failuredate = new System.Windows.Forms.Label();
            this.productionFailuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFailures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.failureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(12, 429);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(101, 42);
            this.btn_return.TabIndex = 0;
            this.btn_return.Text = "Powrót";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(37, 317);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(37, 17);
            this.label_description.TabIndex = 1;
            this.label_description.Text = "Opis";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(178, 317);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(358, 22);
            this.tb_description.TabIndex = 2;
            // 
            // dtp_failuredate
            // 
            this.dtp_failuredate.Location = new System.Drawing.Point(336, 372);
            this.dtp_failuredate.Name = "dtp_failuredate";
            this.dtp_failuredate.Size = new System.Drawing.Size(200, 22);
            this.dtp_failuredate.TabIndex = 3;
            // 
            // gridViewFailures
            // 
            this.gridViewFailures.AutoGenerateColumns = false;
            this.gridViewFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewFailures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFailureDataGridViewTextBoxColumn,
            this.idProcesDataGridViewTextBoxColumn,
            this.specificationDataGridViewTextBoxColumn,
            this.failureDateDataGridViewTextBoxColumn,
            this.failureMaintenancesDataGridViewTextBoxColumn,
            this.productionProceDataGridViewTextBoxColumn});
            this.gridViewFailures.DataSource = this.failureBindingSource;
            this.gridViewFailures.Location = new System.Drawing.Point(12, 12);
            this.gridViewFailures.Name = "gridViewFailures";
            this.gridViewFailures.RowTemplate.Height = 24;
            this.gridViewFailures.Size = new System.Drawing.Size(524, 267);
            this.gridViewFailures.TabIndex = 4;
            // 
            // idFailureDataGridViewTextBoxColumn
            // 
            this.idFailureDataGridViewTextBoxColumn.DataPropertyName = "IdFailure";
            this.idFailureDataGridViewTextBoxColumn.HeaderText = "IdFailure";
            this.idFailureDataGridViewTextBoxColumn.Name = "idFailureDataGridViewTextBoxColumn";
            // 
            // idProcesDataGridViewTextBoxColumn
            // 
            this.idProcesDataGridViewTextBoxColumn.DataPropertyName = "IdProces";
            this.idProcesDataGridViewTextBoxColumn.HeaderText = "IdProces";
            this.idProcesDataGridViewTextBoxColumn.Name = "idProcesDataGridViewTextBoxColumn";
            // 
            // specificationDataGridViewTextBoxColumn
            // 
            this.specificationDataGridViewTextBoxColumn.DataPropertyName = "Specification";
            this.specificationDataGridViewTextBoxColumn.HeaderText = "Specification";
            this.specificationDataGridViewTextBoxColumn.Name = "specificationDataGridViewTextBoxColumn";
            // 
            // failureDateDataGridViewTextBoxColumn
            // 
            this.failureDateDataGridViewTextBoxColumn.DataPropertyName = "FailureDate";
            this.failureDateDataGridViewTextBoxColumn.HeaderText = "FailureDate";
            this.failureDateDataGridViewTextBoxColumn.Name = "failureDateDataGridViewTextBoxColumn";
            // 
            // failureMaintenancesDataGridViewTextBoxColumn
            // 
            this.failureMaintenancesDataGridViewTextBoxColumn.DataPropertyName = "FailureMaintenances";
            this.failureMaintenancesDataGridViewTextBoxColumn.HeaderText = "FailureMaintenances";
            this.failureMaintenancesDataGridViewTextBoxColumn.Name = "failureMaintenancesDataGridViewTextBoxColumn";
            // 
            // productionProceDataGridViewTextBoxColumn
            // 
            this.productionProceDataGridViewTextBoxColumn.DataPropertyName = "ProductionProce";
            this.productionProceDataGridViewTextBoxColumn.HeaderText = "ProductionProce";
            this.productionProceDataGridViewTextBoxColumn.Name = "productionProceDataGridViewTextBoxColumn";
            // 
            // failureBindingSource
            // 
            this.failureBindingSource.DataSource = typeof(KWZP2019.Failure);
            // 
            // label_failuredate
            // 
            this.label_failuredate.AutoSize = true;
            this.label_failuredate.Location = new System.Drawing.Point(37, 377);
            this.label_failuredate.Name = "label_failuredate";
            this.label_failuredate.Size = new System.Drawing.Size(78, 17);
            this.label_failuredate.TabIndex = 8;
            this.label_failuredate.Text = "Data awarii";
            // 
            // productionFailuresBindingSource
            // 
            this.productionFailuresBindingSource.DataSource = typeof(KWZP2019.ProductionFailures);
            // 
            // ProductionFailures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 514);
            this.Controls.Add(this.label_failuredate);
            this.Controls.Add(this.gridViewFailures);
            this.Controls.Add(this.dtp_failuredate);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.btn_return);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductionFailures";
            this.Text = "Awarie";
            this.Load += new System.EventHandler(this.ProductionFailures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFailures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.failureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.DateTimePicker dtp_failuredate;
        private System.Windows.Forms.DataGridView gridViewFailures;
        private System.Windows.Forms.Label label_failuredate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFailureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn failureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn failureMaintenancesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionProceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource failureBindingSource;
        private System.Windows.Forms.BindingSource productionFailuresBindingSource;
    }
}