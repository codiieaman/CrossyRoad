namespace WindowsFormsApplication1
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.frog = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            this.SuspendLayout();
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = ((System.Drawing.Image)(resources.GetObject("car1.Image")));
            this.car1.Location = new System.Drawing.Point(391, 89);
            this.car1.Margin = new System.Windows.Forms.Padding(2);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(121, 72);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 0;
            this.car1.TabStop = false;
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.Image = ((System.Drawing.Image)(resources.GetObject("car2.Image")));
            this.car2.Location = new System.Drawing.Point(-17, 230);
            this.car2.Margin = new System.Windows.Forms.Padding(2);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(121, 73);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 1;
            this.car2.TabStop = false;
            // 
            // frog
            // 
            this.frog.BackColor = System.Drawing.Color.Transparent;
            this.frog.Image = ((System.Drawing.Image)(resources.GetObject("frog.Image")));
            this.frog.Location = new System.Drawing.Point(237, 369);
            this.frog.Margin = new System.Windows.Forms.Padding(2);
            this.frog.Name = "frog";
            this.frog.Size = new System.Drawing.Size(46, 52);
            this.frog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frog.TabIndex = 2;
            this.frog.TabStop = false;
            this.frog.Click += new System.EventHandler(this.frog_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car3
            // 
            this.car3.BackColor = System.Drawing.Color.Transparent;
            this.car3.Image = ((System.Drawing.Image)(resources.GetObject("car3.Image")));
            this.car3.Location = new System.Drawing.Point(300, 230);
            this.car3.Margin = new System.Windows.Forms.Padding(2);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(121, 73);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car3.TabIndex = 7;
            this.car3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(406, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "NEXT LEVEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "PLAY AGAIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Score :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 11;
            // 
            // Level1
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
            this.Controls.Add(this.car3);
            this.Controls.Add(this.frog);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bernard MT Condensed", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Level1";
            this.Text = "LEVEL 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox frog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

