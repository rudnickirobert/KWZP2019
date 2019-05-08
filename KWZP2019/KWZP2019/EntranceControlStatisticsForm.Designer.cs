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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceControlStatisticsForm));
            this.dataGridViewSemiFinished = new System.Windows.Forms.DataGridView();
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
            this.btnRefreshCharts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemiFinished)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSemiFinished
            // 
            this.dataGridViewSemiFinished.AllowUserToAddRows = false;
            this.dataGridViewSemiFinished.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridViewSemiFinished.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSemiFinished.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSemiFinished.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewSemiFinished.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dataGridViewSemiFinished.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSemiFinished.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSemiFinished.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSemiFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSemiFinished.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSemiFinished.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSemiFinished.Location = new System.Drawing.Point(200, 12);
            this.dataGridViewSemiFinished.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewSemiFinished.MultiSelect = false;
            this.dataGridViewSemiFinished.Name = "dataGridViewSemiFinished";
            this.dataGridViewSemiFinished.ReadOnly = true;
            this.dataGridViewSemiFinished.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSemiFinished.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridViewSemiFinished.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSemiFinished.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSemiFinished.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridViewSemiFinished.ShowEditingIcon = false;
            this.dataGridViewSemiFinished.Size = new System.Drawing.Size(180, 206);
            this.dataGridViewSemiFinished.TabIndex = 39;
            this.dataGridViewSemiFinished.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewSemiFinished_RowHeaderMouseClick);
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
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
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
            this.datePickerDateFrom.Location = new System.Drawing.Point(95, 234);
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
            this.datePickerDateTo.Location = new System.Drawing.Point(95, 271);
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
            this.lblDateFrom.Location = new System.Drawing.Point(11, 235);
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
            this.lblDateTo.Location = new System.Drawing.Point(10, 271);
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
            this.btnAllTime.Location = new System.Drawing.Point(12, 306);
            this.btnAllTime.Name = "btnAllTime";
            this.btnAllTime.Size = new System.Drawing.Size(370, 60);
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
            this.pieChartNumberOfPositiveAndNegativeControl.ForeColor = System.Drawing.Color.White;
            this.pieChartNumberOfPositiveAndNegativeControl.Location = new System.Drawing.Point(390, 12);
            this.pieChartNumberOfPositiveAndNegativeControl.Name = "pieChartNumberOfPositiveAndNegativeControl";
            this.pieChartNumberOfPositiveAndNegativeControl.Size = new System.Drawing.Size(206, 206);
            this.pieChartNumberOfPositiveAndNegativeControl.TabIndex = 44;
            // 
            // histogramThickness
            // 
            this.histogramThickness.BackColorTransparent = true;
            this.histogramThickness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.histogramThickness.Location = new System.Drawing.Point(606, 12);
            this.histogramThickness.Name = "histogramThickness";
            this.histogramThickness.Size = new System.Drawing.Size(370, 206);
            this.histogramThickness.TabIndex = 45;
            // 
            // histogramWidth
            // 
            this.histogramWidth.BackColorTransparent = true;
            this.histogramWidth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.histogramWidth.Location = new System.Drawing.Point(390, 230);
            this.histogramWidth.Name = "histogramWidth";
            this.histogramWidth.Size = new System.Drawing.Size(288, 206);
            this.histogramWidth.TabIndex = 45;
            // 
            // histogramWeight
            // 
            this.histogramWeight.BackColorTransparent = true;
            this.histogramWeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.histogramWeight.Location = new System.Drawing.Point(688, 230);
            this.histogramWeight.Name = "histogramWeight";
            this.histogramWeight.Size = new System.Drawing.Size(288, 206);
            this.histogramWeight.TabIndex = 45;
            // 
            // btnRefreshCharts
            // 
            this.btnRefreshCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnRefreshCharts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefreshCharts.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnRefreshCharts.FlatAppearance.BorderSize = 3;
            this.btnRefreshCharts.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefreshCharts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRefreshCharts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnRefreshCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefreshCharts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshCharts.Image = global::KWZP2019.Properties.Resources.icons8_date_span_40;
            this.btnRefreshCharts.Location = new System.Drawing.Point(12, 374);
            this.btnRefreshCharts.Name = "btnRefreshCharts";
            this.btnRefreshCharts.Size = new System.Drawing.Size(370, 60);
            this.btnRefreshCharts.TabIndex = 1;
            this.btnRefreshCharts.Text = "Odśwież wykresy";
            this.btnRefreshCharts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshCharts.UseVisualStyleBackColor = false;
            this.btnRefreshCharts.Click += new System.EventHandler(this.BtnRefreshCharts_Click);
            // 
            // EntranceControlStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 451);
            this.Controls.Add(this.histogramWidth);
            this.Controls.Add(this.histogramWeight);
            this.Controls.Add(this.histogramThickness);
            this.Controls.Add(this.pieChartNumberOfPositiveAndNegativeControl);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.datePickerDateTo);
            this.Controls.Add(this.datePickerDateFrom);
            this.Controls.Add(this.dataGridViewSemiFinished);
            this.Controls.Add(this.btnRefreshCharts);
            this.Controls.Add(this.btnAllTime);
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
        private System.Windows.Forms.DataGridView dataGridViewSemiFinished;
        private System.Windows.Forms.DateTimePicker datePickerDateFrom;
        private System.Windows.Forms.DateTimePicker datePickerDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Button btnAllTime;
        private LiveCharts.WinForms.PieChart pieChartNumberOfPositiveAndNegativeControl;
        private LiveCharts.WinForms.CartesianChart histogramThickness;
        private LiveCharts.WinForms.CartesianChart histogramWidth;
        private LiveCharts.WinForms.CartesianChart histogramWeight;
        private System.Windows.Forms.Button btnRefreshCharts;
    }
}