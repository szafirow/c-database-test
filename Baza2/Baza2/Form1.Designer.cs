namespace Baza2
{
    partial class Form1
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
            System.Windows.Forms.Button button_view;
            System.Windows.Forms.Button button_add;
            System.Windows.Forms.Button button_save;
            System.Windows.Forms.Button button_del;
            System.Windows.Forms.Button button_insert;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            button_view = new System.Windows.Forms.Button();
            button_add = new System.Windows.Forms.Button();
            button_save = new System.Windows.Forms.Button();
            button_del = new System.Windows.Forms.Button();
            button_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_view
            // 
            button_view.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button_view.Location = new System.Drawing.Point(22, 13);
            button_view.Name = "button_view";
            button_view.Size = new System.Drawing.Size(107, 56);
            button_view.TabIndex = 1;
            button_view.Text = "Wyświetl";
            button_view.UseVisualStyleBackColor = true;
            button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // button_add
            // 
            button_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button_add.Location = new System.Drawing.Point(148, 13);
            button_add.Name = "button_add";
            button_add.Size = new System.Drawing.Size(107, 56);
            button_add.TabIndex = 2;
            button_add.Text = "Dodaj pracownika";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_save
            // 
            button_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button_save.Location = new System.Drawing.Point(400, 13);
            button_save.Name = "button_save";
            button_save.Size = new System.Drawing.Size(107, 56);
            button_save.TabIndex = 3;
            button_save.Text = "Edytuj zamówienie";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_del
            // 
            button_del.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button_del.Location = new System.Drawing.Point(526, 13);
            button_del.Name = "button_del";
            button_del.Size = new System.Drawing.Size(107, 56);
            button_del.TabIndex = 4;
            button_del.Text = "Usuń";
            button_del.UseVisualStyleBackColor = true;
            button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_insert
            // 
            button_insert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button_insert.Location = new System.Drawing.Point(274, 12);
            button_insert.Name = "button_insert";
            button_insert.Size = new System.Drawing.Size(107, 56);
            button_insert.TabIndex = 6;
            button_insert.Text = "Dodaj zamówienie";
            button_insert.UseVisualStyleBackColor = true;
            button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 569);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(961, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 667);
            this.Controls.Add(button_insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(button_del);
            this.Controls.Add(button_save);
            this.Controls.Add(button_add);
            this.Controls.Add(button_view);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "ObsługaZamówień";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

