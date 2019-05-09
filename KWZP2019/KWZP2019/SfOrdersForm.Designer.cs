namespace KWZP2019
{
    partial class SfOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SfOrdersForm));
            this.sfOrdersDgv = new System.Windows.Forms.DataGridView();
            this.sfOrderDetailsDgv = new System.Windows.Forms.DataGridView();
            this.sfOrdersLbl = new System.Windows.Forms.Label();
            this.sfOrderDetailsLbl = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.sfOrderDetailBtn = new System.Windows.Forms.Button();
            this.sfOrderBtn = new System.Windows.Forms.Button();
            this.deleteOrderDetailBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sfOrdersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfOrderDetailsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // sfOrdersDgv
            // 
            this.sfOrdersDgv.AllowUserToAddRows = false;
            this.sfOrdersDgv.AllowUserToDeleteRows = false;
            this.sfOrdersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sfOrdersDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.sfOrdersDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.sfOrdersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sfOrdersDgv.Location = new System.Drawing.Point(29, 112);
            this.sfOrdersDgv.Name = "sfOrdersDgv";
            this.sfOrdersDgv.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.sfOrdersDgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sfOrdersDgv.Size = new System.Drawing.Size(626, 360);
            this.sfOrdersDgv.TabIndex = 0;
            this.sfOrdersDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sfOrdersDgv_CellContentClick);
            // 
            // sfOrderDetailsDgv
            // 
            this.sfOrderDetailsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sfOrderDetailsDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.sfOrderDetailsDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.sfOrderDetailsDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.sfOrderDetailsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sfOrderDetailsDgv.Location = new System.Drawing.Point(729, 112);
            this.sfOrderDetailsDgv.Name = "sfOrderDetailsDgv";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.sfOrderDetailsDgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.sfOrderDetailsDgv.Size = new System.Drawing.Size(412, 360);
            this.sfOrderDetailsDgv.TabIndex = 1;
            // 
            // sfOrdersLbl
            // 
            this.sfOrdersLbl.AutoSize = true;
            this.sfOrdersLbl.BackColor = System.Drawing.Color.Transparent;
            this.sfOrdersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.sfOrdersLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sfOrdersLbl.Location = new System.Drawing.Point(24, 58);
            this.sfOrdersLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sfOrdersLbl.Name = "sfOrdersLbl";
            this.sfOrdersLbl.Size = new System.Drawing.Size(302, 29);
            this.sfOrdersLbl.TabIndex = 14;
            this.sfOrdersLbl.Text = "Zamówienia półfabrykatów";
            // 
            // sfOrderDetailsLbl
            // 
            this.sfOrderDetailsLbl.AutoSize = true;
            this.sfOrderDetailsLbl.BackColor = System.Drawing.Color.Transparent;
            this.sfOrderDetailsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.sfOrderDetailsLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sfOrderDetailsLbl.Location = new System.Drawing.Point(724, 58);
            this.sfOrderDetailsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sfOrderDetailsLbl.Name = "sfOrderDetailsLbl";
            this.sfOrderDetailsLbl.Size = new System.Drawing.Size(287, 29);
            this.sfOrderDetailsLbl.TabIndex = 14;
            this.sfOrderDetailsLbl.Text = "Szczegół zamówienia nr: ";
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.returnBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.returnBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnBtn.Image = ((System.Drawing.Image)(resources.GetObject("returnBtn.Image")));
            this.returnBtn.Location = new System.Drawing.Point(29, 595);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(200, 120);
            this.returnBtn.TabIndex = 20;
            this.returnBtn.Text = "Powrót";
            this.returnBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // sfOrderDetailBtn
            // 
            this.sfOrderDetailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.sfOrderDetailBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sfOrderDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.sfOrderDetailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sfOrderDetailBtn.Location = new System.Drawing.Point(729, 501);
            this.sfOrderDetailBtn.Name = "sfOrderDetailBtn";
            this.sfOrderDetailBtn.Size = new System.Drawing.Size(412, 70);
            this.sfOrderDetailBtn.TabIndex = 21;
            this.sfOrderDetailBtn.Text = "Dodaj szczegół zamówienia";
            this.sfOrderDetailBtn.UseVisualStyleBackColor = false;
            this.sfOrderDetailBtn.Click += new System.EventHandler(this.sfOrderDetailBtn_Click);
            // 
            // sfOrderBtn
            // 
            this.sfOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.sfOrderBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sfOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.sfOrderBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sfOrderBtn.Location = new System.Drawing.Point(29, 501);
            this.sfOrderBtn.Name = "sfOrderBtn";
            this.sfOrderBtn.Size = new System.Drawing.Size(626, 70);
            this.sfOrderBtn.TabIndex = 22;
            this.sfOrderBtn.Text = "Dodaj zamówienie";
            this.sfOrderBtn.UseVisualStyleBackColor = false;
            this.sfOrderBtn.Click += new System.EventHandler(this.sfOrderBtn_Click);
            // 
            // deleteOrderDetailBtn
            // 
            this.deleteOrderDetailBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.deleteOrderDetailBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deleteOrderDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.deleteOrderDetailBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteOrderDetailBtn.Location = new System.Drawing.Point(729, 632);
            this.deleteOrderDetailBtn.Name = "deleteOrderDetailBtn";
            this.deleteOrderDetailBtn.Size = new System.Drawing.Size(412, 70);
            this.deleteOrderDetailBtn.TabIndex = 21;
            this.deleteOrderDetailBtn.Text = "Usuń szczegół zamówienia";
            this.deleteOrderDetailBtn.UseVisualStyleBackColor = false;
            this.deleteOrderDetailBtn.Click += new System.EventHandler(this.deleteOrderDetailBtn_Click);
            // 
            // SfOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.sfOrderBtn);
            this.Controls.Add(this.deleteOrderDetailBtn);
            this.Controls.Add(this.sfOrderDetailBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.sfOrderDetailsLbl);
            this.Controls.Add(this.sfOrdersLbl);
            this.Controls.Add(this.sfOrderDetailsDgv);
            this.Controls.Add(this.sfOrdersDgv);
            this.Name = "SfOrdersForm";
            this.Text = "SfOrdersForm";
            this.Load += new System.EventHandler(this.SfOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfOrdersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfOrderDetailsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sfOrdersDgv;
        private System.Windows.Forms.DataGridView sfOrderDetailsDgv;
        private System.Windows.Forms.Label sfOrdersLbl;
        private System.Windows.Forms.Label sfOrderDetailsLbl;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button sfOrderDetailBtn;
        private System.Windows.Forms.Button sfOrderBtn;
        private System.Windows.Forms.Button deleteOrderDetailBtn;
    }
}