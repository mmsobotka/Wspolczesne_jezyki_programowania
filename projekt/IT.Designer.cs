using System;

namespace projekt
{
    partial class IT
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IT));
            this.back_to_menu = new System.Windows.Forms.PictureBox();
            this.back_to_map = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboNumber = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.PictureBox();
            this.bad = new System.Windows.Forms.PictureBox();
            this.good = new System.Windows.Forms.PictureBox();
            this.number1 = new ePOSOne.btnProduct.Button_WOC();
            this.number2 = new ePOSOne.btnProduct.Button_WOC();
            this.number3 = new ePOSOne.btnProduct.Button_WOC();
            this.binarylabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.points = new ePOSOne.btnProduct.Button_WOC();
            this.answer = new ePOSOne.btnProduct.Button_WOC();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.help_IT = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.facts_IT = new System.Windows.Forms.Panel();
            this.close_facts = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.good)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            this.help_IT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.facts_IT.SuspendLayout();
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
            this.back_to_map.TabIndex = 25;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboNumber);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.bad);
            this.panel1.Controls.Add(this.good);
            this.panel1.Controls.Add(this.number1);
            this.panel1.Controls.Add(this.number2);
            this.panel1.Controls.Add(this.number3);
            this.panel1.Controls.Add(this.binarylabel);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.points);
            this.panel1.Controls.Add(this.answer);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(155, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 520);
            this.panel1.TabIndex = 32;
            // 
            // comboNumber
            // 
            this.comboNumber.AutoSize = true;
            this.comboNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboNumber.Font = new System.Drawing.Font("Snap ITC", 16F);
            this.comboNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(222)))));
            this.comboNumber.Location = new System.Drawing.Point(188, 466);
            this.comboNumber.Name = "comboNumber";
            this.comboNumber.Size = new System.Drawing.Size(0, 29);
            this.comboNumber.TabIndex = 57;
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
            this.start.TabIndex = 35;
            this.start.TabStop = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // bad
            // 
            this.bad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bad.BackgroundImage")));
            this.bad.Location = new System.Drawing.Point(375, 250);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(28, 28);
            this.bad.TabIndex = 56;
            this.bad.TabStop = false;
            this.bad.Visible = false;
            // 
            // good
            // 
            this.good.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("good.BackgroundImage")));
            this.good.Location = new System.Drawing.Point(375, 250);
            this.good.Name = "good";
            this.good.Size = new System.Drawing.Size(28, 28);
            this.good.TabIndex = 55;
            this.good.TabStop = false;
            this.good.Visible = false;
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.Color.Transparent;
            this.number1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.number1.BorderColor = System.Drawing.Color.Transparent;
            this.number1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.number1.FlatAppearance.BorderSize = 0;
            this.number1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.number1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.number1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number1.ForeColor = System.Drawing.Color.Transparent;
            this.number1.Location = new System.Drawing.Point(117, 317);
            this.number1.Name = "number1";
            this.number1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.number1.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.number1.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.number1.Size = new System.Drawing.Size(119, 59);
            this.number1.TabIndex = 54;
            this.number1.Tag = "options1";
            this.number1.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number1.UseVisualStyleBackColor = false;
            this.number1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDownOption1);
            this.number1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMoveOption1);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.Color.Transparent;
            this.number2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.number2.BorderColor = System.Drawing.Color.Transparent;
            this.number2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.number2.FlatAppearance.BorderSize = 0;
            this.number2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.number2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.number2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number2.ForeColor = System.Drawing.Color.Transparent;
            this.number2.Location = new System.Drawing.Point(260, 317);
            this.number2.Name = "number2";
            this.number2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.number2.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.number2.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.number2.Size = new System.Drawing.Size(119, 59);
            this.number2.TabIndex = 53;
            this.number2.Tag = "options2";
            this.number2.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number2.UseVisualStyleBackColor = false;
            this.number2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDownOption2);
            this.number2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMoveOption2);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.Transparent;
            this.number3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.number3.BorderColor = System.Drawing.Color.Transparent;
            this.number3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.number3.FlatAppearance.BorderSize = 0;
            this.number3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.number3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.number3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.number3.ForeColor = System.Drawing.Color.Transparent;
            this.number3.Location = new System.Drawing.Point(398, 317);
            this.number3.Name = "number3";
            this.number3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.number3.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.number3.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.number3.Size = new System.Drawing.Size(119, 59);
            this.number3.TabIndex = 52;
            this.number3.Tag = "options3";
            this.number3.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.number3.UseVisualStyleBackColor = false;
            this.number3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDownOption3);
            this.number3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMoveOption3);
            // 
            // binarylabel
            // 
            this.binarylabel.AutoSize = true;
            this.binarylabel.Font = new System.Drawing.Font("Consolas", 21.75F);
            this.binarylabel.Location = new System.Drawing.Point(245, 158);
            this.binarylabel.Name = "binarylabel";
            this.binarylabel.Size = new System.Drawing.Size(0, 34);
            this.binarylabel.TabIndex = 50;
            this.binarylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Enabled = false;
            this.pictureBox5.Location = new System.Drawing.Point(3, 461);
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
            this.points.ForeColor = System.Drawing.SystemColors.WindowText;
            this.points.Location = new System.Drawing.Point(49, 461);
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
            // answer
            // 
            this.answer.BackColor = System.Drawing.Color.Transparent;
            this.answer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.answer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.answer.ButtonColor = System.Drawing.Color.White;
            this.answer.Enabled = false;
            this.answer.FlatAppearance.BorderSize = 0;
            this.answer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.answer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answer.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answer.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.answer.Location = new System.Drawing.Point(260, 204);
            this.answer.Name = "answer";
            this.answer.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.answer.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.answer.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.answer.Size = new System.Drawing.Size(119, 59);
            this.answer.TabIndex = 47;
            this.answer.Tag = "answer";
            this.answer.Text = "Odpowiedź";
            this.answer.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.answer.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(17, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "SYSTEM DECYMALNY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(17, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "SYSTEM BINARNY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(17, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(588, 30);
            this.label5.TabIndex = 37;
            this.label5.Text = "Polecenie: Za pomocą myszki przesuń wybraną liczbę reprezentującą wynik zamiany n" +
    "a \r\nodpowiednie pole.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(96, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "ZAMIANA LICZB MIĘDZY SYSTEMAMI DWÓJKOWYM I DZIESIĘTNYM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(142, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Zadanie Informatyka - Systemy Liczbowe";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(111, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 64);
            this.panel2.TabIndex = 34;
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
            // help_IT
            // 
            this.help_IT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("help_IT.BackgroundImage")));
            this.help_IT.Controls.Add(this.close);
            this.help_IT.Location = new System.Drawing.Point(375, 146);
            this.help_IT.Name = "help_IT";
            this.help_IT.Size = new System.Drawing.Size(453, 455);
            this.help_IT.TabIndex = 100;
            this.help_IT.Visible = false;
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
            // facts_IT
            // 
            this.facts_IT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("facts_IT.BackgroundImage")));
            this.facts_IT.Controls.Add(this.close_facts);
            this.facts_IT.Location = new System.Drawing.Point(375, 320);
            this.facts_IT.Name = "facts_IT";
            this.facts_IT.Size = new System.Drawing.Size(487, 281);
            this.facts_IT.TabIndex = 101;
            this.facts_IT.Visible = false;
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
            // IT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.facts_IT);
            this.Controls.Add(this.help_IT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back_to_map);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.back_to_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IT";
            this.Text = "IT";
            ((System.ComponentModel.ISupportInitialize)(this.back_to_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_to_map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.good)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.help_IT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.facts_IT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_facts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox back_to_menu;
        private System.Windows.Forms.PictureBox back_to_map;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ePOSOne.btnProduct.Button_WOC points;
        private ePOSOne.btnProduct.Button_WOC answer;
        private System.Windows.Forms.Label binarylabel;
        private ePOSOne.btnProduct.Button_WOC number1;
        private ePOSOne.btnProduct.Button_WOC number2;
        private ePOSOne.btnProduct.Button_WOC number3;
        private System.Windows.Forms.PictureBox bad;
        private System.Windows.Forms.PictureBox good;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.Label comboNumber;
        private System.Windows.Forms.Panel help_IT;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel facts_IT;
        private System.Windows.Forms.PictureBox close_facts;
    }
}