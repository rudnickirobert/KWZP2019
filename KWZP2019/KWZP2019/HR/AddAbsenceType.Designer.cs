namespace KWZP2019
{
    partial class AddAbsenceType
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
            this.lblAbsenceReason = new System.Windows.Forms.Label();
            this.tbAbsenceReason = new System.Windows.Forms.TextBox();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.tbMultiplier = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAbsencesTypes = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsencesTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAbsenceReason
            // 
            this.lblAbsenceReason.AutoSize = true;
            this.lblAbsenceReason.Location = new System.Drawing.Point(421, 207);
            this.lblAbsenceReason.Name = "lblAbsenceReason";
            this.lblAbsenceReason.Size = new System.Drawing.Size(137, 17);
            this.lblAbsenceReason.TabIndex = 0;
            this.lblAbsenceReason.Text = "Powód nieobecności";
            // 
            // tbAbsenceReason
            // 
            this.tbAbsenceReason.Location = new System.Drawing.Point(647, 207);
            this.tbAbsenceReason.Name = "tbAbsenceReason";
            this.tbAbsenceReason.Size = new System.Drawing.Size(100, 22);
            this.tbAbsenceReason.TabIndex = 1;
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(421, 249);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(181, 17);
            this.lblMultiplier.TabIndex = 2;
            this.lblMultiplier.Text = "Współczynnik nieobecności";
            // 
            // tbMultiplier
            // 
            this.tbMultiplier.Location = new System.Drawing.Point(647, 249);
            this.tbMultiplier.Name = "tbMultiplier";
            this.tbMultiplier.Size = new System.Drawing.Size(100, 22);
            this.tbMultiplier.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(579, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAbsencesTypes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvAbsencesTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAbsencesTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAbsencesTypes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvAbsencesTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsencesTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAbsencesTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsencesTypes.EnableHeadersVisualStyles = false;
            this.dgvAbsencesTypes.Location = new System.Drawing.Point(12, 25);
            this.dgvAbsencesTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAbsencesTypes.Name = "dgvAbsencesTypes";
            this.dgvAbsencesTypes.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAbsencesTypes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAbsencesTypes.RowTemplate.Height = 24;
            this.dgvAbsencesTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsencesTypes.Size = new System.Drawing.Size(340, 390);
            this.dgvAbsencesTypes.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(385, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddAbsenceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAbsencesTypes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbMultiplier);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.tbAbsenceReason);
            this.Controls.Add(this.lblAbsenceReason);
            this.Name = "AddAbsenceType";
            this.Text = "AddAbsenceType";
            this.Load += new System.EventHandler(this.AddAbsenceType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsencesTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbsenceReason;
        private System.Windows.Forms.TextBox tbAbsenceReason;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.TextBox tbMultiplier;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAbsencesTypes;
        private System.Windows.Forms.Button btnDelete;
    }
}