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
            this.textBoxTimePerMeter = new System.Windows.Forms.TextBox();
            this.textBoxSpeedFactor = new System.Windows.Forms.TextBox();
            this.lblTechnologyName = new System.Windows.Forms.Label();
            this.lblTimePerMeter = new System.Windows.Forms.Label();
            this.lblSpeedFactor = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblSpeedFactorFrom = new System.Windows.Forms.Label();
            this.lblTimePerMeterFrom = new System.Windows.Forms.Label();
            this.lblTechnologyNameFrom = new System.Windows.Forms.Label();
            this.textBoxSpeedFactorTo = new System.Windows.Forms.TextBox();
            this.textBoxTimePerMeterTo = new System.Windows.Forms.TextBox();
            this.textBoxTechnologyNameTo = new System.Windows.Forms.TextBox();
            this.lblSelectedTechnology = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVtechnology)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVtechnology
            // 
            this.dataGVtechnology.AllowUserToAddRows = false;
            this.dataGVtechnology.AllowUserToDeleteRows = false;
            this.dataGVtechnology.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGVtechnology.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVtechnology.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVtechnology.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGVtechnology.Location = new System.Drawing.Point(12, 12);
            this.dataGVtechnology.Name = "dataGVtechnology";
            this.dataGVtechnology.Size = new System.Drawing.Size(655, 363);
            this.dataGVtechnology.TabIndex = 0;
            this.dataGVtechnology.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGVtechnology_RowHeaderMouseDoubleClick);
            // 
            // textBoxTechnologyName
            // 
            this.textBoxTechnologyName.Location = new System.Drawing.Point(842, 110);
            this.textBoxTechnologyName.Name = "textBoxTechnologyName";
            this.textBoxTechnologyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTechnologyName.TabIndex = 1;
            // 
            // textBoxTimePerMeter
            // 
            this.textBoxTimePerMeter.Location = new System.Drawing.Point(842, 160);
            this.textBoxTimePerMeter.Name = "textBoxTimePerMeter";
            this.textBoxTimePerMeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimePerMeter.TabIndex = 1;
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
            // lblTimePerMeter
            // 
            this.lblTimePerMeter.AutoSize = true;
            this.lblTimePerMeter.Location = new System.Drawing.Point(735, 167);
            this.lblTimePerMeter.Name = "lblTimePerMeter";
            this.lblTimePerMeter.Size = new System.Drawing.Size(101, 13);
            this.lblTimePerMeter.TabIndex = 2;
            this.lblTimePerMeter.Text = "Prędkość produkcji ";
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
            this.btnSave.Location = new System.Drawing.Point(767, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(738, 623);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "POWRÓT";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(127, 623);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edycja";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblSpeedFactorFrom
            // 
            this.lblSpeedFactorFrom.AutoSize = true;
            this.lblSpeedFactorFrom.Location = new System.Drawing.Point(44, 520);
            this.lblSpeedFactorFrom.Name = "lblSpeedFactorFrom";
            this.lblSpeedFactorFrom.Size = new System.Drawing.Size(124, 13);
            this.lblSpeedFactorFrom.TabIndex = 10;
            this.lblSpeedFactorFrom.Text = "Współczynnik prędkości";
            this.lblSpeedFactorFrom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTimePerMeterFrom
            // 
            this.lblTimePerMeterFrom.AutoSize = true;
            this.lblTimePerMeterFrom.Location = new System.Drawing.Point(44, 469);
            this.lblTimePerMeterFrom.Name = "lblTimePerMeterFrom";
            this.lblTimePerMeterFrom.Size = new System.Drawing.Size(101, 13);
            this.lblTimePerMeterFrom.TabIndex = 11;
            this.lblTimePerMeterFrom.Text = "Prędkość produkcji ";
            this.lblTimePerMeterFrom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTechnologyNameFrom
            // 
            this.lblTechnologyNameFrom.AutoSize = true;
            this.lblTechnologyNameFrom.Location = new System.Drawing.Point(44, 411);
            this.lblTechnologyNameFrom.Name = "lblTechnologyNameFrom";
            this.lblTechnologyNameFrom.Size = new System.Drawing.Size(92, 13);
            this.lblTechnologyNameFrom.TabIndex = 12;
            this.lblTechnologyNameFrom.Text = "Nazwa technologi";
            this.lblTechnologyNameFrom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSpeedFactorTo
            // 
            this.textBoxSpeedFactorTo.Location = new System.Drawing.Point(181, 513);
            this.textBoxSpeedFactorTo.Name = "textBoxSpeedFactorTo";
            this.textBoxSpeedFactorTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeedFactorTo.TabIndex = 7;
            // 
            // textBoxTimePerMeterTo
            // 
            this.textBoxTimePerMeterTo.Location = new System.Drawing.Point(181, 462);
            this.textBoxTimePerMeterTo.Name = "textBoxTimePerMeterTo";
            this.textBoxTimePerMeterTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimePerMeterTo.TabIndex = 8;
            // 
            // textBoxTechnologyNameTo
            // 
            this.textBoxTechnologyNameTo.Location = new System.Drawing.Point(181, 411);
            this.textBoxTechnologyNameTo.Name = "textBoxTechnologyNameTo";
            this.textBoxTechnologyNameTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTechnologyNameTo.TabIndex = 9;
            // 
            // lblSelectedTechnology
            // 
            this.lblSelectedTechnology.AutoSize = true;
            this.lblSelectedTechnology.Location = new System.Drawing.Point(44, 378);
            this.lblSelectedTechnology.Name = "lblSelectedTechnology";
            this.lblSelectedTechnology.Size = new System.Drawing.Size(111, 13);
            this.lblSelectedTechnology.TabIndex = 13;
            this.lblSelectedTechnology.Text = "Wybrana technologia ";
            this.lblSelectedTechnology.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(306, 623);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ProductionTechnology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSelectedTechnology);
            this.Controls.Add(this.lblSpeedFactorFrom);
            this.Controls.Add(this.lblTimePerMeterFrom);
            this.Controls.Add(this.lblTechnologyNameFrom);
            this.Controls.Add(this.textBoxSpeedFactorTo);
            this.Controls.Add(this.textBoxTimePerMeterTo);
            this.Controls.Add(this.textBoxTechnologyNameTo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSpeedFactor);
            this.Controls.Add(this.lblTimePerMeter);
            this.Controls.Add(this.lblTechnologyName);
            this.Controls.Add(this.textBoxSpeedFactor);
            this.Controls.Add(this.textBoxTimePerMeter);
            this.Controls.Add(this.textBoxTechnologyName);
            this.Controls.Add(this.dataGVtechnology);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.TextBox textBoxTimePerMeter;
        private System.Windows.Forms.TextBox textBoxSpeedFactor;
        private System.Windows.Forms.Label lblTechnologyName;
        private System.Windows.Forms.Label lblTimePerMeter;
        private System.Windows.Forms.Label lblSpeedFactor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblSpeedFactorFrom;
        private System.Windows.Forms.Label lblTimePerMeterFrom;
        private System.Windows.Forms.Label lblTechnologyNameFrom;
        private System.Windows.Forms.TextBox textBoxSpeedFactorTo;
        private System.Windows.Forms.TextBox textBoxTimePerMeterTo;
        private System.Windows.Forms.TextBox textBoxTechnologyNameTo;
        private System.Windows.Forms.Label lblSelectedTechnology;
        private System.Windows.Forms.Button btnDelete;
    }
}