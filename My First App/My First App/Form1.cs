using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer didNaatHitHer = new System.Media.SoundPlayer(@"C:\Users\niccy\Dropbox\nico\C#\COMPX101\Week2\Introduction to Visual Studio\Project 1\My First App\I did not hit her.wav");
            didNaatHitHer.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBox1.CreateGraphics();

            Pen pen1 = new Pen(Color.Blue, 2);

            System.Media.SoundPlayer ohHiMark = new System.Media.SoundPlayer(@"C:\Users\niccy\Dropbox\nico\C#\COMPX101\Week2\Introduction to Visual Studio\Project 1\My First App\Oh, hi Mark.wav");
            ohHiMark.Play();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
