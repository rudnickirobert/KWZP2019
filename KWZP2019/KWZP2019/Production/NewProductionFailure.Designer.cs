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
            this.comboBox_idproces = new System.Windows.Forms.ComboBox();
            this.productionProcessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_Failure = new System.Windows.Forms.DateTimePicker();
            this.label_idProces = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_failureDate = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.button_abort = new System.Windows.Forms.Button();
            this.productionFailuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productionProcessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionFailuresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(330, 208);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Zapisz";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_idproces
            // 
            this.comboBox_idproces.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productionProcessBindingSource, "IdProces", true));
            this.comboBox_idproces.DataSource = this.productionProcessBindingSource;
            this.comboBox_idproces.DisplayMember = "IdProces";
            this.comboBox_idproces.FormattingEnabled = true;
            this.comboBox_idproces.Location = new System.Drawing.Point(160, 53);
            this.comboBox_idproces.Name = "comboBox_idproces";
            this.comboBox_idproces.Size = new System.Drawing.Size(245, 24);
            this.comboBox_idproces.TabIndex = 1;
            this.comboBox_idproces.ValueMember = "IdProces";
            // 
            // productionProcessBindingSource
            // 
            this.productionProcessBindingSource.DataSource = typeof(KWZP2019.ProductionProcess);
            // 
            // dateTimePicker_Failure
            // 
            this.dateTimePicker_Failure.Location = new System.Drawing.Point(160, 105);
            this.dateTimePicker_Failure.Name = "dateTimePicker_Failure";
            this.dateTimePicker_Failure.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker_Failure.TabIndex = 2;
            // 
            // label_idProces
            // 
            this.label_idProces.AutoSize = true;
            this.label_idProces.Location = new System.Drawing.Point(40, 61);
            this.label_idProces.Name = "label_idProces";
            this.label_idProces.Size = new System.Drawing.Size(100, 16);
            this.label_idProces.TabIndex = 3;
            this.label_idProces.Text = "Numer procesu";
            // 
            // textBox_description
            // 
            this.textBox_description.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_description.Location = new System.Drawing.Point(160, 156);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(245, 22);
            this.textBox_description.TabIndex = 4;
            // 
            // label_failureDate
            // 
            this.label_failureDate.AutoSize = true;
            this.label_failureDate.Location = new System.Drawing.Point(40, 111);
            this.label_failureDate.Name = "label_failureDate";
            this.label_failureDate.Size = new System.Drawing.Size(75, 16);
            this.label_failureDate.TabIndex = 5;
            this.label_failureDate.Text = "Data awarii";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(40, 162);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(36, 16);
            this.label_description.TabIndex = 6;
            this.label_description.Text = "Opis";
            // 
            // button_abort
            // 
            this.button_abort.Location = new System.Drawing.Point(43, 208);
            this.button_abort.Name = "button_abort";
            this.button_abort.Size = new System.Drawing.Size(75, 23);
            this.button_abort.TabIndex = 7;
            this.button_abort.Text = "Anuluj";
            this.button_abort.UseVisualStyleBackColor = true;
            this.button_abort.Click += new System.EventHandler(this.button_abort_Click);
            // 
            // productionFailuresBindingSource
            // 
            this.productionFailuresBindingSource.DataSource = typeof(KWZP2019.ProductionFailures);
            // 
            // NewProductionFailure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 511);
            this.Controls.Add(this.button_abort);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_failureDate);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label_idProces);
            this.Controls.Add(this.dateTimePicker_Failure);
            this.Controls.Add(this.comboBox_idproces);
            this.Controls.Add(this.button_save);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
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
        private System.Windows.Forms.ComboBox comboBox_idproces;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Failure;
        private System.Windows.Forms.Label label_idProces;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label_failureDate;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Button button_abort;
        private System.Windows.Forms.BindingSource productionProcessBindingSource;
        private System.Windows.Forms.BindingSource productionFailuresBindingSource;
    }
}