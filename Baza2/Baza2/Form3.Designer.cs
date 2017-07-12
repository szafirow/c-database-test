namespace Baza2
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_data2 = new System.Windows.Forms.DateTimePicker();
            this.button_insert2 = new System.Windows.Forms.Button();
            this.comboBox_emp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pracownik";
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(16, 116);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(244, 26);
            this.textBox_adress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data";
            // 
            // dateTimePicker_data2
            // 
            this.dateTimePicker_data2.Location = new System.Drawing.Point(12, 191);
            this.dateTimePicker_data2.Name = "dateTimePicker_data2";
            this.dateTimePicker_data2.Size = new System.Drawing.Size(244, 26);
            this.dateTimePicker_data2.TabIndex = 4;
            // 
            // button_insert2
            // 
            this.button_insert2.Location = new System.Drawing.Point(12, 238);
            this.button_insert2.Name = "button_insert2";
            this.button_insert2.Size = new System.Drawing.Size(244, 44);
            this.button_insert2.TabIndex = 5;
            this.button_insert2.Text = "Dodaj";
            this.button_insert2.UseVisualStyleBackColor = true;
            this.button_insert2.Click += new System.EventHandler(this.button_insert2_Click);
            // 
            // comboBox_emp
            // 
            this.comboBox_emp.FormattingEnabled = true;
            this.comboBox_emp.Location = new System.Drawing.Point(12, 51);
            this.comboBox_emp.Name = "comboBox_emp";
            this.comboBox_emp.Size = new System.Drawing.Size(244, 28);
            this.comboBox_emp.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 302);
            this.Controls.Add(this.comboBox_emp);
            this.Controls.Add(this.button_insert2);
            this.Controls.Add(this.dateTimePicker_data2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Dodawanie zamówienia";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data2;
        private System.Windows.Forms.Button button_insert2;
        private System.Windows.Forms.ComboBox comboBox_emp;
    }
}