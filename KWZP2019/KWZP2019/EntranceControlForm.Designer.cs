﻿namespace KWZP2019
{
    partial class EntranceControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceControlForm));
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblControlDate = new System.Windows.Forms.Label();
            this.lblThickness = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblMass = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.picBoxControlStatus = new System.Windows.Forms.PictureBox();
            this.domUDOrderId = new System.Windows.Forms.DomainUpDown();
            this.domUDSfId = new System.Windows.Forms.DomainUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtboxThickness = new System.Windows.Forms.TextBox();
            this.txtboxWidth = new System.Windows.Forms.TextBox();
            this.txtboxMass = new System.Windows.Forms.TextBox();
            this.txtboxComment = new System.Windows.Forms.TextBox();
            this.checkBoxComposition = new System.Windows.Forms.CheckBox();
            this.lblParameterCheck = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.lblEmployeeFullName = new System.Windows.Forms.Label();
            this.lblDaysOfDelay = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.picBoxChemicalComposition = new System.Windows.Forms.PictureBox();
            this.datePickerControlDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxControlStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChemicalComposition)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.Location = new System.Drawing.Point(67, 186);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(200, 120);
            this.btnReturnMain.TabIndex = 0;
            this.btnReturnMain.Text = "Menu Główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(67, 32);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 120);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Location = new System.Drawing.Point(576, 126);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(387, 56);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Wprowadź dane kontroli";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlDate
            // 
            this.lblControlDate.BackColor = System.Drawing.Color.Transparent;
            this.lblControlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblControlDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblControlDate.Location = new System.Drawing.Point(542, 378);
            this.lblControlDate.Name = "lblControlDate";
            this.lblControlDate.Size = new System.Drawing.Size(160, 26);
            this.lblControlDate.TabIndex = 3;
            this.lblControlDate.Text = "Data kontroli";
            this.lblControlDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThickness
            // 
            this.lblThickness.BackColor = System.Drawing.Color.Transparent;
            this.lblThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblThickness.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblThickness.Location = new System.Drawing.Point(835, 233);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(160, 26);
            this.lblThickness.TabIndex = 4;
            this.lblThickness.Text = "Grubość";
            this.lblThickness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWidth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWidth.Location = new System.Drawing.Point(835, 306);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(160, 26);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Szerokość";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMass
            // 
            this.lblMass.BackColor = System.Drawing.Color.Transparent;
            this.lblMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMass.Location = new System.Drawing.Point(835, 378);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(160, 26);
            this.lblMass.TabIndex = 6;
            this.lblMass.Text = "Masa";
            this.lblMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComment
            // 
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComment.Location = new System.Drawing.Point(835, 558);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(160, 26);
            this.lblComment.TabIndex = 9;
            this.lblComment.Text = "Komentarz";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxControlStatus
            // 
            this.picBoxControlStatus.BackColor = System.Drawing.Color.Transparent;
            this.picBoxControlStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxControlStatus.BackgroundImage")));
            this.picBoxControlStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxControlStatus.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBoxControlStatus.ErrorImage")));
            this.picBoxControlStatus.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxControlStatus.InitialImage")));
            this.picBoxControlStatus.Location = new System.Drawing.Point(545, 509);
            this.picBoxControlStatus.Name = "picBoxControlStatus";
            this.picBoxControlStatus.Size = new System.Drawing.Size(160, 160);
            this.picBoxControlStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxControlStatus.TabIndex = 10;
            this.picBoxControlStatus.TabStop = false;
            // 
            // domUDOrderId
            // 
            this.domUDOrderId.BackColor = System.Drawing.SystemColors.Window;
            this.domUDOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domUDOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domUDOrderId.Location = new System.Drawing.Point(545, 233);
            this.domUDOrderId.Name = "domUDOrderId";
            this.domUDOrderId.Size = new System.Drawing.Size(160, 26);
            this.domUDOrderId.TabIndex = 12;
            this.domUDOrderId.Text = "Wybierz zamówienie";
            this.domUDOrderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.domUDOrderId.SelectedItemChanged += new System.EventHandler(this.domUDOrderId_SelectedItemChanged);
            // 
            // domUDSfId
            // 
            this.domUDSfId.BackColor = System.Drawing.SystemColors.Window;
            this.domUDSfId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.domUDSfId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.domUDSfId.Location = new System.Drawing.Point(545, 277);
            this.domUDSfId.Name = "domUDSfId";
            this.domUDSfId.Size = new System.Drawing.Size(160, 26);
            this.domUDSfId.TabIndex = 13;
            this.domUDSfId.Text = "Id półfabrykatu";
            this.domUDSfId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(438, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(670, 737);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // txtboxThickness
            // 
            this.txtboxThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxThickness.Location = new System.Drawing.Point(835, 262);
            this.txtboxThickness.Name = "txtboxThickness";
            this.txtboxThickness.Size = new System.Drawing.Size(160, 26);
            this.txtboxThickness.TabIndex = 22;
            // 
            // txtboxWidth
            // 
            this.txtboxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxWidth.Location = new System.Drawing.Point(835, 335);
            this.txtboxWidth.Name = "txtboxWidth";
            this.txtboxWidth.Size = new System.Drawing.Size(160, 26);
            this.txtboxWidth.TabIndex = 23;
            // 
            // txtboxMass
            // 
            this.txtboxMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxMass.Location = new System.Drawing.Point(835, 407);
            this.txtboxMass.Name = "txtboxMass";
            this.txtboxMass.Size = new System.Drawing.Size(160, 26);
            this.txtboxMass.TabIndex = 24;
            // 
            // txtboxComment
            // 
            this.txtboxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxComment.Location = new System.Drawing.Point(817, 587);
            this.txtboxComment.Multiline = true;
            this.txtboxComment.Name = "txtboxComment";
            this.txtboxComment.Size = new System.Drawing.Size(202, 93);
            this.txtboxComment.TabIndex = 25;
            // 
            // checkBoxComposition
            // 
            this.checkBoxComposition.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxComposition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxComposition.Location = new System.Drawing.Point(825, 525);
            this.checkBoxComposition.Name = "checkBoxComposition";
            this.checkBoxComposition.Size = new System.Drawing.Size(170, 26);
            this.checkBoxComposition.TabIndex = 26;
            this.checkBoxComposition.Text = "Skład chemiczny";
            this.checkBoxComposition.UseVisualStyleBackColor = false;
            // 
            // lblParameterCheck
            // 
            this.lblParameterCheck.BackColor = System.Drawing.Color.Transparent;
            this.lblParameterCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParameterCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblParameterCheck.Location = new System.Drawing.Point(521, 480);
            this.lblParameterCheck.Name = "lblParameterCheck";
            this.lblParameterCheck.Size = new System.Drawing.Size(200, 26);
            this.lblParameterCheck.TabIndex = 28;
            this.lblParameterCheck.Text = "StatusKontroli";
            this.lblParameterCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(67, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 120);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Wyczyść dane";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDone.FlatAppearance.BorderSize = 3;
            this.btnDone.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDone.Image = ((System.Drawing.Image)(resources.GetObject("btnDone.Image")));
            this.btnDone.Location = new System.Drawing.Point(67, 614);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(200, 120);
            this.btnDone.TabIndex = 30;
            this.btnDone.Text = "Zatwierdź";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmployeeId.Location = new System.Drawing.Point(656, 317);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(49, 26);
            this.textBoxEmployeeId.TabIndex = 31;
            this.textBoxEmployeeId.TextChanged += new System.EventHandler(this.textBoxEmployeeId_TextChanged);
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeId.Location = new System.Drawing.Point(542, 320);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(114, 20);
            this.lblEmployeeId.TabIndex = 32;
            this.lblEmployeeId.Text = "ID pracownika:";
            // 
            // lblEmployeeFullName
            // 
            this.lblEmployeeFullName.AutoSize = true;
            this.lblEmployeeFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeFullName.Location = new System.Drawing.Point(551, 354);
            this.lblEmployeeFullName.Name = "lblEmployeeFullName";
            this.lblEmployeeFullName.Size = new System.Drawing.Size(13, 20);
            this.lblEmployeeFullName.TabIndex = 33;
            this.lblEmployeeFullName.Text = " ";
            // 
            // lblDaysOfDelay
            // 
            this.lblDaysOfDelay.AutoSize = true;
            this.lblDaysOfDelay.BackColor = System.Drawing.Color.Transparent;
            this.lblDaysOfDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDaysOfDelay.Location = new System.Drawing.Point(714, 236);
            this.lblDaysOfDelay.Name = "lblDaysOfDelay";
            this.lblDaysOfDelay.Size = new System.Drawing.Size(13, 20);
            this.lblDaysOfDelay.TabIndex = 33;
            this.lblDaysOfDelay.Text = " ";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblColor.Location = new System.Drawing.Point(835, 448);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(160, 26);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Kolor";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxColor.Location = new System.Drawing.Point(835, 477);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(160, 26);
            this.textBoxColor.TabIndex = 24;
            // 
            // picBoxChemicalComposition
            // 
            this.picBoxChemicalComposition.BackColor = System.Drawing.Color.Transparent;
            this.picBoxChemicalComposition.Location = new System.Drawing.Point(989, 522);
            this.picBoxChemicalComposition.Name = "picBoxChemicalComposition";
            this.picBoxChemicalComposition.Size = new System.Drawing.Size(30, 30);
            this.picBoxChemicalComposition.TabIndex = 34;
            this.picBoxChemicalComposition.TabStop = false;
            // 
            // datePickerControlDate
            // 
            this.datePickerControlDate.Enabled = false;
            this.datePickerControlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerControlDate.Location = new System.Drawing.Point(529, 407);
            this.datePickerControlDate.Name = "datePickerControlDate";
            this.datePickerControlDate.Size = new System.Drawing.Size(188, 26);
            this.datePickerControlDate.TabIndex = 35;
            this.datePickerControlDate.Value = new System.DateTime(2019, 4, 16, 20, 35, 51, 0);
            // 
            // EntranceControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.datePickerControlDate);
            this.Controls.Add(this.picBoxChemicalComposition);
            this.Controls.Add(this.lblDaysOfDelay);
            this.Controls.Add(this.lblEmployeeFullName);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.textBoxEmployeeId);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblParameterCheck);
            this.Controls.Add(this.checkBoxComposition);
            this.Controls.Add(this.txtboxComment);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.txtboxMass);
            this.Controls.Add(this.txtboxWidth);
            this.Controls.Add(this.txtboxThickness);
            this.Controls.Add(this.domUDSfId);
            this.Controls.Add(this.domUDOrderId);
            this.Controls.Add(this.picBoxControlStatus);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblMass);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblThickness);
            this.Controls.Add(this.lblControlDate);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntranceControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola Wejściowa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntranceControlForm_FormClosed);
            this.Load += new System.EventHandler(this.EntranceControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxControlStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChemicalComposition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblControlDate;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.PictureBox picBoxControlStatus;
        private System.Windows.Forms.DomainUpDown domUDOrderId;
        private System.Windows.Forms.DomainUpDown domUDSfId;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtboxThickness;
        private System.Windows.Forms.TextBox txtboxWidth;
        private System.Windows.Forms.TextBox txtboxMass;
        private System.Windows.Forms.TextBox txtboxComment;
        private System.Windows.Forms.CheckBox checkBoxComposition;
        private System.Windows.Forms.Label lblParameterCheck;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblEmployeeFullName;
        private System.Windows.Forms.Label lblDaysOfDelay;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.PictureBox picBoxChemicalComposition;
        private System.Windows.Forms.DateTimePicker datePickerControlDate;
    }
}