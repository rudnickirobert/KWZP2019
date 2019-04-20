﻿namespace KWZP2019
{
    partial class NewProductionPlan
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
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cBoxIntoProduction = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.viewProcessEmpl = new System.Windows.Forms.DataGridView();
            this.idDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionEmployeeDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOperators = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewProcessEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionEmployeeDetailBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(590, 21);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(91, 34);
            this.btnAddEmp.TabIndex = 0;
            this.btnAddEmp.Text = "DODAJ";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szczegół zamówienia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Przydzielona maszyna";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(226, 176);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data zamówienia";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(477, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Szacowana data realizacji";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(226, 284);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(162, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numer planu produkcji:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "ZAPISZ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(56, 427);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 34);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "POWRÓT";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cBoxIntoProduction
            // 
            this.cBoxIntoProduction.AutoSize = true;
            this.cBoxIntoProduction.Location = new System.Drawing.Point(226, 330);
            this.cBoxIntoProduction.Name = "cBoxIntoProduction";
            this.cBoxIntoProduction.Size = new System.Drawing.Size(18, 17);
            this.cBoxIntoProduction.TabIndex = 15;
            this.cBoxIntoProduction.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Przekazano do produkcji?";
            // 
            // viewProcessEmpl
            // 
            this.viewProcessEmpl.AutoGenerateColumns = false;
            this.viewProcessEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProcessEmpl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetailDataGridViewTextBoxColumn,
            this.idProcesDataGridViewTextBoxColumn,
            this.idEmployeeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.plannedProductionDataGridViewTextBoxColumn,
            this.allocationDataGridViewTextBoxColumn});
            this.viewProcessEmpl.DataSource = this.plannedProductionEmployeeDetailBindingSource;
            this.viewProcessEmpl.Location = new System.Drawing.Point(432, 123);
            this.viewProcessEmpl.Name = "viewProcessEmpl";
            this.viewProcessEmpl.RowTemplate.Height = 24;
            this.viewProcessEmpl.Size = new System.Drawing.Size(520, 223);
            this.viewProcessEmpl.TabIndex = 17;
            // 
            // idDetailDataGridViewTextBoxColumn
            // 
            this.idDetailDataGridViewTextBoxColumn.DataPropertyName = "IdDetail";
            this.idDetailDataGridViewTextBoxColumn.HeaderText = "IdDetail";
            this.idDetailDataGridViewTextBoxColumn.Name = "idDetailDataGridViewTextBoxColumn";
            this.idDetailDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProcesDataGridViewTextBoxColumn
            // 
            this.idProcesDataGridViewTextBoxColumn.DataPropertyName = "IdProces";
            this.idProcesDataGridViewTextBoxColumn.HeaderText = "IdProces";
            this.idProcesDataGridViewTextBoxColumn.Name = "idProcesDataGridViewTextBoxColumn";
            this.idProcesDataGridViewTextBoxColumn.Visible = false;
            // 
            // idEmployeeDataGridViewTextBoxColumn
            // 
            this.idEmployeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEmployeeDataGridViewTextBoxColumn.DataPropertyName = "IdEmployee";
            this.idEmployeeDataGridViewTextBoxColumn.HeaderText = "IdEmployee";
            this.idEmployeeDataGridViewTextBoxColumn.Name = "idEmployeeDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // plannedProductionDataGridViewTextBoxColumn
            // 
            this.plannedProductionDataGridViewTextBoxColumn.DataPropertyName = "PlannedProduction";
            this.plannedProductionDataGridViewTextBoxColumn.HeaderText = "PlannedProduction";
            this.plannedProductionDataGridViewTextBoxColumn.Name = "plannedProductionDataGridViewTextBoxColumn";
            this.plannedProductionDataGridViewTextBoxColumn.Visible = false;
            // 
            // allocationDataGridViewTextBoxColumn
            // 
            this.allocationDataGridViewTextBoxColumn.DataPropertyName = "Allocation";
            this.allocationDataGridViewTextBoxColumn.HeaderText = "Allocation";
            this.allocationDataGridViewTextBoxColumn.Name = "allocationDataGridViewTextBoxColumn";
            this.allocationDataGridViewTextBoxColumn.Visible = false;
            // 
            // plannedProductionEmployeeDetailBindingSource
            // 
            this.plannedProductionEmployeeDetailBindingSource.DataSource = typeof(KWZP2019.PlannedProductionEmployeeDetail);
            // 
            // lblOperators
            // 
            this.lblOperators.AutoSize = true;
            this.lblOperators.Location = new System.Drawing.Point(429, 92);
            this.lblOperators.Name = "lblOperators";
            this.lblOperators.Size = new System.Drawing.Size(158, 17);
            this.lblOperators.TabIndex = 18;
            this.lblOperators.Text = "Przydzieleni pracownicy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.dateTimePicker4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.btnAddEmp);
            this.groupBox1.Location = new System.Drawing.Point(226, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie pracowników";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(590, 59);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 34);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "USUŃ";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(346, 66);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker4.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Data zakończenia";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(346, 38);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data rozpoczęcia";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 59);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(194, 24);
            this.comboBox3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pracownik";
            // 
            // NewProductionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOperators);
            this.Controls.Add(this.viewProcessEmpl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxIntoProduction);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "NewProductionPlan";
            this.Text = "NewProductionPlan";
            this.Load += new System.EventHandler(this.NewProductionPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProcessEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionEmployeeDetailBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.CheckBox cBoxIntoProduction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView viewProcessEmpl;
        private System.Windows.Forms.BindingSource plannedProductionEmployeeDetailBindingSource;
        private System.Windows.Forms.Label lblOperators;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedProductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
    }
}