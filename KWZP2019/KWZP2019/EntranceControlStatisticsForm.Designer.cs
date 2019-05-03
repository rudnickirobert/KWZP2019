namespace KWZP2019
{
    partial class EntranceControlStatisticsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceControlStatisticsForm));
            this.dataGridViewSemiFinished = new System.Windows.Forms.DataGridView();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnShowPieChart = new System.Windows.Forms.Button();
            this.btnShowHistograms = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.datePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.datePickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.btnAllTime = new System.Windows.Forms.Button();
            this.pieChartNumberOfPositiveAndNegativeControl = new LiveCharts.WinForms.PieChart();
            this.histogramThickness = new LiveCharts.WinForms.CartesianChart();
            this.histogramWidth = new LiveCharts.WinForms.CartesianChart();
            this.histogramWeight = new LiveCharts.WinForms.CartesianChart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemiFinished)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSemiFinished
            // 
            this.dataGridViewSemiFinished.AllowUserToAddRows = false;
            this.dataGridViewSemiFinished.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridViewSemiFinished.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewSemiFinished.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSemiFinished.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewSemiFinished.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dataGridViewSemiFinished.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSemiFinished.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSemiFinished.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewSemiFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSemiFinished.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewSemiFinished.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSemiFinished.Location = new System.Drawing.Point(200, 12);
            this.dataGridViewSemiFinished.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSemiFinished.MultiSelect = false;
            this.dataGridViewSemiFinished.Name = "dataGridViewSemiFinished";
            this.dataGridViewSemiFinished.ReadOnly = true;
            this.dataGridViewSemiFinished.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSemiFinished.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridViewSemiFinished.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewSemiFinished.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSemiFinished.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridViewSemiFinished.ShowEditingIcon = false;
            this.dataGridViewSemiFinished.Size = new System.Drawing.Size(180, 206);
            this.dataGridViewSemiFinished.TabIndex = 39;
            this.dataGridViewSemiFinished.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewSemiFinished_RowHeaderMouseClick);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.Location = new System.Drawing.Point(12, 12);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(180, 100);
            this.btnReturnMain.TabIndex = 2;
            this.btnReturnMain.Text = "Menu Główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.BtnReturnMain_Click);
            // 
            // btnShowPieChart
            // 
            this.btnShowPieChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnShowPieChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowPieChart.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnShowPieChart.FlatAppearance.BorderSize = 3;
            this.btnShowPieChart.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowPieChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowPieChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnShowPieChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowPieChart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowPieChart.Image = global::KWZP2019.Properties.Resources.icons8_fraction_40;
            this.btnShowPieChart.Location = new System.Drawing.Point(16, 446);
            this.btnShowPieChart.Name = "btnShowPieChart";
            this.btnShowPieChart.Size = new System.Drawing.Size(200, 100);
            this.btnShowPieChart.TabIndex = 1;
            this.btnShowPieChart.Text = "Wykres kołowy";
            this.btnShowPieChart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowPieChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowPieChart.UseVisualStyleBackColor = false;
            this.btnShowPieChart.Click += new System.EventHandler(this.BtnShowPieChart_Click);
            // 
            // btnShowHistograms
            // 
            this.btnShowHistograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnShowHistograms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowHistograms.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnShowHistograms.FlatAppearance.BorderSize = 3;
            this.btnShowHistograms.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowHistograms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowHistograms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnShowHistograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHistograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowHistograms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowHistograms.Image = global::KWZP2019.Properties.Resources.icons8_bar_chart_40;
            this.btnShowHistograms.Location = new System.Drawing.Point(241, 446);
            this.btnShowHistograms.Name = "btnShowHistograms";
            this.btnShowHistograms.Size = new System.Drawing.Size(200, 100);
            this.btnShowHistograms.TabIndex = 1;
            this.btnShowHistograms.Text = "Histogramy";
            this.btnShowHistograms.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowHistograms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShowHistograms.UseVisualStyleBackColor = false;
            this.btnShowHistograms.Click += new System.EventHandler(this.BtnShowHistograms_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(12, 118);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(180, 100);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // datePickerDateFrom
            // 
            this.datePickerDateFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerDateFrom.Location = new System.Drawing.Point(96, 248);
            this.datePickerDateFrom.Margin = new System.Windows.Forms.Padding(0);
            this.datePickerDateFrom.Name = "datePickerDateFrom";
            this.datePickerDateFrom.Size = new System.Drawing.Size(285, 26);
            this.datePickerDateFrom.TabIndex = 41;
            this.datePickerDateFrom.Value = new System.DateTime(2019, 4, 24, 21, 29, 8, 0);
            this.datePickerDateFrom.ValueChanged += new System.EventHandler(this.DatePickerDateFrom_ValueChanged);
            // 
            // datePickerDateTo
            // 
            this.datePickerDateTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerDateTo.Location = new System.Drawing.Point(96, 285);
            this.datePickerDateTo.Margin = new System.Windows.Forms.Padding(0);
            this.datePickerDateTo.Name = "datePickerDateTo";
            this.datePickerDateTo.Size = new System.Drawing.Size(286, 26);
            this.datePickerDateTo.TabIndex = 42;
            this.datePickerDateTo.Value = new System.DateTime(2019, 4, 24, 21, 29, 8, 0);
            this.datePickerDateTo.ValueChanged += new System.EventHandler(this.DatePickerDateTo_ValueChanged);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateFrom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateFrom.Location = new System.Drawing.Point(12, 249);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(79, 26);
            this.lblDateFrom.TabIndex = 43;
            this.lblDateFrom.Text = "Data od";
            this.lblDateFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTo
            // 
            this.lblDateTo.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDateTo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDateTo.Location = new System.Drawing.Point(11, 285);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(79, 26);
            this.lblDateTo.TabIndex = 43;
            this.lblDateTo.Text = "Data do";
            this.lblDateTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAllTime
            // 
            this.btnAllTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAllTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAllTime.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAllTime.FlatAppearance.BorderSize = 3;
            this.btnAllTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAllTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAllTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnAllTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAllTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllTime.Image = global::KWZP2019.Properties.Resources.icons8_date_span_40;
            this.btnAllTime.Location = new System.Drawing.Point(12, 344);
            this.btnAllTime.Name = "btnAllTime";
            this.btnAllTime.Size = new System.Drawing.Size(369, 60);
            this.btnAllTime.TabIndex = 1;
            this.btnAllTime.Text = "Cały okres czasu";
            this.btnAllTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllTime.UseVisualStyleBackColor = false;
            this.btnAllTime.Click += new System.EventHandler(this.BtnAllTime_Click);
            // 
            // pieChartNumberOfPositiveAndNegativeControl
            // 
            this.pieChartNumberOfPositiveAndNegativeControl.BackColorTransparent = true;
            this.pieChartNumberOfPositiveAndNegativeControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pieChartNumberOfPositiveAndNegativeControl.Location = new System.Drawing.Point(390, 12);
            this.pieChartNumberOfPositiveAndNegativeControl.Name = "pieChartNumberOfPositiveAndNegativeControl";
            this.pieChartNumberOfPositiveAndNegativeControl.Size = new System.Drawing.Size(206, 206);
            this.pieChartNumberOfPositiveAndNegativeControl.TabIndex = 44;
            // 
            // histogramThickness
            // 
            this.histogramThickness.BackColorTransparent = true;
            this.histogramThickness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.histogramThickness.Location = new System.Drawing.Point(612, 12);
            this.histogramThickness.Name = "histogramThickness";
            this.histogramThickness.Size = new System.Drawing.Size(206, 206);
            this.histogramThickness.TabIndex = 45;
            // 
            // histogramWidth
            // 
            this.histogramWidth.BackColorTransparent = true;
            this.histogramWidth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.histogramWidth.Location = new System.Drawing.Point(390, 234);
            this.histogramWidth.Name = "histogramWidth";
            this.histogramWidth.Size = new System.Drawing.Size(206, 206);
            this.histogramWidth.TabIndex = 45;
            // 
            // histogramWeight
            // 
            this.histogramWeight.BackColorTransparent = true;
            this.histogramWeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.histogramWeight.Location = new System.Drawing.Point(612, 234);
            this.histogramWeight.Name = "histogramWeight";
            this.histogramWeight.Size = new System.Drawing.Size(206, 206);
            this.histogramWeight.TabIndex = 45;
            // 
            // EntranceControlStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 561);
            this.Controls.Add(this.histogramWeight);
            this.Controls.Add(this.histogramWidth);
            this.Controls.Add(this.histogramThickness);
            this.Controls.Add(this.pieChartNumberOfPositiveAndNegativeControl);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.datePickerDateTo);
            this.Controls.Add(this.datePickerDateFrom);
            this.Controls.Add(this.dataGridViewSemiFinished);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnShowPieChart);
            this.Controls.Add(this.btnAllTime);
            this.Controls.Add(this.btnShowHistograms);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntranceControlStatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntranceControlStatisticsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntranceControlStatisticsForm_FormClosed);
            this.Load += new System.EventHandler(this.EntranceControlStatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemiFinished)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.DataGridView dataGridViewSemiFinished;
        private System.Windows.Forms.Button btnShowHistograms;
        private System.Windows.Forms.Button btnShowPieChart;
        private System.Windows.Forms.DateTimePicker datePickerDateFrom;
        private System.Windows.Forms.DateTimePicker datePickerDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Button btnAllTime;
        private LiveCharts.WinForms.PieChart pieChartNumberOfPositiveAndNegativeControl;
        private LiveCharts.WinForms.CartesianChart histogramThickness;
        private LiveCharts.WinForms.CartesianChart histogramWidth;
        private LiveCharts.WinForms.CartesianChart histogramWeight;
    }
}