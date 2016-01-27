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
using System.Media;

namespace Chess
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            
        }
        
        public static string Current_User;
        public static string Current_HighScore;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //connectie met de database
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand userExist = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = @Username", con))
                using (SqlCommand checkWw = new SqlCommand("SELECT Password  FROM [User] WHERE Username = @Username", con))
                using (SqlCommand userName = new SqlCommand("SELECT Username  FROM [User] WHERE Username = @Username", con))
                using (SqlCommand userHighScore = new SqlCommand("SELECT Highscore  FROM [User] WHERE Username = @Username", con))
                {
                    int count;
                    string wachtwoord;

                    userExist.Parameters.AddWithValue("@Username", this.txtGebruikersNaam.Text);
                    checkWw.Parameters.AddWithValue("@Username", this.txtGebruikersNaam.Text);
                    userName.Parameters.AddWithValue("@Username", this.txtGebruikersNaam.Text);
                    userHighScore.Parameters.AddWithValue("@Username", this.txtGebruikersNaam.Text);
                    
                    string hashInput = GetMD5Hash(txtWachtwoord.Text);
                    
                    con.Open();
                    count = (Int32)userExist.ExecuteScalar();
                    wachtwoord = (string)checkWw.ExecuteScalar();
                    con.Close();
                    
                    if (count > 0 && string.Equals(hashInput, wachtwoord))
                    {
                        
                        con.Open();
                        using (var reader = userName.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                var temp = reader["Username"];
                                if (temp != DBNull.Value)
                                {
                                    Current_User = reader["Username"].ToString();
                                    mainMenu mainmenu = new mainMenu();
                                     this.Hide();
                                }
                            }
                        }
                        con.Close();

                        con.Open();
                        using (var reader = userHighScore.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                var temp = reader["Highscore"];
                                if (temp != DBNull.Value)
                                {
                                    Current_HighScore = reader["Highscore"].ToString();
                                    mainMenu mainmenu = new mainMenu();
                                    mainmenu.Show();
                                    this.Hide();

                                }
                            }
                        }
                        con.Close();
                        
                    }
                        
                    else
                    {
                        MessageBox.Show("Gebruikersnaam/Wachtwoord is incorrect");
                        this.txtWachtwoord.Text = "";
                        this.txtGebruikersNaam.Focus();
                    }
                }

            }
        }
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

             private void btnRegistreren_Click(object sender, EventArgs e)
             {
                 Registreren registreren = new Registreren();
                 registreren.Show();
             }

       }
}
