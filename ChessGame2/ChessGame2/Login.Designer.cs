namespace Chess
{
    partial class Login
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
            this.lblGebruikersNaam = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.txtGebruikersNaam = new System.Windows.Forms.TextBox();
            this.txtWachtwoord = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistreren = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblGebruikersNaam
            // 
            this.lblGebruikersNaam.AutoSize = true;
            this.lblGebruikersNaam.Location = new System.Drawing.Point(30, 25);
            this.lblGebruikersNaam.Name = "lblGebruikersNaam";
            this.lblGebruikersNaam.Size = new System.Drawing.Size(87, 13);
            this.lblGebruikersNaam.TabIndex = 0;
            this.lblGebruikersNaam.Text = "Gebruikersnaam:";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(30, 52);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(71, 13);
            this.lblWachtwoord.TabIndex = 1;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // txtGebruikersNaam
            // 
            this.txtGebruikersNaam.Location = new System.Drawing.Point(134, 22);
            this.txtGebruikersNaam.Name = "txtGebruikersNaam";
            this.txtGebruikersNaam.Size = new System.Drawing.Size(100, 20);
            this.txtGebruikersNaam.TabIndex = 2;
            // 
            // txtWachtwoord
            // 
            this.txtWachtwoord.Location = new System.Drawing.Point(134, 49);
            this.txtWachtwoord.Name = "txtWachtwoord";
            this.txtWachtwoord.PasswordChar = '*';
            this.txtWachtwoord.Size = new System.Drawing.Size(100, 20);
            this.txtWachtwoord.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(134, 103);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistreren
            // 
            this.btnRegistreren.Location = new System.Drawing.Point(134, 132);
            this.btnRegistreren.Name = "btnRegistreren";
            this.btnRegistreren.Size = new System.Drawing.Size(75, 23);
            this.btnRegistreren.TabIndex = 5;
            this.btnRegistreren.Text = "Registreren";
            this.btnRegistreren.UseVisualStyleBackColor = true;
            this.btnRegistreren.Click += new System.EventHandler(this.btnRegistreren_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRegistreren);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtWachtwoord);
            this.Controls.Add(this.txtGebruikersNaam);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblGebruikersNaam);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGebruikersNaam;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.TextBox txtGebruikersNaam;
        private System.Windows.Forms.TextBox txtWachtwoord;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistreren;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}