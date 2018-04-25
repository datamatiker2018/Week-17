namespace WinFormListBoxExample
{
    partial class ListBoxExample
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.displayCustomerDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 25);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(231, 147);
            this.listBox.TabIndex = 0;
            // 
            // displayCustomerDataButton
            // 
            this.displayCustomerDataButton.Location = new System.Drawing.Point(60, 178);
            this.displayCustomerDataButton.Name = "displayCustomerDataButton";
            this.displayCustomerDataButton.Size = new System.Drawing.Size(125, 38);
            this.displayCustomerDataButton.TabIndex = 1;
            this.displayCustomerDataButton.Text = "Display customer data";
            this.displayCustomerDataButton.UseVisualStyleBackColor = true;
            this.displayCustomerDataButton.Click += new System.EventHandler(this.displayCustomerDataButton_Click);
            // 
            // ListBoxExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 372);
            this.Controls.Add(this.displayCustomerDataButton);
            this.Controls.Add(this.listBox);
            this.Name = "ListBoxExample";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button displayCustomerDataButton;
    }
}

