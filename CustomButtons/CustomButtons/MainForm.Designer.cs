namespace CustomButtons
{
    partial class MainForm
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
            this.randomColorButton2 = new CustomButtons.RandomColorButton();
            this.randomColorButton1 = new CustomButtons.RandomColorButton();
            this.defaultButton1 = new CustomButtons.DefaultButton();
            this.resizeRandomColorButton1 = new CustomButtons.ResizeRandomColorButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 4;
            // 
            // randomColorButton2
            // 
            this.randomColorButton2.Location = new System.Drawing.Point(207, 76);
            this.randomColorButton2.Name = "randomColorButton2";
            this.randomColorButton2.Size = new System.Drawing.Size(147, 56);
            this.randomColorButton2.TabIndex = 5;
            this.randomColorButton2.Text = "randomColorButton2";
            this.randomColorButton2.UseVisualStyleBackColor = true;
            // 
            // randomColorButton1
            // 
            this.randomColorButton1.Location = new System.Drawing.Point(207, 247);
            this.randomColorButton1.Name = "randomColorButton1";
            this.randomColorButton1.Size = new System.Drawing.Size(255, 54);
            this.randomColorButton1.TabIndex = 3;
            this.randomColorButton1.Text = "Random color button";
            this.randomColorButton1.UseVisualStyleBackColor = true;
            // 
            // defaultButton1
            // 
            this.defaultButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.defaultButton1.Location = new System.Drawing.Point(207, 187);
            this.defaultButton1.Name = "defaultButton1";
            this.defaultButton1.Size = new System.Drawing.Size(255, 54);
            this.defaultButton1.TabIndex = 2;
            this.defaultButton1.Text = "Open secondary form";
            this.defaultButton1.Click += new System.EventHandler(this.defaultButton1_Click);
            // 
            // resizeRandomColorButton1
            // 
            this.resizeRandomColorButton1.Location = new System.Drawing.Point(415, 49);
            this.resizeRandomColorButton1.Name = "resizeRandomColorButton1";
            this.resizeRandomColorButton1.Size = new System.Drawing.Size(203, 56);
            this.resizeRandomColorButton1.TabIndex = 6;
            this.resizeRandomColorButton1.Text = "resizeRandomColorButton1";
            this.resizeRandomColorButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 429);
            this.Controls.Add(this.resizeRandomColorButton1);
            this.Controls.Add(this.randomColorButton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.randomColorButton1);
            this.Controls.Add(this.defaultButton1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DefaultButton defaultButton1;
        private RandomColorButton randomColorButton1;
        private System.Windows.Forms.TextBox textBox1;
        private RandomColorButton randomColorButton2;
        private ResizeRandomColorButton resizeRandomColorButton1;
    }
}

