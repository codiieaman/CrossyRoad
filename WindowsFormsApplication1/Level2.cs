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
    public partial class Level2 : Form
    {
        public Level2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void frog_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            car1.Left += 20; ;
            if (car1.Left > 520)
            {car1.Left = -85;}

            car2.Left -= 15;
            if (car2.Left < -150)
            { car2.Left = 520; }

            car3.Left += 8;
            if (car3.Left > 520)
            { car3.Left = -100; }

            car4.Left -= 10;
            if (car4.Left < -60)
            { car4.Left = 520; }

            if (frog.Top < 1)
            {
                timer1.Stop();
                MessageBox.Show("LEVEL COMPLETE" , "ROAD CROSSING");
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
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

        }

        private void car2_Click(object sender, EventArgs e)
        {

        }


        //for Score & Frog Movement
        int count;
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                frog.Top -= 10; count += 5;
                label2.Text = count.ToString();
            }

            else if (e.KeyCode == Keys.Down)
            { frog.Top += 10; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level3 aaa = new Level3();
            aaa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Level2 playAgain = new Level2();
            playAgain.Show();
            this.Hide();
        }   
    }
}
