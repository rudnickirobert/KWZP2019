namespace KWZP2019
{
    partial class OutsourcingForm
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
            this.addNewOutsourcingCompanyBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // addNewOutsourcingCompanyBtn
            // 
            this.addNewOutsourcingCompanyBtn.Location = new System.Drawing.Point(51, 268);
            this.addNewOutsourcingCompanyBtn.Name = "addNewOutsourcingCompanyBtn";
            this.addNewOutsourcingCompanyBtn.Size = new System.Drawing.Size(148, 64);
            this.addNewOutsourcingCompanyBtn.TabIndex = 13;
            this.addNewOutsourcingCompanyBtn.Text = "Dodaj firmę outsourcingową";
            this.addNewOutsourcingCompanyBtn.UseVisualStyleBackColor = true;
            this.addNewOutsourcingCompanyBtn.Click += new System.EventHandler(this.addNewOutsourcingCompanyBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(51, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(827, 157);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // OutsourcingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 594);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addNewOutsourcingCompanyBtn);
            this.Name = "OutsourcingForm";
            this.Text = "OutsourcingForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addNewOutsourcingCompanyBtn;
        private System.Windows.Forms.ListView listView1;
    }
}