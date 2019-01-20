namespace SortedName
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
            this.SortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(13, 395);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(131, 28);
            this.ChooseButton.TabIndex = 0;
            this.ChooseButton.Text = "Choose ";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(775, 351);
            this.textBox1.TabIndex = 1;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(164, 395);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(168, 28);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Sort By Lastname";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ChooseButton);
            this.Name = "Form1";
            this.Text = "Sorted Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SortButton;
    }
}

