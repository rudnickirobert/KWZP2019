namespace KWZP2019
{
    partial class Examination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examination));
            this.dgvExamination = new System.Windows.Forms.DataGridView();
            this.tbSearchEmployeeExamination = new System.Windows.Forms.TextBox();
            this.btnAddExamination = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbSearchEmployeeExaminationName = new System.Windows.Forms.TextBox();
            this.lblSearchEmployeeExaminationName = new System.Windows.Forms.Label();
            this.lblSearchEmployeeExamination = new System.Windows.Forms.Label();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamination)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExamination
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvExamination.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExamination.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExamination.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvExamination.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamination.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExamination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExamination.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExamination.EnableHeadersVisualStyles = false;
            this.dgvExamination.Location = new System.Drawing.Point(521, 173);
            this.dgvExamination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvExamination.Name = "dgvExamination";
            this.dgvExamination.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExamination.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExamination.RowTemplate.Height = 24;
            this.dgvExamination.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamination.Size = new System.Drawing.Size(509, 539);
            this.dgvExamination.TabIndex = 0;
            // 
            // tbSearchEmployeeExamination
            // 
            this.tbSearchEmployeeExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchEmployeeExamination.Location = new System.Drawing.Point(682, 75);
            this.tbSearchEmployeeExamination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchEmployeeExamination.Name = "tbSearchEmployeeExamination";
            this.tbSearchEmployeeExamination.Size = new System.Drawing.Size(206, 23);
            this.tbSearchEmployeeExamination.TabIndex = 1;
            this.tbSearchEmployeeExamination.TextChanged += new System.EventHandler(this.tbSearchEmployeeExamination_TextChanged);
            // 
            // btnAddExamination
            // 
            this.btnAddExamination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAddExamination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddExamination.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddExamination.FlatAppearance.BorderSize = 3;
            this.btnAddExamination.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddExamination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnAddExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAddExamination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddExamination.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExamination.Image")));
            this.btnAddExamination.Location = new System.Drawing.Point(83, 401);
            this.btnAddExamination.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddExamination.Name = "btnAddExamination";
            this.btnAddExamination.Size = new System.Drawing.Size(247, 154);
            this.btnAddExamination.TabIndex = 2;
            this.btnAddExamination.Text = "Dodaj badanie";
            this.btnAddExamination.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddExamination.UseVisualStyleBackColor = false;
            this.btnAddExamination.Click += new System.EventHandler(this.btnAddExamination_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(83, 571);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(247, 154);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbSearchEmployeeExaminationName
            // 
            this.tbSearchEmployeeExaminationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchEmployeeExaminationName.Location = new System.Drawing.Point(682, 121);
            this.tbSearchEmployeeExaminationName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearchEmployeeExaminationName.Name = "tbSearchEmployeeExaminationName";
            this.tbSearchEmployeeExaminationName.Size = new System.Drawing.Size(206, 23);
            this.tbSearchEmployeeExaminationName.TabIndex = 4;
            this.tbSearchEmployeeExaminationName.TextChanged += new System.EventHandler(this.tbSearchEmployeeExaminationName_TextChanged);
            // 
            // lblSearchEmployeeExaminationName
            // 
            this.lblSearchEmployeeExaminationName.AutoSize = true;
            this.lblSearchEmployeeExaminationName.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchEmployeeExaminationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchEmployeeExaminationName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchEmployeeExaminationName.Location = new System.Drawing.Point(518, 127);
            this.lblSearchEmployeeExaminationName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchEmployeeExaminationName.Name = "lblSearchEmployeeExaminationName";
            this.lblSearchEmployeeExaminationName.Size = new System.Drawing.Size(136, 17);
            this.lblSearchEmployeeExaminationName.TabIndex = 5;
            this.lblSearchEmployeeExaminationName.Text = "Wyszukaj po imieniu";
            // 
            // lblSearchEmployeeExamination
            // 
            this.lblSearchEmployeeExamination.AutoSize = true;
            this.lblSearchEmployeeExamination.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchEmployeeExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchEmployeeExamination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchEmployeeExamination.Location = new System.Drawing.Point(518, 81);
            this.lblSearchEmployeeExamination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchEmployeeExamination.Name = "lblSearchEmployeeExamination";
            this.lblSearchEmployeeExamination.Size = new System.Drawing.Size(149, 17);
            this.lblSearchEmployeeExamination.TabIndex = 6;
            this.lblSearchEmployeeExamination.Text = "Wyszukaj po nazwisku";
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
            this.btnReturnMain.Location = new System.Drawing.Point(83, 231);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(247, 154);
            this.btnReturnMain.TabIndex = 7;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
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
            this.btnReturn.Location = new System.Drawing.Point(83, 61);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(247, 154);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Image = global::KWZP2019.Properties.Resources.refreshp;
            this.btnRefresh.Location = new System.Drawing.Point(916, 61);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 104);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.lblSearchEmployeeExamination);
            this.Controls.Add(this.lblSearchEmployeeExaminationName);
            this.Controls.Add(this.tbSearchEmployeeExaminationName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddExamination);
            this.Controls.Add(this.tbSearchEmployeeExamination);
            this.Controls.Add(this.dgvExamination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Examination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Badania lekarskie";
            this.Load += new System.EventHandler(this.Examination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExamination;
        private System.Windows.Forms.TextBox tbSearchEmployeeExamination;
        private System.Windows.Forms.Button btnAddExamination;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbSearchEmployeeExaminationName;
        private System.Windows.Forms.Label lblSearchEmployeeExaminationName;
        private System.Windows.Forms.Label lblSearchEmployeeExamination;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
    }
}