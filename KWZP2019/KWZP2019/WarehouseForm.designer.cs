namespace KWZP2019
{
    partial class WarehouseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseForm));
            this.entraceWarehouseDgv = new System.Windows.Forms.DataGridView();
            this.outWarehouseDgv = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.entraceWarehouseLbl = new System.Windows.Forms.Label();
            this.outWarehouseLbl = new System.Windows.Forms.Label();
            this.semiFinishedLbl = new System.Windows.Forms.Label();
            this.productLbl = new System.Windows.Forms.Label();
            this.semiFinishedCodeTb = new System.Windows.Forms.TextBox();
            this.productCodeTb = new System.Windows.Forms.TextBox();
            this.sfOrderBtn = new System.Windows.Forms.Button();
            this.orderReturnBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.entraceWarehouseDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outWarehouseDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // entraceWarehouseDgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.entraceWarehouseDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.entraceWarehouseDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.entraceWarehouseDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.entraceWarehouseDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.entraceWarehouseDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.entraceWarehouseDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.entraceWarehouseDgv.EnableHeadersVisualStyles = false;
            this.entraceWarehouseDgv.Location = new System.Drawing.Point(29, 155);
            this.entraceWarehouseDgv.Margin = new System.Windows.Forms.Padding(2);
            this.entraceWarehouseDgv.MultiSelect = false;
            this.entraceWarehouseDgv.Name = "entraceWarehouseDgv";
            this.entraceWarehouseDgv.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.entraceWarehouseDgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.entraceWarehouseDgv.RowTemplate.Height = 24;
            this.entraceWarehouseDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entraceWarehouseDgv.Size = new System.Drawing.Size(523, 418);
            this.entraceWarehouseDgv.TabIndex = 16;
            // 
            // outWarehouseDgv
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.outWarehouseDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.outWarehouseDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outWarehouseDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.outWarehouseDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.outWarehouseDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.outWarehouseDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.outWarehouseDgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.outWarehouseDgv.EnableHeadersVisualStyles = false;
            this.outWarehouseDgv.Location = new System.Drawing.Point(644, 155);
            this.outWarehouseDgv.Margin = new System.Windows.Forms.Padding(2);
            this.outWarehouseDgv.MultiSelect = false;
            this.outWarehouseDgv.Name = "outWarehouseDgv";
            this.outWarehouseDgv.RowHeadersVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.outWarehouseDgv.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.outWarehouseDgv.RowTemplate.Height = 24;
            this.outWarehouseDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outWarehouseDgv.Size = new System.Drawing.Size(506, 418);
            this.outWarehouseDgv.TabIndex = 17;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.backBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(60, 618);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(200, 120);
            this.backBtn.TabIndex = 20;
            this.backBtn.Text = "Powrót";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // entraceWarehouseLbl
            // 
            this.entraceWarehouseLbl.AutoSize = true;
            this.entraceWarehouseLbl.BackColor = System.Drawing.Color.Transparent;
            this.entraceWarehouseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.entraceWarehouseLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.entraceWarehouseLbl.Location = new System.Drawing.Point(24, 30);
            this.entraceWarehouseLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.entraceWarehouseLbl.Name = "entraceWarehouseLbl";
            this.entraceWarehouseLbl.Size = new System.Drawing.Size(242, 29);
            this.entraceWarehouseLbl.TabIndex = 21;
            this.entraceWarehouseLbl.Text = "Magazyn wejściowy";
            // 
            // outWarehouseLbl
            // 
            this.outWarehouseLbl.AutoSize = true;
            this.outWarehouseLbl.BackColor = System.Drawing.Color.Transparent;
            this.outWarehouseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.outWarehouseLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.outWarehouseLbl.Location = new System.Drawing.Point(639, 30);
            this.outWarehouseLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outWarehouseLbl.Name = "outWarehouseLbl";
            this.outWarehouseLbl.Size = new System.Drawing.Size(239, 29);
            this.outWarehouseLbl.TabIndex = 22;
            this.outWarehouseLbl.Text = "Magazyn wyjściowy";
            // 
            // semiFinishedLbl
            // 
            this.semiFinishedLbl.AutoSize = true;
            this.semiFinishedLbl.BackColor = System.Drawing.Color.Transparent;
            this.semiFinishedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.semiFinishedLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.semiFinishedLbl.Location = new System.Drawing.Point(26, 93);
            this.semiFinishedLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.semiFinishedLbl.Name = "semiFinishedLbl";
            this.semiFinishedLbl.Size = new System.Drawing.Size(135, 18);
            this.semiFinishedLbl.TabIndex = 23;
            this.semiFinishedLbl.Text = "Kod półfabrykatu";
            // 
            // productLbl
            // 
            this.productLbl.AutoSize = true;
            this.productLbl.BackColor = System.Drawing.Color.Transparent;
            this.productLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.productLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.productLbl.Location = new System.Drawing.Point(641, 93);
            this.productLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productLbl.Name = "productLbl";
            this.productLbl.Size = new System.Drawing.Size(109, 18);
            this.productLbl.TabIndex = 24;
            this.productLbl.Text = "Kod produktu";
            // 
            // semiFinishedCodeTb
            // 
            this.semiFinishedCodeTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.semiFinishedCodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.semiFinishedCodeTb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.semiFinishedCodeTb.Location = new System.Drawing.Point(192, 93);
            this.semiFinishedCodeTb.Margin = new System.Windows.Forms.Padding(2);
            this.semiFinishedCodeTb.Name = "semiFinishedCodeTb";
            this.semiFinishedCodeTb.Size = new System.Drawing.Size(271, 24);
            this.semiFinishedCodeTb.TabIndex = 25;
            this.semiFinishedCodeTb.TextChanged += new System.EventHandler(this.semiFinishedCodeTb_TextChanged);
            // 
            // productCodeTb
            // 
            this.productCodeTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.productCodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.productCodeTb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.productCodeTb.Location = new System.Drawing.Point(788, 93);
            this.productCodeTb.Margin = new System.Windows.Forms.Padding(2);
            this.productCodeTb.Name = "productCodeTb";
            this.productCodeTb.Size = new System.Drawing.Size(271, 24);
            this.productCodeTb.TabIndex = 26;
            this.productCodeTb.TextChanged += new System.EventHandler(this.productCodeTb_TextChanged);
            // 
            // sfOrderBtn
            // 
            this.sfOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.sfOrderBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sfOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.sfOrderBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sfOrderBtn.Location = new System.Drawing.Point(352, 618);
            this.sfOrderBtn.Name = "sfOrderBtn";
            this.sfOrderBtn.Size = new System.Drawing.Size(200, 120);
            this.sfOrderBtn.TabIndex = 20;
            this.sfOrderBtn.Text = "Zamów półfabrykat";
            this.sfOrderBtn.UseVisualStyleBackColor = false;
            this.sfOrderBtn.Click += new System.EventHandler(this.sfOrderBtn_Click);
            // 
            // orderReturnBtn
            // 
            this.orderReturnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.orderReturnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.orderReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.orderReturnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orderReturnBtn.Image = ((System.Drawing.Image)(resources.GetObject("orderReturnBtn.Image")));
            this.orderReturnBtn.Location = new System.Drawing.Point(927, 618);
            this.orderReturnBtn.Name = "orderReturnBtn";
            this.orderReturnBtn.Size = new System.Drawing.Size(223, 120);
            this.orderReturnBtn.TabIndex = 20;
            this.orderReturnBtn.Text = "Powrót do zamówień";
            this.orderReturnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.orderReturnBtn.UseVisualStyleBackColor = false;
            this.orderReturnBtn.Click += new System.EventHandler(this.orderReturnBtn_Click);
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.productCodeTb);
            this.Controls.Add(this.semiFinishedCodeTb);
            this.Controls.Add(this.productLbl);
            this.Controls.Add(this.semiFinishedLbl);
            this.Controls.Add(this.outWarehouseLbl);
            this.Controls.Add(this.entraceWarehouseLbl);
            this.Controls.Add(this.sfOrderBtn);
            this.Controls.Add(this.orderReturnBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.outWarehouseDgv);
            this.Controls.Add(this.entraceWarehouseDgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WarehouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn";
            this.Load += new System.EventHandler(this.WarehouseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entraceWarehouseDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outWarehouseDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView entraceWarehouseDgv;
        private System.Windows.Forms.DataGridView outWarehouseDgv;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label entraceWarehouseLbl;
        private System.Windows.Forms.Label outWarehouseLbl;
        private System.Windows.Forms.Label semiFinishedLbl;
        private System.Windows.Forms.Label productLbl;
        private System.Windows.Forms.TextBox semiFinishedCodeTb;
        private System.Windows.Forms.TextBox productCodeTb;
        private System.Windows.Forms.Button sfOrderBtn;
        private System.Windows.Forms.Button orderReturnBtn;
    }
}