using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class mainMenu : Form
    {
       
        public mainMenu()
        {
            InitializeComponent();

            lblName.Text = Login.Current_User;
            lblHighScore.Text = Login.Current_HighScore;

        }


        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }


        private void mainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void creditBtn_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
