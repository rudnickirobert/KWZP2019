namespace KWZP2019
{
    partial class ProductionProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionProcess));
            this.ProductionProcessGridView = new System.Windows.Forms.DataGridView();
            this.dTPickerProductionActualFilterLower = new System.Windows.Forms.DateTimePicker();
            this.dTPickerProductionActualFilterUpper = new System.Windows.Forms.DateTimePicker();
            this.btnProductionActualFilter = new System.Windows.Forms.Button();
            this.btnProductionActualResetFilter = new System.Windows.Forms.Button();
            this.radioBtnActualProductionFilterEnd = new System.Windows.Forms.RadioButton();
            this.radioBtnActualProductionFilterStart = new System.Windows.Forms.RadioButton();
            this.panelActualProductionRadioBtns = new System.Windows.Forms.Panel();
            this.lblProductionActualFilterBy = new System.Windows.Forms.Label();
            this.lblProductionActualFilterSince = new System.Windows.Forms.Label();
            this.lblProductionActualFilterTo = new System.Windows.Forms.Label();
            this.btnActualProductionBack = new System.Windows.Forms.Button();
            this.vProductionProcessFullDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogMachineNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductionProcessGridView)).BeginInit();
            this.panelActualProductionRadioBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vProductionProcessFullDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductionProcessGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ProductionProcessGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductionProcessGridView.AutoGenerateColumns = false;
            this.ProductionProcessGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.ProductionProcessGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductionProcessGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductionProcessGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductionProcessGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProcesDataGridViewTextBoxColumn,
            this.ProductCode,
            this.Quantity,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSurnameDataGridViewTextBoxColumn,
            this.machineNameDataGridViewTextBoxColumn,
            this.catalogMachineNrDataGridViewTextBoxColumn});
            this.ProductionProcessGridView.DataSource = this.vProductionProcessFullDataBindingSource;
            this.ProductionProcessGridView.EnableHeadersVisualStyles = false;
            this.ProductionProcessGridView.Location = new System.Drawing.Point(250, 130);
            this.ProductionProcessGridView.Name = "ProductionProcessGridView";
            this.ProductionProcessGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ProductionProcessGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductionProcessGridView.Size = new System.Drawing.Size(905, 580);
            this.ProductionProcessGridView.TabIndex = 0;
            // 
            // dTPickerProductionActualFilterLower
            // 
            this.dTPickerProductionActualFilterLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dTPickerProductionActualFilterLower.Location = new System.Drawing.Point(673, 43);
            this.dTPickerProductionActualFilterLower.Name = "dTPickerProductionActualFilterLower";
            this.dTPickerProductionActualFilterLower.Size = new System.Drawing.Size(200, 23);
            this.dTPickerProductionActualFilterLower.TabIndex = 1;
            // 
            // dTPickerProductionActualFilterUpper
            // 
            this.dTPickerProductionActualFilterUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dTPickerProductionActualFilterUpper.Location = new System.Drawing.Point(673, 94);
            this.dTPickerProductionActualFilterUpper.Name = "dTPickerProductionActualFilterUpper";
            this.dTPickerProductionActualFilterUpper.Size = new System.Drawing.Size(200, 23);
            this.dTPickerProductionActualFilterUpper.TabIndex = 2;
            // 
            // btnProductionActualFilter
            // 
            this.btnProductionActualFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnProductionActualFilter.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnProductionActualFilter.FlatAppearance.BorderSize = 3;
            this.btnProductionActualFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnProductionActualFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductionActualFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductionActualFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductionActualFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnProductionActualFilter.Image")));
            this.btnProductionActualFilter.Location = new System.Drawing.Point(901, 14);
            this.btnProductionActualFilter.Name = "btnProductionActualFilter";
            this.btnProductionActualFilter.Size = new System.Drawing.Size(110, 110);
            this.btnProductionActualFilter.TabIndex = 3;
            this.btnProductionActualFilter.Text = "Filtruj";
            this.btnProductionActualFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductionActualFilter.UseVisualStyleBackColor = false;
            this.btnProductionActualFilter.Click += new System.EventHandler(this.btnProductionActualFilter_Click);
            // 
            // btnProductionActualResetFilter
            // 
            this.btnProductionActualResetFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnProductionActualResetFilter.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnProductionActualResetFilter.FlatAppearance.BorderSize = 3;
            this.btnProductionActualResetFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnProductionActualResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductionActualResetFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductionActualResetFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductionActualResetFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnProductionActualResetFilter.Image")));
            this.btnProductionActualResetFilter.Location = new System.Drawing.Point(1041, 14);
            this.btnProductionActualResetFilter.Name = "btnProductionActualResetFilter";
            this.btnProductionActualResetFilter.Size = new System.Drawing.Size(110, 110);
            this.btnProductionActualResetFilter.TabIndex = 4;
            this.btnProductionActualResetFilter.Text = "Resetuj";
            this.btnProductionActualResetFilter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductionActualResetFilter.UseVisualStyleBackColor = false;
            this.btnProductionActualResetFilter.Click += new System.EventHandler(this.btnProductionActualResetFilter_Click);
            // 
            // radioBtnActualProductionFilterEnd
            // 
            this.radioBtnActualProductionFilterEnd.AutoSize = true;
            this.radioBtnActualProductionFilterEnd.Checked = true;
            this.radioBtnActualProductionFilterEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioBtnActualProductionFilterEnd.ForeColor = System.Drawing.Color.Transparent;
            this.radioBtnActualProductionFilterEnd.Location = new System.Drawing.Point(31, 57);
            this.radioBtnActualProductionFilterEnd.Name = "radioBtnActualProductionFilterEnd";
            this.radioBtnActualProductionFilterEnd.Size = new System.Drawing.Size(178, 24);
            this.radioBtnActualProductionFilterEnd.TabIndex = 6;
            this.radioBtnActualProductionFilterEnd.TabStop = true;
            this.radioBtnActualProductionFilterEnd.Text = "Dacie zakończenia";
            this.radioBtnActualProductionFilterEnd.UseVisualStyleBackColor = true;
            // 
            // radioBtnActualProductionFilterStart
            // 
            this.radioBtnActualProductionFilterStart.AutoSize = true;
            this.radioBtnActualProductionFilterStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioBtnActualProductionFilterStart.ForeColor = System.Drawing.Color.Transparent;
            this.radioBtnActualProductionFilterStart.Location = new System.Drawing.Point(31, 27);
            this.radioBtnActualProductionFilterStart.Name = "radioBtnActualProductionFilterStart";
            this.radioBtnActualProductionFilterStart.Size = new System.Drawing.Size(174, 24);
            this.radioBtnActualProductionFilterStart.TabIndex = 5;
            this.radioBtnActualProductionFilterStart.Text = "Dacie rozpoczęcia";
            this.radioBtnActualProductionFilterStart.UseVisualStyleBackColor = true;
            // 
            // panelActualProductionRadioBtns
            // 
            this.panelActualProductionRadioBtns.BackColor = System.Drawing.Color.Transparent;
            this.panelActualProductionRadioBtns.Controls.Add(this.lblProductionActualFilterBy);
            this.panelActualProductionRadioBtns.Controls.Add(this.radioBtnActualProductionFilterStart);
            this.panelActualProductionRadioBtns.Controls.Add(this.radioBtnActualProductionFilterEnd);
            this.panelActualProductionRadioBtns.Location = new System.Drawing.Point(429, 23);
            this.panelActualProductionRadioBtns.Name = "panelActualProductionRadioBtns";
            this.panelActualProductionRadioBtns.Size = new System.Drawing.Size(213, 100);
            this.panelActualProductionRadioBtns.TabIndex = 7;
            // 
            // lblProductionActualFilterBy
            // 
            this.lblProductionActualFilterBy.AutoSize = true;
            this.lblProductionActualFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductionActualFilterBy.ForeColor = System.Drawing.Color.White;
            this.lblProductionActualFilterBy.Location = new System.Drawing.Point(27, 0);
            this.lblProductionActualFilterBy.Name = "lblProductionActualFilterBy";
            this.lblProductionActualFilterBy.Size = new System.Drawing.Size(84, 20);
            this.lblProductionActualFilterBy.TabIndex = 7;
            this.lblProductionActualFilterBy.Text = "Filtruj po:";
            // 
            // lblProductionActualFilterSince
            // 
            this.lblProductionActualFilterSince.AutoSize = true;
            this.lblProductionActualFilterSince.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionActualFilterSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductionActualFilterSince.ForeColor = System.Drawing.Color.White;
            this.lblProductionActualFilterSince.Location = new System.Drawing.Point(673, 18);
            this.lblProductionActualFilterSince.Name = "lblProductionActualFilterSince";
            this.lblProductionActualFilterSince.Size = new System.Drawing.Size(32, 20);
            this.lblProductionActualFilterSince.TabIndex = 8;
            this.lblProductionActualFilterSince.Text = "Od";
            // 
            // lblProductionActualFilterTo
            // 
            this.lblProductionActualFilterTo.AutoSize = true;
            this.lblProductionActualFilterTo.BackColor = System.Drawing.Color.Transparent;
            this.lblProductionActualFilterTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductionActualFilterTo.ForeColor = System.Drawing.Color.White;
            this.lblProductionActualFilterTo.Location = new System.Drawing.Point(673, 71);
            this.lblProductionActualFilterTo.Name = "lblProductionActualFilterTo";
            this.lblProductionActualFilterTo.Size = new System.Drawing.Size(32, 20);
            this.lblProductionActualFilterTo.TabIndex = 9;
            this.lblProductionActualFilterTo.Text = "Do";
            // 
            // btnActualProductionBack
            // 
            this.btnActualProductionBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnActualProductionBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnActualProductionBack.FlatAppearance.BorderSize = 3;
            this.btnActualProductionBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnActualProductionBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualProductionBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnActualProductionBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualProductionBack.Image = global::KWZP2019.Properties.Resources.icons8_return_40;
            this.btnActualProductionBack.Location = new System.Drawing.Point(27, 23);
            this.btnActualProductionBack.Name = "btnActualProductionBack";
            this.btnActualProductionBack.Size = new System.Drawing.Size(200, 120);
            this.btnActualProductionBack.TabIndex = 10;
            this.btnActualProductionBack.Text = "Powrót";
            this.btnActualProductionBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualProductionBack.UseVisualStyleBackColor = false;
            this.btnActualProductionBack.Click += new System.EventHandler(this.btnActualProductionBack_Click);
            // 
            // vProductionProcessFullDataBindingSource
            // 
            this.vProductionProcessFullDataBindingSource.DataSource = typeof(KWZP2019.vProductionProcessFullData);
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
            // ProductionProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnActualProductionBack);
            this.Controls.Add(this.lblProductionActualFilterTo);
            this.Controls.Add(this.lblProductionActualFilterSince);
            this.Controls.Add(this.panelActualProductionRadioBtns);
            this.Controls.Add(this.btnProductionActualResetFilter);
            this.Controls.Add(this.btnProductionActualFilter);
            this.Controls.Add(this.dTPickerProductionActualFilterUpper);
            this.Controls.Add(this.dTPickerProductionActualFilterLower);
            this.Controls.Add(this.ProductionProcessGridView);
            this.MaximizeBox = false;
            this.Name = "ProductionProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W produkcji";
            this.Load += new System.EventHandler(this.ProductionProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductionProcessGridView)).EndInit();
            this.panelActualProductionRadioBtns.ResumeLayout(false);
            this.panelActualProductionRadioBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vProductionProcessFullDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductionProcessGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vProductionProcessFullDataBindingSource;
        private System.Windows.Forms.DateTimePicker dTPickerProductionActualFilterLower;
        private System.Windows.Forms.DateTimePicker dTPickerProductionActualFilterUpper;
        private System.Windows.Forms.Button btnProductionActualFilter;
        private System.Windows.Forms.Button btnProductionActualResetFilter;
        private System.Windows.Forms.RadioButton radioBtnActualProductionFilterEnd;
        private System.Windows.Forms.RadioButton radioBtnActualProductionFilterStart;
        private System.Windows.Forms.Panel panelActualProductionRadioBtns;
        private System.Windows.Forms.Label lblProductionActualFilterBy;
        private System.Windows.Forms.Label lblProductionActualFilterSince;
        private System.Windows.Forms.Label lblProductionActualFilterTo;
        private System.Windows.Forms.Button btnActualProductionBack;
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