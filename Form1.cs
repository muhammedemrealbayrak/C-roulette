using System.Security.Principal;

namespace RouletteGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int a, balance = 1000, betAmour = 0, account_balance = 10000, payForRulet, password;
        string account;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = rnd.Next(37);
            betAmour = Convert.ToInt32(textBox4.Text);
            textBox4.Text = betAmour.ToString();
            switch (a)
            {
                case 0:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(365, 161);//5
                        BALL.Location = new Point(658, 350);//6
                        BALL.Location = new Point(678, 185);//4
                        BALL.Location = new Point(616, 127);//32
                        BALL.Location = new Point(595, 105);//0
                        if (button3.Enabled)
                        {
                            MessageBox.Show("SIFIR KAZANDI...");
                            balance += betAmour * 35;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 1:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(678, 185);//4
                        BALL.Location = new Point(458, 96);//28
                        BALL.Location = new Point(346, 218);//9
                        BALL.Location = new Point(345, 302);//20
                        BALL.Location = new Point(354, 326);//1
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE TEK:{1} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 2:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(342, 268);//14
                        BALL.Location = new Point(485, 86);//12
                        BALL.Location = new Point(639, 147);//15
                        BALL.Location = new Point(679, 218);//21
                        BALL.Location = new Point(688, 242);//2
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE ÇÝFT:{2} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 3:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(485, 429);//23
                        BALL.Location = new Point(346, 242);//31
                        BALL.Location = new Point(430, 108);//7
                        BALL.Location = new Point(512, 89);//35
                        BALL.Location = new Point(539, 89);//3
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE TEK:{3} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 4:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(354, 326);//1
                        BALL.Location = new Point(430, 108);//7
                        BALL.Location = new Point(595, 105);//0
                        BALL.Location = new Point(662, 161);//19
                        BALL.Location = new Point(678, 185);//4
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE ÇÝFT:{4} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 5:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(658, 350);//6
                        BALL.Location = new Point(405, 397);//24
                        BALL.Location = new Point(342, 268);//14
                        BALL.Location = new Point(352, 185);//22
                        BALL.Location = new Point(365, 161);//5
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE TEK:{5} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 6:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(365, 161);//5
                        BALL.Location = new Point(595, 105);//0
                        BALL.Location = new Point(688, 242);//2
                        BALL.Location = new Point(671, 326);//34
                        BALL.Location = new Point(658, 350);//6
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE ÇÝFT:{6} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 7:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(592, 406);//36
                        BALL.Location = new Point(370, 351);//33
                        BALL.Location = new Point(352, 185);//22
                        BALL.Location = new Point(408, 127);//29
                        BALL.Location = new Point(430, 108);//7
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE TEK:{7} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 8:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(512, 89);//35
                        BALL.Location = new Point(688, 242);//2
                        BALL.Location = new Point(621, 399);//13
                        BALL.Location = new Point(543, 426);//30
                        BALL.Location = new Point(514, 430);//8
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE ÇÝFT:{8} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 9:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(680, 302);//17
                        BALL.Location = new Point(514, 430);//8
                        BALL.Location = new Point(370, 351);//33
                        BALL.Location = new Point(346, 242);//31
                        BALL.Location = new Point(346, 218);//9
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE TEK:{9} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 10:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(569, 95);//26
                        BALL.Location = new Point(680, 302);//17
                        BALL.Location = new Point(568, 422);//11
                        BALL.Location = new Point(485, 429);//23
                        BALL.Location = new Point(458, 423);//10
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE ÇÝFT:{10} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 11:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(458, 96);//28
                        BALL.Location = new Point(678, 185);//4
                        BALL.Location = new Point(658, 350);//6
                        BALL.Location = new Point(592, 406);//36
                        BALL.Location = new Point(568, 422);//11
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE TEK:{11} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 12:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(543, 426);//30
                        BALL.Location = new Point(345, 302);//20
                        BALL.Location = new Point(386, 137);//18
                        BALL.Location = new Point(458, 96);//28
                        BALL.Location = new Point(485, 86);//12
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE ÇÝFT:{12} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 13:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(430, 108);//7
                        BALL.Location = new Point(662, 161);
                        BALL.Location = new Point(671, 326);
                        BALL.Location = new Point(641, 374);
                        BALL.Location = new Point(621, 399);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE TEK:{13} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 14:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(688, 242);
                        BALL.Location = new Point(543, 426);
                        BALL.Location = new Point(387, 376);
                        BALL.Location = new Point(345, 302);
                        BALL.Location = new Point(342, 268);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE ÇÝFT:{14} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 15:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(387, 376);
                        BALL.Location = new Point(386, 137);
                        BALL.Location = new Point(539, 89);//3
                        BALL.Location = new Point(616, 127);
                        BALL.Location = new Point(639, 147);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE TEK:{15} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 16:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(639, 147);
                        BALL.Location = new Point(641, 374);
                        BALL.Location = new Point(485, 429);
                        BALL.Location = new Point(405, 397);
                        BALL.Location = new Point(387, 376);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE ÇÝFT:{16} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 17:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(346, 218);//9
                        BALL.Location = new Point(539, 89);//3
                        BALL.Location = new Point(678, 185);//4
                        BALL.Location = new Point(684, 276);
                        BALL.Location = new Point(680, 302);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE TEK:{17} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 18:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(641, 374);
                        BALL.Location = new Point(405, 397);
                        BALL.Location = new Point(342, 268);
                        BALL.Location = new Point(365, 161);//5
                        BALL.Location = new Point(386, 137);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE ÇÝFT:{18} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 19:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(370, 351);
                        BALL.Location = new Point(408, 127);
                        BALL.Location = new Point(569, 95);
                        BALL.Location = new Point(639, 147);
                        BALL.Location = new Point(662, 161);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE TEK:{19} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 20:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(679, 218);
                        BALL.Location = new Point(568, 422);//11
                        BALL.Location = new Point(405, 397);
                        BALL.Location = new Point(354, 326);//1
                        BALL.Location = new Point(345, 302);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE ÇÝFT:{20} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 21:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(345, 302);
                        BALL.Location = new Point(458, 96);
                        BALL.Location = new Point(616, 127);
                        BALL.Location = new Point(678, 185);//4
                        BALL.Location = new Point(679, 218);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE TEK:{21} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 22:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(671, 326);
                        BALL.Location = new Point(458, 423);//10
                        BALL.Location = new Point(345, 302);
                        BALL.Location = new Point(346, 218);//9
                        BALL.Location = new Point(352, 185);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE ÇÝFT:{22} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 23:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(539, 89);//3
                        BALL.Location = new Point(684, 276);
                        BALL.Location = new Point(514, 430);//8
                        BALL.Location = new Point(365, 161);//5
                        BALL.Location = new Point(485, 429);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE TEK:{23} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 24:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(616, 127);
                        BALL.Location = new Point(658, 350);//6
                        BALL.Location = new Point(514, 430);//8
                        BALL.Location = new Point(365, 161);//5
                        BALL.Location = new Point(405, 397);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE ÇÝFT:{24} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 25:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(346, 242);
                        BALL.Location = new Point(512, 89);
                        BALL.Location = new Point(662, 161);
                        BALL.Location = new Point(688, 242);//2
                        BALL.Location = new Point(684, 276);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE TEK:{25} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 26:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(458, 423);//10
                        BALL.Location = new Point(346, 218);//9
                        BALL.Location = new Point(458, 96);
                        BALL.Location = new Point(539, 89);//3
                        BALL.Location = new Point(569, 95);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE ÇÝFT:{26} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 27:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(386, 137);
                        BALL.Location = new Point(616, 127);
                        BALL.Location = new Point(684, 276);
                        BALL.Location = new Point(658, 350);//6
                        BALL.Location = new Point(641, 374);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE TEK:{27} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 28:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(592, 406);
                        BALL.Location = new Point(370, 351);
                        BALL.Location = new Point(352, 185);
                        BALL.Location = new Point(430, 108);//7
                        BALL.Location = new Point(458, 96);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE ÇÝFT:{28} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 29:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(641, 374);
                        BALL.Location = new Point(405, 397);
                        BALL.Location = new Point(346, 242);
                        BALL.Location = new Point(386, 137);
                        BALL.Location = new Point(408, 127);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE TEK:{29} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 30:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(485, 86);//12
                        BALL.Location = new Point(679, 218);
                        BALL.Location = new Point(641, 374);
                        BALL.Location = new Point(568, 422);//11
                        BALL.Location = new Point(543, 426);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE ÇÝFT:{30} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 31:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(568, 422);//11
                        BALL.Location = new Point(543, 426);
                        BALL.Location = new Point(387, 376);
                        BALL.Location = new Point(370, 351);
                        BALL.Location = new Point(346, 242);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE TEK:{31} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 32:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(405, 397);
                        BALL.Location = new Point(365, 161);//5
                        BALL.Location = new Point(512, 89);
                        BALL.Location = new Point(595, 105);//0
                        BALL.Location = new Point(616, 127);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE ÇÝFT:{32} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 33:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(662, 161);
                        BALL.Location = new Point(621, 399);
                        BALL.Location = new Point(458, 423);//10
                        BALL.Location = new Point(387, 376);
                        BALL.Location = new Point(370, 351);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"KIRMIZI VE TEK:{33} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 34:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(352, 185);
                        BALL.Location = new Point(569, 95);
                        BALL.Location = new Point(679, 218);
                        BALL.Location = new Point(680, 302);
                        BALL.Location = new Point(671, 326);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE ÇÝFT:{34} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 35:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(514, 430);//8
                        BALL.Location = new Point(342, 268);
                        BALL.Location = new Point(408, 127);
                        BALL.Location = new Point(485, 86);//12
                        BALL.Location = new Point(512, 89);
                        if (button2.Enabled || button4.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE TEK:{35} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
                case 36:
                    //betAmour = Convert.ToInt32(textBox4.Text);
                    if (balance > 0 || betAmour < balance)
                    {
                        BALL.Location = new Point(430, 108);//7
                        BALL.Location = new Point(662, 161);
                        BALL.Location = new Point(671, 326);
                        BALL.Location = new Point(621, 399);
                        BALL.Location = new Point(592, 406);
                        if (button1.Enabled || button5.Enabled)
                        {
                            MessageBox.Show($"SÝYAH VE ÇÝFT:{36} KAZANDI...");
                            balance += betAmour * 2;
                            label2.Text = balance.ToString();
                        }
                        else
                        {
                            balance -= betAmour;
                            label2.Text = balance.ToString();
                        }
                    }
                    break;
            }
        }

        private void hesabaErismek(object sender, EventArgs e)
        {
            account = textBox1.Text;
            password = Convert.ToInt32(textBox2.Text);
            payForRulet = Convert.ToInt32(textBox3.Text);
            account_balance -= payForRulet;
            balance += payForRulet;
            label2.Text = balance.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Enabled)
            {   hesabaErismek(sender, e);
                MessageBox.Show($"HESABINIZDAKÝ PARA MÝKTARI:{account_balance}");
                if (payForRulet > account_balance)
                {
                    payForRulet = account_balance;
                    account_balance = 0;
                    balance += payForRulet;
                    label2.Text = balance.ToString();
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void BALL_Click(object sender, EventArgs e)
        {

        }

    }
}
