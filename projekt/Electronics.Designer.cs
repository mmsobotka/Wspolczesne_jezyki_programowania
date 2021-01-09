
namespace projekt
{
    partial class Electronics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Electronics));
            this.back_to_menu = new System.Windows.Forms.PictureBox();
            this.back_to_map = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboNumber = new System.Windows.Forms.Label();
            this.check_bad = new System.Windows.Forms.PictureBox();
            this.check_good = new System.Windows.Forms.PictureBox();
            this.check_Gate = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            this.bit1_off = new System.Windows.Forms.PictureBox();
            this.bit0_off = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bit0_on = new System.Windows.Forms.PictureBox();
            this.bit1_on = new System.Windows.Forms.PictureBox();
            this.labeld = new System.Windows.Forms.Label();
            this.labelc = new System.Windows.Forms.Label();
            this.labelb = new System.Windows.Forms.Label();
            this.labela = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelgate = new System.Windows.Forms.Label();
            this.or = new System.Windows.Forms.PictureBox();
            this.nand = new System.Windows.Forms.PictureBox();
            this.nor = new System.Windows.Forms.PictureBox();
            this.xor = new System.Windows.Forms.PictureBox();
            this.not = new System.Windows.Forms.PictureBox();
            this.and = new System.Windows.Forms.PictureBox();
            this.system = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.points = new ePOSOne.btnProduct.Button_WOC();
            this.label3 = new System.Windows.Forms.Label();
            this.help_electronics = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.facts_electronics = new System.Windows.Forms.Panel();
            this.close_facts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_bad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_good)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_Gate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit1_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit0_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit0_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit1_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.or)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.not)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.and)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.system)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.help_electronics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.facts_electronics.SuspendLayout();
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
            this.panel2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13F);
            this.label2.Location = new System.Drawing.Point(111, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wydział Elektroniki, Telekomunikacji i Informatyki";
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
            this.panel1.Controls.Add(this.comboNumber);
            this.panel1.Controls.Add(this.check_bad);
            this.panel1.Controls.Add(this.check_good);
            this.panel1.Controls.Add(this.check_Gate);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.bit1_off);
            this.panel1.Controls.Add(this.bit0_off);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bit0_on);
            this.panel1.Controls.Add(this.bit1_on);
            this.panel1.Controls.Add(this.labeld);
            this.panel1.Controls.Add(this.labelc);
            this.panel1.Controls.Add(this.labelb);
            this.panel1.Controls.Add(this.labela);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelgate);
            this.panel1.Controls.Add(this.or);
            this.panel1.Controls.Add(this.nand);
            this.panel1.Controls.Add(this.nor);
            this.panel1.Controls.Add(this.xor);
            this.panel1.Controls.Add(this.not);
            this.panel1.Controls.Add(this.and);
            this.panel1.Controls.Add(this.system);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.points);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(155, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 520);
            this.panel1.TabIndex = 36;
            // 
            // comboNumber
            // 
            this.comboNumber.AutoSize = true;
            this.comboNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboNumber.Font = new System.Drawing.Font("Snap ITC", 16F);
            this.comboNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(222)))));
            this.comboNumber.Location = new System.Drawing.Point(188, 476);
            this.comboNumber.Name = "comboNumber";
            this.comboNumber.Size = new System.Drawing.Size(0, 29);
            this.comboNumber.TabIndex = 58;
            // 
            // check_bad
            // 
            this.check_bad.BackColor = System.Drawing.Color.Transparent;
            this.check_bad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check_bad.BackgroundImage")));
            this.check_bad.Location = new System.Drawing.Point(219, 397);
            this.check_bad.Name = "check_bad";
            this.check_bad.Size = new System.Drawing.Size(35, 35);
            this.check_bad.TabIndex = 92;
            this.check_bad.TabStop = false;
            this.check_bad.Visible = false;
            // 
            // check_good
            // 
            this.check_good.BackColor = System.Drawing.Color.Transparent;
            this.check_good.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check_good.BackgroundImage")));
            this.check_good.Location = new System.Drawing.Point(219, 397);
            this.check_good.Name = "check_good";
            this.check_good.Size = new System.Drawing.Size(35, 35);
            this.check_good.TabIndex = 91;
            this.check_good.TabStop = false;
            this.check_good.Visible = false;
            // 
            // check_Gate
            // 
            this.check_Gate.BackColor = System.Drawing.Color.Transparent;
            this.check_Gate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check_Gate.BackgroundImage")));
            this.check_Gate.Location = new System.Drawing.Point(219, 397);
            this.check_Gate.Name = "check_Gate";
            this.check_Gate.Size = new System.Drawing.Size(35, 35);
            this.check_Gate.TabIndex = 90;
            this.check_Gate.TabStop = false;
            this.check_Gate.Click += new System.EventHandler(this.check_Gate_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.start.Location = new System.Drawing.Point(547, 439);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(65, 66);
            this.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.start.TabIndex = 89;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // bit1_off
            // 
            this.bit1_off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bit1_off.BackgroundImage")));
            this.bit1_off.Location = new System.Drawing.Point(77, 367);
            this.bit1_off.Name = "bit1_off";
            this.bit1_off.Size = new System.Drawing.Size(41, 65);
            this.bit1_off.TabIndex = 87;
            this.bit1_off.TabStop = false;
            this.bit1_off.Click += new System.EventHandler(this.bit1_off_Click);
            // 
            // bit0_off
            // 
            this.bit0_off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bit0_off.BackgroundImage")));
            this.bit0_off.Location = new System.Drawing.Point(158, 367);
            this.bit0_off.Name = "bit0_off";
            this.bit0_off.Size = new System.Drawing.Size(41, 65);
            this.bit0_off.TabIndex = 86;
            this.bit0_off.TabStop = false;
            this.bit0_off.Click += new System.EventHandler(this.bit0_off_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(170, 439);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 85;
            this.label16.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(89, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 84;
            this.label4.Text = "1";
            // 
            // bit0_on
            // 
            this.bit0_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bit0_on.BackgroundImage")));
            this.bit0_on.Location = new System.Drawing.Point(158, 367);
            this.bit0_on.Name = "bit0_on";
            this.bit0_on.Size = new System.Drawing.Size(41, 65);
            this.bit0_on.TabIndex = 83;
            this.bit0_on.TabStop = false;
            this.bit0_on.Visible = false;
            this.bit0_on.Click += new System.EventHandler(this.bit0_on_Click);
            // 
            // bit1_on
            // 
            this.bit1_on.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bit1_on.BackgroundImage")));
            this.bit1_on.Location = new System.Drawing.Point(77, 367);
            this.bit1_on.Name = "bit1_on";
            this.bit1_on.Size = new System.Drawing.Size(41, 65);
            this.bit1_on.TabIndex = 82;
            this.bit1_on.TabStop = false;
            this.bit1_on.Visible = false;
            this.bit1_on.Click += new System.EventHandler(this.bit1_on_Click);
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeld.Location = new System.Drawing.Point(272, 339);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(15, 16);
            this.labeld.TabIndex = 81;
            this.labeld.Text = "1";
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelc.Location = new System.Drawing.Point(205, 339);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(15, 16);
            this.labelc.TabIndex = 80;
            this.labelc.Text = "1";
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelb.Location = new System.Drawing.Point(140, 339);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(15, 16);
            this.labelb.TabIndex = 79;
            this.labelb.Text = "1";
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labela.Location = new System.Drawing.Point(74, 339);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(15, 16);
            this.labela.TabIndex = 78;
            this.labela.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(237, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 77;
            this.label11.Text = "D =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(170, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "C =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(109, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "B =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(39, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "A =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(16, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(616, 30);
            this.label7.TabIndex = 73;
            this.label7.Text = "Polecenie: Jaką funkcję realizuje przedstawiony poniżej układ? Odpowiedź przedsta" +
    "w \r\npoprzez zaświecenie bitu 0 lub 1. Przyporządkuj nazwę bramki do odpowiednieg" +
    "o schematu.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(123, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "PODSTAWY TECHNIKI CYFROWEJ - BRAMKI LOGICZNE";
            // 
            // labelgate
            // 
            this.labelgate.AutoSize = true;
            this.labelgate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelgate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelgate.Location = new System.Drawing.Point(406, 386);
            this.labelgate.Name = "labelgate";
            this.labelgate.Size = new System.Drawing.Size(47, 21);
            this.labelgate.TabIndex = 71;
            this.labelgate.Text = "NAND";
            // 
            // or
            // 
            this.or.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("or.BackgroundImage")));
            this.or.Location = new System.Drawing.Point(498, 268);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(110, 44);
            this.or.TabIndex = 70;
            this.or.TabStop = false;
            this.or.Click += new System.EventHandler(this.or_Click);
            // 
            // nand
            // 
            this.nand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nand.BackgroundImage")));
            this.nand.Location = new System.Drawing.Point(406, 225);
            this.nand.Name = "nand";
            this.nand.Size = new System.Drawing.Size(110, 37);
            this.nand.TabIndex = 68;
            this.nand.TabStop = false;
            this.nand.Click += new System.EventHandler(this.nand_Click);
            // 
            // nor
            // 
            this.nor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nor.BackgroundImage")));
            this.nor.Location = new System.Drawing.Point(406, 318);
            this.nor.Name = "nor";
            this.nor.Size = new System.Drawing.Size(110, 45);
            this.nor.TabIndex = 67;
            this.nor.TabStop = false;
            this.nor.Click += new System.EventHandler(this.nor_Click);
            // 
            // xor
            // 
            this.xor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xor.BackgroundImage")));
            this.xor.Location = new System.Drawing.Point(498, 369);
            this.xor.Name = "xor";
            this.xor.Size = new System.Drawing.Size(110, 38);
            this.xor.TabIndex = 66;
            this.xor.TabStop = false;
            this.xor.Click += new System.EventHandler(this.xor_Click);
            // 
            // not
            // 
            this.not.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("not.BackgroundImage")));
            this.not.Location = new System.Drawing.Point(498, 178);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(110, 41);
            this.not.TabIndex = 65;
            this.not.TabStop = false;
            this.not.Click += new System.EventHandler(this.not_Click);
            // 
            // and
            // 
            this.and.BackColor = System.Drawing.Color.Transparent;
            this.and.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("and.BackgroundImage")));
            this.and.Location = new System.Drawing.Point(406, 122);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(109, 50);
            this.and.TabIndex = 64;
            this.and.TabStop = false;
            this.and.Click += new System.EventHandler(this.and_Click);
            // 
            // system
            // 
            this.system.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("system.BackgroundImage")));
            this.system.Location = new System.Drawing.Point(20, 148);
            this.system.Name = "system";
            this.system.Size = new System.Drawing.Size(345, 172);
            this.system.TabIndex = 50;
            this.system.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(3, 469);
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
            this.points.Location = new System.Drawing.Point(49, 469);
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
            this.label3.Location = new System.Drawing.Point(131, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zadanie Elektronika - Bramki Logiczne";
            // 
            // help_electronics
            // 
            this.help_electronics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_electronics.BackgroundImage")));
            this.help_electronics.Controls.Add(this.close);
            this.help_electronics.Location = new System.Drawing.Point(375, 146);
            this.help_electronics.Name = "help_electronics";
            this.help_electronics.Size = new System.Drawing.Size(453, 455);
            this.help_electronics.TabIndex = 101;
            this.help_electronics.Visible = false;
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
            // facts_electronics
            // 
            this.facts_electronics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("facts_electronics.BackgroundImage")));
            this.facts_electronics.Controls.Add(this.close_facts);
            this.facts_electronics.Location = new System.Drawing.Point(375, 320);
            this.facts_electronics.Name = "facts_electronics";
            this.facts_electronics.Size = new System.Drawing.Size(487, 281);
            this.facts_electronics.TabIndex = 102;
            this.facts_electronics.Visible = false;
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
            // Electronics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.facts_electronics);
            this.Controls.Add(this.help_electronics);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.back_to_map);
            this.Controls.Add(this.back_to_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Electronics";
            this.Text = "Electronics";
            ((System.ComponentModel.ISupportInitialize)(this.back_to_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_bad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_good)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_Gate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit1_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit0_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit0_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bit1_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.or)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.not)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.and)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.system)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.help_electronics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.facts_electronics.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox or;
        private System.Windows.Forms.PictureBox nand;
        private System.Windows.Forms.PictureBox nor;
        private System.Windows.Forms.PictureBox xor;
        private System.Windows.Forms.PictureBox not;
        private System.Windows.Forms.PictureBox and;
        private System.Windows.Forms.Label labelgate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox system;
        private System.Windows.Forms.PictureBox bit1_off;
        private System.Windows.Forms.PictureBox bit0_off;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox bit0_on;
        private System.Windows.Forms.PictureBox bit1_on;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox check_Gate;
        private System.Windows.Forms.PictureBox check_bad;
        private System.Windows.Forms.PictureBox check_good;
        private System.Windows.Forms.Label comboNumber;
        private System.Windows.Forms.Panel help_electronics;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel facts_electronics;
        private System.Windows.Forms.PictureBox close_facts;
    }
}