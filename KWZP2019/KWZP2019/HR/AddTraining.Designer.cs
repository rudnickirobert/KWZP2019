﻿namespace KWZP2019
{
    partial class AddTraining
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTraining));
            this.dgvTrainings = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTrainingName = new System.Windows.Forms.Label();
            this.tbTrainingName = new System.Windows.Forms.TextBox();
            this.lblTrainingStartDate = new System.Windows.Forms.Label();
            this.dtpTrainingStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTrainingEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTrainingEndDate = new System.Windows.Forms.Label();
            this.lblEmployeeFirstName = new System.Windows.Forms.Label();
            this.tbEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.tbEmployeeLastName = new System.Windows.Forms.TextBox();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbTrainingPrice = new System.Windows.Forms.TextBox();
            this.lblTrainingPrice = new System.Windows.Forms.Label();
            this.tbSearchTraining = new System.Windows.Forms.TextBox();
            this.tbSearchTrainingName = new System.Windows.Forms.TextBox();
            this.lblSearchTrainingSurname = new System.Windows.Forms.Label();
            this.lblSearchTrainingName = new System.Windows.Forms.Label();
            this.pbAddTraining = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.cbEmployeeList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainings
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTrainings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTrainings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrainings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvTrainings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrainings.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTrainings.EnableHeadersVisualStyles = false;
            this.dgvTrainings.Location = new System.Drawing.Point(21, 98);
            this.dgvTrainings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTrainings.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTrainings.RowTemplate.Height = 24;
            this.dgvTrainings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainings.Size = new System.Drawing.Size(531, 372);
            this.dgvTrainings.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(765, 507);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(247, 154);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(21, 493);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(256, 57);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTrainingName
            // 
            this.lblTrainingName.AutoSize = true;
            this.lblTrainingName.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrainingName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrainingName.Location = new System.Drawing.Point(648, 234);
            this.lblTrainingName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainingName.Name = "lblTrainingName";
            this.lblTrainingName.Size = new System.Drawing.Size(142, 20);
            this.lblTrainingName.TabIndex = 3;
            this.lblTrainingName.Text = "Nazwa szkolenia";
            // 
            // tbTrainingName
            // 
            this.tbTrainingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTrainingName.Location = new System.Drawing.Point(846, 239);
            this.tbTrainingName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTrainingName.Name = "tbTrainingName";
            this.tbTrainingName.Size = new System.Drawing.Size(251, 23);
            this.tbTrainingName.TabIndex = 4;
            // 
            // lblTrainingStartDate
            // 
            this.lblTrainingStartDate.AutoSize = true;
            this.lblTrainingStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainingStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrainingStartDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrainingStartDate.Location = new System.Drawing.Point(648, 283);
            this.lblTrainingStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainingStartDate.Name = "lblTrainingStartDate";
            this.lblTrainingStartDate.Size = new System.Drawing.Size(163, 20);
            this.lblTrainingStartDate.TabIndex = 5;
            this.lblTrainingStartDate.Text = "Początek szkolenia";
            // 
            // dtpTrainingStartDate
            // 
            this.dtpTrainingStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpTrainingStartDate.Location = new System.Drawing.Point(846, 288);
            this.dtpTrainingStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTrainingStartDate.Name = "dtpTrainingStartDate";
            this.dtpTrainingStartDate.Size = new System.Drawing.Size(251, 23);
            this.dtpTrainingStartDate.TabIndex = 6;
            // 
            // dtpTrainingEndDate
            // 
            this.dtpTrainingEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpTrainingEndDate.Location = new System.Drawing.Point(846, 335);
            this.dtpTrainingEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTrainingEndDate.Name = "dtpTrainingEndDate";
            this.dtpTrainingEndDate.Size = new System.Drawing.Size(251, 23);
            this.dtpTrainingEndDate.TabIndex = 7;
            // 
            // lblTrainingEndDate
            // 
            this.lblTrainingEndDate.AutoSize = true;
            this.lblTrainingEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainingEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrainingEndDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrainingEndDate.Location = new System.Drawing.Point(648, 333);
            this.lblTrainingEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainingEndDate.Name = "lblTrainingEndDate";
            this.lblTrainingEndDate.Size = new System.Drawing.Size(143, 20);
            this.lblTrainingEndDate.TabIndex = 8;
            this.lblTrainingEndDate.Text = "Koniec szkolenia";
            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.AutoSize = true;
            this.lblEmployeeFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmployeeFirstName.Location = new System.Drawing.Point(648, 379);
            this.lblEmployeeFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new System.Drawing.Size(138, 20);
            this.lblEmployeeFirstName.TabIndex = 9;
            this.lblEmployeeFirstName.Text = "Imię pracownika";
            // 
            // tbEmployeeFirstName
            // 
            this.tbEmployeeFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbEmployeeFirstName.Location = new System.Drawing.Point(846, 376);
            this.tbEmployeeFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmployeeFirstName.Name = "tbEmployeeFirstName";
            this.tbEmployeeFirstName.Size = new System.Drawing.Size(251, 23);
            this.tbEmployeeFirstName.TabIndex = 10;
            // 
            // tbEmployeeLastName
            // 
            this.tbEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbEmployeeLastName.Location = new System.Drawing.Point(846, 418);
            this.tbEmployeeLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmployeeLastName.Name = "tbEmployeeLastName";
            this.tbEmployeeLastName.Size = new System.Drawing.Size(251, 23);
            this.tbEmployeeLastName.TabIndex = 11;
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.AutoSize = true;
            this.lblEmployeeLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmployeeLastName.Location = new System.Drawing.Point(648, 421);
            this.lblEmployeeLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(179, 20);
            this.lblEmployeeLastName.TabIndex = 12;
            this.lblEmployeeLastName.Text = "Nazwisko pracownika";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(304, 493);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(247, 57);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // tbTrainingPrice
            // 
            this.tbTrainingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTrainingPrice.Location = new System.Drawing.Point(846, 460);
            this.tbTrainingPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTrainingPrice.Name = "tbTrainingPrice";
            this.tbTrainingPrice.Size = new System.Drawing.Size(251, 23);
            this.tbTrainingPrice.TabIndex = 14;
            // 
            // lblTrainingPrice
            // 
            this.lblTrainingPrice.AutoSize = true;
            this.lblTrainingPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrainingPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrainingPrice.Location = new System.Drawing.Point(648, 463);
            this.lblTrainingPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainingPrice.Name = "lblTrainingPrice";
            this.lblTrainingPrice.Size = new System.Drawing.Size(54, 20);
            this.lblTrainingPrice.TabIndex = 15;
            this.lblTrainingPrice.Text = "Koszt";
            // 
            // tbSearchTraining
            // 
            this.tbSearchTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbSearchTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchTraining.Location = new System.Drawing.Point(104, 26);
            this.tbSearchTraining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchTraining.Name = "tbSearchTraining";
            this.tbSearchTraining.Size = new System.Drawing.Size(231, 23);
            this.tbSearchTraining.TabIndex = 16;
            this.tbSearchTraining.TextChanged += new System.EventHandler(this.tbSearchTraining_TextChanged);
            // 
            // tbSearchTrainingName
            // 
            this.tbSearchTrainingName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbSearchTrainingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchTrainingName.Location = new System.Drawing.Point(104, 58);
            this.tbSearchTrainingName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchTrainingName.Name = "tbSearchTrainingName";
            this.tbSearchTrainingName.Size = new System.Drawing.Size(231, 23);
            this.tbSearchTrainingName.TabIndex = 17;
            this.tbSearchTrainingName.TextChanged += new System.EventHandler(this.tbSearchTrainingName_TextChanged);
            // 
            // lblSearchTrainingSurname
            // 
            this.lblSearchTrainingSurname.AutoSize = true;
            this.lblSearchTrainingSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchTrainingSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchTrainingSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchTrainingSurname.Location = new System.Drawing.Point(18, 32);
            this.lblSearchTrainingSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchTrainingSurname.Name = "lblSearchTrainingSurname";
            this.lblSearchTrainingSurname.Size = new System.Drawing.Size(67, 17);
            this.lblSearchTrainingSurname.TabIndex = 18;
            this.lblSearchTrainingSurname.Text = "Nazwisko";
            // 
            // lblSearchTrainingName
            // 
            this.lblSearchTrainingName.AutoSize = true;
            this.lblSearchTrainingName.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchTrainingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchTrainingName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchTrainingName.Location = new System.Drawing.Point(18, 64);
            this.lblSearchTrainingName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchTrainingName.Name = "lblSearchTrainingName";
            this.lblSearchTrainingName.Size = new System.Drawing.Size(33, 17);
            this.lblSearchTrainingName.TabIndex = 19;
            this.lblSearchTrainingName.Text = "Imię";
            // 
            // pbAddTraining
            // 
            this.pbAddTraining.BackColor = System.Drawing.Color.Transparent;
            this.pbAddTraining.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAddTraining.BackgroundImage")));
            this.pbAddTraining.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddTraining.Location = new System.Drawing.Point(572, 12);
            this.pbAddTraining.Name = "pbAddTraining";
            this.pbAddTraining.Size = new System.Drawing.Size(581, 716);
            this.pbAddTraining.TabIndex = 20;
            this.pbAddTraining.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Location = new System.Drawing.Point(744, 135);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(235, 29);
            this.lblFormTitle.TabIndex = 21;
            this.lblFormTitle.Text = "Wprowadź szkolenie";
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
            this.btnReturn.Location = new System.Drawing.Point(21, 576);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(256, 152);
            this.btnReturn.TabIndex = 24;
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
            this.btnReturnMain.Location = new System.Drawing.Point(304, 574);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(247, 154);
            this.btnReturnMain.TabIndex = 25;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // cbEmployeeList
            // 
            this.cbEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cbEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbEmployeeList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbEmployeeList.FormattingEnabled = true;
            this.cbEmployeeList.Location = new System.Drawing.Point(838, 390);
            this.cbEmployeeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEmployeeList.Name = "cbEmployeeList";
            this.cbEmployeeList.Size = new System.Drawing.Size(259, 26);
            this.cbEmployeeList.TabIndex = 37;
            // 
            // AddTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.cbEmployeeList);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblSearchTrainingName);
            this.Controls.Add(this.lblSearchTrainingSurname);
            this.Controls.Add(this.tbSearchTrainingName);
            this.Controls.Add(this.tbSearchTraining);
            this.Controls.Add(this.lblTrainingPrice);
            this.Controls.Add(this.tbTrainingPrice);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblEmployeeLastName);
            this.Controls.Add(this.tbEmployeeLastName);
            this.Controls.Add(this.tbEmployeeFirstName);
            this.Controls.Add(this.lblEmployeeFirstName);
            this.Controls.Add(this.lblTrainingEndDate);
            this.Controls.Add(this.dtpTrainingEndDate);
            this.Controls.Add(this.dtpTrainingStartDate);
            this.Controls.Add(this.lblTrainingStartDate);
            this.Controls.Add(this.tbTrainingName);
            this.Controls.Add(this.lblTrainingName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTrainings);
            this.Controls.Add(this.pbAddTraining);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szkolenia";
            this.Load += new System.EventHandler(this.AddTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrainings;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTrainingName;
        private System.Windows.Forms.TextBox tbTrainingName;
        private System.Windows.Forms.Label lblTrainingStartDate;
        private System.Windows.Forms.DateTimePicker dtpTrainingStartDate;
        private System.Windows.Forms.DateTimePicker dtpTrainingEndDate;
        private System.Windows.Forms.Label lblTrainingEndDate;
        private System.Windows.Forms.Label lblEmployeeFirstName;
        private System.Windows.Forms.TextBox tbEmployeeFirstName;
        private System.Windows.Forms.TextBox tbEmployeeLastName;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbTrainingPrice;
        private System.Windows.Forms.Label lblTrainingPrice;
        private System.Windows.Forms.TextBox tbSearchTraining;
        private System.Windows.Forms.TextBox tbSearchTrainingName;
        private System.Windows.Forms.Label lblSearchTrainingSurname;
        private System.Windows.Forms.Label lblSearchTrainingName;
        private System.Windows.Forms.PictureBox pbAddTraining;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.ComboBox cbEmployeeList;
    }
}