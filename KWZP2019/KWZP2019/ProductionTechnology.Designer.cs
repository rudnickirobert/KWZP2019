namespace KWZP2019
{
    partial class ProductionTechnology
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
            this.dataGVtechnology = new System.Windows.Forms.DataGridView();
            this.textBoxTechnologyName = new System.Windows.Forms.TextBox();
            this.textBoxTimePermeter = new System.Windows.Forms.TextBox();
            this.textBoxSpeedFactor = new System.Windows.Forms.TextBox();
            this.lblTechnologyName = new System.Windows.Forms.Label();
            this.lblTimePermeter = new System.Windows.Forms.Label();
            this.lblSpeedFactor = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVtechnology)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVtechnology
            // 
            this.dataGVtechnology.AllowUserToDeleteRows = false;
            this.dataGVtechnology.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGVtechnology.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVtechnology.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVtechnology.Location = new System.Drawing.Point(12, 12);
            this.dataGVtechnology.Name = "dataGVtechnology";
            this.dataGVtechnology.Size = new System.Drawing.Size(655, 524);
            this.dataGVtechnology.TabIndex = 0;
            // 
            // textBoxTechnologyName
            // 
            this.textBoxTechnologyName.Location = new System.Drawing.Point(842, 110);
            this.textBoxTechnologyName.Name = "textBoxTechnologyName";
            this.textBoxTechnologyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTechnologyName.TabIndex = 1;
            // 
            // textBoxTimePermeter
            // 
            this.textBoxTimePermeter.Location = new System.Drawing.Point(842, 160);
            this.textBoxTimePermeter.Name = "textBoxTimePermeter";
            this.textBoxTimePermeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimePermeter.TabIndex = 1;
            // 
            // textBoxSpeedFactor
            // 
            this.textBoxSpeedFactor.Location = new System.Drawing.Point(842, 211);
            this.textBoxSpeedFactor.Name = "textBoxSpeedFactor";
            this.textBoxSpeedFactor.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeedFactor.TabIndex = 1;
            // 
            // lblTechnologyName
            // 
            this.lblTechnologyName.AutoSize = true;
            this.lblTechnologyName.Location = new System.Drawing.Point(750, 116);
            this.lblTechnologyName.Name = "lblTechnologyName";
            this.lblTechnologyName.Size = new System.Drawing.Size(92, 13);
            this.lblTechnologyName.TabIndex = 2;
            this.lblTechnologyName.Text = "Nazwa technologi";
            // 
            // lblTimePermeter
            // 
            this.lblTimePermeter.AutoSize = true;
            this.lblTimePermeter.Location = new System.Drawing.Point(735, 167);
            this.lblTimePermeter.Name = "lblTimePermeter";
            this.lblTimePermeter.Size = new System.Drawing.Size(101, 13);
            this.lblTimePermeter.TabIndex = 2;
            this.lblTimePermeter.Text = "Prędkość produkcji ";
            // 
            // lblSpeedFactor
            // 
            this.lblSpeedFactor.AutoSize = true;
            this.lblSpeedFactor.Location = new System.Drawing.Point(712, 218);
            this.lblSpeedFactor.Name = "lblSpeedFactor";
            this.lblSpeedFactor.Size = new System.Drawing.Size(124, 13);
            this.lblSpeedFactor.TabIndex = 2;
            this.lblSpeedFactor.Text = "Współczynnik prędkości";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(766, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProductionTechnology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSpeedFactor);
            this.Controls.Add(this.lblTimePermeter);
            this.Controls.Add(this.lblTechnologyName);
            this.Controls.Add(this.textBoxSpeedFactor);
            this.Controls.Add(this.textBoxTimePermeter);
            this.Controls.Add(this.textBoxTechnologyName);
            this.Controls.Add(this.dataGVtechnology);
            this.Name = "ProductionTechnology";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technologia";
            this.Load += new System.EventHandler(this.ProductionTechnology_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVtechnology)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVtechnology;
        private System.Windows.Forms.TextBox textBoxTechnologyName;
        private System.Windows.Forms.TextBox textBoxTimePermeter;
        private System.Windows.Forms.TextBox textBoxSpeedFactor;
        private System.Windows.Forms.Label lblTechnologyName;
        private System.Windows.Forms.Label lblTimePermeter;
        private System.Windows.Forms.Label lblSpeedFactor;
        private System.Windows.Forms.Button btnSave;
    }
}