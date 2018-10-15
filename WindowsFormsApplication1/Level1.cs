using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Level1 : Form
    {
        public Level1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            car1.Left -= 10;
            if (car1.Left < -100)
            {
                car1.Left = 550;
            }


            car2.Left += 5;
            if (car2.Left > 550)
            {
                car2.Left = -100;
            }

            car3.Left += 5;
            if (car3.Left > 550)
            {
                car3.Left = -100;
            }

            if (frog.Top < 1 )
            {
                timer1.Stop();
                MessageBox.Show("LEVEL COMPLETE","ROAD CROSSING");
                button1.Visible = true;
                button2.Visible = true;
            }

            //Collison Picture Box

            if (car1.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

            else if (car2.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

            else if (car3.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //for Score & Frog Movement
        int count;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Down)
            {frog.Top += 10;}
            else if (e.KeyCode == Keys.Up)
            { frog.Top -= 10;
            count += 5;
            label2.Text = count.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level2 aaa = new Level2();
            aaa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Level1 playAgain = new Level1();
            playAgain.Show();
            this.Hide();
        }

        private void frog_Click(object sender, EventArgs e)
        {
            if (car1.Bounds.IntersectsWith(frog.Bounds))
            {
                MessageBox.Show("GAME OVER" , "ROAD CROSSING");
            }
        }

      
    }
}
