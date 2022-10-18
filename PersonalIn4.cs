using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class PersonalIn4 : Form
    {
        SoundPlayer soundpl = new SoundPlayer(@"D:\Downloads\LaLaLaxTremor_Drop.wav");
        public PersonalIn4()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            soundpl.Stop();
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void PersonalIn4_Load(object sender, EventArgs e)
        {   
            soundpl.Play();
        }

    }
}
