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
    public partial class Level5 : Form
    {
        public Level5()
        {
            InitializeComponent();
            timer1.Start();
        }


        //for Score & Frog Movement
        int count;
        private void Level5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            { frog.Top += 10; }

            else if (e.KeyCode == Keys.Up)
            { frog.Top -= 10;
            count += 5;
            label2.Text = count.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            car1.Left -= 25;
            if (car1.Left < -200)
            { car1.Left = 520; }

            car2.Left -= 25;
            if (car2.Left < -200)
            { car2.Left = 520; }

            car3.Left -= 25;
            if (car3.Left < -200)
            { car3.Left = 520; }

            b1.Left += 20;
            if (b1.Left > 520)
            { b1.Left = -100; }

            b2.Left += 20;
            if (b2.Left > 520)
            { b2.Left = -100; }

            b3.Left += 12;
            if (b3.Left > 520)
            { b3.Left = -100; }

            b4.Left += 12;
            if (b4.Left > 520)
            { b4.Left = -100; }

            car4.Left += 12;
            if (car4.Left > 520)
            { car4.Left = -100; }

            car5.Left -= 80;
            if (car5.Left < -500)
            { car5.Left = 520; }

            bike1.Left += 10;
            if (bike1.Left > 520)
            { bike1.Left = -100; }

            bike2.Left += 10;
            if (bike2.Left > 520)
            { bike2.Left = -100; }

            bike3.Left += 10;
            if (bike3.Left > 520)
            { bike3.Left = -100; }

            bike4.Left += 10;
            if (bike4.Left > 520)
            { bike4.Left = -100; }

            car6.Left -= 5;
            if (car6.Left < -200)
            { car6.Left = 520; }

            car7.Left -= 5;
            if (car7.Left < -200)
            { car7.Left = 520; }

            car8.Left -= 5;
            if (car8.Left < -200)
            { car8.Left = 520; }

            car9.Left -= 5;
            if (car9.Left < -200)
            { car9.Left = 520; }

            if (frog.Top < 1)
            {
                timer1.Stop();
                MessageBox.Show("ALL LEVELS COMPLETE", "ROAD CROSSING");
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
                MessageBox.Show("GAME OVER", "ROAD CROSSING"); ;
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

            else if (car7.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

            else if (car8.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING"); ;
                button2.Visible = true;
            }

            else if (car9.Bounds.IntersectsWith(frog.Bounds))
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

            else if (bike4.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

            else if (b1.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER");
                button2.Visible = true;
            }

            else if (b2.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

            else if (b3.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

            else if (b4.Bounds.IntersectsWith(frog.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GAME OVER", "ROAD CROSSING");
                button2.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Level5 playAgain = new Level5();
            playAgain.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main aaa = new Main();
            aaa.Show();
            this.Hide();
        }

        
    }
}
