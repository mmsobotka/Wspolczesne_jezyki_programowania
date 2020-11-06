namespace projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.

        public int picAnimation;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_1 = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.button_3 = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_4 = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_2);
            this.panel1.Controls.Add(this.button_1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_3);
            this.panel1.Location = new System.Drawing.Point(255, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 455);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.Transparent;
            this.button_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_2.BorderColor = System.Drawing.Color.Transparent;
            this.button_2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_2.Location = new System.Drawing.Point(120, 242);
            this.button_2.Name = "button_2";
            this.button_2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_2.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_2.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_2.Size = new System.Drawing.Size(223, 77);
            this.button_2.TabIndex = 9;
            this.button_2.Text = "Wyniki";
            this.button_2.TextColor = System.Drawing.Color.Black;
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.Transparent;
            this.button_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_1.BorderColor = System.Drawing.Color.Transparent;
            this.button_1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_1.Location = new System.Drawing.Point(120, 145);
            this.button_1.Name = "button_1";
            this.button_1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_1.Size = new System.Drawing.Size(223, 77);
            this.button_1.TabIndex = 8;
            this.button_1.Text = "Start";
            this.button_1.TextColor = System.Drawing.Color.Black;
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 43F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 68);
            this.label1.TabIndex = 7;
            this.label1.Text = "Podróż po PG!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.Transparent;
            this.button_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_3.BorderColor = System.Drawing.Color.Transparent;
            this.button_3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_3.FlatAppearance.BorderSize = 0;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_3.Location = new System.Drawing.Point(120, 339);
            this.button_3.Name = "button_3";
            this.button_3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_3.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_3.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_3.Size = new System.Drawing.Size(223, 77);
            this.button_3.TabIndex = 6;
            this.button_3.Text = "Opcje";
            this.button_3.TextColor = System.Drawing.Color.Black;
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(74, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(-18, 566);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 103);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.Transparent;
            this.button_4.BorderColor = System.Drawing.Color.White;
            this.button_4.ButtonColor = System.Drawing.Color.OrangeRed;
            this.button_4.FlatAppearance.BorderSize = 0;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_4.Location = new System.Drawing.Point(872, 12);
            this.button_4.Name = "button_4";
            this.button_4.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_4.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_4.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_4.Size = new System.Drawing.Size(51, 48);
            this.button_4.TabIndex = 11;
            this.button_4.Text = "X";
            this.button_4.TextColor = System.Drawing.Color.White;
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC button_3;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC button_2;
        private ePOSOne.btnProduct.Button_WOC button_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ePOSOne.btnProduct.Button_WOC button_4;
        private System.Windows.Forms.Timer timer1;
    }
}

