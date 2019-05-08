namespace KWZP2019
{
    partial class OshTrainingNewEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OshTrainingNewEmployeeForm));
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.dateTimePickerNewTraining = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTraining = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblNewTraining = new System.Windows.Forms.Label();
            this.txtBoxPesel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.lblFormTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblFormTitle, "lblFormTitle");
            this.lblFormTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormTitle.Name = "lblFormTitle";
            // 
            // dateTimePickerNewTraining
            // 
            resources.ApplyResources(this.dateTimePickerNewTraining, "dateTimePickerNewTraining");
            this.dateTimePickerNewTraining.Name = "dateTimePickerNewTraining";
            this.dateTimePickerNewTraining.Value = new System.DateTime(2019, 5, 7, 1, 40, 0, 0);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // btnAddTraining
            // 
            this.btnAddTraining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.btnAddTraining, "btnAddTraining");
            this.btnAddTraining.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAddTraining.FlatAppearance.BorderSize = 3;
            this.btnAddTraining.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddTraining.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddTraining.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnAddTraining.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddTraining.Name = "btnAddTraining";
            this.btnAddTraining.UseVisualStyleBackColor = false;
            this.btnAddTraining.Click += new System.EventHandler(this.btnAddTraining_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            resources.ApplyResources(this.btnReturn, "btnReturn");
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.FlatAppearance.BorderSize = 3;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(144)))), ((int)(((byte)(175)))));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblNewTraining
            // 
            resources.ApplyResources(this.lblNewTraining, "lblNewTraining");
            this.lblNewTraining.BackColor = System.Drawing.Color.Transparent;
            this.lblNewTraining.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNewTraining.Name = "lblNewTraining";
            // 
            // txtBoxPesel
            // 
            resources.ApplyResources(this.txtBoxPesel, "txtBoxPesel");
            this.txtBoxPesel.Name = "txtBoxPesel";
            // 
            // OshTrainingNewEmployeeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.txtBoxPesel);
            this.Controls.Add(this.lblNewTraining);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddTraining);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerNewTraining);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OshTrainingNewEmployeeForm";
            this.Load += new System.EventHandler(this.OshTrainingNewEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerNewTraining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTraining;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblNewTraining;
        private System.Windows.Forms.TextBox txtBoxPesel;
    }
}