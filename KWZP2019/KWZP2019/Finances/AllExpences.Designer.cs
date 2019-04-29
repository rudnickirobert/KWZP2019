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
            this.btSum = new System.Windows.Forms.Button();
            this.dgvOutsourcing = new System.Windows.Forms.DataGridView();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dgvSalaries = new System.Windows.Forms.DataGridView();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerategeneralreport = new System.Windows.Forms.Button();
            this.btnAcceptselectedtime = new System.Windows.Forms.Button();
            this.lblSpecifytimerange = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tbExpencesSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutsourcing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSumPayment
            // 
            this.tbSumPayment.Location = new System.Drawing.Point(371, 101);
            this.tbSumPayment.Name = "tbSumPayment";
            this.tbSumPayment.Size = new System.Drawing.Size(138, 20);
            this.tbSumPayment.TabIndex = 46;
            // 
            // tbSumInvoices
            // 
            this.tbSumInvoices.Location = new System.Drawing.Point(109, 104);
            this.tbSumInvoices.Name = "tbSumInvoices";
            this.tbSumInvoices.Size = new System.Drawing.Size(138, 20);
            this.tbSumInvoices.TabIndex = 45;
            // 
            // tbSumOS
            // 
            this.tbSumOS.Location = new System.Drawing.Point(371, 288);
            this.tbSumOS.Name = "tbSumOS";
            this.tbSumOS.Size = new System.Drawing.Size(138, 20);
            this.tbSumOS.TabIndex = 44;
            // 
            // tbSumOrders
            // 
            this.tbSumOrders.Location = new System.Drawing.Point(109, 288);
            this.tbSumOrders.Name = "tbSumOrders";
            this.tbSumOrders.Size = new System.Drawing.Size(138, 20);
            this.tbSumOrders.TabIndex = 43;
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(12, 560);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(497, 23);
            this.btSum.TabIndex = 42;
            this.btSum.Text = "Sumuj wszystkie widoki";
            this.btSum.UseVisualStyleBackColor = true;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Outsourcing:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Zamówienia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Wypłaty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Faktury:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Wydatki:";
            // 
            // btnGenerategeneralreport
            // 
            this.btnGenerategeneralreport.Location = new System.Drawing.Point(12, 589);
            this.btnGenerategeneralreport.Name = "btnGenerategeneralreport";
            this.btnGenerategeneralreport.Size = new System.Drawing.Size(497, 23);
            this.btnGenerategeneralreport.TabIndex = 32;
            this.btnGenerategeneralreport.Text = "Generuj raport";
            this.btnGenerategeneralreport.UseVisualStyleBackColor = true;
            // 
            // btnAcceptselectedtime
            // 
            this.btnAcceptselectedtime.Location = new System.Drawing.Point(12, 54);
            this.btnAcceptselectedtime.Name = "btnAcceptselectedtime";
            this.btnAcceptselectedtime.Size = new System.Drawing.Size(497, 23);
            this.btnAcceptselectedtime.TabIndex = 31;
            this.btnAcceptselectedtime.Text = "Zatwierdź wybrany przedzial";
            this.btnAcceptselectedtime.UseVisualStyleBackColor = true;
            // 
            // lblSpecifytimerange
            // 
            this.lblSpecifytimerange.AutoSize = true;
            this.lblSpecifytimerange.Location = new System.Drawing.Point(215, 12);
            this.lblSpecifytimerange.Name = "lblSpecifytimerange";
            this.lblSpecifytimerange.Size = new System.Drawing.Size(118, 13);
            this.lblSpecifytimerange.TabIndex = 30;
            this.lblSpecifytimerange.Text = "Określ zakres czasowy:";
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
            this.tbExpencesSum.Size = new System.Drawing.Size(138, 20);
            this.tbExpencesSum.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Suma wydatków:";
            // 
            // Costs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 625);
            this.Controls.Add(this.tbExpencesSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSumPayment);
            this.Controls.Add(this.tbSumInvoices);
            this.Controls.Add(this.tbSumOS);
            this.Controls.Add(this.tbSumOrders);
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
            this.Controls.Add(this.btnGenerategeneralreport);
            this.Controls.Add(this.btnAcceptselectedtime);
            this.Controls.Add(this.lblSpecifytimerange);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "Costs";
            this.Text = "Koszta";
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
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.DataGridView dgvOutsourcing;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridView dgvSalaries;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerategeneralreport;
        private System.Windows.Forms.Button btnAcceptselectedtime;
        private System.Windows.Forms.Label lblSpecifytimerange;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox tbExpencesSum;
        private System.Windows.Forms.Label label6;
    }
}