
namespace projekt
{
    partial class Options
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.back_to_menu = new System.Windows.Forms.PictureBox();
            this.panel_options = new System.Windows.Forms.Panel();
            this.picture_r = new System.Windows.Forms.PictureBox();
            this.picture_l = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.PictureBox();
            this.soundx = new System.Windows.Forms.PictureBox();
            this.sound = new System.Windows.Forms.PictureBox();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.button_start = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_help = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_menu)).BeginInit();
            this.panel_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_l)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).BeginInit();
            this.panel_help.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // back_to_menu
            // 
            this.back_to_menu.BackColor = System.Drawing.Color.Transparent;
            this.back_to_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_to_menu.BackgroundImage")));
            this.back_to_menu.Location = new System.Drawing.Point(12, 12);
            this.back_to_menu.Name = "back_to_menu";
            this.back_to_menu.Size = new System.Drawing.Size(65, 66);
            this.back_to_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back_to_menu.TabIndex = 24;
            this.back_to_menu.TabStop = false;
            this.back_to_menu.Click += new System.EventHandler(this.back_to_menu_Click);
            // 
            // panel_options
            // 
            this.panel_options.BackColor = System.Drawing.SystemColors.Control;
            this.panel_options.Controls.Add(this.picture_r);
            this.panel_options.Controls.Add(this.picture_l);
            this.panel_options.Controls.Add(this.help);
            this.panel_options.Controls.Add(this.soundx);
            this.panel_options.Controls.Add(this.sound);
            this.panel_options.Controls.Add(this.button_WOC2);
            this.panel_options.Controls.Add(this.button_WOC1);
            this.panel_options.Controls.Add(this.button_start);
            this.panel_options.Controls.Add(this.label1);
            this.panel_options.Location = new System.Drawing.Point(255, 95);
            this.panel_options.Name = "panel_options";
            this.panel_options.Size = new System.Drawing.Size(453, 455);
            this.panel_options.TabIndex = 25;
            // 
            // picture_r
            // 
            this.picture_r.BackColor = System.Drawing.Color.Transparent;
            this.picture_r.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_r.BackgroundImage")));
            this.picture_r.Location = new System.Drawing.Point(246, 240);
            this.picture_r.Name = "picture_r";
            this.picture_r.Size = new System.Drawing.Size(100, 43);
            this.picture_r.TabIndex = 16;
            this.picture_r.TabStop = false;
            this.picture_r.Visible = false;
            this.picture_r.Click += new System.EventHandler(this.picture_r_Click);
            // 
            // picture_l
            // 
            this.picture_l.BackColor = System.Drawing.Color.Transparent;
            this.picture_l.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_l.BackgroundImage")));
            this.picture_l.Location = new System.Drawing.Point(246, 240);
            this.picture_l.Name = "picture_l";
            this.picture_l.Size = new System.Drawing.Size(100, 43);
            this.picture_l.TabIndex = 15;
            this.picture_l.TabStop = false;
            this.picture_l.Click += new System.EventHandler(this.picture_l_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help.BackgroundImage")));
            this.help.Location = new System.Drawing.Point(260, 302);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(70, 70);
            this.help.TabIndex = 14;
            this.help.TabStop = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // soundx
            // 
            this.soundx.BackColor = System.Drawing.Color.Transparent;
            this.soundx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundx.BackgroundImage")));
            this.soundx.Location = new System.Drawing.Point(261, 145);
            this.soundx.Name = "soundx";
            this.soundx.Size = new System.Drawing.Size(69, 70);
            this.soundx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.soundx.TabIndex = 13;
            this.soundx.TabStop = false;
            this.soundx.Visible = false;
            this.soundx.Click += new System.EventHandler(this.soundx_Click);
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.Color.Transparent;
            this.sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound.BackgroundImage")));
            this.sound.Location = new System.Drawing.Point(261, 145);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(69, 70);
            this.sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sound.TabIndex = 12;
            this.sound.TabStop = false;
            this.sound.Click += new System.EventHandler(this.sound_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_WOC2.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_WOC2.Enabled = false;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button_WOC2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_WOC2.Location = new System.Drawing.Point(50, 309);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC2.Size = new System.Drawing.Size(168, 63);
            this.button_WOC2.TabIndex = 11;
            this.button_WOC2.Text = "Pomoc";
            this.button_WOC2.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.button_WOC2.UseVisualStyleBackColor = false;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_WOC1.Enabled = false;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_WOC1.Location = new System.Drawing.Point(50, 230);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_WOC1.Size = new System.Drawing.Size(168, 63);
            this.button_WOC1.TabIndex = 10;
            this.button_WOC1.Text = "Motyw";
            this.button_WOC1.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.button_WOC1.UseVisualStyleBackColor = false;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Transparent;
            this.button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_start.BorderColor = System.Drawing.Color.Transparent;
            this.button_start.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_start.Enabled = false;
            this.button_start.FlatAppearance.BorderSize = 0;
            this.button_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.button_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button_start.Location = new System.Drawing.Point(50, 152);
            this.button_start.Name = "button_start";
            this.button_start.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_start.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.button_start.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.button_start.Size = new System.Drawing.Size(168, 63);
            this.button_start.TabIndex = 8;
            this.button_start.Text = "Muzyka";
            this.button_start.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.button_start.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "         Opcje         ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_help
            // 
            this.panel_help.BackColor = System.Drawing.SystemColors.Control;
            this.panel_help.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_help.BackgroundImage")));
            this.panel_help.Controls.Add(this.close);
            this.panel_help.Location = new System.Drawing.Point(255, 95);
            this.panel_help.Name = "panel_help";
            this.panel_help.Size = new System.Drawing.Size(453, 455);
            this.panel_help.TabIndex = 26;
            this.panel_help.Visible = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.Location = new System.Drawing.Point(415, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 35);
            this.close.TabIndex = 96;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panel_help);
            this.Controls.Add(this.panel_options);
            this.Controls.Add(this.back_to_menu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.back_to_menu)).EndInit();
            this.panel_options.ResumeLayout(false);
            this.panel_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_l)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound)).EndInit();
            this.panel_help.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox back_to_menu;
        private System.Windows.Forms.Panel panel_options;
        private ePOSOne.btnProduct.Button_WOC button_start;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.PictureBox sound;
        private System.Windows.Forms.PictureBox soundx;
        private System.Windows.Forms.PictureBox picture_r;
        private System.Windows.Forms.PictureBox picture_l;
        private System.Windows.Forms.PictureBox help;
        private System.Windows.Forms.Panel panel_help;
        private System.Windows.Forms.PictureBox close;
    }
}