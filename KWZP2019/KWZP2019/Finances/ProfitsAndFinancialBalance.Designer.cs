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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profits));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnSum = new System.Windows.Forms.Button();
            this.tbSumIncome = new System.Windows.Forms.TextBox();
            this.tbSumOrders = new System.Windows.Forms.TextBox();
            this.tbSumOutsourcing = new System.Windows.Forms.TextBox();
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
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pbProfits = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.dgvPartOrder = new System.Windows.Forms.DataGridView();
            this.lblPartOrderPln = new System.Windows.Forms.Label();
            this.tbPartOrder = new System.Windows.Forms.TextBox();
            this.lblPartOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutsourcing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpStartDate.Location = new System.Drawing.Point(527, 262);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(247, 23);
            this.dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpEndDate.Location = new System.Drawing.Point(823, 262);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(252, 23);
            this.dtpEndDate.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFrom.Location = new System.Drawing.Point(484, 265);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(37, 20);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Od:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTo.Location = new System.Drawing.Point(780, 264);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 20);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Do:";
            // 
            // lblSpecifyTimeRange
            // 
            this.lblSpecifyTimeRange.AutoSize = true;
            this.lblSpecifyTimeRange.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecifyTimeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpecifyTimeRange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSpecifyTimeRange.Location = new System.Drawing.Point(666, 219);
            this.lblSpecifyTimeRange.Name = "lblSpecifyTimeRange";
            this.lblSpecifyTimeRange.Size = new System.Drawing.Size(278, 29);
            this.lblSpecifyTimeRange.TabIndex = 4;
            this.lblSpecifyTimeRange.Text = "Określ zakres czasowy";
            // 
            // lblIncomes
            // 
            this.lblIncomes.AutoSize = true;
            this.lblIncomes.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIncomes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIncomes.Location = new System.Drawing.Point(751, 356);
            this.lblIncomes.Name = "lblIncomes";
            this.lblIncomes.Size = new System.Drawing.Size(73, 29);
            this.lblIncomes.TabIndex = 7;
            this.lblIncomes.Text = "Zyski";
            // 
            // btnGenerateGeneralReport
            // 
            this.btnGenerateGeneralReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnGenerateGeneralReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerateGeneralReport.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateGeneralReport.FlatAppearance.BorderSize = 3;
            this.btnGenerateGeneralReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerateGeneralReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnGenerateGeneralReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateGeneralReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnGenerateGeneralReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerateGeneralReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateGeneralReport.Image")));
            this.btnGenerateGeneralReport.Location = new System.Drawing.Point(72, 464);
            this.btnGenerateGeneralReport.Name = "btnGenerateGeneralReport";
            this.btnGenerateGeneralReport.Size = new System.Drawing.Size(247, 154);
            this.btnGenerateGeneralReport.TabIndex = 9;
            this.btnGenerateGeneralReport.Text = "Generuj raport";
            this.btnGenerateGeneralReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateGeneralReport.UseVisualStyleBackColor = false;
            this.btnGenerateGeneralReport.Click += new System.EventHandler(this.btnGenerateGeneralReport_Click);
            // 
            // lblExpences
            // 
            this.lblExpences.AutoSize = true;
            this.lblExpences.BackColor = System.Drawing.Color.Transparent;
            this.lblExpences.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblExpences.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExpences.Location = new System.Drawing.Point(734, 419);
            this.lblExpences.Name = "lblExpences";
            this.lblExpences.Size = new System.Drawing.Size(104, 29);
            this.lblExpences.TabIndex = 11;
            this.lblExpences.Text = "Wydatki";
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInvoices.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInvoices.Location = new System.Drawing.Point(512, 462);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(69, 20);
            this.lblInvoices.TabIndex = 12;
            this.lblInvoices.Text = "Faktury";
            // 
            // lblSalaries
            // 
            this.lblSalaries.AutoSize = true;
            this.lblSalaries.BackColor = System.Drawing.Color.Transparent;
            this.lblSalaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSalaries.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSalaries.Location = new System.Drawing.Point(512, 514);
            this.lblSalaries.Name = "lblSalaries";
            this.lblSalaries.Size = new System.Drawing.Size(72, 20);
            this.lblSalaries.TabIndex = 13;
            this.lblSalaries.Text = "Wypłaty";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.BackColor = System.Drawing.Color.Transparent;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrders.Location = new System.Drawing.Point(512, 488);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(108, 20);
            this.lblOrders.TabIndex = 14;
            this.lblOrders.Text = "Półfabrykaty";
            // 
            // lblOutsourcing
            // 
            this.lblOutsourcing.AutoSize = true;
            this.lblOutsourcing.BackColor = System.Drawing.Color.Transparent;
            this.lblOutsourcing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOutsourcing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOutsourcing.Location = new System.Drawing.Point(512, 540);
            this.lblOutsourcing.Name = "lblOutsourcing";
            this.lblOutsourcing.Size = new System.Drawing.Size(106, 20);
            this.lblOutsourcing.TabIndex = 15;
            this.lblOutsourcing.Text = "Outsourcing";
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnSum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSum.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSum.FlatAppearance.BorderSize = 3;
            this.btnSum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSum.Location = new System.Drawing.Point(579, 305);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(452, 46);
            this.btnSum.TabIndex = 20;
            this.btnSum.Text = "Oblicz dla wybranego przedziału";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // tbSumIncome
            // 
            this.tbSumIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSumIncome.Location = new System.Drawing.Point(597, 388);
            this.tbSumIncome.Name = "tbSumIncome";
            this.tbSumIncome.ReadOnly = true;
            this.tbSumIncome.Size = new System.Drawing.Size(267, 23);
            this.tbSumIncome.TabIndex = 21;
            this.tbSumIncome.Text = "0";
            this.tbSumIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumOrders
            // 
            this.tbSumOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSumOrders.Location = new System.Drawing.Point(709, 485);
            this.tbSumOrders.Name = "tbSumOrders";
            this.tbSumOrders.ReadOnly = true;
            this.tbSumOrders.Size = new System.Drawing.Size(155, 23);
            this.tbSumOrders.TabIndex = 22;
            this.tbSumOrders.Text = "0";
            this.tbSumOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumOutsourcing
            // 
            this.tbSumOutsourcing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSumOutsourcing.Location = new System.Drawing.Point(709, 537);
            this.tbSumOutsourcing.Name = "tbSumOutsourcing";
            this.tbSumOutsourcing.ReadOnly = true;
            this.tbSumOutsourcing.Size = new System.Drawing.Size(155, 23);
            this.tbSumOutsourcing.TabIndex = 23;
            this.tbSumOutsourcing.Text = "0";
            this.tbSumOutsourcing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumInvoices
            // 
            this.tbSumInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSumInvoices.Location = new System.Drawing.Point(709, 459);
            this.tbSumInvoices.Name = "tbSumInvoices";
            this.tbSumInvoices.ReadOnly = true;
            this.tbSumInvoices.Size = new System.Drawing.Size(155, 23);
            this.tbSumInvoices.TabIndex = 24;
            this.tbSumInvoices.Text = "0";
            this.tbSumInvoices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSumPayment
            // 
            this.tbSumPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSumPayment.Location = new System.Drawing.Point(709, 511);
            this.tbSumPayment.Name = "tbSumPayment";
            this.tbSumPayment.ReadOnly = true;
            this.tbSumPayment.Size = new System.Drawing.Size(155, 23);
            this.tbSumPayment.TabIndex = 25;
            this.tbSumPayment.Text = "0";
            this.tbSumPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPureMoney
            // 
            this.tbPureMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPureMoney.Location = new System.Drawing.Point(597, 637);
            this.tbPureMoney.Name = "tbPureMoney";
            this.tbPureMoney.ReadOnly = true;
            this.tbPureMoney.Size = new System.Drawing.Size(267, 23);
            this.tbPureMoney.TabIndex = 26;
            this.tbPureMoney.Text = "0";
            this.tbPureMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSumFinancialStatement
            // 
            this.lblSumFinancialStatement.AutoSize = true;
            this.lblSumFinancialStatement.BackColor = System.Drawing.Color.Transparent;
            this.lblSumFinancialStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSumFinancialStatement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSumFinancialStatement.Location = new System.Drawing.Point(686, 592);
            this.lblSumFinancialStatement.Name = "lblSumFinancialStatement";
            this.lblSumFinancialStatement.Size = new System.Drawing.Size(207, 29);
            this.lblSumFinancialStatement.TabIndex = 27;
            this.lblSumFinancialStatement.Text = "Bilans finansowy";
            // 
            // dgvProfits
            // 
            this.dgvProfits.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvProfits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfits.Location = new System.Drawing.Point(1352, 180);
            this.dgvProfits.Name = "dgvProfits";
            this.dgvProfits.Size = new System.Drawing.Size(50, 50);
            this.dgvProfits.TabIndex = 31;
            // 
            // dgvOutsourcing
            // 
            this.dgvOutsourcing.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvOutsourcing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutsourcing.Location = new System.Drawing.Point(1378, 295);
            this.dgvOutsourcing.Name = "dgvOutsourcing";
            this.dgvOutsourcing.Size = new System.Drawing.Size(50, 50);
            this.dgvOutsourcing.TabIndex = 45;
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(1319, 295);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(50, 50);
            this.dgvOrders.TabIndex = 44;
            // 
            // dgvSalaries
            // 
            this.dgvSalaries.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvSalaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaries.Location = new System.Drawing.Point(1378, 236);
            this.dgvSalaries.Name = "dgvSalaries";
            this.dgvSalaries.Size = new System.Drawing.Size(50, 50);
            this.dgvSalaries.TabIndex = 43;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(1319, 236);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.Size = new System.Drawing.Size(50, 50);
            this.dgvInvoices.TabIndex = 42;
            // 
            // lblIncomesPln
            // 
            this.lblIncomesPln.AutoSize = true;
            this.lblIncomesPln.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomesPln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIncomesPln.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIncomesPln.Location = new System.Drawing.Point(870, 391);
            this.lblIncomesPln.Name = "lblIncomesPln";
            this.lblIncomesPln.Size = new System.Drawing.Size(125, 20);
            this.lblIncomesPln.TabIndex = 46;
            this.lblIncomesPln.Text = "złotych (netto)";
            // 
            // lblInvoicesPln
            // 
            this.lblInvoicesPln.AutoSize = true;
            this.lblInvoicesPln.BackColor = System.Drawing.Color.Transparent;
            this.lblInvoicesPln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInvoicesPln.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInvoicesPln.Location = new System.Drawing.Point(870, 462);
            this.lblInvoicesPln.Name = "lblInvoicesPln";
            this.lblInvoicesPln.Size = new System.Drawing.Size(125, 20);
            this.lblInvoicesPln.TabIndex = 47;
            this.lblInvoicesPln.Text = "złotych (netto)";
            // 
            // lblOrdersPln
            // 
            this.lblOrdersPln.AutoSize = true;
            this.lblOrdersPln.BackColor = System.Drawing.Color.Transparent;
            this.lblOrdersPln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrdersPln.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrdersPln.Location = new System.Drawing.Point(870, 488);
            this.lblOrdersPln.Name = "lblOrdersPln";
            this.lblOrdersPln.Size = new System.Drawing.Size(125, 20);
            this.lblOrdersPln.TabIndex = 48;
            this.lblOrdersPln.Text = "złotych (netto)";
            // 
            // lblSalariesPln
            // 
            this.lblSalariesPln.AutoSize = true;
            this.lblSalariesPln.BackColor = System.Drawing.Color.Transparent;
            this.lblSalariesPln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSalariesPln.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSalariesPln.Location = new System.Drawing.Point(870, 514);
            this.lblSalariesPln.Name = "lblSalariesPln";
            this.lblSalariesPln.Size = new System.Drawing.Size(125, 20);
            this.lblSalariesPln.TabIndex = 49;
            this.lblSalariesPln.Text = "złotych (netto)";
            // 
            // lblOutsourcingPln
            // 
            this.lblOutsourcingPln.AutoSize = true;
            this.lblOutsourcingPln.BackColor = System.Drawing.Color.Transparent;
            this.lblOutsourcingPln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOutsourcingPln.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOutsourcingPln.Location = new System.Drawing.Point(870, 540);
            this.lblOutsourcingPln.Name = "lblOutsourcingPln";
            this.lblOutsourcingPln.Size = new System.Drawing.Size(125, 20);
            this.lblOutsourcingPln.TabIndex = 50;
            this.lblOutsourcingPln.Text = "złotych (netto)";
            // 
            // lblCurrentFinancialState
            // 
            this.lblCurrentFinancialState.AutoSize = true;
            this.lblCurrentFinancialState.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentFinancialState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCurrentFinancialState.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCurrentFinancialState.Location = new System.Drawing.Point(870, 640);
            this.lblCurrentFinancialState.Name = "lblCurrentFinancialState";
            this.lblCurrentFinancialState.Size = new System.Drawing.Size(125, 20);
            this.lblCurrentFinancialState.TabIndex = 51;
            this.lblCurrentFinancialState.Text = "złotych (netto)";
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
            this.btnReturnMain.Location = new System.Drawing.Point(72, 279);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(247, 154);
            this.btnReturnMain.TabIndex = 52;
            this.btnReturnMain.Text = "Menu głowne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
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
            this.btnReturn.Location = new System.Drawing.Point(72, 94);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(247, 154);
            this.btnReturn.TabIndex = 53;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pbProfits
            // 
            this.pbProfits.BackColor = System.Drawing.Color.Transparent;
            this.pbProfits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbProfits.BackgroundImage")));
            this.pbProfits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProfits.Location = new System.Drawing.Point(411, 12);
            this.pbProfits.Name = "pbProfits";
            this.pbProfits.Size = new System.Drawing.Size(740, 716);
            this.pbProfits.TabIndex = 54;
            this.pbProfits.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Location = new System.Drawing.Point(685, 132);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(217, 31);
            this.lblFormTitle.TabIndex = 55;
            this.lblFormTitle.Text = "Bilans finansowy";
            // 
            // dgvPartOrder
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvPartOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPartOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartOrder.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvPartOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPartOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPartOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPartOrder.EnableHeadersVisualStyles = false;
            this.dgvPartOrder.Location = new System.Drawing.Point(1352, 351);
            this.dgvPartOrder.Name = "dgvPartOrder";
            this.dgvPartOrder.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPartOrder.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPartOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartOrder.Size = new System.Drawing.Size(50, 50);
            this.dgvPartOrder.TabIndex = 57;
            // 
            // lblPartOrderPln
            // 
            this.lblPartOrderPln.AutoSize = true;
            this.lblPartOrderPln.BackColor = System.Drawing.Color.Transparent;
            this.lblPartOrderPln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPartOrderPln.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPartOrderPln.Location = new System.Drawing.Point(870, 566);
            this.lblPartOrderPln.Name = "lblPartOrderPln";
            this.lblPartOrderPln.Size = new System.Drawing.Size(125, 20);
            this.lblPartOrderPln.TabIndex = 60;
            this.lblPartOrderPln.Text = "złotych (netto)";
            // 
            // tbPartOrder
            // 
            this.tbPartOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPartOrder.Location = new System.Drawing.Point(709, 563);
            this.tbPartOrder.Name = "tbPartOrder";
            this.tbPartOrder.ReadOnly = true;
            this.tbPartOrder.Size = new System.Drawing.Size(155, 23);
            this.tbPartOrder.TabIndex = 59;
            this.tbPartOrder.Text = "0";
            this.tbPartOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPartOrder
            // 
            this.lblPartOrder.AutoSize = true;
            this.lblPartOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblPartOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPartOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPartOrder.Location = new System.Drawing.Point(512, 566);
            this.lblPartOrder.Name = "lblPartOrder";
            this.lblPartOrder.Size = new System.Drawing.Size(188, 20);
            this.lblPartOrder.TabIndex = 58;
            this.lblPartOrder.Text = "Koszta eksploatacyjne";
            // 
            // Profits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.lblPartOrderPln);
            this.Controls.Add(this.tbPartOrder);
            this.Controls.Add(this.lblPartOrder);
            this.Controls.Add(this.dgvPartOrder);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReturnMain);
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
            this.Controls.Add(this.tbSumOutsourcing);
            this.Controls.Add(this.tbSumOrders);
            this.Controls.Add(this.tbSumIncome);
            this.Controls.Add(this.btnSum);
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
            this.Controls.Add(this.pbProfits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilans finansowy";
            this.Load += new System.EventHandler(this.Profits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutsourcing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartOrder)).EndInit();
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
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox tbSumIncome;
        private System.Windows.Forms.TextBox tbSumOrders;
        private System.Windows.Forms.TextBox tbSumOutsourcing;
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
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pbProfits;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DataGridView dgvPartOrder;
        private System.Windows.Forms.Label lblPartOrderPln;
        private System.Windows.Forms.TextBox tbPartOrder;
        private System.Windows.Forms.Label lblPartOrder;
    }
}