namespace CustomButtons
{
    partial class SecondaryForm
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
            this.defaultButton1 = new CustomButtons.DefaultButton();
            this.SuspendLayout();
            // 
            // defaultButton1
            // 
            this.defaultButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.defaultButton1.Location = new System.Drawing.Point(181, 125);
            this.defaultButton1.Name = "defaultButton1";
            this.defaultButton1.Size = new System.Drawing.Size(161, 46);
            this.defaultButton1.TabIndex = 0;
            this.defaultButton1.Text = "defaultButton1";
            // 
            // SecondaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 291);
            this.Controls.Add(this.defaultButton1);
            this.Name = "SecondaryForm";
            this.Text = "Secondary";
            this.ResumeLayout(false);

        }

        #endregion

        private DefaultButton defaultButton1;
    }
}