using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picAnimation = 0;
        }  
             
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            
        }
              
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button_1_Click(object sender, EventArgs e)
        {

        }

        private void button_2_Click(object sender, EventArgs e)
        {

        }
        private void button_3_Click(object sender, EventArgs e)
        {

        }

        private void button_4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picAnimation == 0)
            {
                this.pictureBox2.Load(".\\..\\..\\picture\\fog1.png");
               
            }
            else if (picAnimation == 1)
            {
                this.pictureBox2.Load(".\\..\\..\\picture\\fog2.png");
            }
            
            picAnimation++;

            if (picAnimation == 3)
            {
                picAnimation = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
