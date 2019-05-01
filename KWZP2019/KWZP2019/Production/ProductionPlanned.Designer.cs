namespace KWZP2019
{
    partial class ProductionPlanned
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
            this.PlannedProductionGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPlanSearch = new System.Windows.Forms.TextBox();
            this.btnAddPlan = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefreshPlanList = new System.Windows.Forms.Button();
            this.plannedProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PlannedProductionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlannedProductionGridView
            // 
            this.PlannedProductionGridView.AutoGenerateColumns = false;
            this.PlannedProductionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlannedProductionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.maintenanceDataGridViewTextBoxColumn});
            this.PlannedProductionGridView.DataSource = this.plannedProductionBindingSource;
            this.PlannedProductionGridView.Location = new System.Drawing.Point(12, 119);
            this.PlannedProductionGridView.Name = "PlannedProductionGridView";
            this.PlannedProductionGridView.RowTemplate.Height = 24;
            this.PlannedProductionGridView.Size = new System.Drawing.Size(1043, 316);
            this.PlannedProductionGridView.TabIndex = 0;
            this.PlannedProductionGridView.SelectionChanged += new System.EventHandler(this.PlannedProductionGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Szukaj planu:";
            // 
            // txtBoxPlanSearch
            // 
            this.txtBoxPlanSearch.Location = new System.Drawing.Point(486, 70);
            this.txtBoxPlanSearch.Name = "txtBoxPlanSearch";
            this.txtBoxPlanSearch.Size = new System.Drawing.Size(166, 22);
            this.txtBoxPlanSearch.TabIndex = 2;
            this.txtBoxPlanSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPlanSearch_KeyPress);
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.Location = new System.Drawing.Point(12, 62);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(215, 39);
            this.btnAddPlan.TabIndex = 3;
            this.btnAddPlan.Text = "Nowy plan /edytuj plan";
            this.btnAddPlan.UseVisualStyleBackColor = true;
            this.btnAddPlan.Click += new System.EventHandler(this.btnAddPlan_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(445, 448);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(126, 39);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "POWRÓT";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefreshPlanList
            // 
            this.btnRefreshPlanList.Location = new System.Drawing.Point(690, 65);
            this.btnRefreshPlanList.Name = "btnRefreshPlanList";
            this.btnRefreshPlanList.Size = new System.Drawing.Size(129, 39);
            this.btnRefreshPlanList.TabIndex = 9;
            this.btnRefreshPlanList.Text = "Odśwież listę";
            this.btnRefreshPlanList.UseVisualStyleBackColor = true;
            this.btnRefreshPlanList.Click += new System.EventHandler(this.btnRefreshPlanList_Click);
            // 
            // plannedProductionBindingSource
            // 
            this.plannedProductionBindingSource.DataSource = typeof(KWZP2019.PlannedProduction);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPlan";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numer planu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdDetail";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numer szczegółu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdMachine";
            this.dataGridViewTextBoxColumn3.HeaderText = "Maszyna";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PlannedStartd";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data początku";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PlannedEndd";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data zakończenia";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Inproduction";
            this.dataGridViewTextBoxColumn6.HeaderText = "Przekazano do produckji";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OrderDetail";
            this.dataGridViewTextBoxColumn7.HeaderText = "OrderDetail";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OrderDetail1";
            this.dataGridViewTextBoxColumn8.HeaderText = "OrderDetail1";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PlannedProductionEmployeeDetails";
            this.dataGridViewTextBoxColumn9.HeaderText = "PlannedProductionEmployeeDetails";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ProductionProces";
            this.dataGridViewTextBoxColumn10.HeaderText = "ProductionProces";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // maintenanceDataGridViewTextBoxColumn
            // 
            this.maintenanceDataGridViewTextBoxColumn.DataPropertyName = "Maintenance";
            this.maintenanceDataGridViewTextBoxColumn.HeaderText = "Maintenance";
            this.maintenanceDataGridViewTextBoxColumn.Name = "maintenanceDataGridViewTextBoxColumn";
            this.maintenanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // ProductionPlanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 499);
            this.Controls.Add(this.btnRefreshPlanList);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddPlan);
            this.Controls.Add(this.txtBoxPlanSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlannedProductionGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductionPlanned";
            this.Text = "Planowana produkcja";
            this.Load += new System.EventHandler(this.ProductionPlanned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlannedProductionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlannedProductionGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMachineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedStartdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedEnddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inproductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetail1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedProductionEmployeeDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionProcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPlanSearch;
        private System.Windows.Forms.Button btnAddPlan;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefreshPlanList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource plannedProductionBindingSource;
    }
}