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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllIncomes));
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSumIncome
            // 
            this.tbSumIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSumIncome.Location = new System.Drawing.Point(541, 656);
            this.tbSumIncome.Name = "tbSumIncome";
            this.tbSumIncome.ReadOnly = true;
            this.tbSumIncome.Size = new System.Drawing.Size(309, 26);
            this.tbSumIncome.TabIndex = 32;
            this.tbSumIncome.Text = "0";
            this.tbSumIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnSum.Location = new System.Drawing.Point(541, 582);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(452, 46);
            this.btnSum.TabIndex = 31;
            this.btnSum.Text = "Sumuj wszystkie widoki";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // dgvProfits
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvProfits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProfits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvProfits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProfits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfits.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProfits.EnableHeadersVisualStyles = false;
            this.dgvProfits.Location = new System.Drawing.Point(470, 246);
            this.dgvProfits.Name = "dgvProfits";
            this.dgvProfits.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProfits.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProfits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfits.Size = new System.Drawing.Size(600, 306);
            this.dgvProfits.TabIndex = 30;
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
            this.btnGenerateGeneralReport.Location = new System.Drawing.Point(44, 452);
            this.btnGenerateGeneralReport.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerateGeneralReport.Name = "btnGenerateGeneralReport";
            this.btnGenerateGeneralReport.Size = new System.Drawing.Size(247, 154);
            this.btnGenerateGeneralReport.TabIndex = 29;
            this.btnGenerateGeneralReport.Text = "Generuj raport";
            this.btnGenerateGeneralReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateGeneralReport.UseVisualStyleBackColor = false;
            this.btnGenerateGeneralReport.Click += new System.EventHandler(this.btnGenerateGeneralReport_Click);
            // 
            // lblIncomes
            // 
            this.lblIncomes.AutoSize = true;
            this.lblIncomes.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIncomes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIncomes.Location = new System.Drawing.Point(738, 204);
            this.lblIncomes.Name = "lblIncomes";
            this.lblIncomes.Size = new System.Drawing.Size(73, 29);
            this.lblIncomes.TabIndex = 28;
            this.lblIncomes.Text = "Zyski";
            // 
            // btnAcceptSelectedTime
            // 
            this.btnAcceptSelectedTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAcceptSelectedTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAcceptSelectedTime.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAcceptSelectedTime.FlatAppearance.BorderSize = 3;
            this.btnAcceptSelectedTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAcceptSelectedTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnAcceptSelectedTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptSelectedTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAcceptSelectedTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcceptSelectedTime.Location = new System.Drawing.Point(553, 140);
            this.btnAcceptSelectedTime.Margin = new System.Windows.Forms.Padding(0);
            this.btnAcceptSelectedTime.Name = "btnAcceptSelectedTime";
            this.btnAcceptSelectedTime.Size = new System.Drawing.Size(452, 46);
            this.btnAcceptSelectedTime.TabIndex = 27;
            this.btnAcceptSelectedTime.Text = "Zatwierdź wybrany przedzial";
            this.btnAcceptSelectedTime.UseVisualStyleBackColor = false;
            this.btnAcceptSelectedTime.Click += new System.EventHandler(this.btnAcceptSelectedTime_Click);
            // 
            // lblSpecifyTimeRange
            // 
            this.lblSpecifyTimeRange.AutoSize = true;
            this.lblSpecifyTimeRange.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecifyTimeRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpecifyTimeRange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSpecifyTimeRange.Location = new System.Drawing.Point(655, 40);
            this.lblSpecifyTimeRange.Name = "lblSpecifyTimeRange";
            this.lblSpecifyTimeRange.Size = new System.Drawing.Size(278, 29);
            this.lblSpecifyTimeRange.TabIndex = 26;
            this.lblSpecifyTimeRange.Text = "Określ zakres czasowy";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTo.Location = new System.Drawing.Point(774, 96);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 20);
            this.lblTo.TabIndex = 25;
            this.lblTo.Text = "Do:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFrom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFrom.Location = new System.Drawing.Point(466, 97);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(37, 20);
            this.lblFrom.TabIndex = 24;
            this.lblFrom.Text = "Od:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpEndDate.CustomFormat = "yyyy-MM-dd";
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpEndDate.Location = new System.Drawing.Point(817, 93);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(253, 23);
            this.dtpEndDate.TabIndex = 23;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpStartDate.Location = new System.Drawing.Point(509, 94);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(248, 23);
            this.dtpStartDate.TabIndex = 22;
            // 
            // lblPln
            // 
            this.lblPln.AutoSize = true;
            this.lblPln.BackColor = System.Drawing.Color.Transparent;
            this.lblPln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPln.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPln.Location = new System.Drawing.Point(868, 662);
            this.lblPln.Name = "lblPln";
            this.lblPln.Size = new System.Drawing.Size(125, 20);
            this.lblPln.TabIndex = 33;
            this.lblPln.Text = "złotych (netto)";
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
            this.btnReturn.Location = new System.Drawing.Point(44, 93);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(247, 154);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.btnReturnMain.Location = new System.Drawing.Point(44, 273);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(247, 154);
            this.btnReturnMain.TabIndex = 35;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // AllIncomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnReturn);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AllIncomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
    }
}