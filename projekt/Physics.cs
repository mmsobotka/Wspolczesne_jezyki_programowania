using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Physics : Form
    {
        Point[] orginalAppleLocation = new Point[3];
        Point orginalFeatherLocation = new Point();
        bool isClicked = false;
        bool isAnswearClicked = false;
        int[] times= new int[3];
        int result = 0;
        int selectedIndex = 0;
        int score = 0;
        int combo = 1;
        int correctAnswears = 0;
        Random random = new Random();

        public Physics(Map map)
        {
            InitializeComponent();
            mainWindowMap = map;

            if (mainWindowMap.mainWindow.choosenTheme == 1)
            {
                this.BackgroundImage = new Bitmap(".\\..\\..\\picture\\tlo.jpg");
            }
            else
            {
                this.BackColor = Color.FromArgb(209, 238, 244);
                this.BackgroundImage = null;
            }

            Map.openedTasks++;
            orginalAppleLocation[0] = apple0.Location;
            orginalAppleLocation[1] = apple1.Location;
            orginalAppleLocation[2] = apple2.Location;
            orginalFeatherLocation = feather0.Location;
            help_physics.Visible = false;
            facts_physics.Visible = false;

            generateGame();
        }

        private void generateGame() 
        {
            apple0.Location = orginalAppleLocation[0];
            apple1.Location = orginalAppleLocation[1];
            apple2.Location = orginalAppleLocation[2];
            feather0.Location = orginalFeatherLocation;
            isClicked = false;
            isAnswearClicked = false;
            bad.Visible = false;
            good.Visible = false;
            panel3.Visible = false;
            feather0.Visible = false;
        }

        private void back_to_map_Click(object sender, EventArgs e)
        {
            mainWindowMap.Visible = true;
            isGameDone();
            this.Close();
        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            mainWindowMap.mainWindow.Visible = true;
            isGameDone();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (apple0.Top < apple0Down.Top)
            {
                apple0.Top += 3;
            }
            else
            {
                panel3.Visible = true;
                good.Visible = false;
                bad.Visible = false;
                timer1.Stop();
                isClicked = false;
                generateTimes(5);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (apple1.Top < apple1Down.Top)
            {
                apple1.Top += 3;
            }
            else
            {
                panel3.Visible = true;
                good.Visible = false;
                bad.Visible = false;
                timer2.Stop();
                isClicked = false;
                generateTimes(8);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (apple2.Top < apple2Down.Top)
            {
                apple2.Top += 3;
            }
            else
            {
                panel3.Visible = true;
                good.Visible = false;
                bad.Visible = false;
                timer3.Stop();
                isClicked = false;
                generateTimes(2);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (feather0.Top < featherDown.Top)
            {
                feather0.Top += 3;                
            }
            else
            {
                panel3.Visible = true;
                good.Visible = false;
                bad.Visible = false;
                timer4.Stop();
                isClicked = false;
                generateTimes(12);
            }
        }
        private void apple0_Click(object sender, EventArgs e)
        {
            if (isClicked == false)
            {
                timer1.Start();
                isClicked = true;
                isAnswearClicked = false;
                panel3.Visible = false;                
            }
        }

        private void apple1_Click(object sender, EventArgs e)
        {
            if (isClicked == false)
            {
                timer2.Start();
                isClicked = true;
                isAnswearClicked = false;
                panel3.Visible = false;
            }
        }

        private void apple2_Click(object sender, EventArgs e)
        {
            if (isClicked == false)
            {
                timer3.Start();
                isClicked = true;
                isAnswearClicked = false;
                panel3.Visible = false;
            }
        }

        private void bird_Click(object sender, EventArgs e)
        {
            if (isClicked == false)
            {
                timer4.Start();
                isClicked = true;
                isAnswearClicked = false;
                feather0.Visible = true;
                panel3.Visible = false;
            }
        }

        private void generateTimes(int startTime)
        {
            times[0]= startTime + random.Next(0, 10);
            times[1]= startTime + random.Next(0, 10);
            times[2]= startTime + random.Next(0, 10);

            selectedIndex = random.Next(0, 3);
            button0.Text= "t = " + times[selectedIndex].ToString() + " s ";
            result = calculateAnswear(times[selectedIndex]);
            generateAnswears();
        }

        private int calculateAnswear(int time)
        {
            int g = 10;
            int height = g*(time*time)/2;
            return height;
        }

        private void generateAnswears() 
        {
            ans1.Text = calculateAnswear(times[0]).ToString();
            ans2.Text = calculateAnswear(times[1]).ToString();
            ans3.Text = calculateAnswear(times[2]).ToString();
            
        }

        private void ans1_Click(object sender, EventArgs e)
        {
            if (isAnswearClicked == false)
            {
                if (result == Convert.ToInt32(ans1.Text))
                {
                    good.Visible = true;
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scorePhysics += 10 * combo;
                    correctAnswears++;
                    if (combo <= 5)
                    {
                        comboNumber.Text = "x" + combo.ToString();
                        combo++;
                    }
                }
                else
                {
                    bad.Visible = true;
                    score -= 10;
                    mainWindowMap.mainWindow.scorePhysics -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                }
                points.Text = score.ToString();
                isAnswearClicked = true;
            }
        }

        private void ans2_Click(object sender, EventArgs e)
        {
            if (isAnswearClicked == false)
            {
                if (result == Convert.ToInt32(ans2.Text))
                {
                    good.Visible = true;
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scorePhysics += 10 * combo;
                    correctAnswears++;
                    if (combo <= 5)
                    {
                        comboNumber.Text = "x" + combo.ToString();
                        combo++;
                    }
                }
                else
                {
                    bad.Visible = true;
                    score -= 10;
                    mainWindowMap.mainWindow.scorePhysics -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                }
                points.Text = score.ToString();
                isAnswearClicked = true;
            }
        }

        private void ans3_Click(object sender, EventArgs e)
        {
            if (isAnswearClicked == false)
            {
                if (result == Convert.ToInt32(ans3.Text))
                {
                    good.Visible = true;
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scorePhysics += 10 * combo;
                    correctAnswears++;
                    if (combo <= 5)
                    {
                        comboNumber.Text = "x" + combo.ToString();
                        combo++;
                    }
                }
                else
                {
                    bad.Visible = true;
                    score -= 10;
                    mainWindowMap.mainWindow.scorePhysics -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                }
                points.Text = score.ToString();
                isAnswearClicked = true;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            generateGame();
        } 

        private void isGameDone()
        {
            if (correctAnswears >= 5) 
            {
                mainWindowMap.mainWindow.isPhysicsDone = true;
                mainWindowMap.tasksDone();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            help_physics.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            facts_physics.Visible = true;
        }

        private void close_facts_Click(object sender, EventArgs e)
        {
            facts_physics.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            help_physics.Visible = true;
        }
    }
}
