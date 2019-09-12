namespace SortByLastNameApp
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
            this.ChooseButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LastNameButton = new System.Windows.Forms.Button();
            this.FirstNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(10, 321);
            this.ChooseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(98, 23);
            this.ChooseButton.TabIndex = 0;
            this.ChooseButton.Text = "Choose ";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(582, 286);
            this.textBox1.TabIndex = 1;
            // 
            // LastNameButton
            // 
            this.LastNameButton.Location = new System.Drawing.Point(123, 321);
            this.LastNameButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastNameButton.Name = "LastNameButton";
            this.LastNameButton.Size = new System.Drawing.Size(126, 23);
            this.LastNameButton.TabIndex = 2;
            this.LastNameButton.Text = "Sort By Last Name";
            this.LastNameButton.UseVisualStyleBackColor = true;
            this.LastNameButton.Click += new System.EventHandler(this.LastNameButton_Click);
            // 
            // FirstNameButton
            // 
            this.FirstNameButton.Location = new System.Drawing.Point(273, 321);
            this.FirstNameButton.Name = "FirstNameButton";
            this.FirstNameButton.Size = new System.Drawing.Size(133, 23);
            this.FirstNameButton.TabIndex = 3;
            this.FirstNameButton.Text = "Sort By First Name";
            this.FirstNameButton.UseVisualStyleBackColor = true;
            this.FirstNameButton.Click += new System.EventHandler(this.FirstNameButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.FirstNameButton);
            this.Controls.Add(this.LastNameButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChooseButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Sorted Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LastNameButton;
        private System.Windows.Forms.Button FirstNameButton;
    }
}

