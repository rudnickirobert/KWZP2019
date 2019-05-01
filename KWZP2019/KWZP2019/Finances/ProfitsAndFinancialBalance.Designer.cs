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
            this.lblSpecifyTimeRange = new System.Windows.Forms.Label();
            this.lblIncomes = new System.Windows.Forms.Label();
            this.btnGenerateGeneralReport = new System.Windows.Forms.Button();
            this.lblExpences = new System.Windows.Forms.Label();
            this.lblInvoices = new System.Windows.Forms.Label();
            this.lblSalaries = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblOutsourcing = new System.Windows.Forms.Label();
            this.btSum = new System.Windows.Forms.Button();
            this.tbSumIncome = new System.Windows.Forms.TextBox();
            this.tbSumOrders = new System.Windows.Forms.TextBox();
            this.tbSumOS = new System.Windows.Forms.TextBox();
            this.tbSumInvoices = new System.Windows.Forms.TextBox();
            this.tbSumPayment = new System.Windows.Forms.TextBox();
            this.tbPureMoney = new System.Windows.Forms.TextBox();
            this.lblSumFinancialStatement = new System.Windows.Forms.Label();
            this.dgvProfits = new System.Windows.Forms.DataGridView();
            this.dgvOutsourcing = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvSalaries = new System.Windows.Forms.DataGridView();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.lblIncomesPln = new System.Windows.Forms.Label();
            this.lblInvoicesPln = new System.Windows.Forms.Label();
            this.lblOrdersPln = new System.Windows.Forms.Label();
            this.lblSalariesPln = new System.Windows.Forms.Label();
            this.lblOutsourcingPln = new System.Windows.Forms.Label();
            this.lblCurrentFinancialState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutsourcing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
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
            // lblSpecifyTimeRange
            // 
            this.lblSpecifyTimeRange.AutoSize = true;
            this.lblSpecifyTimeRange.Location = new System.Drawing.Point(215, 4);
            this.lblSpecifyTimeRange.Name = "lblSpecifyTimeRange";
            this.lblSpecifyTimeRange.Size = new System.Drawing.Size(118, 13);
            this.lblSpecifyTimeRange.TabIndex = 4;
            this.lblSpecifyTimeRange.Text = "Określ zakres czasowy:";
            // 
            // lblIncomes
            // 
            this.lblIncomes.AutoSize = true;
            this.lblIncomes.Location = new System.Drawing.Point(146, 92);
            this.lblIncomes.Name = "lblIncomes";
            this.lblIncomes.Size = new System.Drawing.Size(35, 13);
            this.lblIncomes.TabIndex = 7;
            this.lblIncomes.Text = "Zyski:";
            // 
            // btnGenerateGeneralReport
            // 
            this.btnGenerateGeneralReport.Location = new System.Drawing.Point(12, 499);
            this.btnGenerateGeneralReport.Name = "btnGenerateGeneralReport";
            this.btnGenerateGeneralReport.Size = new System.Drawing.Size(497, 23);
            this.btnGenerateGeneralReport.TabIndex = 9;
            this.btnGenerateGeneralReport.Text = "Generuj raport";
            this.btnGenerateGeneralReport.UseVisualStyleBackColor = true;
            this.btnGenerateGeneralReport.Click += new System.EventHandler(this.btnGenerategeneralreport_Click);
            // 
            // lblExpences
            // 
            this.lblExpences.AutoSize = true;
            this.lblExpences.Location = new System.Drawing.Point(146, 146);
            this.lblExpences.Name = "lblExpences";
            this.lblExpences.Size = new System.Drawing.Size(49, 13);
            this.lblExpences.TabIndex = 11;
            this.lblExpences.Text = "Wydatki:";
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.Location = new System.Drawing.Point(82, 177);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(45, 13);
            this.lblInvoices.TabIndex = 12;
            this.lblInvoices.Text = "Faktury:";
            // 
            // lblSalaries
            // 
            this.lblSalaries.AutoSize = true;
            this.lblSalaries.Location = new System.Drawing.Point(82, 229);
            this.lblSalaries.Name = "lblSalaries";
            this.lblSalaries.Size = new System.Drawing.Size(50, 13);
            this.lblSalaries.TabIndex = 13;
            this.lblSalaries.Text = "Wypłaty:";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(82, 203);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(67, 13);
            this.lblOrders.TabIndex = 14;
            this.lblOrders.Text = "Zamówienia:";
            // 
            // lblOutsourcing
            // 
            this.lblOutsourcing.AutoSize = true;
            this.lblOutsourcing.Location = new System.Drawing.Point(82, 255);
            this.lblOutsourcing.Name = "lblOutsourcing";
            this.lblOutsourcing.Size = new System.Drawing.Size(67, 13);
            this.lblOutsourcing.TabIndex = 15;
            this.lblOutsourcing.Text = "Outsourcing:";
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(12, 470);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(497, 23);
            this.btSum.TabIndex = 20;
            this.btSum.Text = "Oblicz dla wybranego przedziału";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // tbSumIncome
            // 
            this.tbSumIncome.Location = new System.Drawing.Point(85, 108);
            this.tbSumIncome.Name = "tbSumIncome";
            this.tbSumIncome.ReadOnly = true;
            this.tbSumIncome.Size = new System.Drawing.Size(267, 20);
            this.tbSumIncome.TabIndex = 21;
            this.tbSumIncome.Text = "0";
            this.tbSumIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumOrders
            // 
            this.tbSumOrders.Location = new System.Drawing.Point(177, 200);
            this.tbSumOrders.Name = "tbSumOrders";
            this.tbSumOrders.ReadOnly = true;
            this.tbSumOrders.Size = new System.Drawing.Size(138, 20);
            this.tbSumOrders.TabIndex = 22;
            this.tbSumOrders.Text = "0";
            this.tbSumOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumOS
            // 
            this.tbSumOS.Location = new System.Drawing.Point(177, 252);
            this.tbSumOS.Name = "tbSumOS";
            this.tbSumOS.ReadOnly = true;
            this.tbSumOS.Size = new System.Drawing.Size(138, 20);
            this.tbSumOS.TabIndex = 23;
            this.tbSumOS.Text = "0";
            this.tbSumOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumInvoices
            // 
            this.tbSumInvoices.Location = new System.Drawing.Point(177, 174);
            this.tbSumInvoices.Name = "tbSumInvoices";
            this.tbSumInvoices.ReadOnly = true;
            this.tbSumInvoices.Size = new System.Drawing.Size(138, 20);
            this.tbSumInvoices.TabIndex = 24;
            this.tbSumInvoices.Text = "0";
            this.tbSumInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumPayment
            // 
            this.tbSumPayment.Location = new System.Drawing.Point(177, 226);
            this.tbSumPayment.Name = "tbSumPayment";
            this.tbSumPayment.ReadOnly = true;
            this.tbSumPayment.Size = new System.Drawing.Size(138, 20);
            this.tbSumPayment.TabIndex = 25;
            this.tbSumPayment.Text = "0";
            this.tbSumPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPureMoney
            // 
            this.tbPureMoney.Location = new System.Drawing.Point(85, 332);
            this.tbPureMoney.Name = "tbPureMoney";
            this.tbPureMoney.ReadOnly = true;
            this.tbPureMoney.Size = new System.Drawing.Size(267, 20);
            this.tbPureMoney.TabIndex = 26;
            this.tbPureMoney.Text = "0";
            this.tbPureMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSumFinancialStatement
            // 
            this.lblSumFinancialStatement.AutoSize = true;
            this.lblSumFinancialStatement.Location = new System.Drawing.Point(146, 307);
            this.lblSumFinancialStatement.Name = "lblSumFinancialStatement";
            this.lblSumFinancialStatement.Size = new System.Drawing.Size(88, 13);
            this.lblSumFinancialStatement.TabIndex = 27;
            this.lblSumFinancialStatement.Text = "Bilans finansowy:";
            // 
            // dgvProfits
            // 
            this.dgvProfits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfits.Location = new System.Drawing.Point(1352, 180);
            this.dgvProfits.Name = "dgvProfits";
            this.dgvProfits.Size = new System.Drawing.Size(50, 50);
            this.dgvProfits.TabIndex = 31;
            // 
            // dgvOutsourcing
            // 
            this.dgvOutsourcing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutsourcing.Location = new System.Drawing.Point(1378, 295);
            this.dgvOutsourcing.Name = "dgvOutsourcing";
            this.dgvOutsourcing.Size = new System.Drawing.Size(50, 50);
            this.dgvOutsourcing.TabIndex = 45;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(1319, 295);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(50, 50);
            this.dgvOrders.TabIndex = 44;
            // 
            // dgvSalaries
            // 
            this.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaries.Location = new System.Drawing.Point(1378, 236);
            this.dgvSalaries.Name = "dgvSalaries";
            this.dgvSalaries.Size = new System.Drawing.Size(50, 50);
            this.dgvSalaries.TabIndex = 43;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(1319, 236);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(50, 50);
            this.dgvInvoices.TabIndex = 42;
            // 
            // lblIncomesPln
            // 
            this.lblIncomesPln.AutoSize = true;
            this.lblIncomesPln.Location = new System.Drawing.Point(358, 111);
            this.lblIncomesPln.Name = "lblIncomesPln";
            this.lblIncomesPln.Size = new System.Drawing.Size(75, 13);
            this.lblIncomesPln.TabIndex = 46;
            this.lblIncomesPln.Text = "złotych (netto)";
            // 
            // lblInvoicesPln
            // 
            this.lblInvoicesPln.AutoSize = true;
            this.lblInvoicesPln.Location = new System.Drawing.Point(321, 177);
            this.lblInvoicesPln.Name = "lblInvoicesPln";
            this.lblInvoicesPln.Size = new System.Drawing.Size(75, 13);
            this.lblInvoicesPln.TabIndex = 47;
            this.lblInvoicesPln.Text = "złotych (netto)";
            // 
            // lblOrdersPln
            // 
            this.lblOrdersPln.AutoSize = true;
            this.lblOrdersPln.Location = new System.Drawing.Point(321, 203);
            this.lblOrdersPln.Name = "lblOrdersPln";
            this.lblOrdersPln.Size = new System.Drawing.Size(75, 13);
            this.lblOrdersPln.TabIndex = 48;
            this.lblOrdersPln.Text = "złotych (netto)";
            // 
            // lblSalariesPln
            // 
            this.lblSalariesPln.AutoSize = true;
            this.lblSalariesPln.Location = new System.Drawing.Point(321, 229);
            this.lblSalariesPln.Name = "lblSalariesPln";
            this.lblSalariesPln.Size = new System.Drawing.Size(75, 13);
            this.lblSalariesPln.TabIndex = 49;
            this.lblSalariesPln.Text = "złotych (netto)";
            // 
            // lblOutsourcingPln
            // 
            this.lblOutsourcingPln.AutoSize = true;
            this.lblOutsourcingPln.Location = new System.Drawing.Point(321, 255);
            this.lblOutsourcingPln.Name = "lblOutsourcingPln";
            this.lblOutsourcingPln.Size = new System.Drawing.Size(75, 13);
            this.lblOutsourcingPln.TabIndex = 50;
            this.lblOutsourcingPln.Text = "złotych (netto)";
            // 
            // lblCurrentFinancialState
            // 
            this.lblCurrentFinancialState.AutoSize = true;
            this.lblCurrentFinancialState.Location = new System.Drawing.Point(358, 335);
            this.lblCurrentFinancialState.Name = "lblCurrentFinancialState";
            this.lblCurrentFinancialState.Size = new System.Drawing.Size(75, 13);
            this.lblCurrentFinancialState.TabIndex = 51;
            this.lblCurrentFinancialState.Text = "złotych (netto)";
            // 
            // Profits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 523);
            this.Controls.Add(this.lblCurrentFinancialState);
            this.Controls.Add(this.lblOutsourcingPln);
            this.Controls.Add(this.lblSalariesPln);
            this.Controls.Add(this.lblOrdersPln);
            this.Controls.Add(this.lblInvoicesPln);
            this.Controls.Add(this.lblIncomesPln);
            this.Controls.Add(this.dgvOutsourcing);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.dgvSalaries);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.dgvProfits);
            this.Controls.Add(this.lblSumFinancialStatement);
            this.Controls.Add(this.tbPureMoney);
            this.Controls.Add(this.tbSumPayment);
            this.Controls.Add(this.tbSumInvoices);
            this.Controls.Add(this.tbSumOS);
            this.Controls.Add(this.tbSumOrders);
            this.Controls.Add(this.tbSumIncome);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.lblOutsourcing);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lblSalaries);
            this.Controls.Add(this.lblInvoices);
            this.Controls.Add(this.lblExpences);
            this.Controls.Add(this.btnGenerateGeneralReport);
            this.Controls.Add(this.lblIncomes);
            this.Controls.Add(this.lblSpecifyTimeRange);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "Profits";
            this.Text = "Bilans finansowy";
            this.Load += new System.EventHandler(this.Profits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutsourcing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSpecifyTimeRange;
        private System.Windows.Forms.Label lblIncomes;
        private System.Windows.Forms.Button btnGenerateGeneralReport;
        private System.Windows.Forms.Label lblExpences;
        private System.Windows.Forms.Label lblInvoices;
        private System.Windows.Forms.Label lblSalaries;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblOutsourcing;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.TextBox tbSumIncome;
        private System.Windows.Forms.TextBox tbSumOrders;
        private System.Windows.Forms.TextBox tbSumOS;
        private System.Windows.Forms.TextBox tbSumInvoices;
        private System.Windows.Forms.TextBox tbSumPayment;
        private System.Windows.Forms.TextBox tbPureMoney;
        private System.Windows.Forms.Label lblSumFinancialStatement;
        private System.Windows.Forms.DataGridView dgvProfits;
        private System.Windows.Forms.DataGridView dgvOutsourcing;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvSalaries;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Label lblIncomesPln;
        private System.Windows.Forms.Label lblInvoicesPln;
        private System.Windows.Forms.Label lblOrdersPln;
        private System.Windows.Forms.Label lblSalariesPln;
        private System.Windows.Forms.Label lblOutsourcingPln;
        private System.Windows.Forms.Label lblCurrentFinancialState;
    }
}