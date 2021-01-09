
namespace projekt
{
    partial class Chemistry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chemistry));
            this.back_to_menu = new System.Windows.Forms.PictureBox();
            this.back_to_map = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.check_good1 = new System.Windows.Forms.PictureBox();
            this.check_good2 = new System.Windows.Forms.PictureBox();
            this.check_bad1 = new System.Windows.Forms.PictureBox();
            this.check_bad2 = new System.Windows.Forms.PictureBox();
            this.comboNumber1 = new System.Windows.Forms.Label();
            this.checkSymbol = new System.Windows.Forms.PictureBox();
            this.answerSymbol = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.PictureBox();
            this.check = new System.Windows.Forms.PictureBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelElementName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tlen = new System.Windows.Forms.PictureBox();
            this.hel = new System.Windows.Forms.PictureBox();
            this.mangan = new System.Windows.Forms.PictureBox();
            this.potas = new System.Windows.Forms.PictureBox();
            this.cynk = new System.Windows.Forms.PictureBox();
            this.chlor = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.masa_at = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wodor = new System.Windows.Forms.PictureBox();
            this.wapn = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.points = new ePOSOne.btnProduct.Button_WOC();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.help_chemistry = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.facts_chemistry = new System.Windows.Forms.Panel();
            this.close_facts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_good1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_good2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_bad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_bad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chlor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wodor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wapn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.help_chemistry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.facts_chemistry.SuspendLayout();
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
            this.pictureBox2.TabIndex = 29;
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
            this.pictureBox1.TabIndex = 30;
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
            this.label2.Location = new System.Drawing.Point(262, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wydział Chemiczny";
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
            this.panel1.Controls.Add(this.check_good1);
            this.panel1.Controls.Add(this.check_good2);
            this.panel1.Controls.Add(this.check_bad1);
            this.panel1.Controls.Add(this.check_bad2);
            this.panel1.Controls.Add(this.comboNumber1);
            this.panel1.Controls.Add(this.checkSymbol);
            this.panel1.Controls.Add(this.answerSymbol);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.check);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.labelElementName);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.tlen);
            this.panel1.Controls.Add(this.hel);
            this.panel1.Controls.Add(this.mangan);
            this.panel1.Controls.Add(this.potas);
            this.panel1.Controls.Add(this.cynk);
            this.panel1.Controls.Add(this.chlor);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.masa_at);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.wodor);
            this.panel1.Controls.Add(this.wapn);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.points);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(155, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 520);
            this.panel1.TabIndex = 38;
            // 
            // check_good1
            // 
            this.check_good1.BackColor = System.Drawing.Color.Transparent;
            this.check_good1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check_good1.BackgroundImage")));
            this.check_good1.Location = new System.Drawing.Point(585, 350);
            this.check_good1.Name = "check_good1";
            this.check_good1.Size = new System.Drawing.Size(35, 35);
            this.check_good1.TabIndex = 96;
            this.check_good1.TabStop = false;
            this.check_good1.Visible = false;
            // 
            // check_good2
            // 
            this.check_good2.BackColor = System.Drawing.Color.Transparent;
            this.check_good2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check_good2.BackgroundImage")));
            this.check_good2.Location = new System.Drawing.Point(246, 428);
            this.check_good2.Name = "check_good2";
            this.check_good2.Size = new System.Drawing.Size(35, 35);
            this.check_good2.TabIndex = 95;
            this.check_good2.TabStop = false;
            this.check_good2.Visible = false;
            // 
            // check_bad1
            // 
            this.check_bad1.BackColor = System.Drawing.Color.Transparent;
            this.check_bad1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check_bad1.BackgroundImage")));
            this.check_bad1.Location = new System.Drawing.Point(585, 350);
            this.check_bad1.Name = "check_bad1";
            this.check_bad1.Size = new System.Drawing.Size(35, 35);
            this.check_bad1.TabIndex = 94;
            this.check_bad1.TabStop = false;
            this.check_bad1.Visible = false;
            // 
            // check_bad2
            // 
            this.check_bad2.BackColor = System.Drawing.Color.Transparent;
            this.check_bad2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check_bad2.BackgroundImage")));
            this.check_bad2.Location = new System.Drawing.Point(246, 428);
            this.check_bad2.Name = "check_bad2";
            this.check_bad2.Size = new System.Drawing.Size(35, 35);
            this.check_bad2.TabIndex = 93;
            this.check_bad2.TabStop = false;
            this.check_bad2.Visible = false;
            // 
            // comboNumber1
            // 
            this.comboNumber1.AutoSize = true;
            this.comboNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboNumber1.Font = new System.Drawing.Font("Snap ITC", 16F);
            this.comboNumber1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(222)))));
            this.comboNumber1.Location = new System.Drawing.Point(188, 474);
            this.comboNumber1.Name = "comboNumber1";
            this.comboNumber1.Size = new System.Drawing.Size(0, 29);
            this.comboNumber1.TabIndex = 90;
            // 
            // checkSymbol
            // 
            this.checkSymbol.BackColor = System.Drawing.Color.Transparent;
            this.checkSymbol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkSymbol.BackgroundImage")));
            this.checkSymbol.Location = new System.Drawing.Point(246, 428);
            this.checkSymbol.Name = "checkSymbol";
            this.checkSymbol.Size = new System.Drawing.Size(35, 35);
            this.checkSymbol.TabIndex = 89;
            this.checkSymbol.TabStop = false;
            this.checkSymbol.Click += new System.EventHandler(this.checkTask2);
            // 
            // answerSymbol
            // 
            this.answerSymbol.BackColor = System.Drawing.Color.White;
            this.answerSymbol.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerSymbol.Location = new System.Drawing.Point(179, 417);
            this.answerSymbol.Multiline = true;
            this.answerSymbol.Name = "answerSymbol";
            this.answerSymbol.Size = new System.Drawing.Size(50, 25);
            this.answerSymbol.TabIndex = 88;
            this.answerSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.start.TabIndex = 87;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Transparent;
            this.check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("check.BackgroundImage")));
            this.check.Location = new System.Drawing.Point(585, 350);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(35, 35);
            this.check.TabIndex = 86;
            this.check.TabStop = false;
            this.check.Click += new System.EventHandler(this.checkTask1);
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox9.Location = new System.Drawing.Point(438, 134);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(25, 25);
            this.textBox9.TabIndex = 84;
            this.textBox9.Text = "?";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox8.Location = new System.Drawing.Point(438, 174);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(25, 25);
            this.textBox8.TabIndex = 83;
            this.textBox8.Text = "?";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(438, 214);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(25, 25);
            this.textBox7.TabIndex = 82;
            this.textBox7.Text = "?";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(178, 188);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(25, 25);
            this.textBox6.TabIndex = 81;
            this.textBox6.Text = "?";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelElementName
            // 
            this.labelElementName.AutoSize = true;
            this.labelElementName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelElementName.Location = new System.Drawing.Point(174, 383);
            this.labelElementName.Name = "labelElementName";
            this.labelElementName.Size = new System.Drawing.Size(70, 22);
            this.labelElementName.TabIndex = 79;
            this.labelElementName.Text = "Magnez";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(5, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 18);
            this.label12.TabIndex = 78;
            this.label12.Text = "symbol pierwiastka\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(5, 387);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 18);
            this.label11.TabIndex = 77;
            this.label11.Text = "nazwa pierwiastka\r\n";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(538, 319);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(60, 25);
            this.textBox5.TabIndex = 76;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(403, 319);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(60, 25);
            this.textBox4.TabIndex = 75;
            // 
            // tlen
            // 
            this.tlen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tlen.BackgroundImage")));
            this.tlen.Location = new System.Drawing.Point(263, 134);
            this.tlen.Name = "tlen";
            this.tlen.Size = new System.Drawing.Size(120, 140);
            this.tlen.TabIndex = 55;
            this.tlen.TabStop = false;
            // 
            // hel
            // 
            this.hel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hel.BackgroundImage")));
            this.hel.Location = new System.Drawing.Point(263, 134);
            this.hel.Name = "hel";
            this.hel.Size = new System.Drawing.Size(120, 140);
            this.hel.TabIndex = 52;
            this.hel.TabStop = false;
            // 
            // mangan
            // 
            this.mangan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mangan.BackgroundImage")));
            this.mangan.Location = new System.Drawing.Point(263, 134);
            this.mangan.Name = "mangan";
            this.mangan.Size = new System.Drawing.Size(120, 140);
            this.mangan.TabIndex = 53;
            this.mangan.TabStop = false;
            // 
            // potas
            // 
            this.potas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("potas.BackgroundImage")));
            this.potas.Location = new System.Drawing.Point(263, 134);
            this.potas.Name = "potas";
            this.potas.Size = new System.Drawing.Size(120, 140);
            this.potas.TabIndex = 54;
            this.potas.TabStop = false;
            // 
            // cynk
            // 
            this.cynk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cynk.BackgroundImage")));
            this.cynk.Location = new System.Drawing.Point(263, 134);
            this.cynk.Name = "cynk";
            this.cynk.Size = new System.Drawing.Size(120, 140);
            this.cynk.TabIndex = 51;
            this.cynk.TabStop = false;
            // 
            // chlor
            // 
            this.chlor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chlor.BackgroundImage")));
            this.chlor.Location = new System.Drawing.Point(263, 134);
            this.chlor.Name = "chlor";
            this.chlor.Size = new System.Drawing.Size(120, 140);
            this.chlor.TabIndex = 50;
            this.chlor.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(278, 319);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(60, 25);
            this.textBox3.TabIndex = 74;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(153, 319);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(60, 25);
            this.textBox2.TabIndex = 73;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(31, 319);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 25);
            this.textBox1.TabIndex = 72;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // masa_at
            // 
            this.masa_at.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masa_at.Enabled = false;
            this.masa_at.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.masa_at.Location = new System.Drawing.Point(178, 239);
            this.masa_at.Multiline = true;
            this.masa_at.Name = "masa_at";
            this.masa_at.Size = new System.Drawing.Size(25, 25);
            this.masa_at.TabIndex = 67;
            this.masa_at.Text = "?";
            this.masa_at.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(131, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 66;
            this.label10.Text = "WARTOŚCIOWOŚĆ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(260, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 65;
            this.label9.Text = "MASA ATOMOWA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(502, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 15);
            this.label8.TabIndex = 64;
            this.label8.Text = "SYMBOL PIERWIASTKA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(367, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 63;
            this.label7.Text = "NAZWA PIERWIASTKA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 62;
            this.label4.Text = "LICZBA ATOMOWA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(11, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(609, 30);
            this.label6.TabIndex = 61;
            this.label6.Text = "Polecenie: W odpowiednie miejsca wpisz odczytane ze schematu właściwości pierwias" +
    "tka. \r\nW ramach zadania dodatkowego zapisz symbol pierwiastka wyświetlonego poni" +
    "żej.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(96, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(472, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "POZNANIE PODSTAWOWYCH WŁAŚCIWOŚCI PIERWIASTKÓW CHEMICZNYCH";
            // 
            // wodor
            // 
            this.wodor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wodor.BackgroundImage")));
            this.wodor.Location = new System.Drawing.Point(263, 134);
            this.wodor.Name = "wodor";
            this.wodor.Size = new System.Drawing.Size(120, 140);
            this.wodor.TabIndex = 57;
            this.wodor.TabStop = false;
            // 
            // wapn
            // 
            this.wapn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wapn.BackgroundImage")));
            this.wapn.Location = new System.Drawing.Point(263, 134);
            this.wapn.Name = "wapn";
            this.wapn.Size = new System.Drawing.Size(120, 140);
            this.wapn.TabIndex = 56;
            this.wapn.TabStop = false;
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
            this.label3.Size = new System.Drawing.Size(405, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zadanie Chemia - Układ Okresowy Pierwiastków";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(209, 134);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(223, 135);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // help_chemistry
            // 
            this.help_chemistry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_chemistry.BackgroundImage")));
            this.help_chemistry.Controls.Add(this.close);
            this.help_chemistry.Location = new System.Drawing.Point(375, 146);
            this.help_chemistry.Name = "help_chemistry";
            this.help_chemistry.Size = new System.Drawing.Size(453, 455);
            this.help_chemistry.TabIndex = 101;
            this.help_chemistry.Visible = false;
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
            // facts_chemistry
            // 
            this.facts_chemistry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("facts_chemistry.BackgroundImage")));
            this.facts_chemistry.Controls.Add(this.close_facts);
            this.facts_chemistry.Location = new System.Drawing.Point(375, 320);
            this.facts_chemistry.Name = "facts_chemistry";
            this.facts_chemistry.Size = new System.Drawing.Size(487, 281);
            this.facts_chemistry.TabIndex = 102;
            this.facts_chemistry.Visible = false;
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
            // Chemistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.facts_chemistry);
            this.Controls.Add(this.help_chemistry);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.back_to_map);
            this.Controls.Add(this.back_to_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chemistry";
            this.Text = "Chemistry";
            ((System.ComponentModel.ISupportInitialize)(this.back_to_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_good1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_good2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_bad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_bad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cynk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chlor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wodor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wapn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.help_chemistry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.facts_chemistry.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox wodor;
        private System.Windows.Forms.PictureBox wapn;
        private System.Windows.Forms.PictureBox tlen;
        private System.Windows.Forms.PictureBox potas;
        private System.Windows.Forms.PictureBox mangan;
        private System.Windows.Forms.PictureBox hel;
        private System.Windows.Forms.PictureBox cynk;
        private System.Windows.Forms.PictureBox chlor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox masa_at;
        private System.Windows.Forms.Label labelElementName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.PictureBox check;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.TextBox answerSymbol;
        private System.Windows.Forms.PictureBox checkSymbol;
        private System.Windows.Forms.Label comboNumber1;
        private System.Windows.Forms.PictureBox check_bad1;
        private System.Windows.Forms.PictureBox check_bad2;
        private System.Windows.Forms.PictureBox check_good1;
        private System.Windows.Forms.PictureBox check_good2;
        private System.Windows.Forms.Panel help_chemistry;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel facts_chemistry;
        private System.Windows.Forms.PictureBox close_facts;
    }
}