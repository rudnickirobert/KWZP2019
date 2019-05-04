namespace KWZP2019
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMachine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxPlanNr = new System.Windows.Forms.TextBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.dateTimeEmployeeEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeEmployeeStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.btnNewPlan = new System.Windows.Forms.Button();
            this.viewOrderDetail = new System.Windows.Forms.DataGridView();
            this.idDetailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnhandledOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btnEndDateCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewProcessEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionEmployeeDetailBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUnhandledOrderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddEmployee.FlatAppearance.BorderSize = 3;
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Image = global::KWZP2019.Properties.Resources.icons8_add_user_male_40;
            this.btnAddEmployee.Location = new System.Drawing.Point(583, 17);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(91, 55);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szczegół zamówienia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Przydzielona maszyna";
            // 
            // comboBoxMachine
            // 
            this.comboBoxMachine.FormattingEnabled = true;
            this.comboBoxMachine.Location = new System.Drawing.Point(317, 299);
            this.comboBoxMachine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMachine.Name = "comboBoxMachine";
            this.comboBoxMachine.Size = new System.Drawing.Size(259, 24);
            this.comboBoxMachine.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(601, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data zamówienia";
            // 
            // tBoxPlanNr
            // 
            this.tBoxPlanNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxPlanNr.Location = new System.Drawing.Point(271, 14);
            this.tBoxPlanNr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxPlanNr.Name = "tBoxPlanNr";
            this.tBoxPlanNr.Size = new System.Drawing.Size(135, 38);
            this.tBoxPlanNr.TabIndex = 7;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.AllowDrop = true;
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeStart.Location = new System.Drawing.Point(888, 462);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(264, 22);
            this.dateTimeStart.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(601, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Szacowana data realizacji";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeEnd.Location = new System.Drawing.Point(888, 510);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(264, 22);
            this.dateTimeEnd.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numer planu produkcji:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::KWZP2019.Properties.Resources.icons8_save_40;
            this.btnSave.Location = new System.Drawing.Point(160, 463);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 71);
            this.btnSave.TabIndex = 13;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = global::KWZP2019.Properties.Resources.icons8_return_40;
            this.btnReturn.Location = new System.Drawing.Point(15, 463);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(113, 74);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cBoxIntoProduction
            // 
            this.cBoxIntoProduction.AutoSize = true;
            this.cBoxIntoProduction.Location = new System.Drawing.Point(317, 358);
            this.cBoxIntoProduction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cBoxIntoProduction.Name = "cBoxIntoProduction";
            this.cBoxIntoProduction.Size = new System.Drawing.Size(18, 17);
            this.cBoxIntoProduction.TabIndex = 15;
            this.cBoxIntoProduction.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 25);
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
            this.viewProcessEmpl.Location = new System.Drawing.Point(607, 156);
            this.viewProcessEmpl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewProcessEmpl.Name = "viewProcessEmpl";
            this.viewProcessEmpl.RowTemplate.Height = 24;
            this.viewProcessEmpl.Size = new System.Drawing.Size(697, 101);
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
            this.idEmployeeDataGridViewTextBoxColumn.HeaderText = "Numer pracownika";
            this.idEmployeeDataGridViewTextBoxColumn.Name = "idEmployeeDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Data rozpoczęcia";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Data zakończenia";
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
            this.lblOperators.BackColor = System.Drawing.Color.Transparent;
            this.lblOperators.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOperators.ForeColor = System.Drawing.Color.White;
            this.lblOperators.Location = new System.Drawing.Point(843, 114);
            this.lblOperators.Name = "lblOperators";
            this.lblOperators.Size = new System.Drawing.Size(220, 25);
            this.lblOperators.TabIndex = 18;
            this.lblOperators.Text = "Przydzieleni pracownicy";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnRemoveEmployee);
            this.groupBox1.Controls.Add(this.dateTimeEmployeeEnd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimeEmployeeStart);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxEmployee);
            this.groupBox1.Controls.Add(this.btnAddEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(607, 283);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(697, 138);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie pracowników";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(5, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pracownik";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnRemoveEmployee.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnRemoveEmployee.FlatAppearance.BorderSize = 3;
            this.btnRemoveEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmployee.ForeColor = System.Drawing.Color.White;
            this.btnRemoveEmployee.Image = global::KWZP2019.Properties.Resources.icons8_denied_40;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(583, 75);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(91, 54);
            this.btnRemoveEmployee.TabIndex = 24;
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // dateTimeEmployeeEnd
            // 
            this.dateTimeEmployeeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeEmployeeEnd.Location = new System.Drawing.Point(347, 97);
            this.dateTimeEmployeeEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeEmployeeEnd.Name = "dateTimeEmployeeEnd";
            this.dateTimeEmployeeEnd.Size = new System.Drawing.Size(200, 23);
            this.dateTimeEmployeeEnd.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(219, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Data zakończenia";
            // 
            // dateTimeEmployeeStart
            // 
            this.dateTimeEmployeeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimeEmployeeStart.Location = new System.Drawing.Point(347, 38);
            this.dateTimeEmployeeStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeEmployeeStart.Name = "dateTimeEmployeeStart";
            this.dateTimeEmployeeStart.Size = new System.Drawing.Size(200, 23);
            this.dateTimeEmployeeStart.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(219, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data rozpoczęcia";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(5, 59);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(193, 33);
            this.comboBoxEmployee.TabIndex = 5;
            // 
            // btnNewPlan
            // 
            this.btnNewPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnNewPlan.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNewPlan.FlatAppearance.BorderSize = 3;
            this.btnNewPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnNewPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewPlan.ForeColor = System.Drawing.Color.White;
            this.btnNewPlan.Image = global::KWZP2019.Properties.Resources.icons8_add_new_80;
            this.btnNewPlan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewPlan.Location = new System.Drawing.Point(504, 14);
            this.btnNewPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewPlan.Name = "btnNewPlan";
            this.btnNewPlan.Size = new System.Drawing.Size(168, 138);
            this.btnNewPlan.TabIndex = 21;
            this.btnNewPlan.Text = "NOWY PLAN";
            this.btnNewPlan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewPlan.UseVisualStyleBackColor = false;
            this.btnNewPlan.Click += new System.EventHandler(this.btnNewPlan_Click);
            // 
            // viewOrderDetail
            // 
            this.viewOrderDetail.AutoGenerateColumns = false;
            this.viewOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetailDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn});
            this.viewOrderDetail.DataSource = this.vUnhandledOrderDetailsBindingSource;
            this.viewOrderDetail.Location = new System.Drawing.Point(23, 156);
            this.viewOrderDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewOrderDetail.Name = "viewOrderDetail";
            this.viewOrderDetail.RowTemplate.Height = 24;
            this.viewOrderDetail.Size = new System.Drawing.Size(555, 101);
            this.viewOrderDetail.TabIndex = 22;
            this.viewOrderDetail.SelectionChanged += new System.EventHandler(this.viewOrderDetail_SelectionChanged);
            // 
            // idDetailDataGridViewTextBoxColumn1
            // 
            this.idDetailDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDetailDataGridViewTextBoxColumn1.DataPropertyName = "IdDetail";
            this.idDetailDataGridViewTextBoxColumn1.HeaderText = "Nr szczegółu";
            this.idDetailDataGridViewTextBoxColumn1.Name = "idDetailDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Ilosć";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Kod produktu";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // vUnhandledOrderDetailsBindingSource
            // 
            this.vUnhandledOrderDetailsBindingSource.DataSource = typeof(KWZP2019.vUnhandledOrderDetail);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btnEndDateCalculate
            // 
            this.btnEndDateCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnEndDateCalculate.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEndDateCalculate.FlatAppearance.BorderSize = 3;
            this.btnEndDateCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnEndDateCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndDateCalculate.ForeColor = System.Drawing.Color.White;
            this.btnEndDateCalculate.Image = global::KWZP2019.Properties.Resources.icons8_abacus_80;
            this.btnEndDateCalculate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEndDateCalculate.Location = new System.Drawing.Point(341, 394);
            this.btnEndDateCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndDateCalculate.Name = "btnEndDateCalculate";
            this.btnEndDateCalculate.Size = new System.Drawing.Size(237, 140);
            this.btnEndDateCalculate.TabIndex = 23;
            this.btnEndDateCalculate.Text = "OSZACUJ DATĘ KOŃCOWĄ";
            this.btnEndDateCalculate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEndDateCalculate.UseVisualStyleBackColor = false;
            this.btnEndDateCalculate.Click += new System.EventHandler(this.btnEndDateCalculate_Click);
            // 
            // NewProductionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 566);
            this.Controls.Add(this.btnEndDateCalculate);
            this.Controls.Add(this.viewOrderDetail);
            this.Controls.Add(this.btnNewPlan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOperators);
            this.Controls.Add(this.viewProcessEmpl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxIntoProduction);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.tBoxPlanNr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMachine);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewProductionPlan";
            this.Text = "NewProductionPlan";
            this.Load += new System.EventHandler(this.NewProductionPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProcessEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionEmployeeDetailBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUnhandledOrderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMachine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxPlanNr;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
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
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.DateTimePicker dateTimeEmployeeEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeEmployeeStart;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewPlan;
        private System.Windows.Forms.DataGridView viewOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vUnhandledOrderDetailsBindingSource;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button btnEndDateCalculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedProductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocationDataGridViewTextBoxColumn;
    }
}