namespace projekt
{    partial class mainMenu
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.z = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_options = new ePOSOne.btnProduct.Button_WOC();
            this.button_scores = new ePOSOne.btnProduct.Button_WOC();
            this.button_start = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.autobus_biel = new System.Windows.Forms.PictureBox();
            this.autobus1 = new System.Windows.Forms.PictureBox();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobus_biel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobus1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.SystemColors.Control;
            this.panel_menu.Controls.Add(this.z);
            this.panel_menu.Controls.Add(this.label2);
            this.panel_menu.Controls.Add(this.button_options);
            this.panel_menu.Controls.Add(this.button_scores);
            this.panel_menu.Controls.Add(this.button_start);
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Location = new System.Drawing.Point(255, 95);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(453, 455);
            this.panel_menu.TabIndex = 8;
            // 
            // z
            // 
            this.z.BackColor = System.Drawing.Color.Transparent;
            this.z.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("z.BackgroundImage")));
            this.z.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.z.Location = new System.Drawing.Point(197, 64);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(31, 47);
            this.z.TabIndex = 10;
            this.z.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(200, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 40);
            this.label2.TabIndex = 11;
            this.label2.Text = ".\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // button_options
            // 
            this.button_options.BackColor = System.Drawing.Color.Transparent;
            this.button_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_options.BorderColor = System.Drawing.Color.Transparent;
            this.button_options.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_options.FlatAppearance.BorderSize = 0;
            this.button_options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button_options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.button_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_options.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_options.ForeColor = System.Drawing.Color.Transparent;
            this.button_options.Location = new System.Drawing.Point(122, 323);
            this.button_options.Name = "button_options";
            this.button_options.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_options.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_options.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_options.Size = new System.Drawing.Size(223, 77);
            this.button_options.TabIndex = 6;
            this.button_options.Text = "Opcje";
            this.button_options.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.button_options.UseVisualStyleBackColor = false;
            this.button_options.Click += new System.EventHandler(this.button_options_Click);
            // 
            // button_scores
            // 
            this.button_scores.BackColor = System.Drawing.Color.Transparent;
            this.button_scores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_scores.BorderColor = System.Drawing.Color.Transparent;
            this.button_scores.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_scores.FlatAppearance.BorderSize = 0;
            this.button_scores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button_scores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.button_scores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scores.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scores.ForeColor = System.Drawing.Color.Transparent;
            this.button_scores.Location = new System.Drawing.Point(122, 240);
            this.button_scores.Name = "button_scores";
            this.button_scores.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_scores.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_scores.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_scores.Size = new System.Drawing.Size(223, 77);
            this.button_scores.TabIndex = 9;
            this.button_scores.Text = "Wyniki";
            this.button_scores.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.button_scores.UseVisualStyleBackColor = false;
            this.button_scores.Click += new System.EventHandler(this.button_scores_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Transparent;
            this.button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_start.BorderColor = System.Drawing.Color.Transparent;
            this.button_start.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_start.FlatAppearance.BorderSize = 0;
            this.button_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.Color.Transparent;
            this.button_start.Location = new System.Drawing.Point(122, 157);
            this.button_start.Name = "button_start";
            this.button_start.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_start.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_start.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_start.Size = new System.Drawing.Size(223, 77);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "Start";
            this.button_start.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "Podróz po PG!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(-41, 540);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 103);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // autobus_biel
            // 
            this.autobus_biel.BackColor = System.Drawing.Color.Transparent;
            this.autobus_biel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("autobus_biel.BackgroundImage")));
            this.autobus_biel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.autobus_biel.Location = new System.Drawing.Point(65, 438);
            this.autobus_biel.Name = "autobus_biel";
            this.autobus_biel.Size = new System.Drawing.Size(306, 232);
            this.autobus_biel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.autobus_biel.TabIndex = 11;
            this.autobus_biel.TabStop = false;
            this.autobus_biel.Visible = false;
            // 
            // autobus1
            // 
            this.autobus1.BackColor = System.Drawing.Color.Transparent;
            this.autobus1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("autobus1.BackgroundImage")));
            this.autobus1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.autobus1.Location = new System.Drawing.Point(77, 457);
            this.autobus1.Name = "autobus1";
            this.autobus1.Size = new System.Drawing.Size(300, 221);
            this.autobus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.autobus1.TabIndex = 12;
            this.autobus1.TabStop = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.autobus1);
            this.Controls.Add(this.autobus_biel);
            this.Controls.Add(this.panel_menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.mainMenu_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobus_biel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobus1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC button_options;
        private System.Windows.Forms.Panel panel_menu;
        private ePOSOne.btnProduct.Button_WOC button_scores;
        private ePOSOne.btnProduct.Button_WOC button_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox z;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox autobus_biel;
        private System.Windows.Forms.PictureBox autobus1;
    }
}

