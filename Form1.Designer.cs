namespace RouletteGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            BALL = new Button();
            label1 = new Label();
            label2 = new Label();
            button7 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(20, 291);
            button1.Name = "button1";
            button1.Size = new Size(94, 91);
            button1.TabIndex = 0;
            button1.Text = "RED";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(108, 291);
            button2.Name = "button2";
            button2.Size = new Size(94, 91);
            button2.TabIndex = 1;
            button2.Text = "BLACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(69, 379);
            button3.Name = "button3";
            button3.Size = new Size(94, 91);
            button3.TabIndex = 2;
            button3.Text = "ZERO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(20, 201);
            button4.Name = "button4";
            button4.Size = new Size(94, 91);
            button4.TabIndex = 3;
            button4.Text = "ODD";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Aqua;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(108, 201);
            button5.Name = "button5";
            button5.Size = new Size(94, 91);
            button5.TabIndex = 4;
            button5.Text = "EVEN";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // BALL
            // 
            BALL.BackColor = Color.White;
            BALL.Location = new Point(510, 89);
            BALL.Name = "BALL";
            BALL.Size = new Size(20, 23);
            BALL.TabIndex = 5;
            BALL.UseVisualStyleBackColor = false;
            BALL.Click += BALL_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(51, 64);
            label1.Name = "label1";
            label1.Size = new Size(100, 48);
            label1.TabIndex = 6;
            label1.Text = "BALANCE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(51, 112);
            label2.Name = "label2";
            label2.Size = new Size(82, 42);
            label2.TabIndex = 7;
            // 
            // button7
            // 
            button7.BackgroundImage = Properties.Resources.indir;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Location = new Point(895, 304);
            button7.Name = "button7";
            button7.Size = new Size(94, 64);
            button7.TabIndex = 8;
            button7.Text = "PARA YATIRMA";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(914, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(864, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(884, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(792, 122);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 12;
            label3.Text = "KULLANICI ADI :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(792, 191);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 13;
            label4.Text = "ŞİFRE :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(870, 236);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 14;
            label5.Text = "YÜKLENECEK MİKTAR";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(128, 64, 64);
            label6.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            label6.Location = new Point(803, 50);
            label6.Name = "label6";
            label6.Size = new Size(236, 31);
            label6.TabIndex = 15;
            label6.Text = "ONLİNE-BANKACILIK";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(841, 506);
            label7.Name = "label7";
            label7.Size = new Size(188, 20);
            label7.TabIndex = 16;
            label7.Text = "AUTHOR:@memrealbayrak";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(864, 433);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(815, 436);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 18;
            label8.Text = "BET :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            BackgroundImage = Properties.Resources.png_transparent_online_casino_gambling_casino_game_dice_game_dice_online_casino_thumbnail;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1041, 535);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BALL);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button BALL;
        private Label label1;
        private Label label2;
        private Button button7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
    }
}
