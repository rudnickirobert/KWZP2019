﻿namespace KWZP2019
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbSearchAbsence = new System.Windows.Forms.TextBox();
            this.lblSearchSurname = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(11, 102);
            this.dgvAbsences.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersVisible = false;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.Size = new System.Drawing.Size(535, 391);
            this.dgvAbsences.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(750, 507);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(257, 162);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Dodaj";

            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.UseVisualStyleBackColor = false;

            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(9, 507);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(250, 57);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // cbAbsenceType
            // 
            this.cbAbsenceType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cbAbsenceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbAbsenceType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbAbsenceType.FormattingEnabled = true;
            this.cbAbsenceType.Location = new System.Drawing.Point(812, 350);
            this.cbAbsenceType.Margin = new System.Windows.Forms.Padding(2);
            this.cbAbsenceType.Name = "cbAbsenceType";
            this.cbAbsenceType.Size = new System.Drawing.Size(259, 26);
            this.cbAbsenceType.TabIndex = 3;
            // 
            // lblAbsenceType
            // 
            this.lblAbsenceType.AutoSize = true;
            this.lblAbsenceType.BackColor = System.Drawing.Color.Transparent;
            this.lblAbsenceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblAbsenceType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAbsenceType.Location = new System.Drawing.Point(643, 358);
            this.lblAbsenceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbsenceType.Name = "lblAbsenceType";
            this.lblAbsenceType.Size = new System.Drawing.Size(140, 18);
            this.lblAbsenceType.TabIndex = 4;
            this.lblAbsenceType.Text = "Typ nieobecności";
            // 
            // dateTimePickerFirstDay
            // 
            this.dateTimePickerFirstDay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dateTimePickerFirstDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerFirstDay.Location = new System.Drawing.Point(812, 411);
            this.dateTimePickerFirstDay.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerFirstDay.Name = "dateTimePickerFirstDay";
            this.dateTimePickerFirstDay.Size = new System.Drawing.Size(259, 24);
            this.dateTimePickerFirstDay.TabIndex = 5;
            // 
            // lblFirstDay
            // 
            this.lblFirstDay.AutoSize = true;
            this.lblFirstDay.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblFirstDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFirstDay.Location = new System.Drawing.Point(662, 417);
            this.lblFirstDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstDay.Name = "lblFirstDay";
            this.lblFirstDay.Size = new System.Drawing.Size(121, 18);
            this.lblFirstDay.TabIndex = 6;
            this.lblFirstDay.Text = "Pierwszy dzień";
            // 
            // dateTimePickerLastDay
            // 
            this.dateTimePickerLastDay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dateTimePickerLastDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePickerLastDay.Location = new System.Drawing.Point(812, 470);
            this.dateTimePickerLastDay.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerLastDay.Name = "dateTimePickerLastDay";
            this.dateTimePickerLastDay.Size = new System.Drawing.Size(259, 24);
            this.dateTimePickerLastDay.TabIndex = 7;
            // 
            // lblLastDay
            // 
            this.lblLastDay.AutoSize = true;
            this.lblLastDay.BackColor = System.Drawing.Color.Transparent;
            this.lblLastDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblLastDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLastDay.Location = new System.Drawing.Point(676, 476);
            this.lblLastDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastDay.Name = "lblLastDay";
            this.lblLastDay.Size = new System.Drawing.Size(107, 18);
            this.lblLastDay.TabIndex = 8;
            this.lblLastDay.Text = "Ostatni dzień";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(299, 507);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(247, 57);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbLastName.Location = new System.Drawing.Point(812, 291);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(259, 24);
            this.tbLastName.TabIndex = 10;
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbFirstName.Location = new System.Drawing.Point(812, 232);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(259, 24);
            this.tbFirstName.TabIndex = 11;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFirstName.Location = new System.Drawing.Point(744, 238);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(39, 18);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLastName.Location = new System.Drawing.Point(701, 297);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 18);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Nazwisko";
            // 
            // tbSearchAbsence
            // 
            this.tbSearchAbsence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbSearchAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbSearchAbsence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSearchAbsence.Location = new System.Drawing.Point(15, 56);
            this.tbSearchAbsence.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchAbsence.Name = "tbSearchAbsence";
            this.tbSearchAbsence.Size = new System.Drawing.Size(271, 24);
            this.tbSearchAbsence.TabIndex = 14;
            this.tbSearchAbsence.TextChanged += new System.EventHandler(this.tbSearchAbsence_TextChanged);
            // 
            // lblSearchSurname
            // 
            this.lblSearchSurname.AutoSize = true;
            this.lblSearchSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearchSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchSurname.Location = new System.Drawing.Point(17, 25);
            this.lblSearchSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchSurname.Name = "lblSearchSurname";
            this.lblSearchSurname.Size = new System.Drawing.Size(82, 18);
            this.lblSearchSurname.TabIndex = 15;
            this.lblSearchSurname.Text = "Nazwisko";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearchName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchName.Location = new System.Drawing.Point(346, 25);
            this.lblSearchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(39, 18);
            this.lblSearchName.TabIndex = 16;
            this.lblSearchName.Text = "Imię";
            // 
            // tbSearchName
            // 
            this.tbSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbSearchName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSearchName.Location = new System.Drawing.Point(349, 56);
            this.tbSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(197, 24);
            this.tbSearchName.TabIndex = 17;
            this.tbSearchName.TextChanged += new System.EventHandler(this.tbSearchName_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(9, 576);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(256, 152);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.Location = new System.Drawing.Point(299, 576);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(247, 154);
            this.btnReturnMain.TabIndex = 19;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Location = new System.Drawing.Point(736, 135);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(283, 25);
            this.lblFormTitle.TabIndex = 34;
            this.lblFormTitle.Text = "Dodaj nieobecność pracownika";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(585, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 716);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Absences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.lblSearchSurname);
            this.Controls.Add(this.tbSearchAbsence);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblLastDay);
            this.Controls.Add(this.dateTimePickerLastDay);
            this.Controls.Add(this.lblFirstDay);
            this.Controls.Add(this.dateTimePickerFirstDay);
            this.Controls.Add(this.lblAbsenceType);
            this.Controls.Add(this.cbAbsenceType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Absences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Absences";
            this.Load += new System.EventHandler(this.Absences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbSearchAbsence;
        private System.Windows.Forms.Label lblSearchSurname;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}