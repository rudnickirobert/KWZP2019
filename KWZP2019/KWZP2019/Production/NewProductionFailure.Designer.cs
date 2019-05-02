namespace KWZP2019
{
    partial class NewProductionFailure
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
            this.components = new System.ComponentModel.Container();
            this.button_save = new System.Windows.Forms.Button();
            this.cBidproces = new System.Windows.Forms.ComboBox();
            this.productionProcessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_Failure = new System.Windows.Forms.DateTimePicker();
            this.label_idProces = new System.Windows.Forms.Label();
            this.tBdescription = new System.Windows.Forms.TextBox();
            this.label_failureDate = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.productionFailuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productionProcessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(182, 180);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(134, 100);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Zapisz";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // cBidproces
            // 
            this.cBidproces.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productionProcessBindingSource, "IdProces", true));
            this.cBidproces.DataSource = this.productionProcessBindingSource;
            this.cBidproces.DisplayMember = "IdProces";
            this.cBidproces.FormattingEnabled = true;
            this.cBidproces.Location = new System.Drawing.Point(120, 43);
            this.cBidproces.Margin = new System.Windows.Forms.Padding(2);
            this.cBidproces.Name = "cBidproces";
            this.cBidproces.Size = new System.Drawing.Size(185, 21);
            this.cBidproces.TabIndex = 1;
            this.cBidproces.ValueMember = "IdProces";
            // 
            // productionProcessBindingSource
            // 
            this.productionProcessBindingSource.DataSource = typeof(KWZP2019.ProductionProcess);
            // 
            // dateTimePicker_Failure
            // 
            this.dateTimePicker_Failure.Location = new System.Drawing.Point(120, 85);
            this.dateTimePicker_Failure.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_Failure.Name = "dateTimePicker_Failure";
            this.dateTimePicker_Failure.Size = new System.Drawing.Size(185, 20);
            this.dateTimePicker_Failure.TabIndex = 2;
            // 
            // label_idProces
            // 
            this.label_idProces.AutoSize = true;
            this.label_idProces.Location = new System.Drawing.Point(30, 50);
            this.label_idProces.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_idProces.Name = "label_idProces";
            this.label_idProces.Size = new System.Drawing.Size(79, 13);
            this.label_idProces.TabIndex = 3;
            this.label_idProces.Text = "Numer procesu";
            // 
            // tBdescription
            // 
            this.tBdescription.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tBdescription.Location = new System.Drawing.Point(120, 127);
            this.tBdescription.Margin = new System.Windows.Forms.Padding(2);
            this.tBdescription.Name = "tBdescription";
            this.tBdescription.Size = new System.Drawing.Size(185, 20);
            this.tBdescription.TabIndex = 4;
            // 
            // label_failureDate
            // 
            this.label_failureDate.AutoSize = true;
            this.label_failureDate.Location = new System.Drawing.Point(30, 90);
            this.label_failureDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_failureDate.Name = "label_failureDate";
            this.label_failureDate.Size = new System.Drawing.Size(60, 13);
            this.label_failureDate.TabIndex = 5;
            this.label_failureDate.Text = "Data awarii";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(30, 132);
            this.label_description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(28, 13);
            this.label_description.TabIndex = 6;
            this.label_description.Text = "Opis";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(22, 180);
            this.button_Back.Margin = new System.Windows.Forms.Padding(2);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(141, 100);
            this.button_Back.TabIndex = 7;
            this.button_Back.Text = "Powrót";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_abort_Click);
            // 
            // productionFailuresBindingSource
            // 
            this.productionFailuresBindingSource.DataSource = typeof(KWZP2019.ProductionFailures);
            // 
            // NewProductionFailure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KWZP2019.Properties.Resources._53062472_302328053765523_8291849142804676608_n;
            this.ClientSize = new System.Drawing.Size(336, 287);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_failureDate);
            this.Controls.Add(this.tBdescription);
            this.Controls.Add(this.label_idProces);
            this.Controls.Add(this.dateTimePicker_Failure);
            this.Controls.Add(this.cBidproces);
            this.Controls.Add(this.button_save);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewProductionFailure";
            this.Text = "NewProductionFailure";
            this.Load += new System.EventHandler(this.NewProductionFailure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productionProcessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox cBidproces;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Failure;
        private System.Windows.Forms.Label label_idProces;
        private System.Windows.Forms.TextBox tBdescription;
        private System.Windows.Forms.Label label_failureDate;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.BindingSource productionProcessBindingSource;
        private System.Windows.Forms.BindingSource productionFailuresBindingSource;
    }
}