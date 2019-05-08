namespace KWZP2019
{
    partial class EducationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationForm));
            this.dgvEducation = new System.Windows.Forms.DataGridView();
            this.cbEducationLevel = new System.Windows.Forms.ComboBox();
            this.dtpGraduationDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEducationLevel = new System.Windows.Forms.Label();
            this.lblGraduationDate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbEducationSearch = new System.Windows.Forms.TextBox();
            this.pbEducationForm = new System.Windows.Forms.PictureBox();
            this.cbEmployeeList = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblEducationSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEducationForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEducation
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvEducation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEducation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEducation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvEducation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEducation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEducation.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEducation.EnableHeadersVisualStyles = false;
            this.dgvEducation.Location = new System.Drawing.Point(11, 75);
            this.dgvEducation.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEducation.Name = "dgvEducation";
            this.dgvEducation.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEducation.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEducation.RowTemplate.Height = 24;
            this.dgvEducation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEducation.Size = new System.Drawing.Size(540, 417);
            this.dgvEducation.TabIndex = 0;
            // 
            // cbEducationLevel
            // 
            this.cbEducationLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbEducationLevel.FormattingEnabled = true;
            this.cbEducationLevel.Location = new System.Drawing.Point(848, 253);
            this.cbEducationLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cbEducationLevel.Name = "cbEducationLevel";
            this.cbEducationLevel.Size = new System.Drawing.Size(250, 24);
            this.cbEducationLevel.TabIndex = 4;
            // 
            // dtpGraduationDate
            // 
            this.dtpGraduationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpGraduationDate.Location = new System.Drawing.Point(848, 292);
            this.dtpGraduationDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGraduationDate.Name = "dtpGraduationDate";
            this.dtpGraduationDate.Size = new System.Drawing.Size(250, 23);
            this.dtpGraduationDate.TabIndex = 8;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmployeeName.Location = new System.Drawing.Point(632, 218);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(90, 20);
            this.lblEmployeeName.TabIndex = 9;
            this.lblEmployeeName.Text = "Pracownik";
            // 
            // lblEducationLevel
            // 
            this.lblEducationLevel.AutoSize = true;
            this.lblEducationLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblEducationLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEducationLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEducationLevel.Location = new System.Drawing.Point(632, 257);
            this.lblEducationLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEducationLevel.Name = "lblEducationLevel";
            this.lblEducationLevel.Size = new System.Drawing.Size(187, 20);
            this.lblEducationLevel.TabIndex = 11;
            this.lblEducationLevel.Text = "Stopień wykształcenia";
            // 
            // lblGraduationDate
            // 
            this.lblGraduationDate.AutoSize = true;
            this.lblGraduationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblGraduationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGraduationDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGraduationDate.Location = new System.Drawing.Point(632, 295);
            this.lblGraduationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGraduationDate.Name = "lblGraduationDate";
            this.lblGraduationDate.Size = new System.Drawing.Size(210, 20);
            this.lblGraduationDate.TabIndex = 12;
            this.lblGraduationDate.Text = "Data ukończenia studiów";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(11, 509);
            this.btnClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(247, 57);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(771, 359);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(246, 154);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(295, 509);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(247, 57);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbEducationSearch
            // 
            this.tbEducationSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbEducationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbEducationSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbEducationSearch.Location = new System.Drawing.Point(177, 35);
            this.tbEducationSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbEducationSearch.Name = "tbEducationSearch";
            this.tbEducationSearch.Size = new System.Drawing.Size(365, 23);
            this.tbEducationSearch.TabIndex = 16;
            this.tbEducationSearch.TextChanged += new System.EventHandler(this.tbEducationSearch_TextChanged);
            // 
            // pbEducationForm
            // 
            this.pbEducationForm.BackColor = System.Drawing.Color.Transparent;
            this.pbEducationForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEducationForm.BackgroundImage")));
            this.pbEducationForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEducationForm.Location = new System.Drawing.Point(572, 12);
            this.pbEducationForm.Name = "pbEducationForm";
            this.pbEducationForm.Size = new System.Drawing.Size(587, 570);
            this.pbEducationForm.TabIndex = 17;
            this.pbEducationForm.TabStop = false;
            // 
            // cbEmployeeList
            // 
            this.cbEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cbEmployeeList.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbEmployeeList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbEmployeeList.FormattingEnabled = true;
            this.cbEmployeeList.Location = new System.Drawing.Point(771, 212);
            this.cbEmployeeList.Margin = new System.Windows.Forms.Padding(2);
            this.cbEmployeeList.Name = "cbEmployeeList";
            this.cbEmployeeList.Size = new System.Drawing.Size(327, 26);
            this.cbEmployeeList.TabIndex = 37;
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
            this.btnReturn.Location = new System.Drawing.Point(295, 585);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(247, 154);
            this.btnReturn.TabIndex = 38;
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
            this.btnReturnMain.Location = new System.Drawing.Point(12, 585);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(247, 154);
            this.btnReturnMain.TabIndex = 39;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Location = new System.Drawing.Point(709, 109);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(318, 29);
            this.lblFormTitle.TabIndex = 40;
            this.lblFormTitle.Text = "Dodaj stopień wykształcenia";
            // 
            // lblEducationSearch
            // 
            this.lblEducationSearch.AutoSize = true;
            this.lblEducationSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblEducationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEducationSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEducationSearch.Location = new System.Drawing.Point(12, 41);
            this.lblEducationSearch.Name = "lblEducationSearch";
            this.lblEducationSearch.Size = new System.Drawing.Size(149, 17);
            this.lblEducationSearch.TabIndex = 41;
            this.lblEducationSearch.Text = "Wyszukaj po nazwisku";
            // 
            // EducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.lblEducationSearch);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.cbEmployeeList);
            this.Controls.Add(this.tbEducationSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblGraduationDate);
            this.Controls.Add(this.lblEducationLevel);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.dtpGraduationDate);
            this.Controls.Add(this.cbEducationLevel);
            this.Controls.Add(this.dgvEducation);
            this.Controls.Add(this.pbEducationForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EducationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wykształcenie";
            this.Load += new System.EventHandler(this.EducationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEducationForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEducation;
        private System.Windows.Forms.ComboBox cbEducationLevel;
        private System.Windows.Forms.DateTimePicker dtpGraduationDate;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEducationLevel;
        private System.Windows.Forms.Label lblGraduationDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbEducationSearch;
        private System.Windows.Forms.PictureBox pbEducationForm;
        private System.Windows.Forms.ComboBox cbEmployeeList;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblEducationSearch;
    }
}