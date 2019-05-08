namespace KWZP2019
{
    partial class SalariesSummary
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
            this.dgvSalariesData = new System.Windows.Forms.DataGridView();
            this.btnAcceptChangesAndSendToDatabase = new System.Windows.Forms.Button();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.tbCurrentDate = new System.Windows.Forms.TextBox();
            this.FullSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalariesData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalariesData
            // 
            this.dgvSalariesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalariesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullSalary,
            this.Bonus});
            this.dgvSalariesData.Location = new System.Drawing.Point(12, 84);
            this.dgvSalariesData.Name = "dgvSalariesData";
            this.dgvSalariesData.ReadOnly = true;
            this.dgvSalariesData.Size = new System.Drawing.Size(971, 254);
            this.dgvSalariesData.TabIndex = 0;
            // 
            // btnAcceptChangesAndSendToDatabase
            // 
            this.btnAcceptChangesAndSendToDatabase.Location = new System.Drawing.Point(12, 344);
            this.btnAcceptChangesAndSendToDatabase.Name = "btnAcceptChangesAndSendToDatabase";
            this.btnAcceptChangesAndSendToDatabase.Size = new System.Drawing.Size(322, 23);
            this.btnAcceptChangesAndSendToDatabase.TabIndex = 1;
            this.btnAcceptChangesAndSendToDatabase.Text = "Zatwierdź zmiany i zapisz je do bazy";
            this.btnAcceptChangesAndSendToDatabase.UseVisualStyleBackColor = true;
            this.btnAcceptChangesAndSendToDatabase.Click += new System.EventHandler(this.btnAcceptChanges_Click);
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(141, 28);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(193, 20);
            this.tbBonus.TabIndex = 3;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(12, 68);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(275, 13);
            this.lblInstruction.TabIndex = 4;
            this.lblInstruction.Text = "Wybierz wiersz z pracownikiem, aby przyznać mu premię:";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(12, 31);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(123, 13);
            this.lblBonus.TabIndex = 5;
            this.lblBonus.Text = "Wprowadź kwotę premii:";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(72, 13);
            this.lblCurrentDate.TabIndex = 6;
            this.lblCurrentDate.Text = "Bieżąca data:";
            // 
            // tbCurrentDate
            // 
            this.tbCurrentDate.Location = new System.Drawing.Point(141, 6);
            this.tbCurrentDate.Name = "tbCurrentDate";
            this.tbCurrentDate.ReadOnly = true;
            this.tbCurrentDate.Size = new System.Drawing.Size(193, 20);
            this.tbCurrentDate.TabIndex = 7;
            // 
            // FullSalary
            // 
            this.FullSalary.HeaderText = "Pensja z premią";
            this.FullSalary.Name = "FullSalary";
            this.FullSalary.ReadOnly = true;
            // 
            // Bonus
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.Bonus.DefaultCellStyle = dataGridViewCellStyle1;
            this.Bonus.HeaderText = "Premia";
            this.Bonus.Name = "Bonus";
            this.Bonus.ReadOnly = true;
            this.Bonus.ToolTipText = "0";
            // 
            // SalariesSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 416);
            this.Controls.Add(this.tbCurrentDate);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.btnAcceptChangesAndSendToDatabase);
            this.Controls.Add(this.dgvSalariesData);
            this.Name = "SalariesSummary";
            this.Text = "Podlicz wypłaty";
            this.Load += new System.EventHandler(this.SalariesSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalariesData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalariesData;
        private System.Windows.Forms.Button btnAcceptChangesAndSendToDatabase;
        private System.Windows.Forms.TextBox tbBonus;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.TextBox tbCurrentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
    }
}