namespace WindowsFormsApplication1
{
    partial class Level2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car4 = new System.Windows.Forms.PictureBox();
            this.frog = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).BeginInit();
            this.SuspendLayout();
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = ((System.Drawing.Image)(resources.GetObject("car1.Image")));
            this.car1.Location = new System.Drawing.Point(1, 85);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(87, 40);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 0;
            this.car1.TabStop = false;
            // 
            // car3
            // 
            this.car3.BackColor = System.Drawing.Color.Transparent;
            this.car3.Image = ((System.Drawing.Image)(resources.GetObject("car3.Image")));
            this.car3.Location = new System.Drawing.Point(333, 224);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(87, 40);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car3.TabIndex = 1;
            this.car3.TabStop = false;
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.Image = ((System.Drawing.Image)(resources.GetObject("car2.Image")));
            this.car2.Location = new System.Drawing.Point(427, 128);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(89, 40);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 2;
            this.car2.TabStop = false;
            this.car2.Click += new System.EventHandler(this.car2_Click);
            // 
            // car4
            // 
            this.car4.BackColor = System.Drawing.Color.Transparent;
            this.car4.Image = ((System.Drawing.Image)(resources.GetObject("car4.Image")));
            this.car4.Location = new System.Drawing.Point(40, 273);
            this.car4.Name = "car4";
            this.car4.Size = new System.Drawing.Size(86, 40);
            this.car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car4.TabIndex = 3;
            this.car4.TabStop = false;
            // 
            // frog
            // 
            this.frog.BackColor = System.Drawing.Color.Transparent;
            this.frog.Image = ((System.Drawing.Image)(resources.GetObject("frog.Image")));
            this.frog.Location = new System.Drawing.Point(239, 375);
            this.frog.Name = "frog";
            this.frog.Size = new System.Drawing.Size(37, 40);
            this.frog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frog.TabIndex = 4;
            this.frog.TabStop = false;
            this.frog.Click += new System.EventHandler(this.frog_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(406, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "NEXT LEVEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(20, 357);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "PLAY AGAIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Score :";
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(504, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.frog);
            this.Controls.Add(this.car4);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Level2";
            this.Text = "LEVEL 2";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car4;
        private System.Windows.Forms.PictureBox frog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}