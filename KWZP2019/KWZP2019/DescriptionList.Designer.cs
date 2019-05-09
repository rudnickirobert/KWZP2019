namespace KWZP2019
{
    partial class DescriptionList
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
            this.dgvDescription = new System.Windows.Forms.DataGridView();
            this.IdMaintDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionShort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionLong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtShortDescription = new System.Windows.Forms.TextBox();
            this.txtLongDescription = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDescription
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMaintDesc,
            this.DescriptionShort,
            this.DescriptionLong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDescription.EnableHeadersVisualStyles = false;
            this.dgvDescription.Location = new System.Drawing.Point(35, 29);
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
            this.dgvDescription.Size = new System.Drawing.Size(363, 221);
            this.dgvDescription.TabIndex = 0;
            this.dgvDescription.DoubleClick += new System.EventHandler(this.dgvDescription_DoubleClick);
            // 
            // IdMaintDesc
            // 
            this.IdMaintDesc.DataPropertyName = "IdMaintDesc";
            this.IdMaintDesc.HeaderText = "IdMaintDesc";
            this.IdMaintDesc.Name = "IdMaintDesc";
            this.IdMaintDesc.ReadOnly = true;
            this.IdMaintDesc.Visible = false;
            // 
            // DescriptionShort
            // 
            this.DescriptionShort.DataPropertyName = "DescriptionShort";
            this.DescriptionShort.HeaderText = "Krótki opis";
            this.DescriptionShort.Name = "DescriptionShort";
            this.DescriptionShort.ReadOnly = true;
            this.DescriptionShort.Width = 120;
            // 
            // DescriptionLong
            // 
            this.DescriptionLong.DataPropertyName = "DescriptionLong";
            this.DescriptionLong.HeaderText = "Opis";
            this.DescriptionLong.Name = "DescriptionLong";
            this.DescriptionLong.ReadOnly = true;
            this.DescriptionLong.Width = 200;
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(419, 29);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(203, 20);
            this.txtShortDescription.TabIndex = 1;
            // 
            // txtLongDescription
            // 
            this.txtLongDescription.Location = new System.Drawing.Point(419, 55);
            this.txtLongDescription.Multiline = true;
            this.txtLongDescription.Name = "txtLongDescription";
            this.txtLongDescription.Size = new System.Drawing.Size(203, 195);
            this.txtLongDescription.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::KWZP2019.Properties.Resources.usun;
            this.btnDelete.Location = new System.Drawing.Point(338, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 110);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::KWZP2019.Properties.Resources.icons8_import_40;
            this.btnSave.Location = new System.Drawing.Point(185, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 110);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Zapisz";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.AutoSize = true;
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImage = global::KWZP2019.Properties.Resources.icons8_return_40;
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReturnMain.Location = new System.Drawing.Point(492, 285);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(130, 110);
            this.btnReturnMain.TabIndex = 38;
            this.btnReturnMain.Text = "Powrót ";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // DescriptionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 423);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLongDescription);
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.dgvDescription);
            this.Name = "DescriptionList";
            this.Text = "DescriptionList";
            this.Load += new System.EventHandler(this.DescriptionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDescription;
        private System.Windows.Forms.TextBox txtShortDescription;
        private System.Windows.Forms.TextBox txtLongDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaintDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionShort;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionLong;
    }
}