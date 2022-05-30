namespace LIst_task
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
            this.buttonAppend = new System.Windows.Forms.Button();
            this.buttonPrepend = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAddMiddle = new System.Windows.Forms.Button();
            this.buttonRemoveKey = new System.Windows.Forms.Button();
            this.buttonRemoveByIndex = new System.Windows.Forms.Button();
            this.buttonFindByKey = new System.Windows.Forms.Button();
            this.buttonFindByIndex = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 31);
            this.textBox1.TabIndex = 0;
            // 
            // buttonAppend
            // 
            this.buttonAppend.Location = new System.Drawing.Point(13, 60);
            this.buttonAppend.Name = "buttonAppend";
            this.buttonAppend.Size = new System.Drawing.Size(75, 23);
            this.buttonAppend.TabIndex = 1;
            this.buttonAppend.Text = "Append";
            this.buttonAppend.UseVisualStyleBackColor = true;
            this.buttonAppend.Click += new System.EventHandler(this.buttonAppend_Click);
            // 
            // buttonPrepend
            // 
            this.buttonPrepend.Location = new System.Drawing.Point(90, 60);
            this.buttonPrepend.Name = "buttonPrepend";
            this.buttonPrepend.Size = new System.Drawing.Size(75, 23);
            this.buttonPrepend.TabIndex = 2;
            this.buttonPrepend.Text = "Prepend";
            this.buttonPrepend.UseVisualStyleBackColor = true;
            this.buttonPrepend.Click += new System.EventHandler(this.buttonPrepend_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 199);
            this.listBox1.TabIndex = 3;
            // 
            // buttonAddMiddle
            // 
            this.buttonAddMiddle.Location = new System.Drawing.Point(193, 74);
            this.buttonAddMiddle.Name = "buttonAddMiddle";
            this.buttonAddMiddle.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMiddle.TabIndex = 4;
            this.buttonAddMiddle.Text = "Add";
            this.buttonAddMiddle.UseVisualStyleBackColor = true;
            this.buttonAddMiddle.Click += new System.EventHandler(this.buttonAddMiddle_Click);
            // 
            // buttonRemoveKey
            // 
            this.buttonRemoveKey.Location = new System.Drawing.Point(193, 118);
            this.buttonRemoveKey.Name = "buttonRemoveKey";
            this.buttonRemoveKey.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveKey.TabIndex = 5;
            this.buttonRemoveKey.Text = "RemoveK";
            this.buttonRemoveKey.UseVisualStyleBackColor = true;
            this.buttonRemoveKey.Click += new System.EventHandler(this.buttonRemoveKey_Click);
            // 
            // buttonRemoveByIndex
            // 
            this.buttonRemoveByIndex.Location = new System.Drawing.Point(193, 158);
            this.buttonRemoveByIndex.Name = "buttonRemoveByIndex";
            this.buttonRemoveByIndex.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveByIndex.TabIndex = 6;
            this.buttonRemoveByIndex.Text = "RemoveIn";
            this.buttonRemoveByIndex.UseVisualStyleBackColor = true;
            this.buttonRemoveByIndex.Click += new System.EventHandler(this.buttonRemoveByIndex_Click);
            // 
            // buttonFindByKey
            // 
            this.buttonFindByKey.Location = new System.Drawing.Point(193, 198);
            this.buttonFindByKey.Name = "buttonFindByKey";
            this.buttonFindByKey.Size = new System.Drawing.Size(75, 23);
            this.buttonFindByKey.TabIndex = 7;
            this.buttonFindByKey.Text = "FindKey";
            this.buttonFindByKey.UseVisualStyleBackColor = true;
            this.buttonFindByKey.Click += new System.EventHandler(this.buttonFindByKey_Click);
            // 
            // buttonFindByIndex
            // 
            this.buttonFindByIndex.Location = new System.Drawing.Point(193, 238);
            this.buttonFindByIndex.Name = "buttonFindByIndex";
            this.buttonFindByIndex.Size = new System.Drawing.Size(75, 23);
            this.buttonFindByIndex.TabIndex = 8;
            this.buttonFindByIndex.Text = "FindIndex";
            this.buttonFindByIndex.UseVisualStyleBackColor = true;
            this.buttonFindByIndex.Click += new System.EventHandler(this.buttonFindByIndex_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(193, 283);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 9;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите элемент";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonFindByIndex);
            this.Controls.Add(this.buttonFindByKey);
            this.Controls.Add(this.buttonRemoveByIndex);
            this.Controls.Add(this.buttonRemoveKey);
            this.Controls.Add(this.buttonAddMiddle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonPrepend);
            this.Controls.Add(this.buttonAppend);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAppend;
        private System.Windows.Forms.Button buttonPrepend;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAddMiddle;
        private System.Windows.Forms.Button buttonRemoveKey;
        private System.Windows.Forms.Button buttonRemoveByIndex;
        private System.Windows.Forms.Button buttonFindByKey;
        private System.Windows.Forms.Button buttonFindByIndex;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label1;
    }
}

