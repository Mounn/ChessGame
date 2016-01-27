namespace Chess
{
    partial class Options
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
            this.duelStateButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // duelStateButton
            // 
            this.duelStateButton.AutoSize = true;
            this.duelStateButton.Location = new System.Drawing.Point(40, 39);
            this.duelStateButton.Name = "duelStateButton";
            this.duelStateButton.Size = new System.Drawing.Size(77, 17);
            this.duelStateButton.TabIndex = 0;
            this.duelStateButton.Text = "Play Music";
            this.duelStateButton.UseVisualStyleBackColor = true;
            this.duelStateButton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.duelStateButton);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox duelStateButton;



    }
}