﻿
namespace Lists
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
            this.add_button = new System.Windows.Forms.Button();
            this.find_button = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(404, 89);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(404, 138);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(75, 23);
            this.find_button.TabIndex = 1;
            this.find_button.Text = "find";
            this.find_button.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(404, 185);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 2;
            this.remove.Text = "remove";
            this.remove.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 303);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 325);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.add_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ListBox listBox1;
    }
}

