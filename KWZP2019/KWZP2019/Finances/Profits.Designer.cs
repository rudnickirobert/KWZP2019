namespace KWZP2019
{
    partial class Profits
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSpecifytimerange = new System.Windows.Forms.Label();
            this.btnAcceptselectedtime = new System.Windows.Forms.Button();
            this.lblListofrevenues = new System.Windows.Forms.Label();
            this.btnGenerategeneralreport = new System.Windows.Forms.Button();
            this.dgvProfits = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.dgvSalaries = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvOutsourcing = new System.Windows.Forms.DataGridView();
            this.btSum = new System.Windows.Forms.Button();
            this.tbSumIncome = new System.Windows.Forms.TextBox();
            this.tbSumOrders = new System.Windows.Forms.TextBox();
            this.tbSumOS = new System.Windows.Forms.TextBox();
            this.tbSumInvoices = new System.Windows.Forms.TextBox();
            this.tbSumPayment = new System.Windows.Forms.TextBox();
            this.tbPureMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutsourcing)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Location = new System.Drawing.Point(39, 20);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Location = new System.Drawing.Point(309, 20);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(9, 26);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(24, 13);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Od:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(279, 26);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 13);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Do:";
            // 
            // lblSpecifytimerange
            // 
            this.lblSpecifytimerange.AutoSize = true;
            this.lblSpecifytimerange.Location = new System.Drawing.Point(215, 4);
            this.lblSpecifytimerange.Name = "lblSpecifytimerange";
            this.lblSpecifytimerange.Size = new System.Drawing.Size(118, 13);
            this.lblSpecifytimerange.TabIndex = 4;
            this.lblSpecifytimerange.Text = "Określ zakres czasowy:";
            // 
            // btnAcceptselectedtime
            // 
            this.btnAcceptselectedtime.Location = new System.Drawing.Point(12, 46);
            this.btnAcceptselectedtime.Name = "btnAcceptselectedtime";
            this.btnAcceptselectedtime.Size = new System.Drawing.Size(497, 23);
            this.btnAcceptselectedtime.TabIndex = 5;
            this.btnAcceptselectedtime.Text = "Zatwierdź wybrany przedzial";
            this.btnAcceptselectedtime.UseVisualStyleBackColor = true;
            this.btnAcceptselectedtime.Click += new System.EventHandler(this.btnAcceptselectedtime_Click);
            // 
            // lblListofrevenues
            // 
            this.lblListofrevenues.AutoSize = true;
            this.lblListofrevenues.Location = new System.Drawing.Point(112, 83);
            this.lblListofrevenues.Name = "lblListofrevenues";
            this.lblListofrevenues.Size = new System.Drawing.Size(59, 13);
            this.lblListofrevenues.TabIndex = 7;
            this.lblListofrevenues.Text = "Przychody:";
            // 
            // btnGenerategeneralreport
            // 
            this.btnGenerategeneralreport.Location = new System.Drawing.Point(12, 499);
            this.btnGenerategeneralreport.Name = "btnGenerategeneralreport";
            this.btnGenerategeneralreport.Size = new System.Drawing.Size(771, 23);
            this.btnGenerategeneralreport.TabIndex = 9;
            this.btnGenerategeneralreport.Text = "Generuj raport";
            this.btnGenerategeneralreport.UseVisualStyleBackColor = true;
            this.btnGenerategeneralreport.Click += new System.EventHandler(this.btnGenerategeneralreport_Click);
            // 
            // dgvProfits
            // 
            this.dgvProfits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfits.Location = new System.Drawing.Point(12, 122);
            this.dgvProfits.Name = "dgvProfits";
            this.dgvProfits.Size = new System.Drawing.Size(267, 342);
            this.dgvProfits.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Wydatki:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Faktury:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Wypłaty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Zamówienia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Outsourcing:";
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(302, 122);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(230, 155);
            this.dgvInvoices.TabIndex = 16;
            // 
            // dgvSalaries
            // 
            this.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaries.Location = new System.Drawing.Point(553, 122);
            this.dgvSalaries.Name = "dgvSalaries";
            this.dgvSalaries.Size = new System.Drawing.Size(230, 155);
            this.dgvSalaries.TabIndex = 17;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(302, 309);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(230, 155);
            this.dgvOrders.TabIndex = 18;
            // 
            // dgvOutsourcing
            // 
            this.dgvOutsourcing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutsourcing.Location = new System.Drawing.Point(553, 309);
            this.dgvOutsourcing.Name = "dgvOutsourcing";
            this.dgvOutsourcing.Size = new System.Drawing.Size(230, 155);
            this.dgvOutsourcing.TabIndex = 19;
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(12, 470);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(771, 23);
            this.btSum.TabIndex = 20;
            this.btSum.Text = "Sumuj wszystkie widoki";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // tbSumIncome
            // 
            this.tbSumIncome.Location = new System.Drawing.Point(12, 99);
            this.tbSumIncome.Name = "tbSumIncome";
            this.tbSumIncome.Size = new System.Drawing.Size(267, 20);
            this.tbSumIncome.TabIndex = 21;
            // 
            // tbSumOrders
            // 
            this.tbSumOrders.Location = new System.Drawing.Point(394, 283);
            this.tbSumOrders.Name = "tbSumOrders";
            this.tbSumOrders.Size = new System.Drawing.Size(138, 20);
            this.tbSumOrders.TabIndex = 22;
            // 
            // tbSumOS
            // 
            this.tbSumOS.Location = new System.Drawing.Point(645, 283);
            this.tbSumOS.Name = "tbSumOS";
            this.tbSumOS.Size = new System.Drawing.Size(138, 20);
            this.tbSumOS.TabIndex = 23;
            // 
            // tbSumInvoices
            // 
            this.tbSumInvoices.Location = new System.Drawing.Point(394, 99);
            this.tbSumInvoices.Name = "tbSumInvoices";
            this.tbSumInvoices.Size = new System.Drawing.Size(138, 20);
            this.tbSumInvoices.TabIndex = 24;
            // 
            // tbSumPayment
            // 
            this.tbSumPayment.Location = new System.Drawing.Point(645, 96);
            this.tbSumPayment.Name = "tbSumPayment";
            this.tbSumPayment.Size = new System.Drawing.Size(138, 20);
            this.tbSumPayment.TabIndex = 25;
            // 
            // tbPureMoney
            // 
            this.tbPureMoney.Location = new System.Drawing.Point(553, 46);
            this.tbPureMoney.Name = "tbPureMoney";
            this.tbPureMoney.Size = new System.Drawing.Size(230, 20);
            this.tbPureMoney.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Czysty zysk firmy wynosi:";
            // 
            // Profits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPureMoney);
            this.Controls.Add(this.tbSumPayment);
            this.Controls.Add(this.tbSumInvoices);
            this.Controls.Add(this.tbSumOS);
            this.Controls.Add(this.tbSumOrders);
            this.Controls.Add(this.tbSumIncome);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.dgvOutsourcing);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.dgvSalaries);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProfits);
            this.Controls.Add(this.btnGenerategeneralreport);
            this.Controls.Add(this.lblListofrevenues);
            this.Controls.Add(this.btnAcceptselectedtime);
            this.Controls.Add(this.lblSpecifytimerange);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "Profits";
            this.Text = "Zyski";
            this.Load += new System.EventHandler(this.Profits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutsourcing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSpecifytimerange;
        private System.Windows.Forms.Button btnAcceptselectedtime;
        private System.Windows.Forms.Label lblListofrevenues;
        private System.Windows.Forms.Button btnGenerategeneralreport;
        private System.Windows.Forms.DataGridView dgvProfits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridView dgvSalaries;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvOutsourcing;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.TextBox tbSumIncome;
        private System.Windows.Forms.TextBox tbSumOrders;
        private System.Windows.Forms.TextBox tbSumOS;
        private System.Windows.Forms.TextBox tbSumInvoices;
        private System.Windows.Forms.TextBox tbSumPayment;
        private System.Windows.Forms.TextBox tbPureMoney;
        private System.Windows.Forms.Label label6;
    }
}