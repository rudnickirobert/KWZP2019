﻿namespace KWZP2019
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPlanSearch = new System.Windows.Forms.TextBox();
            this.btnAddPlan = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefreshPlanList = new System.Windows.Forms.Button();
            this.txtBoxDetailSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlannedProductionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlannedProductionGridView
            // 
            this.PlannedProductionGridView.AutoGenerateColumns = false;
            this.PlannedProductionGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlannedProductionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlannedProductionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.maintenanceDataGridViewTextBoxColumn});
            this.PlannedProductionGridView.DataSource = this.plannedProductionBindingSource;
            this.PlannedProductionGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlannedProductionGridView.Location = new System.Drawing.Point(9, 125);
            this.PlannedProductionGridView.Margin = new System.Windows.Forms.Padding(2);
            this.PlannedProductionGridView.Name = "PlannedProductionGridView";
            this.PlannedProductionGridView.RowTemplate.Height = 24;
            this.PlannedProductionGridView.Size = new System.Drawing.Size(782, 257);
            this.PlannedProductionGridView.TabIndex = 0;
            this.PlannedProductionGridView.SelectionChanged += new System.EventHandler(this.PlannedProductionGridView_SelectionChanged);
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PlannedProductionEmployeeDetails";
            this.dataGridViewTextBoxColumn9.HeaderText = "PlannedProductionEmployeeDetails";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // maintenanceDataGridViewTextBoxColumn
            // 
            this.maintenanceDataGridViewTextBoxColumn.DataPropertyName = "Maintenance";
            this.maintenanceDataGridViewTextBoxColumn.HeaderText = "Maintenance";
            this.maintenanceDataGridViewTextBoxColumn.Name = "maintenanceDataGridViewTextBoxColumn";
            this.maintenanceDataGridViewTextBoxColumn.Visible = false;
            // 
            // plannedProductionBindingSource
            // 
            this.plannedProductionBindingSource.DataSource = typeof(KWZP2019.PlannedProduction);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(238, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Szukaj planu:";
            // 
            // txtBoxPlanSearch
            // 
            this.txtBoxPlanSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxPlanSearch.Location = new System.Drawing.Point(241, 60);
            this.txtBoxPlanSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPlanSearch.Name = "txtBoxPlanSearch";
            this.txtBoxPlanSearch.Size = new System.Drawing.Size(126, 26);
            this.txtBoxPlanSearch.TabIndex = 2;
            this.txtBoxPlanSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPlanSearch_KeyPress);
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAddPlan.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddPlan.FlatAppearance.BorderSize = 3;
            this.btnAddPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnAddPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPlan.Image = global::KWZP2019.Properties.Resources.icons8_pencil_80;
            this.btnAddPlan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPlan.Location = new System.Drawing.Point(9, 10);
            this.btnAddPlan.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(208, 110);
            this.btnAddPlan.TabIndex = 3;
            this.btnAddPlan.Text = "Nowy plan /edytuj plan";
            this.btnAddPlan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPlan.UseVisualStyleBackColor = false;
            this.btnAddPlan.Click += new System.EventHandler(this.btnAddPlan_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.BackgroundImage = global::KWZP2019.Properties.Resources.icons8_return_40;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(346, 387);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(72, 68);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefreshPlanList
            // 
            this.btnRefreshPlanList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefreshPlanList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnRefreshPlanList.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnRefreshPlanList.FlatAppearance.BorderSize = 3;
            this.btnRefreshPlanList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnRefreshPlanList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPlanList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefreshPlanList.ForeColor = System.Drawing.Color.White;
            this.btnRefreshPlanList.Image = global::KWZP2019.Properties.Resources.icons8_repeat_80;
            this.btnRefreshPlanList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefreshPlanList.Location = new System.Drawing.Point(591, 10);
            this.btnRefreshPlanList.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshPlanList.Name = "btnRefreshPlanList";
            this.btnRefreshPlanList.Size = new System.Drawing.Size(200, 110);
            this.btnRefreshPlanList.TabIndex = 9;
            this.btnRefreshPlanList.Text = "Odśwież listę";
            this.btnRefreshPlanList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefreshPlanList.UseVisualStyleBackColor = false;
            this.btnRefreshPlanList.Click += new System.EventHandler(this.btnRefreshPlanList_Click);
            // 
            // txtBoxDetailSearch
            // 
            this.txtBoxDetailSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxDetailSearch.Location = new System.Drawing.Point(427, 60);
            this.txtBoxDetailSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDetailSearch.Name = "txtBoxDetailSearch";
            this.txtBoxDetailSearch.Size = new System.Drawing.Size(126, 26);
            this.txtBoxDetailSearch.TabIndex = 11;
            this.txtBoxDetailSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDetailSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(423, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Szukaj szczególu:";
            // 
            // ProductionPlanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.txtBoxDetailSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefreshPlanList);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddPlan);
            this.Controls.Add(this.txtBoxPlanSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlannedProductionGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
        private System.Windows.Forms.TextBox txtBoxDetailSearch;
        private System.Windows.Forms.Label label2;
    }
}