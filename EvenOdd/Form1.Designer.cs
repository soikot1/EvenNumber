namespace EvenOdd
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloneButton = new System.Windows.Forms.Button();
            this.EvenButton = new System.Windows.Forms.Button();
            this.OddButton = new System.Windows.Forms.Button();
            this.saveRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cloneRichTextBox = new System.Windows.Forms.RichTextBox();
            this.evenRichTextBox = new System.Windows.Forms.RichTextBox();
            this.oddRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(77, 141);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloneButton
            // 
            this.CloneButton.Location = new System.Drawing.Point(229, 141);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(75, 23);
            this.CloneButton.TabIndex = 2;
            this.CloneButton.Text = "Clone";
            this.CloneButton.UseVisualStyleBackColor = true;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // EvenButton
            // 
            this.EvenButton.Location = new System.Drawing.Point(395, 141);
            this.EvenButton.Name = "EvenButton";
            this.EvenButton.Size = new System.Drawing.Size(75, 23);
            this.EvenButton.TabIndex = 3;
            this.EvenButton.Text = "Even";
            this.EvenButton.UseVisualStyleBackColor = true;
            this.EvenButton.Click += new System.EventHandler(this.EvenButton_Click);
            // 
            // OddButton
            // 
            this.OddButton.Location = new System.Drawing.Point(555, 141);
            this.OddButton.Name = "OddButton";
            this.OddButton.Size = new System.Drawing.Size(75, 23);
            this.OddButton.TabIndex = 4;
            this.OddButton.Text = "Odd";
            this.OddButton.UseVisualStyleBackColor = true;
            this.OddButton.Click += new System.EventHandler(this.OddButton_Click);
            // 
            // saveRichTextBox
            // 
            this.saveRichTextBox.Location = new System.Drawing.Point(53, 184);
            this.saveRichTextBox.Name = "saveRichTextBox";
            this.saveRichTextBox.Size = new System.Drawing.Size(120, 178);
            this.saveRichTextBox.TabIndex = 5;
            this.saveRichTextBox.Text = "";
            // 
            // cloneRichTextBox
            // 
            this.cloneRichTextBox.Location = new System.Drawing.Point(203, 184);
            this.cloneRichTextBox.Name = "cloneRichTextBox";
            this.cloneRichTextBox.Size = new System.Drawing.Size(126, 178);
            this.cloneRichTextBox.TabIndex = 6;
            this.cloneRichTextBox.Text = "";
            // 
            // evenRichTextBox
            // 
            this.evenRichTextBox.Location = new System.Drawing.Point(360, 184);
            this.evenRichTextBox.Name = "evenRichTextBox";
            this.evenRichTextBox.Size = new System.Drawing.Size(129, 178);
            this.evenRichTextBox.TabIndex = 7;
            this.evenRichTextBox.Text = "";
            // 
            // oddRichTextBox
            // 
            this.oddRichTextBox.Location = new System.Drawing.Point(546, 184);
            this.oddRichTextBox.Name = "oddRichTextBox";
            this.oddRichTextBox.Size = new System.Drawing.Size(129, 178);
            this.oddRichTextBox.TabIndex = 8;
            this.oddRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "WeekDays";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oddRichTextBox);
            this.Controls.Add(this.evenRichTextBox);
            this.Controls.Add(this.cloneRichTextBox);
            this.Controls.Add(this.saveRichTextBox);
            this.Controls.Add(this.OddButton);
            this.Controls.Add(this.EvenButton);
            this.Controls.Add(this.CloneButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloneButton;
        private System.Windows.Forms.Button EvenButton;
        private System.Windows.Forms.Button OddButton;
        private System.Windows.Forms.RichTextBox saveRichTextBox;
        private System.Windows.Forms.RichTextBox cloneRichTextBox;
        private System.Windows.Forms.RichTextBox evenRichTextBox;
        private System.Windows.Forms.RichTextBox oddRichTextBox;
        private System.Windows.Forms.Label label1;
    }
}

