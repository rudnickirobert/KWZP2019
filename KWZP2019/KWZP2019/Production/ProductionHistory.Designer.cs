namespace KWZP2019
{
    partial class ProductionHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productionHistoryGridView = new System.Windows.Forms.DataGridView();
            this.vProductionProcessFullDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTPickerProductionHistoryFilterLower = new System.Windows.Forms.DateTimePicker();
            this.dTPickerProductionHistoryFilterUpper = new System.Windows.Forms.DateTimePicker();
            this.btnProdutionHistoryFilter = new System.Windows.Forms.Button();
            this.btnProductionHistoryFilterReset = new System.Windows.Forms.Button();
            this.radioBtnProductionHistoryFilterStart = new System.Windows.Forms.RadioButton();
            this.radioBtnProductionHistoryFilterEnd = new System.Windows.Forms.RadioButton();
            this.panelProductionhistoryRadioBtns = new System.Windows.Forms.Panel();
            this.lblProductionActualFilterBy = new System.Windows.Forms.Label();
            this.lblProductionHistoryFilterTo = new System.Windows.Forms.Label();
            this.lblProductionHistoryFilterSince = new System.Windows.Forms.Label();
            this.btnHistoryProductionBack = new System.Windows.Forms.Button();
            this.idProcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogMachineNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productionHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductionProcessFullDataBindingSource)).BeginInit();
            this.panelProductionhistoryRadioBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // productionHistoryGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.productionHistoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productionHistoryGridView.AutoGenerateColumns = false;
            this.productionHistoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.productionHistoryGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productionHistoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productionHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionHistoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProcesDataGridViewTextBoxColumn,
            this.ProductCode,
            this.Quantity,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSurnameDataGridViewTextBoxColumn,
            this.machineNameDataGridViewTextBoxColumn,
            this.catalogMachineNrDataGridViewTextBoxColumn});
            this.productionHistoryGridView.DataSource = this.vProductionProcessFullDataBindingSource;
            this.productionHistoryGridView.EnableHeadersVisualStyles = false;
            this.productionHistoryGridView.Location = new System.Drawing.Point(250, 130);
            this.productionHistoryGridView.Name = "productionHistoryGridView";
            this.productionHistoryGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.productionHistoryGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.productionHistoryGridView.Size = new System.Drawing.Size(905, 580);
            this.productionHistoryGridView.TabIndex = 0;
            // 
            // vProductionProcessFullDataBindingSource
            // 
            this.vProductionProcessFullDataBindingSource.DataSource = typeof(KWZP2019.vProductionProcessFullData);
            // 
            // dTPickerProductionHistoryFilterLower
            // 
            this.dTPickerProductionHistoryFilterLower.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dTPickerProductionHistoryFilterLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dTPickerProductionHistoryFilterLower.Location = new System.Drawing.Point(673, 43);
            this.dTPickerProductionHistoryFilterLower.Name = "dTPickerProductionHistoryFilterLower";
            this.dTPickerProductionHistoryFilterLower.Size = new System.Drawing.Size(200, 23);
            this.dTPickerProductionHistoryFilterLower.TabIndex = 1;
            // 
            // dTPickerProductionHistoryFilterUpper
            // 
            this.dTPickerProductionHistoryFilterUpper.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dTPickerProductionHistoryFilterUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dTPickerProductionHistoryFilterUpper.Location = new System.Drawing.Point(673, 94);
            this.dTPickerProductionHistoryFilterUpper.Name = "dTPickerProductionHistoryFilterUpper";
            this.dTPickerProductionHistoryFilterUpper.Size = new System.Drawing.Size(200, 23);
            this.dTPickerProductionHistoryFilterUpper.TabIndex = 2;
            // 
            // btnProdutionHistoryFilter
            // 
            this.btnProdutionHistoryFilter.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnProdutionHistoryFilter.FlatAppearance.BorderSize = 3;
            this.btnProdutionHistoryFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnProdutionHistoryFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutionHistoryFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProdutionHistoryFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProdutionHistoryFilter.Image = global::KWZP2019.Properties.Resources.icons8_filter_40;
            this.btnProdutionHistoryFilter.Location = new System.Drawing.Point(901, 14);
            this.btnProdutionHistoryFilter.Name = "btnProdutionHistoryFilter";
            this.btnProdutionHistoryFilter.Size = new System.Drawing.Size(110, 110);
            this.btnProdutionHistoryFilter.TabIndex = 3;
            this.btnProdutionHistoryFilter.Text = "Filtruj";
            this.btnProdutionHistoryFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdutionHistoryFilter.UseVisualStyleBackColor = true;
            this.btnProdutionHistoryFilter.Click += new System.EventHandler(this.btnProdutionHistoryFilter_Click);
            // 
            // btnProductionHistoryFilterReset
            // 
            this.btnProductionHistoryFilterReset.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnProductionHistoryFilterReset.FlatAppearance.BorderSize = 3;
            this.btnProductionHistoryFilterReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnProductionHistoryFilterReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductionHistoryFilterReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductionHistoryFilterReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductionHistoryFilterReset.Image = global::KWZP2019.Properties.Resources.icons8_clear_filters_40;
            this.btnProductionHistoryFilterReset.Location = new System.Drawing.Point(1041, 14);
            this.btnProductionHistoryFilterReset.Name = "btnProductionHistoryFilterReset";
            this.btnProductionHistoryFilterReset.Size = new System.Drawing.Size(110, 110);
            this.btnProductionHistoryFilterReset.TabIndex = 4;
            this.btnProductionHistoryFilterReset.Text = "Resetuj";
            this.btnProductionHistoryFilterReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductionHistoryFilterReset.UseVisualStyleBackColor = true;
            this.btnProductionHistoryFilterReset.Click += new System.EventHandler(this.btnProductionHistoryFilterReset_Click);
            // 
            // radioBtnProductionHistoryFilterStart
            // 
            this.radioBtnProductionHistoryFilterStart.AutoSize = true;
            this.radioBtnProductionHistoryFilterStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioBtnProductionHistoryFilterStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnProductionHistoryFilterStart.Location = new System.Drawing.Point(31, 27);
            this.radioBtnProductionHistoryFilterStart.Name = "radioBtnProductionHistoryFilterStart";
            this.radioBtnProductionHistoryFilterStart.Size = new System.Drawing.Size(174, 24);
            this.radioBtnProductionHistoryFilterStart.TabIndex = 5;
            this.radioBtnProductionHistoryFilterStart.Text = "Dacie rozpoczęcia";
            this.radioBtnProductionHistoryFilterStart.UseVisualStyleBackColor = true;
            // 
            // radioBtnProductionHistoryFilterEnd
            // 
            this.radioBtnProductionHistoryFilterEnd.AutoSize = true;
            this.radioBtnProductionHistoryFilterEnd.Checked = true;
            this.radioBtnProductionHistoryFilterEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioBtnProductionHistoryFilterEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioBtnProductionHistoryFilterEnd.Location = new System.Drawing.Point(31, 57);
            this.radioBtnProductionHistoryFilterEnd.Name = "radioBtnProductionHistoryFilterEnd";
            this.radioBtnProductionHistoryFilterEnd.Size = new System.Drawing.Size(178, 24);
            this.radioBtnProductionHistoryFilterEnd.TabIndex = 6;
            this.radioBtnProductionHistoryFilterEnd.TabStop = true;
            this.radioBtnProductionHistoryFilterEnd.Text = "Dacie zakończenia";
            this.radioBtnProductionHistoryFilterEnd.UseVisualStyleBackColor = true;
            // 
            // panelProductionhistoryRadioBtns
            // 
            this.panelProductionhistoryRadioBtns.BackColor = System.Drawing.Color.Transparent;
            this.panelProductionhistoryRadioBtns.Controls.Add(this.lblProductionActualFilterBy);
            this.panelProductionhistoryRadioBtns.Controls.Add(this.radioBtnProductionHistoryFilterStart);
            this.panelProductionhistoryRadioBtns.Controls.Add(this.radioBtnProductionHistoryFilterEnd);
            this.panelProductionhistoryRadioBtns.Location = new System.Drawing.Point(429, 23);
            this.panelProductionhistoryRadioBtns.Name = "panelProductionhistoryRadioBtns";
            this.panelProductionhistoryRadioBtns.Size = new System.Drawing.Size(213, 81);
            this.panelProductionhistoryRadioBtns.TabIndex = 7;
            // 
            // lblProductionActualFilterBy
            // 
            this.lblProductionActualFilterBy.AutoSize = true;
            this.lblProductionActualFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionActualFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductionActualFilterBy.ForeColor = System.Drawing.Color.White;
            this.lblProductionActualFilterBy.Location = new System.Drawing.Point(27, 0);
            this.lblProductionActualFilterBy.Name = "lblProductionActualFilterBy";
            this.lblProductionActualFilterBy.Size = new System.Drawing.Size(84, 20);
            this.lblProductionActualFilterBy.TabIndex = 12;
            this.lblProductionActualFilterBy.Text = "Filtruj po:";
            // 
            // lblProductionHistoryFilterTo
            // 
            this.lblProductionHistoryFilterTo.AutoSize = true;
            this.lblProductionHistoryFilterTo.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionHistoryFilterTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductionHistoryFilterTo.ForeColor = System.Drawing.Color.White;
            this.lblProductionHistoryFilterTo.Location = new System.Drawing.Point(673, 71);
            this.lblProductionHistoryFilterTo.Name = "lblProductionHistoryFilterTo";
            this.lblProductionHistoryFilterTo.Size = new System.Drawing.Size(32, 20);
            this.lblProductionHistoryFilterTo.TabIndex = 11;
            this.lblProductionHistoryFilterTo.Text = "Do";
            // 
            // lblProductionHistoryFilterSince
            // 
            this.lblProductionHistoryFilterSince.AutoSize = true;
            this.lblProductionHistoryFilterSince.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionHistoryFilterSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductionHistoryFilterSince.ForeColor = System.Drawing.Color.White;
            this.lblProductionHistoryFilterSince.Location = new System.Drawing.Point(673, 18);
            this.lblProductionHistoryFilterSince.Name = "lblProductionHistoryFilterSince";
            this.lblProductionHistoryFilterSince.Size = new System.Drawing.Size(32, 20);
            this.lblProductionHistoryFilterSince.TabIndex = 10;
            this.lblProductionHistoryFilterSince.Text = "Od";
            // 
            // btnHistoryProductionBack
            // 
            this.btnHistoryProductionBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnHistoryProductionBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnHistoryProductionBack.FlatAppearance.BorderSize = 3;
            this.btnHistoryProductionBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnHistoryProductionBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryProductionBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnHistoryProductionBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistoryProductionBack.Image = global::KWZP2019.Properties.Resources.icons8_return_40;
            this.btnHistoryProductionBack.Location = new System.Drawing.Point(27, 23);
            this.btnHistoryProductionBack.Name = "btnHistoryProductionBack";
            this.btnHistoryProductionBack.Size = new System.Drawing.Size(200, 120);
            this.btnHistoryProductionBack.TabIndex = 13;
            this.btnHistoryProductionBack.Text = "Powrót";
            this.btnHistoryProductionBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistoryProductionBack.UseVisualStyleBackColor = false;
            this.btnHistoryProductionBack.Click += new System.EventHandler(this.btnHistoryProductionBack_Click);
            // 
            // idProcesDataGridViewTextBoxColumn
            // 
            this.idProcesDataGridViewTextBoxColumn.DataPropertyName = "IdProces";
            this.idProcesDataGridViewTextBoxColumn.HeaderText = "Numer procesu";
            this.idProcesDataGridViewTextBoxColumn.Name = "idProcesDataGridViewTextBoxColumn";
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "ProductCode";
            this.ProductCode.HeaderText = "Kod produktu";
            this.ProductCode.Name = "ProductCode";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Ilość";
            this.Quantity.Name = "Quantity";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Czas rozpoczęcia";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Czas zakończenia";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Imię pracownika";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // employeeSurnameDataGridViewTextBoxColumn
            // 
            this.employeeSurnameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeSurname";
            this.employeeSurnameDataGridViewTextBoxColumn.HeaderText = "Nazwisko pracownika";
            this.employeeSurnameDataGridViewTextBoxColumn.Name = "employeeSurnameDataGridViewTextBoxColumn";
            // 
            // machineNameDataGridViewTextBoxColumn
            // 
            this.machineNameDataGridViewTextBoxColumn.DataPropertyName = "MachineName";
            this.machineNameDataGridViewTextBoxColumn.HeaderText = "Nazwa maszyny";
            this.machineNameDataGridViewTextBoxColumn.Name = "machineNameDataGridViewTextBoxColumn";
            // 
            // catalogMachineNrDataGridViewTextBoxColumn
            // 
            this.catalogMachineNrDataGridViewTextBoxColumn.DataPropertyName = "CatalogMachineNr";
            this.catalogMachineNrDataGridViewTextBoxColumn.HeaderText = "Numer katalogowy maszyny";
            this.catalogMachineNrDataGridViewTextBoxColumn.Name = "catalogMachineNrDataGridViewTextBoxColumn";
            // 
            // ProductionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 750);
            this.Controls.Add(this.btnHistoryProductionBack);
            this.Controls.Add(this.lblProductionHistoryFilterTo);
            this.Controls.Add(this.lblProductionHistoryFilterSince);
            this.Controls.Add(this.panelProductionhistoryRadioBtns);
            this.Controls.Add(this.btnProductionHistoryFilterReset);
            this.Controls.Add(this.btnProdutionHistoryFilter);
            this.Controls.Add(this.dTPickerProductionHistoryFilterUpper);
            this.Controls.Add(this.dTPickerProductionHistoryFilterLower);
            this.Controls.Add(this.productionHistoryGridView);
            this.MaximizeBox = false;
            this.Name = "ProductionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestr produkcji";
            this.Load += new System.EventHandler(this.ProductionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productionHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductionProcessFullDataBindingSource)).EndInit();
            this.panelProductionhistoryRadioBtns.ResumeLayout(false);
            this.panelProductionhistoryRadioBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productionHistoryGridView;
        private System.Windows.Forms.BindingSource vProductionProcessFullDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dTPickerProductionHistoryFilterLower;
        private System.Windows.Forms.DateTimePicker dTPickerProductionHistoryFilterUpper;
        private System.Windows.Forms.Button btnProdutionHistoryFilter;
        private System.Windows.Forms.Button btnProductionHistoryFilterReset;
        private System.Windows.Forms.RadioButton radioBtnProductionHistoryFilterStart;
        private System.Windows.Forms.RadioButton radioBtnProductionHistoryFilterEnd;
        private System.Windows.Forms.Panel panelProductionhistoryRadioBtns;
        private System.Windows.Forms.Label lblProductionHistoryFilterTo;
        private System.Windows.Forms.Label lblProductionHistoryFilterSince;
        private System.Windows.Forms.Label lblProductionActualFilterBy;
        private System.Windows.Forms.Button btnHistoryProductionBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogMachineNrDataGridViewTextBoxColumn;
    }
}