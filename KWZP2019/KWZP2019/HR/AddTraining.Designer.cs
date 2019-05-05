namespace KWZP2019
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
            this.dgvTrainings = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTrainingName = new System.Windows.Forms.Label();
            this.tbTrainingName = new System.Windows.Forms.TextBox();
            this.lblTrainingStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerTrainingStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTrainingEndDate = new System.Windows.Forms.DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainings
            // 
            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainings.Location = new System.Drawing.Point(27, 54);
            this.dgvTrainings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.RowHeadersVisible = false;
            this.dgvTrainings.RowTemplate.Height = 24;
            this.dgvTrainings.Size = new System.Drawing.Size(503, 353);
            this.dgvTrainings.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(555, 396);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(635, 396);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblTrainingName
            // 
            this.lblTrainingName.AutoSize = true;
            this.lblTrainingName.Location = new System.Drawing.Point(569, 34);
            this.lblTrainingName.Name = "lblTrainingName";
            this.lblTrainingName.Size = new System.Drawing.Size(113, 17);
            this.lblTrainingName.TabIndex = 3;
            this.lblTrainingName.Text = "Nazwa szkolenia";
            // 
            // tbTrainingName
            // 
            this.tbTrainingName.Location = new System.Drawing.Point(572, 54);
            this.tbTrainingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTrainingName.Name = "tbTrainingName";
            this.tbTrainingName.Size = new System.Drawing.Size(100, 22);
            this.tbTrainingName.TabIndex = 4;
            // 
            // lblTrainingStartDate
            // 
            this.lblTrainingStartDate.AutoSize = true;
            this.lblTrainingStartDate.Location = new System.Drawing.Point(572, 95);
            this.lblTrainingStartDate.Name = "lblTrainingStartDate";
            this.lblTrainingStartDate.Size = new System.Drawing.Size(129, 17);
            this.lblTrainingStartDate.TabIndex = 5;
            this.lblTrainingStartDate.Text = "Początek szkolenia";
            // 
            // dateTimePickerTrainingStartDate
            // 
            this.dateTimePickerTrainingStartDate.Location = new System.Drawing.Point(572, 114);
            this.dateTimePickerTrainingStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTrainingStartDate.Name = "dateTimePickerTrainingStartDate";
            this.dateTimePickerTrainingStartDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTrainingStartDate.TabIndex = 6;
            // 
            // dateTimePickerTrainingEndDate
            // 
            this.dateTimePickerTrainingEndDate.Location = new System.Drawing.Point(572, 176);
            this.dateTimePickerTrainingEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTrainingEndDate.Name = "dateTimePickerTrainingEndDate";
            this.dateTimePickerTrainingEndDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTrainingEndDate.TabIndex = 7;
            // 
            // lblTrainingEndDate
            // 
            this.lblTrainingEndDate.AutoSize = true;
            this.lblTrainingEndDate.Location = new System.Drawing.Point(572, 157);
            this.lblTrainingEndDate.Name = "lblTrainingEndDate";
            this.lblTrainingEndDate.Size = new System.Drawing.Size(114, 17);
            this.lblTrainingEndDate.TabIndex = 8;
            this.lblTrainingEndDate.Text = "Koniec szkolenia";
            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.AutoSize = true;
            this.lblEmployeeFirstName.Location = new System.Drawing.Point(572, 212);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new System.Drawing.Size(108, 17);
            this.lblEmployeeFirstName.TabIndex = 9;
            this.lblEmployeeFirstName.Text = "Imię pracownika";
            // 
            // tbEmployeeFirstName
            // 
            this.tbEmployeeFirstName.Location = new System.Drawing.Point(572, 231);
            this.tbEmployeeFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeeFirstName.Name = "tbEmployeeFirstName";
            this.tbEmployeeFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbEmployeeFirstName.TabIndex = 10;
            // 
            // tbEmployeeLastName
            // 
            this.tbEmployeeLastName.Location = new System.Drawing.Point(575, 284);
            this.tbEmployeeLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeeLastName.Name = "tbEmployeeLastName";
            this.tbEmployeeLastName.Size = new System.Drawing.Size(100, 22);
            this.tbEmployeeLastName.TabIndex = 11;
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.AutoSize = true;
            this.lblEmployeeLastName.Location = new System.Drawing.Point(572, 265);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(142, 17);
            this.lblEmployeeLastName.TabIndex = 12;
            this.lblEmployeeLastName.Text = "Nazwisko pracownika";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(716, 396);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 42);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // tbTrainingPrice
            // 
            this.tbTrainingPrice.Location = new System.Drawing.Point(572, 341);
            this.tbTrainingPrice.Name = "tbTrainingPrice";
            this.tbTrainingPrice.Size = new System.Drawing.Size(153, 22);
            this.tbTrainingPrice.TabIndex = 14;
            // 
            // lblTrainingPrice
            // 
            this.lblTrainingPrice.AutoSize = true;
            this.lblTrainingPrice.Location = new System.Drawing.Point(572, 321);
            this.lblTrainingPrice.Name = "lblTrainingPrice";
            this.lblTrainingPrice.Size = new System.Drawing.Size(43, 17);
            this.lblTrainingPrice.TabIndex = 15;
            this.lblTrainingPrice.Text = "Koszt";
            // 
            // tbSearchTraining
            // 
            this.tbSearchTraining.Location = new System.Drawing.Point(27, 27);
            this.tbSearchTraining.Name = "tbSearchTraining";
            this.tbSearchTraining.Size = new System.Drawing.Size(201, 22);
            this.tbSearchTraining.TabIndex = 16;
            this.tbSearchTraining.TextChanged += new System.EventHandler(this.tbSearchTraining_TextChanged);
            // 
            // tbSearchTrainingName
            // 
            this.tbSearchTrainingName.Location = new System.Drawing.Point(329, 27);
            this.tbSearchTrainingName.Name = "tbSearchTrainingName";
            this.tbSearchTrainingName.Size = new System.Drawing.Size(201, 22);
            this.tbSearchTrainingName.TabIndex = 17;
            this.tbSearchTrainingName.TextChanged += new System.EventHandler(this.tbSearchTrainingName_TextChanged);
            // 
            // lblSearchTrainingSurname
            // 
            this.lblSearchTrainingSurname.AutoSize = true;
            this.lblSearchTrainingSurname.Location = new System.Drawing.Point(24, 7);
            this.lblSearchTrainingSurname.Name = "lblSearchTrainingSurname";
            this.lblSearchTrainingSurname.Size = new System.Drawing.Size(67, 17);
            this.lblSearchTrainingSurname.TabIndex = 18;
            this.lblSearchTrainingSurname.Text = "Nazwisko";
            // 
            // lblSearchTrainingName
            // 
            this.lblSearchTrainingName.AutoSize = true;
            this.lblSearchTrainingName.Location = new System.Drawing.Point(326, 7);
            this.lblSearchTrainingName.Name = "lblSearchTrainingName";
            this.lblSearchTrainingName.Size = new System.Drawing.Size(33, 17);
            this.lblSearchTrainingName.TabIndex = 19;
            this.lblSearchTrainingName.Text = "Imię";
            // 
            // AddTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.dateTimePickerTrainingEndDate);
            this.Controls.Add(this.dateTimePickerTrainingStartDate);
            this.Controls.Add(this.lblTrainingStartDate);
            this.Controls.Add(this.tbTrainingName);
            this.Controls.Add(this.lblTrainingName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTrainings);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTraining";
            this.Text = "AddTraining";
            this.Load += new System.EventHandler(this.AddTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dateTimePickerTrainingStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTrainingEndDate;
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
    }
}