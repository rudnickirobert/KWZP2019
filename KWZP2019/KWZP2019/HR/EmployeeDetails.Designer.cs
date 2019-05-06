namespace KWZP2019
{
    partial class EmployeeDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetails));
            this.dgvEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.btnEducation = new System.Windows.Forms.Button();
            this.btnTrainings = new System.Windows.Forms.Button();
            this.tbSearchEmployeeDetails = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeDetails
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvEmployeeDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmployeeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployeeDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvEmployeeDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetails.EnableHeadersVisualStyles = false;
            this.dgvEmployeeDetails.Location = new System.Drawing.Point(277, 154);
            this.dgvEmployeeDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmployeeDetails.Name = "dgvEmployeeDetails";
            this.dgvEmployeeDetails.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmployeeDetails.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEmployeeDetails.RowTemplate.Height = 24;
            this.dgvEmployeeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeDetails.Size = new System.Drawing.Size(896, 430);
            this.dgvEmployeeDetails.TabIndex = 0;
            // 
            // btnEducation
            // 
            this.btnEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnEducation.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEducation.FlatAppearance.BorderSize = 3;
            this.btnEducation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnEducation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnEducation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEducation.Image = ((System.Drawing.Image)(resources.GetObject("btnEducation.Image")));
            this.btnEducation.Location = new System.Drawing.Point(11, 426);
            this.btnEducation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEducation.Name = "btnEducation";
            this.btnEducation.Size = new System.Drawing.Size(247, 154);
            this.btnEducation.TabIndex = 4;
            this.btnEducation.Text = "Wykształcenie";
            this.btnEducation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEducation.UseVisualStyleBackColor = false;
            // 
            // btnTrainings
            // 
            this.btnTrainings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnTrainings.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnTrainings.FlatAppearance.BorderSize = 3;
            this.btnTrainings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTrainings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnTrainings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTrainings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrainings.Image = ((System.Drawing.Image)(resources.GetObject("btnTrainings.Image")));
            this.btnTrainings.Location = new System.Drawing.Point(12, 584);
            this.btnTrainings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrainings.Name = "btnTrainings";
            this.btnTrainings.Size = new System.Drawing.Size(247, 154);
            this.btnTrainings.TabIndex = 5;
            this.btnTrainings.Text = "Szkolenia";
            this.btnTrainings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrainings.UseVisualStyleBackColor = false;
            // 
            // tbSearchEmployeeDetails
            // 
            this.tbSearchEmployeeDetails.Location = new System.Drawing.Point(277, 110);
            this.tbSearchEmployeeDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchEmployeeDetails.Name = "tbSearchEmployeeDetails";
            this.tbSearchEmployeeDetails.Size = new System.Drawing.Size(489, 20);
            this.tbSearchEmployeeDetails.TabIndex = 6;
            this.tbSearchEmployeeDetails.Text = "Wyszukaj po nazwisku";
            this.tbSearchEmployeeDetails.TextChanged += new System.EventHandler(this.tbSearchEmployeeDetails_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(12, 61);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(247, 154);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.Location = new System.Drawing.Point(12, 221);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(247, 154);
            this.btnReturnMain.TabIndex = 8;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbSearchEmployeeDetails);
            this.Controls.Add(this.btnTrainings);
            this.Controls.Add(this.btnEducation);
            this.Controls.Add(this.dgvEmployeeDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeDetails;
        private System.Windows.Forms.Button btnEducation;
        private System.Windows.Forms.Button btnTrainings;
        private System.Windows.Forms.TextBox tbSearchEmployeeDetails;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
    }
}