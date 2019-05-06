namespace KWZP2019
{
    partial class NewMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMaintenanceForm));
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.tpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtMaintenanceNr = new System.Windows.Forms.TextBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.tpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.comFailure = new System.Windows.Forms.ComboBox();
            this.lblMaintenanceNr = new System.Windows.Forms.Label();
            this.lblFailure = new System.Windows.Forms.Label();
            this.tbcPartsEmployees = new System.Windows.Forms.TabControl();
            this.tbpPartsEmployees = new System.Windows.Forms.TabPage();
            this.lblMaintenanceEmployees = new System.Windows.Forms.Label();
            this.btnEmloyeeCalendar = new System.Windows.Forms.Button();
            this.lblEmployeeEndDate = new System.Windows.Forms.Label();
            this.lblEmployeeStartDate = new System.Windows.Forms.Label();
            this.tpEmployeeEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEmployeeEndDate = new System.Windows.Forms.DateTimePicker();
            this.tpEmployeeStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEmployeeStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.IdEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.dgvMaintenanceEmployees = new System.Windows.Forms.DataGridView();
            this.IdEmployeePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMaintenance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmployee1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSurname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.lblPart = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lbxParts = new System.Windows.Forms.ListBox();
            this.btnCancelPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.dgvPart = new System.Windows.Forms.DataGridView();
            this.IdMaintenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPartsEmployees.SuspendLayout();
            this.tbpPartsEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceEmployees)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.AutoSize = true;
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReturnMain.Location = new System.Drawing.Point(950, 500);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(194, 153);
            this.btnReturnMain.TabIndex = 5;
            this.btnReturnMain.Text = "Powrót ";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(595, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 55);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(423, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 55);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMachine
            // 
            this.txtMachine.Location = new System.Drawing.Point(94, 210);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.ReadOnly = true;
            this.txtMachine.Size = new System.Drawing.Size(177, 20);
            this.txtMachine.TabIndex = 31;
            // 
            // tpEndDate
            // 
            this.tpEndDate.Location = new System.Drawing.Point(605, 132);
            this.tpEndDate.Name = "tpEndDate";
            this.tpEndDate.Size = new System.Drawing.Size(134, 20);
            this.tpEndDate.TabIndex = 30;
            this.tpEndDate.Value = new System.DateTime(2019, 5, 7, 16, 0, 0, 0);
            this.tpEndDate.Leave += new System.EventHandler(this.tpEndDate_Leave);
            // 
            // txtMaintenanceNr
            // 
            this.txtMaintenanceNr.Location = new System.Drawing.Point(94, 59);
            this.txtMaintenanceNr.Name = "txtMaintenanceNr";
            this.txtMaintenanceNr.Size = new System.Drawing.Size(152, 20);
            this.txtMaintenanceNr.TabIndex = 29;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(423, 132);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(159, 20);
            this.dtpEndDate.TabIndex = 26;
            this.dtpEndDate.Value = new System.DateTime(2019, 5, 5, 20, 52, 45, 0);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(421, 104);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(205, 13);
            this.lblEndDate.TabIndex = 24;
            this.lblEndDate.Text = "Data planowanego zakończenia zlecenia:";
            // 
            // tpStartDate
            // 
            this.tpStartDate.Location = new System.Drawing.Point(605, 59);
            this.tpStartDate.Name = "tpStartDate";
            this.tpStartDate.Size = new System.Drawing.Size(134, 20);
            this.tpStartDate.TabIndex = 27;
            this.tpStartDate.Value = new System.DateTime(2019, 5, 7, 8, 0, 0, 0);
            this.tpStartDate.Leave += new System.EventHandler(this.tpStartDate_Leave);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(423, 59);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(159, 20);
            this.dtpStartDate.TabIndex = 28;
            this.dtpStartDate.Value = new System.DateTime(2019, 5, 5, 20, 52, 54, 0);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(421, 31);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(202, 13);
            this.lblStartDate.TabIndex = 25;
            this.lblStartDate.Text = "Data planowanego rozpoczęcia zlecenia:";
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(101, 177);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(52, 13);
            this.lblMachine.TabIndex = 23;
            this.lblMachine.Text = "Maszyna:";
            // 
            // comFailure
            // 
            this.comFailure.FormattingEnabled = true;
            this.comFailure.Location = new System.Drawing.Point(94, 131);
            this.comFailure.Name = "comFailure";
            this.comFailure.Size = new System.Drawing.Size(177, 21);
            this.comFailure.TabIndex = 22;
            this.comFailure.SelectedIndexChanged += new System.EventHandler(this.comFailure_SelectedIndexChanged);
            // 
            // lblMaintenanceNr
            // 
            this.lblMaintenanceNr.AutoSize = true;
            this.lblMaintenanceNr.Location = new System.Drawing.Point(101, 31);
            this.lblMaintenanceNr.Name = "lblMaintenanceNr";
            this.lblMaintenanceNr.Size = new System.Drawing.Size(135, 13);
            this.lblMaintenanceNr.TabIndex = 20;
            this.lblMaintenanceNr.Text = "Wprowadź numer zlecenia:";
            // 
            // lblFailure
            // 
            this.lblFailure.AutoSize = true;
            this.lblFailure.Location = new System.Drawing.Point(101, 104);
            this.lblFailure.Name = "lblFailure";
            this.lblFailure.Size = new System.Drawing.Size(82, 13);
            this.lblFailure.TabIndex = 21;
            this.lblFailure.Text = "Wybierz awarię:";
            // 
            // tbcPartsEmployees
            // 
            this.tbcPartsEmployees.Controls.Add(this.tbpPartsEmployees);
            this.tbcPartsEmployees.Controls.Add(this.tabPage2);
            this.tbcPartsEmployees.Location = new System.Drawing.Point(34, 284);
            this.tbcPartsEmployees.Name = "tbcPartsEmployees";
            this.tbcPartsEmployees.SelectedIndex = 0;
            this.tbcPartsEmployees.Size = new System.Drawing.Size(850, 369);
            this.tbcPartsEmployees.TabIndex = 19;
            // 
            // tbpPartsEmployees
            // 
            this.tbpPartsEmployees.Controls.Add(this.lblMaintenanceEmployees);
            this.tbpPartsEmployees.Controls.Add(this.btnEmloyeeCalendar);
            this.tbpPartsEmployees.Controls.Add(this.lblEmployeeEndDate);
            this.tbpPartsEmployees.Controls.Add(this.lblEmployeeStartDate);
            this.tbpPartsEmployees.Controls.Add(this.tpEmployeeEndDate);
            this.tbpPartsEmployees.Controls.Add(this.dtpEmployeeEndDate);
            this.tbpPartsEmployees.Controls.Add(this.tpEmployeeStartDate);
            this.tbpPartsEmployees.Controls.Add(this.dtpEmployeeStartDate);
            this.tbpPartsEmployees.Controls.Add(this.dgvEmployees);
            this.tbpPartsEmployees.Controls.Add(this.btnCancelEmployee);
            this.tbpPartsEmployees.Controls.Add(this.btnDeleteEmployee);
            this.tbpPartsEmployees.Controls.Add(this.btnSaveEmployee);
            this.tbpPartsEmployees.Controls.Add(this.dgvMaintenanceEmployees);
            this.tbpPartsEmployees.Location = new System.Drawing.Point(4, 22);
            this.tbpPartsEmployees.Name = "tbpPartsEmployees";
            this.tbpPartsEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPartsEmployees.Size = new System.Drawing.Size(842, 343);
            this.tbpPartsEmployees.TabIndex = 0;
            this.tbpPartsEmployees.Text = "Pracownicy";
            this.tbpPartsEmployees.UseVisualStyleBackColor = true;
            // 
            // lblMaintenanceEmployees
            // 
            this.lblMaintenanceEmployees.AutoSize = true;
            this.lblMaintenanceEmployees.Location = new System.Drawing.Point(24, 20);
            this.lblMaintenanceEmployees.Name = "lblMaintenanceEmployees";
            this.lblMaintenanceEmployees.Size = new System.Drawing.Size(175, 13);
            this.lblMaintenanceEmployees.TabIndex = 35;
            this.lblMaintenanceEmployees.Text = "Pracownicy dodani do tgo zlecenia:";
            // 
            // btnEmloyeeCalendar
            // 
            this.btnEmloyeeCalendar.Location = new System.Drawing.Point(45, 307);
            this.btnEmloyeeCalendar.Name = "btnEmloyeeCalendar";
            this.btnEmloyeeCalendar.Size = new System.Drawing.Size(163, 23);
            this.btnEmloyeeCalendar.TabIndex = 34;
            this.btnEmloyeeCalendar.Text = "Kalendarz pracowników";
            this.btnEmloyeeCalendar.UseVisualStyleBackColor = true;
            this.btnEmloyeeCalendar.Click += new System.EventHandler(this.btnEmloyeeCalendar_Click);
            // 
            // lblEmployeeEndDate
            // 
            this.lblEmployeeEndDate.AutoSize = true;
            this.lblEmployeeEndDate.Location = new System.Drawing.Point(479, 275);
            this.lblEmployeeEndDate.Name = "lblEmployeeEndDate";
            this.lblEmployeeEndDate.Size = new System.Drawing.Size(48, 13);
            this.lblEmployeeEndDate.TabIndex = 33;
            this.lblEmployeeEndDate.Text = "Data do:";
            // 
            // lblEmployeeStartDate
            // 
            this.lblEmployeeStartDate.AutoSize = true;
            this.lblEmployeeStartDate.Location = new System.Drawing.Point(479, 236);
            this.lblEmployeeStartDate.Name = "lblEmployeeStartDate";
            this.lblEmployeeStartDate.Size = new System.Drawing.Size(48, 13);
            this.lblEmployeeStartDate.TabIndex = 33;
            this.lblEmployeeStartDate.Text = "Data od:";
            // 
            // tpEmployeeEndDate
            // 
            this.tpEmployeeEndDate.Location = new System.Drawing.Point(664, 292);
            this.tpEmployeeEndDate.Name = "tpEmployeeEndDate";
            this.tpEmployeeEndDate.Size = new System.Drawing.Size(134, 20);
            this.tpEmployeeEndDate.TabIndex = 32;
            this.tpEmployeeEndDate.Value = new System.DateTime(2019, 5, 7, 8, 0, 0, 0);
            this.tpEmployeeEndDate.Leave += new System.EventHandler(this.tpEmployeeEndDate_Leave);
            // 
            // dtpEmployeeEndDate
            // 
            this.dtpEmployeeEndDate.Location = new System.Drawing.Point(482, 292);
            this.dtpEmployeeEndDate.Name = "dtpEmployeeEndDate";
            this.dtpEmployeeEndDate.Size = new System.Drawing.Size(159, 20);
            this.dtpEmployeeEndDate.TabIndex = 31;
            this.dtpEmployeeEndDate.Value = new System.DateTime(2019, 5, 5, 20, 52, 45, 0);
            this.dtpEmployeeEndDate.ValueChanged += new System.EventHandler(this.dtpEmployeeEndDate_ValueChanged);
            // 
            // tpEmployeeStartDate
            // 
            this.tpEmployeeStartDate.Location = new System.Drawing.Point(664, 252);
            this.tpEmployeeStartDate.Name = "tpEmployeeStartDate";
            this.tpEmployeeStartDate.Size = new System.Drawing.Size(134, 20);
            this.tpEmployeeStartDate.TabIndex = 29;
            this.tpEmployeeStartDate.Value = new System.DateTime(2019, 5, 7, 8, 0, 0, 0);
            this.tpEmployeeStartDate.Leave += new System.EventHandler(this.tpEmployeeStartDate_Leave);
            // 
            // dtpEmployeeStartDate
            // 
            this.dtpEmployeeStartDate.Location = new System.Drawing.Point(482, 252);
            this.dtpEmployeeStartDate.Name = "dtpEmployeeStartDate";
            this.dtpEmployeeStartDate.Size = new System.Drawing.Size(159, 20);
            this.dtpEmployeeStartDate.TabIndex = 30;
            this.dtpEmployeeStartDate.Value = new System.DateTime(2019, 5, 5, 20, 52, 54, 0);
            this.dtpEmployeeStartDate.ValueChanged += new System.EventHandler(this.dtpEmployeeStartDate_ValueChanged);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmployee,
            this.EmployeeName,
            this.EmployeeSurname});
            this.dgvEmployees.Location = new System.Drawing.Point(482, 71);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(331, 146);
            this.dgvEmployees.TabIndex = 2;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // IdEmployee
            // 
            this.IdEmployee.DataPropertyName = "IdEmployee";
            this.IdEmployee.HeaderText = "IdEmployee";
            this.IdEmployee.Name = "IdEmployee";
            this.IdEmployee.ReadOnly = true;
            this.IdEmployee.Visible = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Imię";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.DataPropertyName = "EmployeeSurname";
            this.EmployeeSurname.HeaderText = "Nazwisko";
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.ReadOnly = true;
            // 
            // btnCancelEmployee
            // 
            this.btnCancelEmployee.Location = new System.Drawing.Point(707, 20);
            this.btnCancelEmployee.Name = "btnCancelEmployee";
            this.btnCancelEmployee.Size = new System.Drawing.Size(106, 45);
            this.btnCancelEmployee.TabIndex = 1;
            this.btnCancelEmployee.Text = "Anuluj";
            this.btnCancelEmployee.UseVisualStyleBackColor = true;
            this.btnCancelEmployee.Click += new System.EventHandler(this.btnCancelEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(595, 20);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(106, 45);
            this.btnDeleteEmployee.TabIndex = 1;
            this.btnDeleteEmployee.Text = "Usuń";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new System.Drawing.Point(482, 20);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(106, 45);
            this.btnSaveEmployee.TabIndex = 1;
            this.btnSaveEmployee.Text = "Dodaj pracownika";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // dgvMaintenanceEmployees
            // 
            this.dgvMaintenanceEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmployeePlan,
            this.IdMaintenance1,
            this.IdEmployee1,
            this.EmployeeName1,
            this.EmployeeSurname1,
            this.StartDate,
            this.EndDate});
            this.dgvMaintenanceEmployees.Location = new System.Drawing.Point(6, 47);
            this.dgvMaintenanceEmployees.Name = "dgvMaintenanceEmployees";
            this.dgvMaintenanceEmployees.ReadOnly = true;
            this.dgvMaintenanceEmployees.Size = new System.Drawing.Size(453, 254);
            this.dgvMaintenanceEmployees.TabIndex = 0;
            this.dgvMaintenanceEmployees.DoubleClick += new System.EventHandler(this.dgvMaintenanceEmployees_DoubleClick);
            // 
            // IdEmployeePlan
            // 
            this.IdEmployeePlan.DataPropertyName = "IdEmployeePlan";
            this.IdEmployeePlan.HeaderText = "IdEmployeePlan";
            this.IdEmployeePlan.Name = "IdEmployeePlan";
            this.IdEmployeePlan.ReadOnly = true;
            this.IdEmployeePlan.Visible = false;
            // 
            // IdMaintenance1
            // 
            this.IdMaintenance1.DataPropertyName = "IdMaintenance";
            this.IdMaintenance1.HeaderText = "IdMaintenance1";
            this.IdMaintenance1.Name = "IdMaintenance1";
            this.IdMaintenance1.ReadOnly = true;
            this.IdMaintenance1.Visible = false;
            // 
            // IdEmployee1
            // 
            this.IdEmployee1.DataPropertyName = "IdEmployee";
            this.IdEmployee1.HeaderText = "IdEmployee1";
            this.IdEmployee1.Name = "IdEmployee1";
            this.IdEmployee1.ReadOnly = true;
            this.IdEmployee1.Visible = false;
            // 
            // EmployeeName1
            // 
            this.EmployeeName1.DataPropertyName = "EmployeeName";
            this.EmployeeName1.HeaderText = "Imię";
            this.EmployeeName1.Name = "EmployeeName1";
            this.EmployeeName1.ReadOnly = true;
            // 
            // EmployeeSurname1
            // 
            this.EmployeeSurname1.DataPropertyName = "EmployeeSurname";
            this.EmployeeSurname1.HeaderText = "Nazwisko";
            this.EmployeeSurname1.Name = "EmployeeSurname1";
            this.EmployeeSurname1.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "Data od:";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "Data do:";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnWarehouse);
            this.tabPage2.Controls.Add(this.lblPart);
            this.tabPage2.Controls.Add(this.txtQuantity);
            this.tabPage2.Controls.Add(this.lblQuantity);
            this.tabPage2.Controls.Add(this.lbxParts);
            this.tabPage2.Controls.Add(this.btnCancelPart);
            this.tabPage2.Controls.Add(this.btnDeletePart);
            this.tabPage2.Controls.Add(this.btnAddPart);
            this.tabPage2.Controls.Add(this.dgvPart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Części";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Location = new System.Drawing.Point(494, 283);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(185, 38);
            this.btnWarehouse.TabIndex = 10;
            this.btnWarehouse.Text = "Zarządzaj magazynem części";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.Location = new System.Drawing.Point(22, 14);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(158, 13);
            this.lblPart.TabIndex = 9;
            this.lblPart.Text = "Części dodane do tego zlecenia";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(540, 239);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 8;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(491, 239);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(32, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Ilość:";
            // 
            // lbxParts
            // 
            this.lbxParts.FormattingEnabled = true;
            this.lbxParts.Location = new System.Drawing.Point(494, 77);
            this.lbxParts.Name = "lbxParts";
            this.lbxParts.Size = new System.Drawing.Size(331, 147);
            this.lbxParts.TabIndex = 6;
            // 
            // btnCancelPart
            // 
            this.btnCancelPart.Location = new System.Drawing.Point(719, 26);
            this.btnCancelPart.Name = "btnCancelPart";
            this.btnCancelPart.Size = new System.Drawing.Size(106, 45);
            this.btnCancelPart.TabIndex = 3;
            this.btnCancelPart.Text = "Anuluj";
            this.btnCancelPart.UseVisualStyleBackColor = true;
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(607, 26);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(106, 45);
            this.btnDeletePart.TabIndex = 4;
            this.btnDeletePart.Text = "Usuń";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(494, 26);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(106, 45);
            this.btnAddPart.TabIndex = 5;
            this.btnAddPart.Text = "Dodaj część";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // dgvPart
            // 
            this.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMaintenance,
            this.IdPart,
            this.PartName,
            this.PartQuantity,
            this.QuantityWarehouse,
            this.UnitName});
            this.dgvPart.Location = new System.Drawing.Point(25, 41);
            this.dgvPart.Name = "dgvPart";
            this.dgvPart.ReadOnly = true;
            this.dgvPart.Size = new System.Drawing.Size(446, 280);
            this.dgvPart.TabIndex = 0;
            // 
            // IdMaintenance
            // 
            this.IdMaintenance.DataPropertyName = "IdMaintenance";
            this.IdMaintenance.HeaderText = "IdMaintenance";
            this.IdMaintenance.Name = "IdMaintenance";
            this.IdMaintenance.ReadOnly = true;
            this.IdMaintenance.Visible = false;
            // 
            // IdPart
            // 
            this.IdPart.DataPropertyName = "IdPart";
            this.IdPart.HeaderText = "IdPart";
            this.IdPart.Name = "IdPart";
            this.IdPart.ReadOnly = true;
            this.IdPart.Visible = false;
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "PartName";
            this.PartName.HeaderText = "Nazwa części";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // PartQuantity
            // 
            this.PartQuantity.DataPropertyName = "PartQuantity";
            this.PartQuantity.HeaderText = "Ilość do zlecenia";
            this.PartQuantity.Name = "PartQuantity";
            this.PartQuantity.ReadOnly = true;
            // 
            // QuantityWarehouse
            // 
            this.QuantityWarehouse.DataPropertyName = "QuantityWarehouse";
            this.QuantityWarehouse.HeaderText = "Ilość na magazynie";
            this.QuantityWarehouse.Name = "QuantityWarehouse";
            this.QuantityWarehouse.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Jednostka";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // NewMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.tpEndDate);
            this.Controls.Add(this.txtMaintenanceNr);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.tpStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.comFailure);
            this.Controls.Add(this.lblMaintenanceNr);
            this.Controls.Add(this.lblFailure);
            this.Controls.Add(this.tbcPartsEmployees);
            this.Controls.Add(this.btnReturnMain);
            this.Name = "NewMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie nowego zlecenia obsługi";
            this.Load += new System.EventHandler(this.NewMaintenanceForm_Load);
            this.tbcPartsEmployees.ResumeLayout(false);
            this.tbpPartsEmployees.ResumeLayout(false);
            this.tbpPartsEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceEmployees)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.DateTimePicker tpEndDate;
        private System.Windows.Forms.TextBox txtMaintenanceNr;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker tpStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.ComboBox comFailure;
        private System.Windows.Forms.Label lblMaintenanceNr;
        private System.Windows.Forms.Label lblFailure;
        private System.Windows.Forms.TabControl tbcPartsEmployees;
        private System.Windows.Forms.TabPage tbpPartsEmployees;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.DataGridView dgvMaintenanceEmployees;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPart;
        private System.Windows.Forms.Button btnCancelEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.ListBox lbxParts;
        private System.Windows.Forms.Button btnCancelPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeEndDate;
        private System.Windows.Forms.Label lblEmployeeStartDate;
        private System.Windows.Forms.DateTimePicker tpEmployeeEndDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeEndDate;
        private System.Windows.Forms.DateTimePicker tpEmployeeStartDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeStartDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnEmloyeeCalendar;
        private System.Windows.Forms.Label lblMaintenanceEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmployeePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaintenance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmployee1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSurname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
    }
}