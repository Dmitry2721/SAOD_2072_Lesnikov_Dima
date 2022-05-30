
namespace Seminar1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.push_button = new System.Windows.Forms.Button();
            this.pop_button = new System.Windows.Forms.Button();
            this.top_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 267);
            this.textBox1.TabIndex = 0;
            // 
            // push_button
            // 
            this.push_button.Location = new System.Drawing.Point(495, 23);
            this.push_button.Name = "push_button";
            this.push_button.Size = new System.Drawing.Size(75, 23);
            this.push_button.TabIndex = 1;
            this.push_button.Text = "push";
            this.push_button.UseVisualStyleBackColor = true;
            // 
            // pop_button
            // 
            this.pop_button.Location = new System.Drawing.Point(495, 70);
            this.pop_button.Name = "pop_button";
            this.pop_button.Size = new System.Drawing.Size(75, 23);
            this.pop_button.TabIndex = 2;
            this.pop_button.Text = "pop";
            this.pop_button.UseVisualStyleBackColor = true;
            // 
            // top_button
            // 
            this.top_button.Location = new System.Drawing.Point(495, 127);
            this.top_button.Name = "top_button";
            this.top_button.Size = new System.Drawing.Size(75, 23);
            this.top_button.TabIndex = 3;
            this.top_button.Text = "top";
            this.top_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 296);
            this.Controls.Add(this.top_button);
            this.Controls.Add(this.pop_button);
            this.Controls.Add(this.push_button);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button push_button;
        private System.Windows.Forms.Button pop_button;
        private System.Windows.Forms.Button top_button;
    }
}

