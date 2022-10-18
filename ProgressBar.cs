using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class ProgressBar : Form
    {
        int startpoint = 0;
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint++;
            bunifuCircleProgressbar1.Value = startpoint;
            if(bunifuCircleProgressbar1.Value==100)
            {
                bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }

        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
