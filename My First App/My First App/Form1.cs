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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBox1.CreateGraphics();

            Pen pen1 = new Pen(Color.Blue, 2);




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
