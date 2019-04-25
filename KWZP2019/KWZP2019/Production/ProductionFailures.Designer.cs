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
            this.dgv_failures = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label_failuredate = new System.Windows.Forms.Label();
            this.productionFailuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.failureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idFailureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failureMaintenancesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionProceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_failures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.failureBindingSource)).BeginInit();
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
            // dgv_failures
            // 
            this.dgv_failures.AutoGenerateColumns = false;
            this.dgv_failures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_failures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFailureDataGridViewTextBoxColumn,
            this.idProcesDataGridViewTextBoxColumn,
            this.specificationDataGridViewTextBoxColumn,
            this.failureDateDataGridViewTextBoxColumn,
            this.failureMaintenancesDataGridViewTextBoxColumn,
            this.productionProceDataGridViewTextBoxColumn});
            this.dgv_failures.DataSource = this.failureBindingSource;
            this.dgv_failures.Location = new System.Drawing.Point(12, 12);
            this.dgv_failures.Name = "dgv_failures";
            this.dgv_failures.RowTemplate.Height = 24;
            this.dgv_failures.Size = new System.Drawing.Size(524, 267);
            this.dgv_failures.TabIndex = 4;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(221, 429);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 42);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Usuń";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(328, 429);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 42);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Dodaj";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(435, 429);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 42);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Zapisz";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            // failureBindingSource
            // 
            this.failureBindingSource.DataSource = typeof(KWZP2019.Failure);
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
            // ProductionFailures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 514);
            this.Controls.Add(this.label_failuredate);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_failures);
            this.Controls.Add(this.dtp_failuredate);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.btn_return);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductionFailures";
            this.Text = "Awarie";
            this.Load += new System.EventHandler(this.ProductionFailures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_failures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.failureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.DateTimePicker dtp_failuredate;
        private System.Windows.Forms.DataGridView dgv_failures;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
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