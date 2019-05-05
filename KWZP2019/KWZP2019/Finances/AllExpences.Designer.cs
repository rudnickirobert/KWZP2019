namespace KWZP2019
{
    partial class AllExpenses
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
            this.tbSumPayment = new System.Windows.Forms.TextBox();
            this.tbSumInvoices = new System.Windows.Forms.TextBox();
            this.tbSumOS = new System.Windows.Forms.TextBox();
            this.tbSumOrders = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.dgvOutsourcing = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvSalaries = new System.Windows.Forms.DataGridView();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.lblOutsourcing = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblSalaries = new System.Windows.Forms.Label();
            this.lblInvoices = new System.Windows.Forms.Label();
            this.lblExpences = new System.Windows.Forms.Label();
            this.btnGenerateGeneralReport = new System.Windows.Forms.Button();
            this.btnAcceptSelectedTime = new System.Windows.Forms.Button();
            this.lblSpecifyTimeRange = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tbExpencesSum = new System.Windows.Forms.TextBox();
            this.lblSumExpences = new System.Windows.Forms.Label();
            this.lblInvoicesPln = new System.Windows.Forms.Label();
            this.lblOrdersPln = new System.Windows.Forms.Label();
            this.lblSalariesPln = new System.Windows.Forms.Label();
            this.lblOutsourcingPln = new System.Windows.Forms.Label();
            this.lblSumPln = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutsourcing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSumPayment
            // 
            this.tbSumPayment.Location = new System.Drawing.Point(332, 104);
            this.tbSumPayment.Name = "tbSumPayment";
            this.tbSumPayment.ReadOnly = true;
            this.tbSumPayment.Size = new System.Drawing.Size(96, 20);
            this.tbSumPayment.TabIndex = 46;
            this.tbSumPayment.Text = "0";
            this.tbSumPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumInvoices
            // 
            this.tbSumInvoices.Location = new System.Drawing.Point(65, 104);
            this.tbSumInvoices.Name = "tbSumInvoices";
            this.tbSumInvoices.ReadOnly = true;
            this.tbSumInvoices.Size = new System.Drawing.Size(101, 20);
            this.tbSumInvoices.TabIndex = 45;
            this.tbSumInvoices.Text = "0";
            this.tbSumInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumOS
            // 
            this.tbSumOS.Location = new System.Drawing.Point(349, 288);
            this.tbSumOS.Name = "tbSumOS";
            this.tbSumOS.ReadOnly = true;
            this.tbSumOS.Size = new System.Drawing.Size(79, 20);
            this.tbSumOS.TabIndex = 44;
            this.tbSumOS.Text = "0";
            this.tbSumOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumOrders
            // 
            this.tbSumOrders.Location = new System.Drawing.Point(87, 288);
            this.tbSumOrders.Name = "tbSumOrders";
            this.tbSumOrders.ReadOnly = true;
            this.tbSumOrders.Size = new System.Drawing.Size(79, 20);
            this.tbSumOrders.TabIndex = 43;
            this.tbSumOrders.Text = "0";
            this.tbSumOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(12, 560);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(497, 23);
            this.btnSum.TabIndex = 42;
            this.btnSum.Text = "Sumuj wszystkie widoki";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // dgvOutsourcing
            // 
            this.dgvOutsourcing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutsourcing.Location = new System.Drawing.Point(279, 314);
            this.dgvOutsourcing.Name = "dgvOutsourcing";
            this.dgvOutsourcing.Size = new System.Drawing.Size(230, 155);
            this.dgvOutsourcing.TabIndex = 41;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(17, 314);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(230, 155);
            this.dgvOrders.TabIndex = 40;
            // 
            // dgvSalaries
            // 
            this.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaries.Location = new System.Drawing.Point(279, 127);
            this.dgvSalaries.Name = "dgvSalaries";
            this.dgvSalaries.Size = new System.Drawing.Size(230, 155);
            this.dgvSalaries.TabIndex = 39;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(17, 127);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(230, 155);
            this.dgvInvoices.TabIndex = 38;
            // 
            // lblOutsourcing
            // 
            this.lblOutsourcing.AutoSize = true;
            this.lblOutsourcing.Location = new System.Drawing.Point(276, 291);
            this.lblOutsourcing.Name = "lblOutsourcing";
            this.lblOutsourcing.Size = new System.Drawing.Size(67, 13);
            this.lblOutsourcing.TabIndex = 37;
            this.lblOutsourcing.Text = "Outsourcing:";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(14, 291);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(67, 13);
            this.lblOrders.TabIndex = 36;
            this.lblOrders.Text = "Zamówienia:";
            // 
            // lblSalaries
            // 
            this.lblSalaries.AutoSize = true;
            this.lblSalaries.Location = new System.Drawing.Point(276, 111);
            this.lblSalaries.Name = "lblSalaries";
            this.lblSalaries.Size = new System.Drawing.Size(50, 13);
            this.lblSalaries.TabIndex = 35;
            this.lblSalaries.Text = "Wypłaty:";
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.Location = new System.Drawing.Point(14, 111);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(45, 13);
            this.lblInvoices.TabIndex = 34;
            this.lblInvoices.Text = "Faktury:";
            // 
            // lblExpences
            // 
            this.lblExpences.AutoSize = true;
            this.lblExpences.Location = new System.Drawing.Point(232, 88);
            this.lblExpences.Name = "lblExpences";
            this.lblExpences.Size = new System.Drawing.Size(49, 13);
            this.lblExpences.TabIndex = 33;
            this.lblExpences.Text = "Wydatki:";
            // 
            // btnGenerateGeneralReport
            // 
            this.btnGenerateGeneralReport.Location = new System.Drawing.Point(12, 589);
            this.btnGenerateGeneralReport.Name = "btnGenerateGeneralReport";
            this.btnGenerateGeneralReport.Size = new System.Drawing.Size(497, 23);
            this.btnGenerateGeneralReport.TabIndex = 32;
            this.btnGenerateGeneralReport.Text = "Generuj raport";
            this.btnGenerateGeneralReport.UseVisualStyleBackColor = true;
            this.btnGenerateGeneralReport.Click += new System.EventHandler(this.btnGenerateGeneralReport_Click);
            // 
            // btnAcceptSelectedTime
            // 
            this.btnAcceptSelectedTime.Location = new System.Drawing.Point(12, 54);
            this.btnAcceptSelectedTime.Name = "btnAcceptSelectedTime";
            this.btnAcceptSelectedTime.Size = new System.Drawing.Size(497, 23);
            this.btnAcceptSelectedTime.TabIndex = 31;
            this.btnAcceptSelectedTime.Text = "Zatwierdź wybrany przedzial";
            this.btnAcceptSelectedTime.UseVisualStyleBackColor = true;
            this.btnAcceptSelectedTime.Click += new System.EventHandler(this.btnAcceptSelectedTime_Click);
            // 
            // lblSpecifyTimeRange
            // 
            this.lblSpecifyTimeRange.AutoSize = true;
            this.lblSpecifyTimeRange.Location = new System.Drawing.Point(215, 12);
            this.lblSpecifyTimeRange.Name = "lblSpecifyTimeRange";
            this.lblSpecifyTimeRange.Size = new System.Drawing.Size(118, 13);
            this.lblSpecifyTimeRange.TabIndex = 30;
            this.lblSpecifyTimeRange.Text = "Określ zakres czasowy:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(279, 34);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 13);
            this.lblTo.TabIndex = 29;
            this.lblTo.Text = "Do:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(9, 34);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(24, 13);
            this.lblFrom.TabIndex = 28;
            this.lblFrom.Text = "Od:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Location = new System.Drawing.Point(309, 28);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 27;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Location = new System.Drawing.Point(39, 28);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 26;
            // 
            // tbExpencesSum
            // 
            this.tbExpencesSum.Location = new System.Drawing.Point(218, 513);
            this.tbExpencesSum.Name = "tbExpencesSum";
            this.tbExpencesSum.ReadOnly = true;
            this.tbExpencesSum.Size = new System.Drawing.Size(138, 20);
            this.tbExpencesSum.TabIndex = 48;
            this.tbExpencesSum.Text = "0";
            this.tbExpencesSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSumExpences
            // 
            this.lblSumExpences.AutoSize = true;
            this.lblSumExpences.Location = new System.Drawing.Point(123, 516);
            this.lblSumExpences.Name = "lblSumExpences";
            this.lblSumExpences.Size = new System.Drawing.Size(88, 13);
            this.lblSumExpences.TabIndex = 47;
            this.lblSumExpences.Text = "Suma wydatków:";
            // 
            // lblInvoicesPln
            // 
            this.lblInvoicesPln.AutoSize = true;
            this.lblInvoicesPln.Location = new System.Drawing.Point(172, 108);
            this.lblInvoicesPln.Name = "lblInvoicesPln";
            this.lblInvoicesPln.Size = new System.Drawing.Size(75, 13);
            this.lblInvoicesPln.TabIndex = 49;
            this.lblInvoicesPln.Text = "złotych (netto)";
            // 
            // lblOrdersPln
            // 
            this.lblOrdersPln.AutoSize = true;
            this.lblOrdersPln.Location = new System.Drawing.Point(172, 291);
            this.lblOrdersPln.Name = "lblOrdersPln";
            this.lblOrdersPln.Size = new System.Drawing.Size(75, 13);
            this.lblOrdersPln.TabIndex = 50;
            this.lblOrdersPln.Text = "złotych (netto)";
            // 
            // lblSalariesPln
            // 
            this.lblSalariesPln.AutoSize = true;
            this.lblSalariesPln.Location = new System.Drawing.Point(434, 107);
            this.lblSalariesPln.Name = "lblSalariesPln";
            this.lblSalariesPln.Size = new System.Drawing.Size(75, 13);
            this.lblSalariesPln.TabIndex = 51;
            this.lblSalariesPln.Text = "złotych (netto)";
            // 
            // lblOutsourcingPln
            // 
            this.lblOutsourcingPln.AutoSize = true;
            this.lblOutsourcingPln.Location = new System.Drawing.Point(434, 291);
            this.lblOutsourcingPln.Name = "lblOutsourcingPln";
            this.lblOutsourcingPln.Size = new System.Drawing.Size(75, 13);
            this.lblOutsourcingPln.TabIndex = 52;
            this.lblOutsourcingPln.Text = "złotych (netto)";
            // 
            // lblSumPln
            // 
            this.lblSumPln.AutoSize = true;
            this.lblSumPln.Location = new System.Drawing.Point(362, 516);
            this.lblSumPln.Name = "lblSumPln";
            this.lblSumPln.Size = new System.Drawing.Size(75, 13);
            this.lblSumPln.TabIndex = 53;
            this.lblSumPln.Text = "złotych (netto)";
            // 
            // AllExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 625);
            this.Controls.Add(this.lblSumPln);
            this.Controls.Add(this.lblOutsourcingPln);
            this.Controls.Add(this.lblSalariesPln);
            this.Controls.Add(this.lblOrdersPln);
            this.Controls.Add(this.lblInvoicesPln);
            this.Controls.Add(this.tbExpencesSum);
            this.Controls.Add(this.lblSumExpences);
            this.Controls.Add(this.tbSumPayment);
            this.Controls.Add(this.tbSumInvoices);
            this.Controls.Add(this.tbSumOS);
            this.Controls.Add(this.tbSumOrders);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.dgvOutsourcing);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.dgvSalaries);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.lblOutsourcing);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lblSalaries);
            this.Controls.Add(this.lblInvoices);
            this.Controls.Add(this.lblExpences);
            this.Controls.Add(this.btnGenerateGeneralReport);
            this.Controls.Add(this.btnAcceptSelectedTime);
            this.Controls.Add(this.lblSpecifyTimeRange);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "AllExpenses";
            this.Text = "Koszta";
            this.Load += new System.EventHandler(this.AllExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutsourcing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSumPayment;
        private System.Windows.Forms.TextBox tbSumInvoices;
        private System.Windows.Forms.TextBox tbSumOS;
        private System.Windows.Forms.TextBox tbSumOrders;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.DataGridView dgvOutsourcing;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvSalaries;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Label lblOutsourcing;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblSalaries;
        private System.Windows.Forms.Label lblInvoices;
        private System.Windows.Forms.Label lblExpences;
        private System.Windows.Forms.Button btnGenerateGeneralReport;
        private System.Windows.Forms.Button btnAcceptSelectedTime;
        private System.Windows.Forms.Label lblSpecifyTimeRange;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox tbExpencesSum;
        private System.Windows.Forms.Label lblSumExpences;
        private System.Windows.Forms.Label lblInvoicesPln;
        private System.Windows.Forms.Label lblOrdersPln;
        private System.Windows.Forms.Label lblSalariesPln;
        private System.Windows.Forms.Label lblOutsourcingPln;
        private System.Windows.Forms.Label lblSumPln;
    }
}