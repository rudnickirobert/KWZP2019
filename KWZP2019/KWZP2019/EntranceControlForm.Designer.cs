namespace KWZP2019
{
    partial class EntranceControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceControlForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblThickness = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblMass = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtboxThickness = new System.Windows.Forms.TextBox();
            this.txtboxWidth = new System.Windows.Forms.TextBox();
            this.txtboxMass = new System.Windows.Forms.TextBox();
            this.txtboxComment = new System.Windows.Forms.TextBox();
            this.checkBoxComposition = new System.Windows.Forms.CheckBox();
            this.lblParameterCheck = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.textBoxEmployeePESEL = new System.Windows.Forms.TextBox();
            this.lblEmployeePESEL = new System.Windows.Forms.Label();
            this.lblEmployeeFullName = new System.Windows.Forms.Label();
            this.lblDelayTime = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtBoxColor = new System.Windows.Forms.TextBox();
            this.datePickerSelectedControlsDate = new System.Windows.Forms.DateTimePicker();
            this.lblIdSfOrder = new System.Windows.Forms.Label();
            this.lblIdSf = new System.Windows.Forms.Label();
            this.picBoxColorStatus = new System.Windows.Forms.PictureBox();
            this.picBoxMassStatus = new System.Windows.Forms.PictureBox();
            this.picBoxWidhtStatus = new System.Windows.Forms.PictureBox();
            this.picBoxThicknessStatus = new System.Windows.Forms.PictureBox();
            this.lblControlNotExist = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.picBoxQuantityStatus = new System.Windows.Forms.PictureBox();
            this.picBoxControlStatus = new System.Windows.Forms.PictureBox();
            this.btnApproval = new System.Windows.Forms.Button();
            this.dataGridViewEntranceControl = new System.Windows.Forms.DataGridView();
            this.lblSelectedControl = new System.Windows.Forms.Label();
            this.lblOrderIdShow = new System.Windows.Forms.Label();
            this.lblSfIdShow = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowFromDay = new System.Windows.Forms.Button();
            this.btnShowFromMonth = new System.Windows.Forms.Button();
            this.btnShowFromYear = new System.Windows.Forms.Button();
            this.btnShowFromToday = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColorStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMassStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWidhtStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThicknessStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuantityStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxControlStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntranceControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturnMain.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMain.FlatAppearance.BorderSize = 3;
            this.btnReturnMain.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturnMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnMain.Image")));
            this.btnReturnMain.Location = new System.Drawing.Point(12, 12);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(180, 100);
            this.btnReturnMain.TabIndex = 0;
            this.btnReturnMain.Text = "Menu Główne";
            this.btnReturnMain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.BtnReturnMain_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.Location = new System.Drawing.Point(198, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(180, 100);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Location = new System.Drawing.Point(670, 32);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(486, 56);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Wprowadź dane kontroli";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThickness
            // 
            this.lblThickness.BackColor = System.Drawing.Color.Transparent;
            this.lblThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblThickness.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblThickness.Location = new System.Drawing.Point(891, 107);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(91, 26);
            this.lblThickness.TabIndex = 4;
            this.lblThickness.Text = "Grubość";
            this.lblThickness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.Color.Transparent;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWidth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWidth.Location = new System.Drawing.Point(879, 151);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(104, 26);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Szerokość";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMass
            // 
            this.lblMass.BackColor = System.Drawing.Color.Transparent;
            this.lblMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMass.Location = new System.Drawing.Point(920, 192);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(61, 26);
            this.lblMass.TabIndex = 6;
            this.lblMass.Text = "Masa";
            this.lblMass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblComment
            // 
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblComment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComment.Location = new System.Drawing.Point(832, 341);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(114, 26);
            this.lblComment.TabIndex = 9;
            this.lblComment.Text = "Komentarz";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxThickness
            // 
            this.txtboxThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxThickness.Location = new System.Drawing.Point(986, 107);
            this.txtboxThickness.Margin = new System.Windows.Forms.Padding(0);
            this.txtboxThickness.Name = "txtboxThickness";
            this.txtboxThickness.Size = new System.Drawing.Size(140, 26);
            this.txtboxThickness.TabIndex = 22;
            this.txtboxThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxThickness.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtboxWidth
            // 
            this.txtboxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxWidth.Location = new System.Drawing.Point(986, 150);
            this.txtboxWidth.Name = "txtboxWidth";
            this.txtboxWidth.Size = new System.Drawing.Size(140, 26);
            this.txtboxWidth.TabIndex = 23;
            this.txtboxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxWidth.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtboxMass
            // 
            this.txtboxMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxMass.Location = new System.Drawing.Point(986, 192);
            this.txtboxMass.Name = "txtboxMass";
            this.txtboxMass.Size = new System.Drawing.Size(140, 26);
            this.txtboxMass.TabIndex = 24;
            this.txtboxMass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtboxMass.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtboxComment
            // 
            this.txtboxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtboxComment.Location = new System.Drawing.Point(812, 375);
            this.txtboxComment.Multiline = true;
            this.txtboxComment.Name = "txtboxComment";
            this.txtboxComment.Size = new System.Drawing.Size(357, 137);
            this.txtboxComment.TabIndex = 25;
            // 
            // checkBoxComposition
            // 
            this.checkBoxComposition.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxComposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxComposition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxComposition.Location = new System.Drawing.Point(997, 320);
            this.checkBoxComposition.Name = "checkBoxComposition";
            this.checkBoxComposition.Size = new System.Drawing.Size(170, 46);
            this.checkBoxComposition.TabIndex = 26;
            this.checkBoxComposition.Text = "Zgodność skład chemicznego";
            this.checkBoxComposition.UseVisualStyleBackColor = false;
            // 
            // lblParameterCheck
            // 
            this.lblParameterCheck.BackColor = System.Drawing.Color.Transparent;
            this.lblParameterCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParameterCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblParameterCheck.Location = new System.Drawing.Point(1008, 563);
            this.lblParameterCheck.Name = "lblParameterCheck";
            this.lblParameterCheck.Size = new System.Drawing.Size(159, 26);
            this.lblParameterCheck.TabIndex = 28;
            this.lblParameterCheck.Text = "StatusKontroli";
            this.lblParameterCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCheck.FlatAppearance.BorderSize = 3;
            this.btnCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.Location = new System.Drawing.Point(826, 586);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(170, 80);
            this.btnCheck.TabIndex = 29;
            this.btnCheck.Text = "Sprawdź";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDone.FlatAppearance.BorderSize = 3;
            this.btnDone.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDone.Image = ((System.Drawing.Image)(resources.GetObject("btnDone.Image")));
            this.btnDone.Location = new System.Drawing.Point(826, 671);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(170, 80);
            this.btnDone.TabIndex = 30;
            this.btnDone.Text = "Zatwierdź";
            this.btnDone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // textBoxEmployeePESEL
            // 
            this.textBoxEmployeePESEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEmployeePESEL.Location = new System.Drawing.Point(718, 186);
            this.textBoxEmployeePESEL.Name = "textBoxEmployeePESEL";
            this.textBoxEmployeePESEL.Size = new System.Drawing.Size(146, 26);
            this.textBoxEmployeePESEL.TabIndex = 31;
            this.textBoxEmployeePESEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmployeePESEL.TextChanged += new System.EventHandler(this.TextBoxEmployeePESEL_TextChanged);
            // 
            // lblEmployeePESEL
            // 
            this.lblEmployeePESEL.AutoSize = true;
            this.lblEmployeePESEL.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeePESEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmployeePESEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeePESEL.ForeColor = System.Drawing.Color.White;
            this.lblEmployeePESEL.Location = new System.Drawing.Point(644, 189);
            this.lblEmployeePESEL.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmployeePESEL.Name = "lblEmployeePESEL";
            this.lblEmployeePESEL.Size = new System.Drawing.Size(71, 20);
            this.lblEmployeePESEL.TabIndex = 32;
            this.lblEmployeePESEL.Text = "PESEL:";
            // 
            // lblEmployeeFullName
            // 
            this.lblEmployeeFullName.AutoSize = true;
            this.lblEmployeeFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeFullName.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeFullName.Location = new System.Drawing.Point(660, 212);
            this.lblEmployeeFullName.Name = "lblEmployeeFullName";
            this.lblEmployeeFullName.Size = new System.Drawing.Size(13, 20);
            this.lblEmployeeFullName.TabIndex = 33;
            this.lblEmployeeFullName.Text = " ";
            this.lblEmployeeFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDelayTime
            // 
            this.lblDelayTime.AutoSize = true;
            this.lblDelayTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDelayTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDelayTime.ForeColor = System.Drawing.Color.White;
            this.lblDelayTime.Location = new System.Drawing.Point(447, 250);
            this.lblDelayTime.Name = "lblDelayTime";
            this.lblDelayTime.Size = new System.Drawing.Size(13, 20);
            this.lblDelayTime.TabIndex = 33;
            this.lblDelayTime.Text = " ";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblColor.Location = new System.Drawing.Point(923, 235);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(58, 26);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Kolor";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxColor
            // 
            this.txtBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxColor.Location = new System.Drawing.Point(986, 235);
            this.txtBoxColor.Name = "txtBoxColor";
            this.txtBoxColor.Size = new System.Drawing.Size(140, 26);
            this.txtBoxColor.TabIndex = 24;
            this.txtBoxColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxColor.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // datePickerSelectedControlsDate
            // 
            this.datePickerSelectedControlsDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerSelectedControlsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datePickerSelectedControlsDate.Location = new System.Drawing.Point(100, 245);
            this.datePickerSelectedControlsDate.Margin = new System.Windows.Forms.Padding(0);
            this.datePickerSelectedControlsDate.Name = "datePickerSelectedControlsDate";
            this.datePickerSelectedControlsDate.Size = new System.Drawing.Size(340, 29);
            this.datePickerSelectedControlsDate.TabIndex = 35;
            this.datePickerSelectedControlsDate.Value = new System.DateTime(2019, 4, 24, 21, 29, 8, 0);
            // 
            // lblIdSfOrder
            // 
            this.lblIdSfOrder.AutoSize = true;
            this.lblIdSfOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblIdSfOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIdSfOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdSfOrder.ForeColor = System.Drawing.Color.White;
            this.lblIdSfOrder.Location = new System.Drawing.Point(642, 130);
            this.lblIdSfOrder.Margin = new System.Windows.Forms.Padding(0);
            this.lblIdSfOrder.Name = "lblIdSfOrder";
            this.lblIdSfOrder.Size = new System.Drawing.Size(130, 20);
            this.lblIdSfOrder.TabIndex = 32;
            this.lblIdSfOrder.Text = "Nr zamówienia:";
            // 
            // lblIdSf
            // 
            this.lblIdSf.AutoSize = true;
            this.lblIdSf.BackColor = System.Drawing.Color.Transparent;
            this.lblIdSf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIdSf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIdSf.ForeColor = System.Drawing.Color.White;
            this.lblIdSf.Location = new System.Drawing.Point(621, 160);
            this.lblIdSf.Margin = new System.Windows.Forms.Padding(0);
            this.lblIdSf.Name = "lblIdSf";
            this.lblIdSf.Size = new System.Drawing.Size(150, 20);
            this.lblIdSf.TabIndex = 32;
            this.lblIdSf.Text = "Kod półfabrykatu:";
            // 
            // picBoxColorStatus
            // 
            this.picBoxColorStatus.BackColor = System.Drawing.Color.Transparent;
            this.picBoxColorStatus.Location = new System.Drawing.Point(1139, 233);
            this.picBoxColorStatus.Name = "picBoxColorStatus";
            this.picBoxColorStatus.Size = new System.Drawing.Size(30, 30);
            this.picBoxColorStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxColorStatus.TabIndex = 34;
            this.picBoxColorStatus.TabStop = false;
            // 
            // picBoxMassStatus
            // 
            this.picBoxMassStatus.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMassStatus.Location = new System.Drawing.Point(1139, 190);
            this.picBoxMassStatus.Name = "picBoxMassStatus";
            this.picBoxMassStatus.Size = new System.Drawing.Size(30, 30);
            this.picBoxMassStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMassStatus.TabIndex = 34;
            this.picBoxMassStatus.TabStop = false;
            // 
            // picBoxWidhtStatus
            // 
            this.picBoxWidhtStatus.BackColor = System.Drawing.Color.Transparent;
            this.picBoxWidhtStatus.Location = new System.Drawing.Point(1138, 147);
            this.picBoxWidhtStatus.Name = "picBoxWidhtStatus";
            this.picBoxWidhtStatus.Size = new System.Drawing.Size(30, 30);
            this.picBoxWidhtStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxWidhtStatus.TabIndex = 34;
            this.picBoxWidhtStatus.TabStop = false;
            // 
            // picBoxThicknessStatus
            // 
            this.picBoxThicknessStatus.BackColor = System.Drawing.Color.Transparent;
            this.picBoxThicknessStatus.Location = new System.Drawing.Point(1138, 105);
            this.picBoxThicknessStatus.Name = "picBoxThicknessStatus";
            this.picBoxThicknessStatus.Size = new System.Drawing.Size(30, 30);
            this.picBoxThicknessStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxThicknessStatus.TabIndex = 34;
            this.picBoxThicknessStatus.TabStop = false;
            // 
            // lblControlNotExist
            // 
            this.lblControlNotExist.AutoSize = true;
            this.lblControlNotExist.BackColor = System.Drawing.Color.Transparent;
            this.lblControlNotExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblControlNotExist.ForeColor = System.Drawing.Color.Red;
            this.lblControlNotExist.Location = new System.Drawing.Point(218, 157);
            this.lblControlNotExist.Name = "lblControlNotExist";
            this.lblControlNotExist.Size = new System.Drawing.Size(16, 24);
            this.lblControlNotExist.TabIndex = 33;
            this.lblControlNotExist.Text = " ";
            this.lblControlNotExist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(925, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ilość";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxQuantity.Location = new System.Drawing.Point(986, 278);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(140, 26);
            this.txtBoxQuantity.TabIndex = 24;
            this.txtBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxQuantity.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // picBoxQuantityStatus
            // 
            this.picBoxQuantityStatus.BackColor = System.Drawing.Color.Transparent;
            this.picBoxQuantityStatus.Location = new System.Drawing.Point(1139, 276);
            this.picBoxQuantityStatus.Name = "picBoxQuantityStatus";
            this.picBoxQuantityStatus.Size = new System.Drawing.Size(30, 30);
            this.picBoxQuantityStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxQuantityStatus.TabIndex = 34;
            this.picBoxQuantityStatus.TabStop = false;
            // 
            // picBoxControlStatus
            // 
            this.picBoxControlStatus.BackColor = System.Drawing.Color.Transparent;
            this.picBoxControlStatus.Image = global::KWZP2019.Properties.Resources.new_80px;
            this.picBoxControlStatus.InitialImage = null;
            this.picBoxControlStatus.Location = new System.Drawing.Point(1003, 591);
            this.picBoxControlStatus.Name = "picBoxControlStatus";
            this.picBoxControlStatus.Size = new System.Drawing.Size(169, 158);
            this.picBoxControlStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxControlStatus.TabIndex = 37;
            this.picBoxControlStatus.TabStop = false;
            // 
            // btnApproval
            // 
            this.btnApproval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnApproval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnApproval.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnApproval.FlatAppearance.BorderSize = 3;
            this.btnApproval.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApproval.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnApproval.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnApproval.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApproval.Image = global::KWZP2019.Properties.Resources.icons8_checkmark_40;
            this.btnApproval.Location = new System.Drawing.Point(672, 586);
            this.btnApproval.Name = "btnApproval";
            this.btnApproval.Size = new System.Drawing.Size(150, 165);
            this.btnApproval.TabIndex = 29;
            this.btnApproval.Text = "Kliknij, aby potwierdzić wyniki";
            this.btnApproval.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApproval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnApproval.UseVisualStyleBackColor = false;
            this.btnApproval.Click += new System.EventHandler(this.BtnApproval_Click);
            // 
            // dataGridViewEntranceControl
            // 
            this.dataGridViewEntranceControl.AllowUserToAddRows = false;
            this.dataGridViewEntranceControl.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridViewEntranceControl.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewEntranceControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEntranceControl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewEntranceControl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.dataGridViewEntranceControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEntranceControl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEntranceControl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewEntranceControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEntranceControl.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewEntranceControl.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEntranceControl.Location = new System.Drawing.Point(30, 280);
            this.dataGridViewEntranceControl.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewEntranceControl.MultiSelect = false;
            this.dataGridViewEntranceControl.Name = "dataGridViewEntranceControl";
            this.dataGridViewEntranceControl.ReadOnly = true;
            this.dataGridViewEntranceControl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEntranceControl.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridViewEntranceControl.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewEntranceControl.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewEntranceControl.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridViewEntranceControl.ShowEditingIcon = false;
            this.dataGridViewEntranceControl.Size = new System.Drawing.Size(700, 250);
            this.dataGridViewEntranceControl.TabIndex = 38;
            this.dataGridViewEntranceControl.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGVEntranceControl_RowHeaderMouseClick);
            // 
            // lblSelectedControl
            // 
            this.lblSelectedControl.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectedControl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectedControl.Location = new System.Drawing.Point(671, 92);
            this.lblSelectedControl.Name = "lblSelectedControl";
            this.lblSelectedControl.Size = new System.Drawing.Size(161, 26);
            this.lblSelectedControl.TabIndex = 4;
            this.lblSelectedControl.Text = "Wybrana Kontrola";
            this.lblSelectedControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderIdShow
            // 
            this.lblOrderIdShow.BackColor = System.Drawing.SystemColors.Window;
            this.lblOrderIdShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOrderIdShow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOrderIdShow.Location = new System.Drawing.Point(774, 127);
            this.lblOrderIdShow.Margin = new System.Windows.Forms.Padding(0);
            this.lblOrderIdShow.Name = "lblOrderIdShow";
            this.lblOrderIdShow.Size = new System.Drawing.Size(90, 26);
            this.lblOrderIdShow.TabIndex = 6;
            this.lblOrderIdShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSfIdShow
            // 
            this.lblSfIdShow.BackColor = System.Drawing.SystemColors.Window;
            this.lblSfIdShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSfIdShow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSfIdShow.Location = new System.Drawing.Point(774, 157);
            this.lblSfIdShow.Margin = new System.Windows.Forms.Padding(0);
            this.lblSfIdShow.Name = "lblSfIdShow";
            this.lblSfIdShow.Size = new System.Drawing.Size(90, 26);
            this.lblSfIdShow.TabIndex = 6;
            this.lblSfIdShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnShowAll.FlatAppearance.BorderSize = 3;
            this.btnShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowAll.Image = global::KWZP2019.Properties.Resources.icons8_date_span_40;
            this.btnShowAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.Location = new System.Drawing.Point(255, 665);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(235, 55);
            this.btnShowAll.TabIndex = 39;
            this.btnShowAll.Text = "Pokaż wszystko";
            this.btnShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // btnShowFromDay
            // 
            this.btnShowFromDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnShowFromDay.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnShowFromDay.FlatAppearance.BorderSize = 3;
            this.btnShowFromDay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowFromDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnShowFromDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFromDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowFromDay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowFromDay.Image = global::KWZP2019.Properties.Resources.icons8_calendar_13_40;
            this.btnShowFromDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowFromDay.Location = new System.Drawing.Point(10, 565);
            this.btnShowFromDay.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowFromDay.Name = "btnShowFromDay";
            this.btnShowFromDay.Size = new System.Drawing.Size(235, 55);
            this.btnShowFromDay.TabIndex = 39;
            this.btnShowFromDay.Text = "Pokaż z dnia";
            this.btnShowFromDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowFromDay.UseVisualStyleBackColor = false;
            this.btnShowFromDay.Click += new System.EventHandler(this.BtnShowFromDay_Click);
            // 
            // btnShowFromMonth
            // 
            this.btnShowFromMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnShowFromMonth.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnShowFromMonth.FlatAppearance.BorderSize = 3;
            this.btnShowFromMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowFromMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnShowFromMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFromMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowFromMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowFromMonth.Image = global::KWZP2019.Properties.Resources.icons8_month_view_40;
            this.btnShowFromMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowFromMonth.Location = new System.Drawing.Point(10, 630);
            this.btnShowFromMonth.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowFromMonth.Name = "btnShowFromMonth";
            this.btnShowFromMonth.Size = new System.Drawing.Size(235, 55);
            this.btnShowFromMonth.TabIndex = 39;
            this.btnShowFromMonth.Text = "Pokaż z miesiąca";
            this.btnShowFromMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowFromMonth.UseVisualStyleBackColor = false;
            this.btnShowFromMonth.Click += new System.EventHandler(this.BtnShowFromMonth_Click);
            // 
            // btnShowFromYear
            // 
            this.btnShowFromYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnShowFromYear.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnShowFromYear.FlatAppearance.BorderSize = 3;
            this.btnShowFromYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowFromYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnShowFromYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFromYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowFromYear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowFromYear.Image = global::KWZP2019.Properties.Resources.icons8_calendar_plus_40;
            this.btnShowFromYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowFromYear.Location = new System.Drawing.Point(10, 695);
            this.btnShowFromYear.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowFromYear.Name = "btnShowFromYear";
            this.btnShowFromYear.Size = new System.Drawing.Size(235, 55);
            this.btnShowFromYear.TabIndex = 39;
            this.btnShowFromYear.Text = "Pokaż z roku";
            this.btnShowFromYear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowFromYear.UseVisualStyleBackColor = false;
            this.btnShowFromYear.Click += new System.EventHandler(this.BtnShowFromYear_Click);
            // 
            // btnShowFromToday
            // 
            this.btnShowFromToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnShowFromToday.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnShowFromToday.FlatAppearance.BorderSize = 3;
            this.btnShowFromToday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnShowFromToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnShowFromToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFromToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnShowFromToday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowFromToday.Image = global::KWZP2019.Properties.Resources.icons8_calendar_1_40;
            this.btnShowFromToday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowFromToday.Location = new System.Drawing.Point(255, 595);
            this.btnShowFromToday.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowFromToday.Name = "btnShowFromToday";
            this.btnShowFromToday.Size = new System.Drawing.Size(235, 55);
            this.btnShowFromToday.TabIndex = 39;
            this.btnShowFromToday.Text = "Pokaż z dziś";
            this.btnShowFromToday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowFromToday.UseVisualStyleBackColor = false;
            this.btnShowFromToday.Click += new System.EventHandler(this.BtnShowFromToday_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.btnStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStatistics.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnStatistics.FlatAppearance.BorderSize = 3;
            this.btnStatistics.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatistics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStatistics.Image = global::KWZP2019.Properties.Resources.icons8_statistics_40;
            this.btnStatistics.Location = new System.Drawing.Point(384, 12);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(180, 100);
            this.btnStatistics.TabIndex = 0;
            this.btnStatistics.Text = "Wykresy";
            this.btnStatistics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.BtnStatistics_Click);
            // 
            // EntranceControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnShowFromYear);
            this.Controls.Add(this.btnShowFromMonth);
            this.Controls.Add(this.btnShowFromToday);
            this.Controls.Add(this.btnShowFromDay);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.picBoxControlStatus);
            this.Controls.Add(this.datePickerSelectedControlsDate);
            this.Controls.Add(this.picBoxThicknessStatus);
            this.Controls.Add(this.picBoxWidhtStatus);
            this.Controls.Add(this.picBoxMassStatus);
            this.Controls.Add(this.picBoxQuantityStatus);
            this.Controls.Add(this.picBoxColorStatus);
            this.Controls.Add(this.lblDelayTime);
            this.Controls.Add(this.lblControlNotExist);
            this.Controls.Add(this.lblEmployeeFullName);
            this.Controls.Add(this.lblIdSf);
            this.Controls.Add(this.lblIdSfOrder);
            this.Controls.Add(this.lblEmployeePESEL);
            this.Controls.Add(this.textBoxEmployeePESEL);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnApproval);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblParameterCheck);
            this.Controls.Add(this.checkBoxComposition);
            this.Controls.Add(this.txtboxComment);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.txtBoxColor);
            this.Controls.Add(this.txtboxMass);
            this.Controls.Add(this.txtboxWidth);
            this.Controls.Add(this.txtboxThickness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblSfIdShow);
            this.Controls.Add(this.lblOrderIdShow);
            this.Controls.Add(this.lblMass);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblSelectedControl);
            this.Controls.Add(this.lblThickness);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReturnMain);
            this.Controls.Add(this.dataGridViewEntranceControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntranceControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola Wejściowa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntranceControlForm_FormClosed);
            this.Load += new System.EventHandler(this.EntranceControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColorStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMassStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWidhtStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThicknessStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuantityStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxControlStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntranceControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtboxThickness;
        private System.Windows.Forms.TextBox txtboxWidth;
        private System.Windows.Forms.TextBox txtboxMass;
        private System.Windows.Forms.TextBox txtboxComment;
        private System.Windows.Forms.CheckBox checkBoxComposition;
        private System.Windows.Forms.Label lblParameterCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox textBoxEmployeePESEL;
        private System.Windows.Forms.Label lblEmployeePESEL;
        private System.Windows.Forms.Label lblEmployeeFullName;
        private System.Windows.Forms.Label lblDelayTime;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtBoxColor;
        private System.Windows.Forms.DateTimePicker datePickerSelectedControlsDate;
        private System.Windows.Forms.Label lblIdSfOrder;
        private System.Windows.Forms.Label lblIdSf;
        private System.Windows.Forms.PictureBox picBoxColorStatus;
        private System.Windows.Forms.PictureBox picBoxMassStatus;
        private System.Windows.Forms.PictureBox picBoxWidhtStatus;
        private System.Windows.Forms.PictureBox picBoxThicknessStatus;
        private System.Windows.Forms.Label lblControlNotExist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.PictureBox picBoxQuantityStatus;
        private System.Windows.Forms.PictureBox picBoxControlStatus;
        private System.Windows.Forms.Button btnApproval;
        private System.Windows.Forms.DataGridView dataGridViewEntranceControl;
        private System.Windows.Forms.Label lblSelectedControl;
        private System.Windows.Forms.Label lblOrderIdShow;
        private System.Windows.Forms.Label lblSfIdShow;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowFromDay;
        private System.Windows.Forms.Button btnShowFromMonth;
        private System.Windows.Forms.Button btnShowFromYear;
        private System.Windows.Forms.Button btnShowFromToday;
        private System.Windows.Forms.Button btnStatistics;
    }
}