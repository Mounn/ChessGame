namespace Chess
{
    partial class Registreren
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtregstrGebruikersNaam = new System.Windows.Forms.TextBox();
            this.txtregstrWachtwoord = new System.Windows.Forms.TextBox();
            this.txtregstrWachtwoord2 = new System.Windows.Forms.TextBox();
            this.btnMaakAan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password:";
            // 
            // txtregstrGebruikersNaam
            // 
            this.txtregstrGebruikersNaam.Location = new System.Drawing.Point(133, 17);
            this.txtregstrGebruikersNaam.Name = "txtregstrGebruikersNaam";
            this.txtregstrGebruikersNaam.Size = new System.Drawing.Size(100, 20);
            this.txtregstrGebruikersNaam.TabIndex = 3;
            // 
            // txtregstrWachtwoord
            // 
            this.txtregstrWachtwoord.Location = new System.Drawing.Point(133, 46);
            this.txtregstrWachtwoord.Name = "txtregstrWachtwoord";
            this.txtregstrWachtwoord.PasswordChar = '*';
            this.txtregstrWachtwoord.Size = new System.Drawing.Size(100, 20);
            this.txtregstrWachtwoord.TabIndex = 4;
            // 
            // txtregstrWachtwoord2
            // 
            this.txtregstrWachtwoord2.Location = new System.Drawing.Point(133, 75);
            this.txtregstrWachtwoord2.Name = "txtregstrWachtwoord2";
            this.txtregstrWachtwoord2.PasswordChar = '*';
            this.txtregstrWachtwoord2.Size = new System.Drawing.Size(100, 20);
            this.txtregstrWachtwoord2.TabIndex = 5;
            // 
            // btnMaakAan
            // 
            this.btnMaakAan.Location = new System.Drawing.Point(133, 123);
            this.btnMaakAan.Name = "btnMaakAan";
            this.btnMaakAan.Size = new System.Drawing.Size(75, 23);
            this.btnMaakAan.TabIndex = 6;
            this.btnMaakAan.Text = "Register";
            this.btnMaakAan.UseVisualStyleBackColor = true;
            this.btnMaakAan.Click += new System.EventHandler(this.btnMaakAan_Click);
            // 
            // Registreren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMaakAan);
            this.Controls.Add(this.txtregstrWachtwoord2);
            this.Controls.Add(this.txtregstrWachtwoord);
            this.Controls.Add(this.txtregstrGebruikersNaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registreren";
            this.Text = "Registreren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtregstrGebruikersNaam;
        private System.Windows.Forms.TextBox txtregstrWachtwoord;
        private System.Windows.Forms.TextBox txtregstrWachtwoord2;
        private System.Windows.Forms.Button btnMaakAan;
    }
}