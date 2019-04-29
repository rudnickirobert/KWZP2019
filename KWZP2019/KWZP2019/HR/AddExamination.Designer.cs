namespace KWZP2019
{
    partial class AddExamination
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
            this.dtpNextExaminationDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEmployeeList = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpValidity = new System.Windows.Forms.TabPage();
            this.tpExpirationDate = new System.Windows.Forms.TabPage();
            this.tbSearchEmployee = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tpValidity.SuspendLayout();
            this.tpExpirationDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNextExaminationDate
            // 
            this.dtpNextExaminationDate.Location = new System.Drawing.Point(19, 91);
            this.dtpNextExaminationDate.Name = "dtpNextExaminationDate";
            this.dtpNextExaminationDate.Size = new System.Drawing.Size(205, 22);
            this.dtpNextExaminationDate.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(585, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 45);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ważność badania [w miesiącach]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data następnego badania";
            // 
            // lbEmployeeList
            // 
            this.lbEmployeeList.FormattingEnabled = true;
            this.lbEmployeeList.ItemHeight = 16;
            this.lbEmployeeList.Location = new System.Drawing.Point(12, 76);
            this.lbEmployeeList.Name = "lbEmployeeList";
            this.lbEmployeeList.Size = new System.Drawing.Size(303, 356);
            this.lbEmployeeList.TabIndex = 5;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpValidity);
            this.tabControl.Controls.Add(this.tpExpirationDate);
            this.tabControl.Location = new System.Drawing.Point(339, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(337, 150);
            this.tabControl.TabIndex = 6;
            // 
            // tpValidity
            // 
            this.tpValidity.Controls.Add(this.label1);
            this.tpValidity.Controls.Add(this.textBox1);
            this.tpValidity.Location = new System.Drawing.Point(4, 25);
            this.tpValidity.Name = "tpValidity";
            this.tpValidity.Padding = new System.Windows.Forms.Padding(3);
            this.tpValidity.Size = new System.Drawing.Size(329, 121);
            this.tpValidity.TabIndex = 0;
            this.tpValidity.Text = "Ważność";
            this.tpValidity.UseVisualStyleBackColor = true;
            // 
            // tpExpirationDate
            // 
            this.tpExpirationDate.Controls.Add(this.label2);
            this.tpExpirationDate.Controls.Add(this.dtpNextExaminationDate);
            this.tpExpirationDate.Location = new System.Drawing.Point(4, 25);
            this.tpExpirationDate.Name = "tpExpirationDate";
            this.tpExpirationDate.Padding = new System.Windows.Forms.Padding(3);
            this.tpExpirationDate.Size = new System.Drawing.Size(329, 121);
            this.tpExpirationDate.TabIndex = 1;
            this.tpExpirationDate.Text = "Termin następnego badania";
            this.tpExpirationDate.UseVisualStyleBackColor = true;
            // 
            // tbSearchEmployee
            // 
            this.tbSearchEmployee.Location = new System.Drawing.Point(13, 37);
            this.tbSearchEmployee.Name = "tbSearchEmployee";
            this.tbSearchEmployee.Size = new System.Drawing.Size(302, 22);
            this.tbSearchEmployee.TabIndex = 8;
            this.tbSearchEmployee.TextChanged += new System.EventHandler(this.tbSearchEmployee_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(339, 193);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(240, 242);
            this.checkedListBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(597, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // AddExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.tbSearchEmployee);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lbEmployeeList);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddExamination";
            this.Text = "Examination";
            this.Load += new System.EventHandler(this.Examination_Load);
            this.tabControl.ResumeLayout(false);
            this.tpValidity.ResumeLayout(false);
            this.tpValidity.PerformLayout();
            this.tpExpirationDate.ResumeLayout(false);
            this.tpExpirationDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNextExaminationDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbEmployeeList;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpValidity;
        private System.Windows.Forms.TabPage tpExpirationDate;
        private System.Windows.Forms.TextBox tbSearchEmployee;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}