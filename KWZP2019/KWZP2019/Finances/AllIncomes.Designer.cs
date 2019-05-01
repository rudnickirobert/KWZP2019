namespace KWZP2019
{
    partial class AllIncomes
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
            this.tbSumIncome = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.dgvProfits = new System.Windows.Forms.DataGridView();
            this.btnGenerateGeneralReport = new System.Windows.Forms.Button();
            this.lblIncomes = new System.Windows.Forms.Label();
            this.btnAcceptSelectedTime = new System.Windows.Forms.Button();
            this.lblSpecifyTimeRange = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblPln = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSumIncome
            // 
            this.tbSumIncome.Location = new System.Drawing.Point(12, 109);
            this.tbSumIncome.Name = "tbSumIncome";
            this.tbSumIncome.ReadOnly = true;
            this.tbSumIncome.Size = new System.Drawing.Size(416, 20);
            this.tbSumIncome.TabIndex = 32;
            this.tbSumIncome.Text = "0";
            this.tbSumIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(12, 480);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(497, 23);
            this.btnSum.TabIndex = 31;
            this.btnSum.Text = "Sumuj wszystkie widoki";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // dgvProfits
            // 
            this.dgvProfits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfits.Location = new System.Drawing.Point(12, 132);
            this.dgvProfits.Name = "dgvProfits";
            this.dgvProfits.Size = new System.Drawing.Size(497, 342);
            this.dgvProfits.TabIndex = 30;
            // 
            // btnGenerateGeneralReport
            // 
            this.btnGenerateGeneralReport.Location = new System.Drawing.Point(12, 509);
            this.btnGenerateGeneralReport.Name = "btnGenerateGeneralReport";
            this.btnGenerateGeneralReport.Size = new System.Drawing.Size(497, 23);
            this.btnGenerateGeneralReport.TabIndex = 29;
            this.btnGenerateGeneralReport.Text = "Generuj raport";
            this.btnGenerateGeneralReport.UseVisualStyleBackColor = true;
            this.btnGenerateGeneralReport.Click += new System.EventHandler(this.btnGenerateGeneralReport_Click);
            // 
            // lblIncomes
            // 
            this.lblIncomes.AutoSize = true;
            this.lblIncomes.Location = new System.Drawing.Point(251, 93);
            this.lblIncomes.Name = "lblIncomes";
            this.lblIncomes.Size = new System.Drawing.Size(35, 13);
            this.lblIncomes.TabIndex = 28;
            this.lblIncomes.Text = "Zyski:";
            // 
            // btnAcceptSelectedTime
            // 
            this.btnAcceptSelectedTime.Location = new System.Drawing.Point(12, 56);
            this.btnAcceptSelectedTime.Name = "btnAcceptSelectedTime";
            this.btnAcceptSelectedTime.Size = new System.Drawing.Size(497, 23);
            this.btnAcceptSelectedTime.TabIndex = 27;
            this.btnAcceptSelectedTime.Text = "Zatwierdź wybrany przedzial";
            this.btnAcceptSelectedTime.UseVisualStyleBackColor = true;
            this.btnAcceptSelectedTime.Click += new System.EventHandler(this.btnAcceptSelectedTime_Click);
            // 
            // lblSpecifyTimeRange
            // 
            this.lblSpecifyTimeRange.AutoSize = true;
            this.lblSpecifyTimeRange.Location = new System.Drawing.Point(215, 14);
            this.lblSpecifyTimeRange.Name = "lblSpecifyTimeRange";
            this.lblSpecifyTimeRange.Size = new System.Drawing.Size(118, 13);
            this.lblSpecifyTimeRange.TabIndex = 26;
            this.lblSpecifyTimeRange.Text = "Określ zakres czasowy:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(279, 36);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 13);
            this.lblTo.TabIndex = 25;
            this.lblTo.Text = "Do:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(9, 36);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(24, 13);
            this.lblFrom.TabIndex = 24;
            this.lblFrom.Text = "Od:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Location = new System.Drawing.Point(309, 30);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 23;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Location = new System.Drawing.Point(39, 30);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 22;
            // 
            // lblPln
            // 
            this.lblPln.AutoSize = true;
            this.lblPln.Location = new System.Drawing.Point(434, 112);
            this.lblPln.Name = "lblPln";
            this.lblPln.Size = new System.Drawing.Size(75, 13);
            this.lblPln.TabIndex = 33;
            this.lblPln.Text = "złotych (netto)";
            // 
            // AllIncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 551);
            this.Controls.Add(this.lblPln);
            this.Controls.Add(this.tbSumIncome);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.dgvProfits);
            this.Controls.Add(this.btnGenerateGeneralReport);
            this.Controls.Add(this.lblIncomes);
            this.Controls.Add(this.btnAcceptSelectedTime);
            this.Controls.Add(this.lblSpecifyTimeRange);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "AllIncomes";
            this.Text = "Zyski";
            this.Load += new System.EventHandler(this.AllCosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSumIncome;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.DataGridView dgvProfits;
        private System.Windows.Forms.Button btnGenerateGeneralReport;
        private System.Windows.Forms.Label lblIncomes;
        private System.Windows.Forms.Button btnAcceptSelectedTime;
        private System.Windows.Forms.Label lblSpecifyTimeRange;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblPln;
    }
}