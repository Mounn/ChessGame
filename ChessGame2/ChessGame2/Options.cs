using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Chess
{
    public partial class Options : Form
    {
        public SoundPlayer _soundPlayer;
        
        public Options()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Hotline.wav");
        }

        private void Options_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (duelStateButton.Checked)
            {
                duelStateButton.Text = "Stop";
                _soundPlayer.Play();
                _soundPlayer.PlayLooping();
            }
            else
            {
                duelStateButton.Text = "Play";
                _soundPlayer.Stop();
            }
        }

     }
}
