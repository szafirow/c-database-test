namespace Baza2
{
    partial class Form2
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 60);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(240, 26);
            this.textBox_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "surname";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(12, 132);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(240, 26);
            this.textBox_surname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "gender";
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "1",
            "0"});
            this.comboBox_gender.Location = new System.Drawing.Point(12, 215);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(240, 28);
            this.comboBox_gender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "data";
            // 
            // dateTimePicker_data
            // 
            this.dateTimePicker_data.Location = new System.Drawing.Point(12, 295);
            this.dateTimePicker_data.Name = "dateTimePicker_data";
            this.dateTimePicker_data.Size = new System.Drawing.Size(240, 26);
            this.dateTimePicker_data.TabIndex = 7;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 338);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(240, 44);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Dodaj";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 414);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dateTimePicker_data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Name = "Form2";
            this.Text = "Dodawanie pracowników";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_data;
        private System.Windows.Forms.Button button_add;
    }
}