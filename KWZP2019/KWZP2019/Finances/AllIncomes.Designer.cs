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
            this.btSum = new System.Windows.Forms.Button();
            this.dgvProfits = new System.Windows.Forms.DataGridView();
            this.btnGenerategeneralreport = new System.Windows.Forms.Button();
            this.lblListofrevenues = new System.Windows.Forms.Label();
            this.btnAcceptselectedtime = new System.Windows.Forms.Button();
            this.lblSpecifytimerange = new System.Windows.Forms.Label();
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
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(12, 480);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(497, 23);
            this.btSum.TabIndex = 31;
            this.btSum.Text = "Sumuj wszystkie widoki";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // dgvProfits
            // 
            this.dgvProfits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfits.Location = new System.Drawing.Point(12, 132);
            this.dgvProfits.Name = "dgvProfits";
            this.dgvProfits.Size = new System.Drawing.Size(497, 342);
            this.dgvProfits.TabIndex = 30;
            // 
            // btnGenerategeneralreport
            // 
            this.btnGenerategeneralreport.Location = new System.Drawing.Point(12, 509);
            this.btnGenerategeneralreport.Name = "btnGenerategeneralreport";
            this.btnGenerategeneralreport.Size = new System.Drawing.Size(497, 23);
            this.btnGenerategeneralreport.TabIndex = 29;
            this.btnGenerategeneralreport.Text = "Generuj raport";
            this.btnGenerategeneralreport.UseVisualStyleBackColor = true;
            this.btnGenerategeneralreport.Click += new System.EventHandler(this.btnGenerategeneralreport_Click);
            // 
            // lblListofrevenues
            // 
            this.lblListofrevenues.AutoSize = true;
            this.lblListofrevenues.Location = new System.Drawing.Point(251, 93);
            this.lblListofrevenues.Name = "lblListofrevenues";
            this.lblListofrevenues.Size = new System.Drawing.Size(35, 13);
            this.lblListofrevenues.TabIndex = 28;
            this.lblListofrevenues.Text = "Zyski:";
            // 
            // btnAcceptselectedtime
            // 
            this.btnAcceptselectedtime.Location = new System.Drawing.Point(12, 56);
            this.btnAcceptselectedtime.Name = "btnAcceptselectedtime";
            this.btnAcceptselectedtime.Size = new System.Drawing.Size(497, 23);
            this.btnAcceptselectedtime.TabIndex = 27;
            this.btnAcceptselectedtime.Text = "Zatwierdź wybrany przedzial";
            this.btnAcceptselectedtime.UseVisualStyleBackColor = true;
            this.btnAcceptselectedtime.Click += new System.EventHandler(this.btnAcceptselectedtime_Click);
            // 
            // lblSpecifytimerange
            // 
            this.lblSpecifytimerange.AutoSize = true;
            this.lblSpecifytimerange.Location = new System.Drawing.Point(215, 14);
            this.lblSpecifytimerange.Name = "lblSpecifytimerange";
            this.lblSpecifytimerange.Size = new System.Drawing.Size(118, 13);
            this.lblSpecifytimerange.TabIndex = 26;
            this.lblSpecifytimerange.Text = "Określ zakres czasowy:";
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
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.dgvProfits);
            this.Controls.Add(this.btnGenerategeneralreport);
            this.Controls.Add(this.lblListofrevenues);
            this.Controls.Add(this.btnAcceptselectedtime);
            this.Controls.Add(this.lblSpecifytimerange);
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
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.DataGridView dgvProfits;
        private System.Windows.Forms.Button btnGenerategeneralreport;
        private System.Windows.Forms.Label lblListofrevenues;
        private System.Windows.Forms.Button btnAcceptselectedtime;
        private System.Windows.Forms.Label lblSpecifytimerange;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblPln;
    }
}