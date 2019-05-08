namespace KWZP2019
{
    partial class AddTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTraining));
            this.dgvTrainings = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTrainingName = new System.Windows.Forms.Label();
            this.tbTrainingName = new System.Windows.Forms.TextBox();
            this.lblTrainingStartDate = new System.Windows.Forms.Label();
            this.dtpTrainingStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTrainingEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTrainingEndDate = new System.Windows.Forms.Label();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.tbTrainingPrice = new System.Windows.Forms.TextBox();
            this.lblTrainingPrice = new System.Windows.Forms.Label();
            this.tbSearchTraining = new System.Windows.Forms.TextBox();
            this.tbSearchTrainingName = new System.Windows.Forms.TextBox();
            this.lblSearchTrainingSurname = new System.Windows.Forms.Label();
            this.lblSearchTrainingName = new System.Windows.Forms.Label();
            this.pbAddTraining = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.cbEmployeeList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainings
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTrainings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrainings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dgvTrainings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrainings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTrainings.EnableHeadersVisualStyles = false;
            this.dgvTrainings.Location = new System.Drawing.Point(28, 121);
            this.dgvTrainings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTrainings.Name = "dgvTrainings";
            this.dgvTrainings.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(86)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTrainings.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTrainings.RowTemplate.Height = 24;
            this.dgvTrainings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainings.Size = new System.Drawing.Size(708, 458);
            this.dgvTrainings.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(1020, 624);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(329, 190);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(28, 607);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(707, 70);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTrainingName
            // 
            this.lblTrainingName.AutoSize = true;
            this.lblTrainingName.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrainingName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrainingName.Location = new System.Drawing.Point(864, 288);
            this.lblTrainingName.Name = "lblTrainingName";
            this.lblTrainingName.Size = new System.Drawing.Size(174, 25);
            this.lblTrainingName.TabIndex = 3;
            this.lblTrainingName.Text = "Nazwa szkolenia";
            // 
            // tbTrainingName
            // 
            this.tbTrainingName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbTrainingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTrainingName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTrainingName.Location = new System.Drawing.Point(1128, 294);
            this.tbTrainingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTrainingName.Name = "tbTrainingName";
            this.tbTrainingName.Size = new System.Drawing.Size(333, 26);
            this.tbTrainingName.TabIndex = 4;
            // 
            // lblTrainingStartDate
            // 
            this.lblTrainingStartDate.AutoSize = true;
            this.lblTrainingStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainingStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrainingStartDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrainingStartDate.Location = new System.Drawing.Point(864, 348);
            this.lblTrainingStartDate.Name = "lblTrainingStartDate";
            this.lblTrainingStartDate.Size = new System.Drawing.Size(198, 25);
            this.lblTrainingStartDate.TabIndex = 5;
            this.lblTrainingStartDate.Text = "Początek szkolenia";
            // 
            // dtpTrainingStartDate
            // 
            this.dtpTrainingStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpTrainingStartDate.Location = new System.Drawing.Point(1128, 354);
            this.dtpTrainingStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTrainingStartDate.Name = "dtpTrainingStartDate";
            this.dtpTrainingStartDate.Size = new System.Drawing.Size(333, 26);
            this.dtpTrainingStartDate.TabIndex = 6;
            // 
            // dtpTrainingEndDate
            // 
            this.dtpTrainingEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpTrainingEndDate.Location = new System.Drawing.Point(1128, 412);
            this.dtpTrainingEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTrainingEndDate.Name = "dtpTrainingEndDate";
            this.dtpTrainingEndDate.Size = new System.Drawing.Size(333, 26);
            this.dtpTrainingEndDate.TabIndex = 7;
            // 
            // lblTrainingEndDate
            // 
            this.lblTrainingEndDate.AutoSize = true;
            this.lblTrainingEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainingEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrainingEndDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrainingEndDate.Location = new System.Drawing.Point(864, 410);
            this.lblTrainingEndDate.Name = "lblTrainingEndDate";
            this.lblTrainingEndDate.Size = new System.Drawing.Size(176, 25);
            this.lblTrainingEndDate.TabIndex = 8;
            this.lblTrainingEndDate.Text = "Koniec szkolenia";
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.AutoSize = true;
            this.lblEmployeeLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmployeeLastName.Location = new System.Drawing.Point(864, 485);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(111, 25);
            this.lblEmployeeLastName.TabIndex = 12;
            this.lblEmployeeLastName.Text = "Pracownik";
            // 
            // tbTrainingPrice
            // 
            this.tbTrainingPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbTrainingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbTrainingPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTrainingPrice.Location = new System.Drawing.Point(1128, 553);
            this.tbTrainingPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTrainingPrice.Name = "tbTrainingPrice";
            this.tbTrainingPrice.Size = new System.Drawing.Size(333, 26);
            this.tbTrainingPrice.TabIndex = 14;
            // 
            // lblTrainingPrice
            // 
            this.lblTrainingPrice.AutoSize = true;
            this.lblTrainingPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrainingPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrainingPrice.Location = new System.Drawing.Point(864, 554);
            this.lblTrainingPrice.Name = "lblTrainingPrice";
            this.lblTrainingPrice.Size = new System.Drawing.Size(67, 25);
            this.lblTrainingPrice.TabIndex = 15;
            this.lblTrainingPrice.Text = "Koszt";
            // 
            // tbSearchTraining
            // 
            this.tbSearchTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbSearchTraining.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchTraining.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSearchTraining.Location = new System.Drawing.Point(208, 33);
            this.tbSearchTraining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchTraining.Name = "tbSearchTraining";
            this.tbSearchTraining.Size = new System.Drawing.Size(307, 26);
            this.tbSearchTraining.TabIndex = 16;
            this.tbSearchTraining.TextChanged += new System.EventHandler(this.tbSearchTraining_TextChanged);
            // 
            // tbSearchTrainingName
            // 
            this.tbSearchTrainingName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.tbSearchTrainingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbSearchTrainingName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbSearchTrainingName.Location = new System.Drawing.Point(208, 73);
            this.tbSearchTrainingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearchTrainingName.Name = "tbSearchTrainingName";
            this.tbSearchTrainingName.Size = new System.Drawing.Size(307, 26);
            this.tbSearchTrainingName.TabIndex = 17;
            this.tbSearchTrainingName.TextChanged += new System.EventHandler(this.tbSearchTrainingName_TextChanged);
            // 
            // lblSearchTrainingSurname
            // 
            this.lblSearchTrainingSurname.AutoSize = true;
            this.lblSearchTrainingSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchTrainingSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchTrainingSurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchTrainingSurname.Location = new System.Drawing.Point(24, 39);
            this.lblSearchTrainingSurname.Name = "lblSearchTrainingSurname";
            this.lblSearchTrainingSurname.Size = new System.Drawing.Size(178, 20);
            this.lblSearchTrainingSurname.TabIndex = 18;
            this.lblSearchTrainingSurname.Text = "Wyszukaj po nazwisko";
            // 
            // lblSearchTrainingName
            // 
            this.lblSearchTrainingName.AutoSize = true;
            this.lblSearchTrainingName.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchTrainingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchTrainingName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchTrainingName.Location = new System.Drawing.Point(24, 79);
            this.lblSearchTrainingName.Name = "lblSearchTrainingName";
            this.lblSearchTrainingName.Size = new System.Drawing.Size(162, 20);
            this.lblSearchTrainingName.TabIndex = 19;
            this.lblSearchTrainingName.Text = "Wyszukaj po imieniu";
            // 
            // pbAddTraining
            // 
            this.pbAddTraining.BackColor = System.Drawing.Color.Transparent;
            this.pbAddTraining.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAddTraining.BackgroundImage")));
            this.pbAddTraining.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddTraining.Location = new System.Drawing.Point(763, 15);
            this.pbAddTraining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAddTraining.Name = "pbAddTraining";
            this.pbAddTraining.Size = new System.Drawing.Size(775, 881);
            this.pbAddTraining.TabIndex = 20;
            this.pbAddTraining.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Location = new System.Drawing.Point(992, 166);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(291, 36);
            this.lblFormTitle.TabIndex = 21;
            this.lblFormTitle.Text = "Wprowadź szkolenie";
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
            this.btnReturn.Location = new System.Drawing.Point(28, 709);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(341, 187);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.btnReturnMain.Location = new System.Drawing.Point(405, 706);
            this.btnReturnMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(329, 190);
            this.btnReturnMain.TabIndex = 25;
            this.btnReturnMain.Text = "Menu główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // cbEmployeeList
            // 
            this.cbEmployeeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.cbEmployeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbEmployeeList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbEmployeeList.FormattingEnabled = true;
            this.cbEmployeeList.Location = new System.Drawing.Point(1128, 480);
            this.cbEmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmployeeList.Name = "cbEmployeeList";
            this.cbEmployeeList.Size = new System.Drawing.Size(333, 30);
            this.cbEmployeeList.TabIndex = 37;
            // 
            // AddTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1579, 922);
            this.Controls.Add(this.cbEmployeeList);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblSearchTrainingName);
            this.Controls.Add(this.lblSearchTrainingSurname);
            this.Controls.Add(this.tbSearchTrainingName);
            this.Controls.Add(this.tbSearchTraining);
            this.Controls.Add(this.lblTrainingPrice);
            this.Controls.Add(this.tbTrainingPrice);
            this.Controls.Add(this.lblEmployeeLastName);
            this.Controls.Add(this.lblTrainingEndDate);
            this.Controls.Add(this.dtpTrainingEndDate);
            this.Controls.Add(this.dtpTrainingStartDate);
            this.Controls.Add(this.lblTrainingStartDate);
            this.Controls.Add(this.tbTrainingName);
            this.Controls.Add(this.lblTrainingName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTrainings);
            this.Controls.Add(this.pbAddTraining);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szkolenia";
            this.Load += new System.EventHandler(this.AddTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrainings;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTrainingName;
        private System.Windows.Forms.TextBox tbTrainingName;
        private System.Windows.Forms.Label lblTrainingStartDate;
        private System.Windows.Forms.DateTimePicker dtpTrainingStartDate;
        private System.Windows.Forms.DateTimePicker dtpTrainingEndDate;
        private System.Windows.Forms.Label lblTrainingEndDate;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.TextBox tbTrainingPrice;
        private System.Windows.Forms.Label lblTrainingPrice;
        private System.Windows.Forms.TextBox tbSearchTraining;
        private System.Windows.Forms.TextBox tbSearchTrainingName;
        private System.Windows.Forms.Label lblSearchTrainingSurname;
        private System.Windows.Forms.Label lblSearchTrainingName;
        private System.Windows.Forms.PictureBox pbAddTraining;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.ComboBox cbEmployeeList;
    }
}