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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalariesSummary));
            this.dgvSalariesData = new System.Windows.Forms.DataGridView();
            this.FullSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAcceptChangesAndSendToDatabase = new System.Windows.Forms.Button();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.tbCurrentDate = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalariesData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalariesData
            // 
            this.dgvSalariesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalariesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullSalary,
            this.Bonus});
            this.dgvSalariesData.Location = new System.Drawing.Point(285, 241);
            this.dgvSalariesData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSalariesData.Name = "dgvSalariesData";
            this.dgvSalariesData.ReadOnly = true;
            this.dgvSalariesData.Size = new System.Drawing.Size(1072, 313);
            this.dgvSalariesData.TabIndex = 0;
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
            // btnAcceptChangesAndSendToDatabase
            // 
            this.btnAcceptChangesAndSendToDatabase.Location = new System.Drawing.Point(676, 775);
            this.btnAcceptChangesAndSendToDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceptChangesAndSendToDatabase.Name = "btnAcceptChangesAndSendToDatabase";
            this.btnAcceptChangesAndSendToDatabase.Size = new System.Drawing.Size(429, 28);
            this.btnAcceptChangesAndSendToDatabase.TabIndex = 1;
            this.btnAcceptChangesAndSendToDatabase.Text = "Zatwierdź zmiany i zapisz je do bazy";
            this.btnAcceptChangesAndSendToDatabase.UseVisualStyleBackColor = true;
            this.btnAcceptChangesAndSendToDatabase.Click += new System.EventHandler(this.btnAcceptChanges_Click);
            // 
            // tbBonus
            // 
            this.tbBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbBonus.Location = new System.Drawing.Point(569, 98);
            this.tbBonus.Margin = new System.Windows.Forms.Padding(4);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(256, 23);
            this.tbBonus.TabIndex = 3;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblInstruction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInstruction.Location = new System.Drawing.Point(282, 198);
            this.lblInstruction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(444, 18);
            this.lblInstruction.TabIndex = 4;
            this.lblInstruction.Text = "Wybierz wiersz z pracownikiem, aby przyznać mu premię:";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.BackColor = System.Drawing.Color.Transparent;
            this.lblBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblBonus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBonus.Location = new System.Drawing.Point(282, 101);
            this.lblBonus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(189, 18);
            this.lblBonus.TabIndex = 5;
            this.lblBonus.Text = "Wprowadź kwotę premii";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurrentDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentDate.Location = new System.Drawing.Point(282, 74);
            this.lblCurrentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(105, 18);
            this.lblCurrentDate.TabIndex = 6;
            this.lblCurrentDate.Text = "Bieżąca data";
            // 
            // tbCurrentDate
            // 
            this.tbCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbCurrentDate.Location = new System.Drawing.Point(569, 71);
            this.tbCurrentDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbCurrentDate.Name = "tbCurrentDate";
            this.tbCurrentDate.ReadOnly = true;
            this.tbCurrentDate.Size = new System.Drawing.Size(256, 23);
            this.tbCurrentDate.TabIndex = 7;
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
            this.btnReturn.Location = new System.Drawing.Point(8, 76);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(247, 154);
            this.btnReturn.TabIndex = 29;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
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
            this.btnReturnMain.Location = new System.Drawing.Point(9, 241);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(247, 154);
            this.btnReturnMain.TabIndex = 30;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            // 
            // SalariesSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbCurrentDate);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.btnAcceptChangesAndSendToDatabase);
            this.Controls.Add(this.dgvSalariesData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalariesSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
    }
}