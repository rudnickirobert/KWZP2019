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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_return = new System.Windows.Forms.Button();
            this.gridViewFailures = new System.Windows.Forms.DataGridView();
            this.failureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionFailuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_add = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
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
            this.btn_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btn_return.BackgroundImage = global::KWZP2019.Properties.Resources.powrott;
            this.btn_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_return.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_return.Location = new System.Drawing.Point(12, 391);
            this.btn_return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(213, 135);
            this.btn_return.TabIndex = 0;
            this.btn_return.Text = "Powrót";
            this.btn_return.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_return.UseVisualStyleBackColor = false;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // gridViewFailures
            // 
            this.gridViewFailures.AutoGenerateColumns = false;
            this.gridViewFailures.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewFailures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewFailures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.productionProcessDataGridViewTextBoxColumn});
            this.gridViewFailures.DataSource = this.failureBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewFailures.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewFailures.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridViewFailures.Location = new System.Drawing.Point(12, 12);
            this.gridViewFailures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridViewFailures.Name = "gridViewFailures";
            this.gridViewFailures.RowTemplate.Height = 24;
            this.gridViewFailures.Size = new System.Drawing.Size(705, 348);
            this.gridViewFailures.TabIndex = 4;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.button_add.BackgroundImage = global::KWZP2019.Properties.Resources.addp;
            this.button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_add.Location = new System.Drawing.Point(504, 391);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(213, 135);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Dodaj";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.button_Refresh.BackgroundImage = global::KWZP2019.Properties.Resources.refreshp;
            this.button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Refresh.Location = new System.Drawing.Point(259, 391);
            this.button_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(213, 135);
            this.button_Refresh.TabIndex = 10;
            this.button_Refresh.Text = "Odśwież";
            this.button_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdFailure";
            this.dataGridViewTextBoxColumn1.HeaderText = "Numer awarii";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdProces";
            this.dataGridViewTextBoxColumn2.HeaderText = "Numer procesu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Specification";
            this.dataGridViewTextBoxColumn3.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.ClientSize = new System.Drawing.Size(735, 537);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.gridViewFailures);
            this.Controls.Add(this.btn_return);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.BindingSource failureBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionProcessDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_Refresh;
    }
}