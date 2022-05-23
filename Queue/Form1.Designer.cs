namespace Queue
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.install_button = new System.Windows.Forms.Button();
            this.push_button = new System.Windows.Forms.Button();
            this.pop_button = new System.Windows.Forms.Button();
            this.top_button = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.clean_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 37);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 149);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 173);
            this.listBox1.TabIndex = 2;
            // 
            // install_button
            // 
            this.install_button.Location = new System.Drawing.Point(230, 26);
            this.install_button.Name = "install_button";
            this.install_button.Size = new System.Drawing.Size(122, 23);
            this.install_button.TabIndex = 3;
            this.install_button.Text = "install";
            this.install_button.UseVisualStyleBackColor = true;
            this.install_button.Click += new System.EventHandler(this.install_button_Click);
            // 
            // push_button
            // 
            this.push_button.Location = new System.Drawing.Point(230, 73);
            this.push_button.Name = "push_button";
            this.push_button.Size = new System.Drawing.Size(122, 23);
            this.push_button.TabIndex = 4;
            this.push_button.Text = "push";
            this.push_button.UseVisualStyleBackColor = true;
            this.push_button.Click += new System.EventHandler(this.push_button_Click);
            // 
            // pop_button
            // 
            this.pop_button.Location = new System.Drawing.Point(230, 126);
            this.pop_button.Name = "pop_button";
            this.pop_button.Size = new System.Drawing.Size(122, 23);
            this.pop_button.TabIndex = 5;
            this.pop_button.Text = "pop";
            this.pop_button.UseVisualStyleBackColor = true;
            this.pop_button.Click += new System.EventHandler(this.pop_button_Click);
            // 
            // top_button
            // 
            this.top_button.Location = new System.Drawing.Point(230, 175);
            this.top_button.Name = "top_button";
            this.top_button.Size = new System.Drawing.Size(122, 23);
            this.top_button.TabIndex = 6;
            this.top_button.Text = "top";
            this.top_button.UseVisualStyleBackColor = true;
            this.top_button.Click += new System.EventHandler(this.top_button_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(230, 219);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 23);
            this.textBox3.TabIndex = 7;
            // 
            // clean_button
            // 
            this.clean_button.Location = new System.Drawing.Point(230, 299);
            this.clean_button.Name = "clean_button";
            this.clean_button.Size = new System.Drawing.Size(122, 23);
            this.clean_button.TabIndex = 8;
            this.clean_button.Text = "clean";
            this.clean_button.UseVisualStyleBackColor = true;
            this.clean_button.Click += new System.EventHandler(this.clean_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 363);
            this.Controls.Add(this.clean_button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.top_button);
            this.Controls.Add(this.pop_button);
            this.Controls.Add(this.push_button);
            this.Controls.Add(this.install_button);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button install_button;
        private System.Windows.Forms.Button push_button;
        private System.Windows.Forms.Button pop_button;
        private System.Windows.Forms.Button top_button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button clean_button;
    }
}

