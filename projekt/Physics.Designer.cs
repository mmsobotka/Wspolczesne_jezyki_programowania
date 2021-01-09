
namespace projekt
{
    partial class Physics
    {
        Map mainWindowMap;
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (Map.openedTasks > 0)
            {
                Map.openedTasks--;
            }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Physics));
            this.back_to_menu = new System.Windows.Forms.PictureBox();
            this.back_to_map = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboNumber = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.PictureBox();
            this.apple2Down = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.good = new System.Windows.Forms.PictureBox();
            this.bad = new System.Windows.Forms.PictureBox();
            this.button0 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_g = new System.Windows.Forms.Button();
            this.ans3 = new ePOSOne.btnProduct.Button_WOC();
            this.ans2 = new ePOSOne.btnProduct.Button_WOC();
            this.ans1 = new ePOSOne.btnProduct.Button_WOC();
            this.featherDown = new System.Windows.Forms.PictureBox();
            this.apple0Down = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.feather0 = new System.Windows.Forms.PictureBox();
            this.apple1 = new System.Windows.Forms.PictureBox();
            this.apple2 = new System.Windows.Forms.PictureBox();
            this.apple0 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.points = new ePOSOne.btnProduct.Button_WOC();
            this.label3 = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.apple1Down = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.help_physics = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.facts_physics = new System.Windows.Forms.Panel();
            this.close_facts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple2Down)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.good)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featherDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple0Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feather0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple1Down)).BeginInit();
            this.help_physics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.facts_physics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_facts)).BeginInit();
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
            // back_to_map
            // 
            this.back_to_map.BackColor = System.Drawing.Color.Transparent;
            this.back_to_map.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_to_map.BackgroundImage")));
            this.back_to_map.Location = new System.Drawing.Point(12, 84);
            this.back_to_map.Name = "back_to_map";
            this.back_to_map.Size = new System.Drawing.Size(65, 66);
            this.back_to_map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.back_to_map.TabIndex = 26;
            this.back_to_map.TabStop = false;
            this.back_to_map.Click += new System.EventHandler(this.back_to_map_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(796, 603);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(867, 603);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(111, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 62);
            this.panel2.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13F);
            this.label2.Location = new System.Drawing.Point(43, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wydział Fizyki Technicznej, Informatyki i Matematyki Stosowanej";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 13F);
            this.label1.Location = new System.Drawing.Point(318, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.comboNumber);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.apple2Down);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.featherDown);
            this.panel1.Controls.Add(this.apple0Down);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.feather0);
            this.panel1.Controls.Add(this.apple1);
            this.panel1.Controls.Add(this.apple2);
            this.panel1.Controls.Add(this.apple0);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.points);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bird);
            this.panel1.Controls.Add(this.apple1Down);
            this.panel1.Location = new System.Drawing.Point(155, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 520);
            this.panel1.TabIndex = 37;
            // 
            // comboNumber
            // 
            this.comboNumber.AutoSize = true;
            this.comboNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboNumber.Font = new System.Drawing.Font("Snap ITC", 16F);
            this.comboNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(222)))));
            this.comboNumber.Location = new System.Drawing.Point(170, 478);
            this.comboNumber.Name = "comboNumber";
            this.comboNumber.Size = new System.Drawing.Size(0, 29);
            this.comboNumber.TabIndex = 62;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.start.Location = new System.Drawing.Point(555, 445);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(65, 66);
            this.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.start.TabIndex = 81;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // apple2Down
            // 
            this.apple2Down.BackColor = System.Drawing.Color.Transparent;
            this.apple2Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apple2Down.BackgroundImage")));
            this.apple2Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.apple2Down.Location = new System.Drawing.Point(20, 362);
            this.apple2Down.Name = "apple2Down";
            this.apple2Down.Size = new System.Drawing.Size(40, 40);
            this.apple2Down.TabIndex = 80;
            this.apple2Down.TabStop = false;
            this.apple2Down.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.good);
            this.panel3.Controls.Add(this.bad);
            this.panel3.Controls.Add(this.button0);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button_g);
            this.panel3.Controls.Add(this.ans3);
            this.panel3.Controls.Add(this.ans2);
            this.panel3.Controls.Add(this.ans1);
            this.panel3.Location = new System.Drawing.Point(360, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 152);
            this.panel3.TabIndex = 78;
            this.panel3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F);
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 62;
            this.label5.Tag = "";
            this.label5.Text = "Znajdź poprawną\r\n wysokość [m]";
            // 
            // good
            // 
            this.good.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("good.BackgroundImage")));
            this.good.Location = new System.Drawing.Point(93, 119);
            this.good.Name = "good";
            this.good.Size = new System.Drawing.Size(28, 28);
            this.good.TabIndex = 61;
            this.good.TabStop = false;
            this.good.Visible = false;
            // 
            // bad
            // 
            this.bad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bad.BackgroundImage")));
            this.bad.Location = new System.Drawing.Point(93, 119);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(28, 28);
            this.bad.TabIndex = 57;
            this.bad.TabStop = false;
            this.bad.Visible = false;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.White;
            this.button0.Enabled = false;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.Location = new System.Drawing.Point(20, 90);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(93, 23);
            this.button0.TabIndex = 59;
            this.button0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button0.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(26, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 60;
            this.label7.Text = "g =";
            // 
            // button_g
            // 
            this.button_g.BackColor = System.Drawing.Color.White;
            this.button_g.Enabled = false;
            this.button_g.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_g.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_g.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_g.Location = new System.Drawing.Point(20, 52);
            this.button_g.Name = "button_g";
            this.button_g.Size = new System.Drawing.Size(93, 23);
            this.button_g.TabIndex = 58;
            this.button_g.Text = "10 m/s2";
            this.button_g.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_g.UseVisualStyleBackColor = false;
            // 
            // ans3
            // 
            this.ans3.BackColor = System.Drawing.Color.Transparent;
            this.ans3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ans3.BorderColor = System.Drawing.Color.Transparent;
            this.ans3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ans3.FlatAppearance.BorderSize = 0;
            this.ans3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.ans3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.ans3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ans3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ans3.ForeColor = System.Drawing.Color.Transparent;
            this.ans3.Location = new System.Drawing.Point(119, 108);
            this.ans3.Name = "ans3";
            this.ans3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ans3.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.ans3.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.ans3.Size = new System.Drawing.Size(69, 37);
            this.ans3.TabIndex = 57;
            this.ans3.Tag = "options1";
            this.ans3.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ans3.UseVisualStyleBackColor = false;
            this.ans3.Click += new System.EventHandler(this.ans3_Click);
            // 
            // ans2
            // 
            this.ans2.BackColor = System.Drawing.Color.Transparent;
            this.ans2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ans2.BorderColor = System.Drawing.Color.Transparent;
            this.ans2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ans2.FlatAppearance.BorderSize = 0;
            this.ans2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.ans2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.ans2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ans2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ans2.ForeColor = System.Drawing.Color.Transparent;
            this.ans2.Location = new System.Drawing.Point(119, 65);
            this.ans2.Name = "ans2";
            this.ans2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ans2.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.ans2.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.ans2.Size = new System.Drawing.Size(69, 37);
            this.ans2.TabIndex = 56;
            this.ans2.Tag = "options1";
            this.ans2.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ans2.UseVisualStyleBackColor = false;
            this.ans2.Click += new System.EventHandler(this.ans2_Click);
            // 
            // ans1
            // 
            this.ans1.BackColor = System.Drawing.Color.Transparent;
            this.ans1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ans1.BorderColor = System.Drawing.Color.Transparent;
            this.ans1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ans1.FlatAppearance.BorderSize = 0;
            this.ans1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.ans1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.ans1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ans1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ans1.ForeColor = System.Drawing.Color.Transparent;
            this.ans1.Location = new System.Drawing.Point(119, 22);
            this.ans1.Name = "ans1";
            this.ans1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.ans1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.ans1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.ans1.Size = new System.Drawing.Size(69, 37);
            this.ans1.TabIndex = 55;
            this.ans1.Tag = "options1";
            this.ans1.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ans1.UseVisualStyleBackColor = false;
            this.ans1.Click += new System.EventHandler(this.ans1_Click);
            // 
            // featherDown
            // 
            this.featherDown.BackColor = System.Drawing.Color.Transparent;
            this.featherDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("featherDown.BackgroundImage")));
            this.featherDown.Location = new System.Drawing.Point(278, 381);
            this.featherDown.Name = "featherDown";
            this.featherDown.Size = new System.Drawing.Size(40, 30);
            this.featherDown.TabIndex = 77;
            this.featherDown.TabStop = false;
            this.featherDown.Visible = false;
            // 
            // apple0Down
            // 
            this.apple0Down.BackColor = System.Drawing.Color.Transparent;
            this.apple0Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apple0Down.BackgroundImage")));
            this.apple0Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.apple0Down.Location = new System.Drawing.Point(128, 403);
            this.apple0Down.Name = "apple0Down";
            this.apple0Down.Size = new System.Drawing.Size(40, 40);
            this.apple0Down.TabIndex = 75;
            this.apple0Down.TabStop = false;
            this.apple0Down.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(17, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(581, 30);
            this.label4.TabIndex = 74;
            this.label4.Text = "Polecenie: Zaobserwuj spadek swobodny wybranego ciała. Znając jego czas spadania," +
    " \r\nzgadnij z jakiej wysokości spada (pomiń opór powietrza).\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(143, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 18);
            this.label6.TabIndex = 73;
            this.label6.Text = "RUCH JEDNOWYMIAROWY - SPADEK SWOBODNY";
            // 
            // feather0
            // 
            this.feather0.BackColor = System.Drawing.Color.Transparent;
            this.feather0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("feather0.BackgroundImage")));
            this.feather0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feather0.Location = new System.Drawing.Point(278, 174);
            this.feather0.Name = "feather0";
            this.feather0.Size = new System.Drawing.Size(40, 30);
            this.feather0.TabIndex = 55;
            this.feather0.TabStop = false;
            this.feather0.Visible = false;
            // 
            // apple1
            // 
            this.apple1.BackColor = System.Drawing.Color.Transparent;
            this.apple1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apple1.BackgroundImage")));
            this.apple1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.apple1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apple1.Location = new System.Drawing.Point(82, 174);
            this.apple1.Name = "apple1";
            this.apple1.Size = new System.Drawing.Size(40, 40);
            this.apple1.TabIndex = 53;
            this.apple1.TabStop = false;
            this.apple1.Click += new System.EventHandler(this.apple1_Click);
            // 
            // apple2
            // 
            this.apple2.BackColor = System.Drawing.Color.Transparent;
            this.apple2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apple2.BackgroundImage")));
            this.apple2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.apple2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apple2.Location = new System.Drawing.Point(20, 233);
            this.apple2.Name = "apple2";
            this.apple2.Size = new System.Drawing.Size(40, 40);
            this.apple2.TabIndex = 52;
            this.apple2.TabStop = false;
            this.apple2.Click += new System.EventHandler(this.apple2_Click);
            // 
            // apple0
            // 
            this.apple0.BackColor = System.Drawing.Color.Transparent;
            this.apple0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apple0.BackgroundImage")));
            this.apple0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.apple0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apple0.Location = new System.Drawing.Point(128, 268);
            this.apple0.Name = "apple0";
            this.apple0.Size = new System.Drawing.Size(40, 40);
            this.apple0.TabIndex = 51;
            this.apple0.TabStop = false;
            this.apple0.Click += new System.EventHandler(this.apple0_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(3, 473);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 43);
            this.pictureBox5.TabIndex = 49;
            this.pictureBox5.TabStop = false;
            // 
            // points
            // 
            this.points.BackColor = System.Drawing.Color.Transparent;
            this.points.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.points.BorderColor = System.Drawing.Color.Transparent;
            this.points.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.points.Enabled = false;
            this.points.FlatAppearance.BorderSize = 0;
            this.points.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.points.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.points.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.points.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.points.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.points.Location = new System.Drawing.Point(49, 473);
            this.points.Name = "points";
            this.points.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.points.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.points.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.points.Size = new System.Drawing.Size(205, 43);
            this.points.TabIndex = 48;
            this.points.Text = "Wyniki";
            this.points.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.points.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(142, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zadanie Fizyka - Spadek Swobodny";
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bird.BackgroundImage")));
            this.bird.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bird.Location = new System.Drawing.Point(304, 106);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(60, 78);
            this.bird.TabIndex = 54;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.bird_Click);
            // 
            // apple1Down
            // 
            this.apple1Down.BackColor = System.Drawing.Color.Transparent;
            this.apple1Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apple1Down.BackgroundImage")));
            this.apple1Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.apple1Down.Location = new System.Drawing.Point(82, 381);
            this.apple1Down.Name = "apple1Down";
            this.apple1Down.Size = new System.Drawing.Size(40, 40);
            this.apple1Down.TabIndex = 79;
            this.apple1Down.TabStop = false;
            this.apple1Down.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 5;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 50;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // help_physics
            // 
            this.help_physics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_physics.BackgroundImage")));
            this.help_physics.Controls.Add(this.close);
            this.help_physics.Location = new System.Drawing.Point(375, 146);
            this.help_physics.Name = "help_physics";
            this.help_physics.Size = new System.Drawing.Size(453, 455);
            this.help_physics.TabIndex = 101;
            this.help_physics.Visible = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.Location = new System.Drawing.Point(415, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 35);
            this.close.TabIndex = 100;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // facts_physics
            // 
            this.facts_physics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("facts_physics.BackgroundImage")));
            this.facts_physics.Controls.Add(this.close_facts);
            this.facts_physics.Location = new System.Drawing.Point(375, 320);
            this.facts_physics.Name = "facts_physics";
            this.facts_physics.Size = new System.Drawing.Size(487, 281);
            this.facts_physics.TabIndex = 102;
            this.facts_physics.Visible = false;
            // 
            // close_facts
            // 
            this.close_facts.BackColor = System.Drawing.Color.Transparent;
            this.close_facts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close_facts.BackgroundImage")));
            this.close_facts.Location = new System.Drawing.Point(449, 3);
            this.close_facts.Name = "close_facts";
            this.close_facts.Size = new System.Drawing.Size(35, 35);
            this.close_facts.TabIndex = 100;
            this.close_facts.TabStop = false;
            this.close_facts.Click += new System.EventHandler(this.close_facts_Click);
            // 
            // Physics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.facts_physics);
            this.Controls.Add(this.help_physics);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.back_to_menu);
            this.Controls.Add(this.back_to_map);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Physics";
            this.Text = "Physics";
            ((System.ComponentModel.ISupportInitialize)(this.back_to_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple2Down)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.good)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featherDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple0Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feather0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple1Down)).EndInit();
            this.help_physics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.facts_physics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_facts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox back_to_menu;
        private System.Windows.Forms.PictureBox back_to_map;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ePOSOne.btnProduct.Button_WOC points;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox feather0;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox apple1;
        private System.Windows.Forms.PictureBox apple2;
        private System.Windows.Forms.PictureBox apple0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox apple0Down;
        private System.Windows.Forms.PictureBox featherDown;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_g;
        private ePOSOne.btnProduct.Button_WOC ans3;
        private ePOSOne.btnProduct.Button_WOC ans2;
        private ePOSOne.btnProduct.Button_WOC ans1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox apple2Down;
        private System.Windows.Forms.PictureBox apple1Down;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox bad;
        private System.Windows.Forms.PictureBox good;
        private System.Windows.Forms.Label comboNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel help_physics;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel facts_physics;
        private System.Windows.Forms.PictureBox close_facts;
    }
}