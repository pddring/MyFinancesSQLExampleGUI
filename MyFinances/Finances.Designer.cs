namespace MyFinances
{
    partial class Finances
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
            this.lstFinances = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstFinances
            // 
            this.lstFinances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFinances.FormattingEnabled = true;
            this.lstFinances.Location = new System.Drawing.Point(0, 0);
            this.lstFinances.Name = "lstFinances";
            this.lstFinances.Size = new System.Drawing.Size(604, 450);
            this.lstFinances.TabIndex = 0;
            // 
            // Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.lstFinances);
            this.Name = "Finances";
            this.Text = "Finances";
            this.Load += new System.EventHandler(this.Finances_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFinances;
    }
}