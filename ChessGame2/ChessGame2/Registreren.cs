using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Registreren : Form
    {
        
       
        public Registreren()
        {
            InitializeComponent();
        }

        private void btnMaakAan_Click(object sender, EventArgs e)
        {
            string regUserName;

            try
            {
                //connectie database
                string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                using (SqlCommand create = new SqlCommand("INSERT into [User] (Username, Password) VALUES(@Username, @Password)", con))
                using (SqlCommand check_User = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = @Username", con))

                    if (!(txtregstrGebruikersNaam.Text == string.Empty))
                    {
                        if (!(txtregstrWachtwoord.Text == string.Empty))
                        {
                            // check of de user bestaat
                            con.Open();
                            check_User.Parameters.AddWithValue("@Username", this.txtregstrGebruikersNaam.Text);
                            int UserExist = (int)check_User.ExecuteScalar();
                            con.Close();

                            // als de user niet bestaat 
                            if (UserExist < 1)
                            {
                                string hashInput = GetMD5Hash(txtregstrWachtwoord.Text);
                                create.Parameters.AddWithValue("@Username", this.txtregstrGebruikersNaam.Text);
                                create.Parameters.AddWithValue("@Password", hashInput);
                                con.Open();
                                regUserName = (string)create.ExecuteScalar();
                                con.Close();

                                MessageBox.Show("Je account is succesvol aagemaakt!");

                                this.Close();

                            }
                            else if (txtregstrWachtwoord.Text != txtregstrWachtwoord2.Text)
                            {
                                MessageBox.Show("Wachtwoorden onjuist");
                            }
                            else
                            {
                                MessageBox.Show("Gebruikersnaam is al in gebruik");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vul Wachtwoord in");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vul gerbruikersnaam in");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Je gegevens zijn incorrect of al in gebruik probeer het opnieuw");
            }
        }

        //functie hashen    
        public static String GetMD5Hash(String TextToHash)
            {

                //Check wether data was passed

                if ((TextToHash == null) || (TextToHash.Length == 0))
                {
                    return String.Empty;
                }

                //Calculate MD5 hash. This requires that the string is splitted into a byte[].
                MD5 md5 = new MD5CryptoServiceProvider();

                byte[] textToHash = Encoding.Default.GetBytes(TextToHash);

                byte[] result = md5.ComputeHash(textToHash);

                //Convert result back to string.
                return System.BitConverter.ToString(result);

            }
    
        
    }
}
