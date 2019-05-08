namespace KWZP2019
{
    partial class Absences
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Absences));
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbAbsenceType = new System.Windows.Forms.ComboBox();
            this.lblAbsenceType = new System.Windows.Forms.Label();
            this.dateTimePickerFirstDay = new System.Windows.Forms.DateTimePicker();
            this.lblFirstDay = new System.Windows.Forms.Label();
            this.dateTimePickerLastDay = new System.Windows.Forms.DateTimePicker();
            this.lblLastDay = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbSearchAbsence = new System.Windows.Forms.TextBox();
            this.lblSearchSurname = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pbAbsence = new System.Windows.Forms.PictureBox();
            this.cbEmployeeList = new System.Windows.Forms.ComboBox();
            this.btnAddAbsenceType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAbsences.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbsences.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbsences.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvAbsences.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsences.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbsences.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAbsences.EnableHeadersVisualStyles = false;
            this.dgvAbsences.Location = new System.Drawing.Point(10, 130);
            this.dgvAbsences.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAbsences.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(515, 370);
            this.dgvAbsences.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonAdd.FlatAppearance.BorderSize = 3;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(713, 493);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(247, 154);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(11, 517);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(514, 57);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbAbsenceType
            // 
            this.cbAbsenceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cbAbsenceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbAbsenceType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbAbsenceType.FormattingEnabled = true;
            this.cbAbsenceType.Location = new System.Drawing.Point(809, 327);
            this.cbAbsenceType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAbsenceType.Name = "cbAbsenceType";
            this.cbAbsenceType.Size = new System.Drawing.Size(164, 26);
            this.cbAbsenceType.TabIndex = 3;
            // 
            // lblAbsenceType
            // 
            this.lblAbsenceType.AutoSize = true;
            this.lblAbsenceType.BackColor = System.Drawing.Color.Transparent;
            this.lblAbsenceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblAbsenceType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAbsenceType.Location = new System.Drawing.Point(652, 327);
            this.lblAbsenceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbsenceType.Name = "lblAbsenceType";
            this.lblAbsenceType.Size = new System.Drawing.Size(155, 20);
            this.lblAbsenceType.TabIndex = 4;
            this.lblAbsenceType.Text = "Typ nieobecności";
            // 
            // dateTimePickerFirstDay
            // 
            this.dateTimePickerFirstDay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dateTimePickerFirstDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerFirstDay.Location = new System.Drawing.Point(809, 377);
            this.dateTimePickerFirstDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFirstDay.Name = "dateTimePickerFirstDay";
            this.dateTimePickerFirstDay.Size = new System.Drawing.Size(195, 24);
            this.dateTimePickerFirstDay.TabIndex = 5;
            // 
            // lblFirstDay
            // 
            this.lblFirstDay.AutoSize = true;
            this.lblFirstDay.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblFirstDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFirstDay.Location = new System.Drawing.Point(652, 377);
            this.lblFirstDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstDay.Name = "lblFirstDay";
            this.lblFirstDay.Size = new System.Drawing.Size(136, 20);
            this.lblFirstDay.TabIndex = 6;
            this.lblFirstDay.Text = "Pierwszy dzień";
            // 
            // dateTimePickerLastDay
            // 
            this.dateTimePickerLastDay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dateTimePickerLastDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerLastDay.Location = new System.Drawing.Point(809, 423);
            this.dateTimePickerLastDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerLastDay.Name = "dateTimePickerLastDay";
            this.dateTimePickerLastDay.Size = new System.Drawing.Size(195, 24);
            this.dateTimePickerLastDay.TabIndex = 7;
            // 
            // lblLastDay
            // 
            this.lblLastDay.AutoSize = true;
            this.lblLastDay.BackColor = System.Drawing.Color.Transparent;
            this.lblLastDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblLastDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLastDay.Location = new System.Drawing.Point(652, 426);
            this.lblLastDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastDay.Name = "lblLastDay";
            this.lblLastDay.Size = new System.Drawing.Size(121, 20);
            this.lblLastDay.TabIndex = 8;
            this.lblLastDay.Text = "Ostatni dzień";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLastName.Location = new System.Drawing.Point(652, 275);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 20);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Pracownik";
            // 
            // tbSearchAbsence
            // 
            this.tbSearchAbsence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbSearchAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchAbsence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSearchAbsence.Location = new System.Drawing.Point(175, 37);
            this.tbSearchAbsence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchAbsence.Name = "tbSearchAbsence";
            this.tbSearchAbsence.Size = new System.Drawing.Size(218, 23);
            this.tbSearchAbsence.TabIndex = 14;
            this.tbSearchAbsence.TextChanged += new System.EventHandler(this.tbSearchAbsence_TextChanged);
            // 
            // lblSearchSurname
            // 
            this.lblSearchSurname.AutoSize = true;
            this.lblSearchSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchSurname.Location = new System.Drawing.Point(11, 44);
            this.lblSearchSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchSurname.Name = "lblSearchSurname";
            this.lblSearchSurname.Size = new System.Drawing.Size(149, 17);
            this.lblSearchSurname.TabIndex = 15;
            this.lblSearchSurname.Text = "Wyszukaj po nazwisku";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSearchName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchName.Location = new System.Drawing.Point(11, 88);
            this.lblSearchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(144, 18);
            this.lblSearchName.TabIndex = 16;
            this.lblSearchName.Text = "Wyszukaj po imieniu";
            // 
            // tbSearchName
            // 
            this.tbSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSearchName.Location = new System.Drawing.Point(175, 82);
            this.tbSearchName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(218, 23);
            this.tbSearchName.TabIndex = 17;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(11, 586);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(247, 154);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.Location = new System.Drawing.Point(278, 586);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(247, 154);
            this.btnReturnMain.TabIndex = 19;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Location = new System.Drawing.Point(675, 163);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(313, 26);
            this.lblFormTitle.TabIndex = 34;
            this.lblFormTitle.Text = "Dodaj nieobecność pracownika";
            // 
            // pbAbsence
            // 
            this.pbAbsence.BackColor = System.Drawing.Color.Transparent;
            this.pbAbsence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAbsence.BackgroundImage")));
            this.pbAbsence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAbsence.Location = new System.Drawing.Point(539, 44);
            this.pbAbsence.Name = "pbAbsence";
            this.pbAbsence.Size = new System.Drawing.Size(587, 693);
            this.pbAbsence.TabIndex = 35;
            this.pbAbsence.TabStop = false;
            // 
            // cbEmployeeList
            // 
            this.cbEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cbEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbEmployeeList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbEmployeeList.FormattingEnabled = true;
            this.cbEmployeeList.Location = new System.Drawing.Point(809, 275);
            this.cbEmployeeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEmployeeList.Name = "cbEmployeeList";
            this.cbEmployeeList.Size = new System.Drawing.Size(195, 26);
            this.cbEmployeeList.TabIndex = 36;
            // 
            // btnAddAbsenceType
            // 
            this.btnAddAbsenceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAddAbsenceType.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddAbsenceType.FlatAppearance.BorderSize = 3;
            this.btnAddAbsenceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAbsenceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddAbsenceType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddAbsenceType.Location = new System.Drawing.Point(991, 305);
            this.btnAddAbsenceType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAbsenceType.Name = "btnAddAbsenceType";
            this.btnAddAbsenceType.Size = new System.Drawing.Size(54, 48);
            this.btnAddAbsenceType.TabIndex = 37;
            this.btnAddAbsenceType.Text = "+";
            this.btnAddAbsenceType.UseVisualStyleBackColor = false;
            this.btnAddAbsenceType.Click += new System.EventHandler(this.btnAddAbsenceType_Click);
            // 
            // Absences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.btnAddAbsenceType);
            this.Controls.Add(this.cbEmployeeList);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.lblSearchSurname);
            this.Controls.Add(this.tbSearchAbsence);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblLastDay);
            this.Controls.Add(this.dateTimePickerLastDay);
            this.Controls.Add(this.lblFirstDay);
            this.Controls.Add(this.dateTimePickerFirstDay);
            this.Controls.Add(this.lblAbsenceType);
            this.Controls.Add(this.cbAbsenceType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.pbAbsence);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Absences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nieobecności";
            this.Load += new System.EventHandler(this.Absences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbsence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbAbsenceType;
        private System.Windows.Forms.Label lblAbsenceType;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstDay;
        private System.Windows.Forms.Label lblFirstDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastDay;
        private System.Windows.Forms.Label lblLastDay;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbSearchAbsence;
        private System.Windows.Forms.Label lblSearchSurname;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pbAbsence;
        private System.Windows.Forms.ComboBox cbEmployeeList;
        private System.Windows.Forms.Button btnAddAbsenceType;
    }
}