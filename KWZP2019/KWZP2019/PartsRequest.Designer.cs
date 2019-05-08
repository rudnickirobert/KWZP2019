namespace KWZP2019
{
    partial class PartsRequest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsRequest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelParts = new System.Windows.Forms.Panel();
            this.labelHeaderParts = new System.Windows.Forms.Label();
            this.btnReturnPartsForm = new System.Windows.Forms.Button();
            this.btnRequestPart_History = new System.Windows.Forms.Button();
            this.btnRequestPart_Delete = new System.Windows.Forms.Button();
            this.dpsRequestDateFrom = new System.Windows.Forms.DateTimePicker();
            this.panelRequestPart_Dates = new System.Windows.Forms.Panel();
            this.pbDateRange = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbDateAfter = new System.Windows.Forms.PictureBox();
            this.pbDateEqual = new System.Windows.Forms.PictureBox();
            this.pbDateBefore = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpsRequestDateTo = new System.Windows.Forms.DateTimePicker();
            this.lbRequestSearch = new System.Windows.Forms.Label();
            this.pbDateAll = new System.Windows.Forms.PictureBox();
            this.tbRequestSearch = new System.Windows.Forms.TextBox();
            this.btnRequestPart_Search = new System.Windows.Forms.Button();
            this.toolTipDateAfter = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDateBefore = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDateEqual = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDateAll = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDateRange = new System.Windows.Forms.ToolTip(this.components);
            this.btnRequestPart_Add = new System.Windows.Forms.Button();
            this.btnRequestPart_Accept = new System.Windows.Forms.Button();
            this.dataPartRequestView = new System.Windows.Forms.DataGridView();
            this.IdPartRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusPartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vPartsRequestViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelParts.SuspendLayout();
            this.panelRequestPart_Dates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateRange)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateEqual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartRequestView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPartsRequestViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelParts
            // 
            this.panelParts.BackColor = System.Drawing.Color.Transparent;
            this.panelParts.Controls.Add(this.labelHeaderParts);
            this.panelParts.Controls.Add(this.btnReturnPartsForm);
            this.panelParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelParts.Location = new System.Drawing.Point(0, 0);
            this.panelParts.Name = "panelParts";
            this.panelParts.Size = new System.Drawing.Size(944, 59);
            this.panelParts.TabIndex = 3;
            // 
            // labelHeaderParts
            // 
            this.labelHeaderParts.AutoSize = true;
            this.labelHeaderParts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelHeaderParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeaderParts.ForeColor = System.Drawing.Color.White;
            this.labelHeaderParts.Location = new System.Drawing.Point(195, 7);
            this.labelHeaderParts.Name = "labelHeaderParts";
            this.labelHeaderParts.Size = new System.Drawing.Size(544, 51);
            this.labelHeaderParts.TabIndex = 4;
            this.labelHeaderParts.Text = "Części - Zapotrzebowanie";
            // 
            // btnReturnPartsForm
            // 
            this.btnReturnPartsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnPartsForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnPartsForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReturnPartsForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReturnPartsForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReturnPartsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnPartsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnPartsForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnPartsForm.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnPartsForm.Image")));
            this.btnReturnPartsForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReturnPartsForm.Location = new System.Drawing.Point(868, 0);
            this.btnReturnPartsForm.Name = "btnReturnPartsForm";
            this.btnReturnPartsForm.Size = new System.Drawing.Size(76, 59);
            this.btnReturnPartsForm.TabIndex = 3;
            this.btnReturnPartsForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnPartsForm.UseVisualStyleBackColor = false;
            this.btnReturnPartsForm.Click += new System.EventHandler(this.btnReturnPartsForm_Click);
            // 
            // btnRequestPart_History
            // 
            this.btnRequestPart_History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnRequestPart_History.FlatAppearance.BorderSize = 0;
            this.btnRequestPart_History.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRequestPart_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRequestPart_History.ForeColor = System.Drawing.Color.White;
            this.btnRequestPart_History.Image = ((System.Drawing.Image)(resources.GetObject("btnRequestPart_History.Image")));
            this.btnRequestPart_History.Location = new System.Drawing.Point(12, 268);
            this.btnRequestPart_History.Name = "btnRequestPart_History";
            this.btnRequestPart_History.Size = new System.Drawing.Size(164, 99);
            this.btnRequestPart_History.TabIndex = 9;
            this.btnRequestPart_History.Text = "Historia";
            this.btnRequestPart_History.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRequestPart_History.UseVisualStyleBackColor = false;
            this.btnRequestPart_History.Click += new System.EventHandler(this.btnRequestPart_History_Click);
            // 
            // btnRequestPart_Delete
            // 
            this.btnRequestPart_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnRequestPart_Delete.FlatAppearance.BorderSize = 0;
            this.btnRequestPart_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRequestPart_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRequestPart_Delete.ForeColor = System.Drawing.Color.White;
            this.btnRequestPart_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btnRequestPart_Delete.Image")));
            this.btnRequestPart_Delete.Location = new System.Drawing.Point(12, 180);
            this.btnRequestPart_Delete.Name = "btnRequestPart_Delete";
            this.btnRequestPart_Delete.Size = new System.Drawing.Size(164, 82);
            this.btnRequestPart_Delete.TabIndex = 11;
            this.btnRequestPart_Delete.Text = "Usuń zapotrzebowanie";
            this.btnRequestPart_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRequestPart_Delete.UseVisualStyleBackColor = false;
            this.btnRequestPart_Delete.Click += new System.EventHandler(this.btnRequestPart_Delete_Click);
            // 
            // dpsRequestDateFrom
            // 
            this.dpsRequestDateFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dpsRequestDateFrom.Checked = false;
            this.dpsRequestDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dpsRequestDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpsRequestDateFrom.Location = new System.Drawing.Point(9, 10);
            this.dpsRequestDateFrom.Name = "dpsRequestDateFrom";
            this.dpsRequestDateFrom.Size = new System.Drawing.Size(142, 29);
            this.dpsRequestDateFrom.TabIndex = 16;
            this.dpsRequestDateFrom.ValueChanged += new System.EventHandler(this.dpsRequestDateFrom_ValueChanged);
            // 
            // panelRequestPart_Dates
            // 
            this.panelRequestPart_Dates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.panelRequestPart_Dates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRequestPart_Dates.Controls.Add(this.pbDateRange);
            this.panelRequestPart_Dates.Controls.Add(this.panel1);
            this.panelRequestPart_Dates.Controls.Add(this.label2);
            this.panelRequestPart_Dates.Controls.Add(this.label1);
            this.panelRequestPart_Dates.Controls.Add(this.dpsRequestDateTo);
            this.panelRequestPart_Dates.Controls.Add(this.lbRequestSearch);
            this.panelRequestPart_Dates.Controls.Add(this.pbDateAll);
            this.panelRequestPart_Dates.Controls.Add(this.tbRequestSearch);
            this.panelRequestPart_Dates.Controls.Add(this.btnRequestPart_Search);
            this.panelRequestPart_Dates.Location = new System.Drawing.Point(193, 385);
            this.panelRequestPart_Dates.Name = "panelRequestPart_Dates";
            this.panelRequestPart_Dates.Size = new System.Drawing.Size(739, 113);
            this.panelRequestPart_Dates.TabIndex = 40;
            // 
            // pbDateRange
            // 
            this.pbDateRange.BackColor = System.Drawing.Color.Transparent;
            this.pbDateRange.Image = ((System.Drawing.Image)(resources.GetObject("pbDateRange.Image")));
            this.pbDateRange.InitialImage = null;
            this.pbDateRange.Location = new System.Drawing.Point(265, 58);
            this.pbDateRange.Name = "pbDateRange";
            this.pbDateRange.Size = new System.Drawing.Size(31, 29);
            this.pbDateRange.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDateRange.TabIndex = 47;
            this.pbDateRange.TabStop = false;
            this.toolTipDateRange.SetToolTip(this.pbDateRange, "Pokaż zapotrzebowania zlecone w wybranym zakresie dat");
            this.pbDateRange.Click += new System.EventHandler(this.pbDateRange_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pbDateAfter);
            this.panel1.Controls.Add(this.pbDateEqual);
            this.panel1.Controls.Add(this.pbDateBefore);
            this.panel1.Controls.Add(this.dpsRequestDateFrom);
            this.panel1.Location = new System.Drawing.Point(46, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 78);
            this.panel1.TabIndex = 46;
            // 
            // pbDateAfter
            // 
            this.pbDateAfter.BackColor = System.Drawing.Color.Transparent;
            this.pbDateAfter.Image = ((System.Drawing.Image)(resources.GetObject("pbDateAfter.Image")));
            this.pbDateAfter.InitialImage = null;
            this.pbDateAfter.Location = new System.Drawing.Point(121, 45);
            this.pbDateAfter.Name = "pbDateAfter";
            this.pbDateAfter.Size = new System.Drawing.Size(30, 29);
            this.pbDateAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDateAfter.TabIndex = 39;
            this.pbDateAfter.TabStop = false;
            this.toolTipDateAfter.SetToolTip(this.pbDateAfter, "Pokaż zapotrzebowania zlecone po dniu");
            this.pbDateAfter.Click += new System.EventHandler(this.pbDateAfter_Click);
            // 
            // pbDateEqual
            // 
            this.pbDateEqual.BackColor = System.Drawing.Color.Transparent;
            this.pbDateEqual.Image = ((System.Drawing.Image)(resources.GetObject("pbDateEqual.Image")));
            this.pbDateEqual.InitialImage = null;
            this.pbDateEqual.Location = new System.Drawing.Point(67, 45);
            this.pbDateEqual.Name = "pbDateEqual";
            this.pbDateEqual.Size = new System.Drawing.Size(28, 29);
            this.pbDateEqual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDateEqual.TabIndex = 40;
            this.pbDateEqual.TabStop = false;
            this.toolTipDateEqual.SetToolTip(this.pbDateEqual, "Pokaż zapotrzebowania zlecone wybranego dnia");
            this.pbDateEqual.Click += new System.EventHandler(this.pbDateEqual_Click);
            // 
            // pbDateBefore
            // 
            this.pbDateBefore.BackColor = System.Drawing.Color.Transparent;
            this.pbDateBefore.Image = ((System.Drawing.Image)(resources.GetObject("pbDateBefore.Image")));
            this.pbDateBefore.InitialImage = null;
            this.pbDateBefore.Location = new System.Drawing.Point(9, 45);
            this.pbDateBefore.Name = "pbDateBefore";
            this.pbDateBefore.Size = new System.Drawing.Size(30, 29);
            this.pbDateBefore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDateBefore.TabIndex = 38;
            this.pbDateBefore.TabStop = false;
            this.toolTipDateBefore.SetToolTip(this.pbDateBefore, "Pokaż zapotrzebowania zlecone przed dniem");
            this.pbDateBefore.Click += new System.EventHandler(this.pbDateBefore_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "DO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "OD";
            // 
            // dpsRequestDateTo
            // 
            this.dpsRequestDateTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dpsRequestDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dpsRequestDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpsRequestDateTo.Location = new System.Drawing.Point(265, 23);
            this.dpsRequestDateTo.Name = "dpsRequestDateTo";
            this.dpsRequestDateTo.Size = new System.Drawing.Size(142, 29);
            this.dpsRequestDateTo.TabIndex = 43;
            this.dpsRequestDateTo.ValueChanged += new System.EventHandler(this.dpsRequestDateTo_ValueChanged);
            // 
            // lbRequestSearch
            // 
            this.lbRequestSearch.AutoSize = true;
            this.lbRequestSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRequestSearch.ForeColor = System.Drawing.Color.White;
            this.lbRequestSearch.Location = new System.Drawing.Point(481, 10);
            this.lbRequestSearch.Name = "lbRequestSearch";
            this.lbRequestSearch.Size = new System.Drawing.Size(203, 20);
            this.lbRequestSearch.TabIndex = 42;
            this.lbRequestSearch.Text = "Wprowadź nazwę części";
            // 
            // pbDateAll
            // 
            this.pbDateAll.BackColor = System.Drawing.Color.Transparent;
            this.pbDateAll.Image = ((System.Drawing.Image)(resources.GetObject("pbDateAll.Image")));
            this.pbDateAll.InitialImage = null;
            this.pbDateAll.Location = new System.Drawing.Point(375, 58);
            this.pbDateAll.Name = "pbDateAll";
            this.pbDateAll.Size = new System.Drawing.Size(32, 29);
            this.pbDateAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDateAll.TabIndex = 41;
            this.pbDateAll.TabStop = false;
            this.toolTipDateAll.SetToolTip(this.pbDateAll, "Pokaż wszystkie zapotrzebowania");
            this.pbDateAll.Click += new System.EventHandler(this.pbDateAll_Click);
            // 
            // tbRequestSearch
            // 
            this.tbRequestSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbRequestSearch.Location = new System.Drawing.Point(457, 33);
            this.tbRequestSearch.Name = "tbRequestSearch";
            this.tbRequestSearch.Size = new System.Drawing.Size(250, 29);
            this.tbRequestSearch.TabIndex = 41;
            this.tbRequestSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRequestPart_Search
            // 
            this.btnRequestPart_Search.BackColor = System.Drawing.Color.Black;
            this.btnRequestPart_Search.FlatAppearance.BorderSize = 0;
            this.btnRequestPart_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRequestPart_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRequestPart_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRequestPart_Search.ForeColor = System.Drawing.Color.White;
            this.btnRequestPart_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequestPart_Search.Location = new System.Drawing.Point(502, 68);
            this.btnRequestPart_Search.Name = "btnRequestPart_Search";
            this.btnRequestPart_Search.Size = new System.Drawing.Size(149, 33);
            this.btnRequestPart_Search.TabIndex = 10;
            this.btnRequestPart_Search.Text = "    Wyszukaj";
            this.btnRequestPart_Search.UseVisualStyleBackColor = false;
            this.btnRequestPart_Search.Click += new System.EventHandler(this.btnRequestPart_Search_Click);
            // 
            // btnRequestPart_Add
            // 
            this.btnRequestPart_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnRequestPart_Add.FlatAppearance.BorderSize = 0;
            this.btnRequestPart_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRequestPart_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRequestPart_Add.ForeColor = System.Drawing.Color.White;
            this.btnRequestPart_Add.Image = ((System.Drawing.Image)(resources.GetObject("btnRequestPart_Add.Image")));
            this.btnRequestPart_Add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRequestPart_Add.Location = new System.Drawing.Point(12, 92);
            this.btnRequestPart_Add.Name = "btnRequestPart_Add";
            this.btnRequestPart_Add.Size = new System.Drawing.Size(164, 82);
            this.btnRequestPart_Add.TabIndex = 43;
            this.btnRequestPart_Add.Text = "Dodaj zapotrzebowanie";
            this.btnRequestPart_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRequestPart_Add.UseVisualStyleBackColor = false;
            this.btnRequestPart_Add.Click += new System.EventHandler(this.btnRequestPart_Add_Click);
            // 
            // btnRequestPart_Accept
            // 
            this.btnRequestPart_Accept.BackColor = System.Drawing.Color.Green;
            this.btnRequestPart_Accept.FlatAppearance.BorderSize = 0;
            this.btnRequestPart_Accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRequestPart_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestPart_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRequestPart_Accept.ForeColor = System.Drawing.Color.White;
            this.btnRequestPart_Accept.Image = ((System.Drawing.Image)(resources.GetObject("btnRequestPart_Accept.Image")));
            this.btnRequestPart_Accept.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRequestPart_Accept.Location = new System.Drawing.Point(12, 400);
            this.btnRequestPart_Accept.Name = "btnRequestPart_Accept";
            this.btnRequestPart_Accept.Size = new System.Drawing.Size(164, 88);
            this.btnRequestPart_Accept.TabIndex = 42;
            this.btnRequestPart_Accept.Text = "ZATWIERDŹ";
            this.btnRequestPart_Accept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRequestPart_Accept.UseVisualStyleBackColor = false;
            this.btnRequestPart_Accept.Click += new System.EventHandler(this.btnRequestPart_Accept_Click);
            // 
            // dataPartRequestView
            // 
            this.dataPartRequestView.AllowUserToAddRows = false;
            this.dataPartRequestView.AllowUserToDeleteRows = false;
            this.dataPartRequestView.AllowUserToResizeColumns = false;
            this.dataPartRequestView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataPartRequestView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPartRequestView.AutoGenerateColumns = false;
            this.dataPartRequestView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataPartRequestView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPartRequestView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataPartRequestView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPartRequestView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPartRequest,
            this.partNameDataGridViewTextBoxColumn,
            this.requestDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusPartDataGridViewTextBoxColumn});
            this.dataPartRequestView.DataSource = this.vPartsRequestViewBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPartRequestView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataPartRequestView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataPartRequestView.Location = new System.Drawing.Point(193, 81);
            this.dataPartRequestView.MultiSelect = false;
            this.dataPartRequestView.Name = "dataPartRequestView";
            this.dataPartRequestView.ReadOnly = true;
            this.dataPartRequestView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPartRequestView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataPartRequestView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataPartRequestView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataPartRequestView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPartRequestView.Size = new System.Drawing.Size(739, 286);
            this.dataPartRequestView.TabIndex = 41;
            this.dataPartRequestView.VirtualMode = true;
            this.dataPartRequestView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataPartRequestView_CellFormatting);
            // 
            // IdPartRequest
            // 
            this.IdPartRequest.DataPropertyName = "IdPartRequest";
            this.IdPartRequest.Frozen = true;
            this.IdPartRequest.HeaderText = "Numer zapotrzebowania";
            this.IdPartRequest.Name = "IdPartRequest";
            this.IdPartRequest.ReadOnly = true;
            this.IdPartRequest.Width = 150;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.Frozen = true;
            this.partNameDataGridViewTextBoxColumn.HeaderText = "Nazwa części";
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            this.partNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.partNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            this.requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            this.requestDateDataGridViewTextBoxColumn.Frozen = true;
            this.requestDateDataGridViewTextBoxColumn.HeaderText = "Data wysłania zapotrzebowania";
            this.requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            this.requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.requestDateDataGridViewTextBoxColumn.Width = 170;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Frozen = true;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusPartDataGridViewTextBoxColumn
            // 
            this.statusPartDataGridViewTextBoxColumn.DataPropertyName = "StatusPart";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.statusPartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.statusPartDataGridViewTextBoxColumn.Frozen = true;
            this.statusPartDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusPartDataGridViewTextBoxColumn.Name = "statusPartDataGridViewTextBoxColumn";
            this.statusPartDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusPartDataGridViewTextBoxColumn.Width = 75;
            // 
            // vPartsRequestViewBindingSource
            // 
            this.vPartsRequestViewBindingSource.DataSource = typeof(KWZP2019.vPartsRequestView);
            // 
            // PartsRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btnRequestPart_Add);
            this.Controls.Add(this.btnRequestPart_Accept);
            this.Controls.Add(this.dataPartRequestView);
            this.Controls.Add(this.panelRequestPart_Dates);
            this.Controls.Add(this.btnRequestPart_Delete);
            this.Controls.Add(this.btnRequestPart_History);
            this.Controls.Add(this.panelParts);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "PartsRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Części - Zapotrzebowanie";
            this.Load += new System.EventHandler(this.PartsRequest_Load);
            this.panelParts.ResumeLayout(false);
            this.panelParts.PerformLayout();
            this.panelRequestPart_Dates.ResumeLayout(false);
            this.panelRequestPart_Dates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateRange)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDateAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateEqual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDateAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPartRequestView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPartsRequestViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturnPartsForm;
        private System.Windows.Forms.Panel panelParts;
        private System.Windows.Forms.Label labelHeaderParts;
        private System.Windows.Forms.Button btnRequestPart_History;
        private System.Windows.Forms.Button btnRequestPart_Search;
        private System.Windows.Forms.Button btnRequestPart_Delete;
        private System.Windows.Forms.DateTimePicker dpsRequestDateFrom;
        private System.Windows.Forms.PictureBox pbDateBefore;
        private System.Windows.Forms.PictureBox pbDateAfter;
        private System.Windows.Forms.Panel panelRequestPart_Dates;
        private System.Windows.Forms.PictureBox pbDateEqual;
        private System.Windows.Forms.PictureBox pbDateAll;
        private System.Windows.Forms.ToolTip toolTipDateAfter;
        private System.Windows.Forms.ToolTip toolTipDateBefore;
        private System.Windows.Forms.ToolTip toolTipDateEqual;
        private System.Windows.Forms.ToolTip toolTipDateAll;
        private System.Windows.Forms.TextBox tbRequestSearch;
        private System.Windows.Forms.Label lbRequestSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpsRequestDateTo;
        private System.Windows.Forms.PictureBox pbDateRange;
        private System.Windows.Forms.ToolTip toolTipDateRange;
        private System.Windows.Forms.Button btnRequestPart_Accept;
        private System.Windows.Forms.Button btnRequestPart_Add;
        private System.Windows.Forms.DataGridView dataPartRequestView;
        private System.Windows.Forms.BindingSource vPartsRequestViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPartRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPartRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusPartDataGridViewTextBoxColumn;
    }
}