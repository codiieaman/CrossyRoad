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
    public partial class Level4 : Form
    {
        public Level4()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            car1.Left -= 20;
            if (car1.Left < -200)
            { car1.Left = 520; }

            car2.Left -= 20;
            if (car2.Left < -200)
            { car2.Left = 520; }

            car3.Left += 25;
            if (car3.Left > 520)
            { car3.Left = -220; }

            car4.Left -= 10;
            if (car4.Left < -200)
            { car4.Left = 520;}

            car5.Left -= 10;
            if (car5.Left < -200)
            { car5.Left = 520; }

            car6.Left += 5;
            if (car6.Left > 520)
            { car6.Left = -100; }

            bike1.Left += 8;
            if (bike1.Left > 520)
            { bike1.Left = -100; }

            bike2.Left += 8;
            if (bike2.Left > 520)
            { bike2.Left = -100; }

            bike3.Left += 5;
            if (bike3.Left > 520)
            { bike3.Left = -100; }

            if (frog.Top < 1)
            {
                timer1.Stop();
                MessageBox.Show("LEVEL COMPLETE", "ROAD CROSSING");
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

            else if (car4.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER");
                button2.Visible = true;
            }

            else if (car5.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

            else if (car6.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

            else if (bike1.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

            else if (bike2.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

            else if (bike3.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

        }


        //for Score & Frog Movement
        int count;
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            { frog.Top += 10;}
            else if (e.KeyCode == Keys.Up)
            { frog.Top -= 10;
            count += 5;
            label2.Text = count.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Level5 aaa = new Level5();
            aaa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Level4 playAgain = new Level4();
            playAgain.Show();
            this.Hide();
        }
    }
}
