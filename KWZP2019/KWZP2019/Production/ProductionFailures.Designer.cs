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
            this.gridViewFailures = new System.Windows.Forms.DataGridView();
            this.failureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionFailuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionProcessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failureBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFailures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.failureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.failureBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(12, 293);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(101, 42);
            this.btn_return.TabIndex = 0;
            this.btn_return.Text = "Powrót";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // gridViewFailures
            // 
            this.gridViewFailures.AutoGenerateColumns = false;
            this.gridViewFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewFailures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.productionProcessDataGridViewTextBoxColumn});
            this.gridViewFailures.DataSource = this.failureBindingSource1;
            this.gridViewFailures.Location = new System.Drawing.Point(12, 12);
            this.gridViewFailures.Name = "gridViewFailures";
            this.gridViewFailures.RowTemplate.Height = 24;
            this.gridViewFailures.Size = new System.Drawing.Size(475, 264);
            this.gridViewFailures.TabIndex = 4;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(377, 293);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 42);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Dodaj";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdFailure";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numer awarii";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 111;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdProces";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numer procesu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Specification";
            this.dataGridViewTextBoxColumn3.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FailureDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data awarii";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FailureMaintenances";
            this.dataGridViewTextBoxColumn5.HeaderText = "FailureMaintenances";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // productionProcessDataGridViewTextBoxColumn
            // 
            this.productionProcessDataGridViewTextBoxColumn.DataPropertyName = "ProductionProcess";
            this.productionProcessDataGridViewTextBoxColumn.HeaderText = "ProductionProcess";
            this.productionProcessDataGridViewTextBoxColumn.Name = "productionProcessDataGridViewTextBoxColumn";
            this.productionProcessDataGridViewTextBoxColumn.Visible = false;
            // 
            // failureBindingSource1
            // 
            this.failureBindingSource1.DataSource = typeof(KWZP2019.Failure);
            // 
            // ProductionFailures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 354);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.gridViewFailures);
            this.Controls.Add(this.btn_return);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductionFailures";
            this.Text = "Awarie";
            this.Load += new System.EventHandler(this.ProductionFailures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFailures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.failureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.failureBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.DataGridView gridViewFailures;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFailureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn failureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn failureMaintenancesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionProceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource failureBindingSource;
        private System.Windows.Forms.BindingSource productionFailuresBindingSource;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionProcessDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource failureBindingSource1;
    }
}