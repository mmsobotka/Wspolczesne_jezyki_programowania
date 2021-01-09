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
    public partial class IT : Form
    {
        Map mainWindowMap;
        Random random = new Random();
        Point[] locations = new Point[3];
        Point[] orginalLocations = new Point[3];
        int correctGameAnswear = -1;
        int correctAnswears = 0;
        bool isAnswered = false;
        int score = 0;
        int combo = 1;
       
        public IT(Map map)
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
            locations[0] = number1.Location;
            locations[1] = number2.Location;
            locations[2] = number3.Location;

            orginalLocations[0] = number1.Location;
            orginalLocations[1] = number2.Location;
            orginalLocations[2] = number3.Location;
            generateGame();
            help_IT.Visible = false;
            facts_IT.Visible = false;
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
        private void start_Click(object sender, EventArgs e)
        {
            generateGame();
        }

        private void generateGame()
        {
            int[] numbers = new int[3];

            for (int number = 0; number <= 2; number++)
            {
                numbers[number] = random.Next(0, 255);
            }

            number1.Text = numbers[0].ToString();
            number2.Text = numbers[1].ToString();
            number3.Text = numbers[2].ToString();

            int selectedIndexOfNumbers = random.Next(0, 2);
            string binary = Convert.ToString(numbers[selectedIndexOfNumbers], 2);
            binarylabel.Text = binary;
            correctGameAnswear = numbers[selectedIndexOfNumbers];

            number1.Left = orginalLocations[0].X;
            number1.Top = orginalLocations[0].Y;

            number2.Left = orginalLocations[1].X;
            number2.Top = orginalLocations[1].Y;

            number3.Left = orginalLocations[2].X;
            number3.Top = orginalLocations[2].Y;

            good.Visible = false;
            bad.Visible = false;
            isAnswered = false;
        }

        private void onMouseDownOption1(object sender, MouseEventArgs e)
        {
            locations[0] = e.Location;
        }

        private void onMouseDownOption2(object sender, MouseEventArgs e)
        {
            locations[1] = e.Location;
        }

        private void onMouseDownOption3(object sender, MouseEventArgs e)
        {
            locations[2] = e.Location;
        }

        private void onMouseMoveOption1(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && isAnswered == false)
            {                
                number1.Left += e.X - locations[0].X;
                number1.Top += e.Y - locations[0].Y;
            }

            if (number1.Bounds.IntersectsWith(answer.Bounds) && isAnswered == false)
            {
                isAnswered = true;
                number1.Location = answer.Location;

                if (correctGameAnswear== Convert.ToInt32(number1.Text))
                {
                    good.Visible = true;
                    score += 10*combo;
                    mainWindowMap.mainWindow.scoreIT += 10 * combo;
                    correctAnswears++;
                    if (combo <=5)
                    {                        
                        comboNumber.Text = "x"+ combo.ToString();
                        combo++;
                    }   
                }
                else
                {
                    bad.Visible = true;
                    score -= 10;
                    mainWindowMap.mainWindow.scoreIT -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                }

                points.Text = score.ToString();
            }            
        }
        private void onMouseMoveOption2(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && isAnswered == false)
            {
                number2.Left += e.X - locations[1].X;
                number2.Top += e.Y - locations[1].Y;
            }

            if (number2.Bounds.IntersectsWith(answer.Bounds) && isAnswered == false)
            {
                isAnswered = true;
                number2.Location = answer.Location;

                if (correctGameAnswear == Convert.ToInt32(number2.Text))
                {
                    good.Visible = true;
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scoreIT += 10 * combo;
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
                    mainWindowMap.mainWindow.scoreIT -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                }
                points.Text = score.ToString();
            }
        }
        private void onMouseMoveOption3(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && isAnswered == false)
            {
                number3.Left += e.X - locations[2].X;
                number3.Top += e.Y - locations[2].Y;
            }

            if (number3.Bounds.IntersectsWith(answer.Bounds) && isAnswered==false)
            {
                isAnswered = true;
                number3.Location = answer.Location;

                if (correctGameAnswear == Convert.ToInt32(number3.Text))
                {
                    good.Visible = true;
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scoreIT += 10 * combo;
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
                    mainWindowMap.mainWindow.scoreIT -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                }
                points.Text = score.ToString();
            }
            
        }
        private void isGameDone()
        {
            if (correctAnswears >= 5)
            {
                mainWindowMap.mainWindow.isITDone = true;
                mainWindowMap.tasksDone();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            help_IT.Visible = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            help_IT.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            facts_IT.Visible = true;
        }

        private void close_facts_Click(object sender, EventArgs e)
        {
            facts_IT.Visible = false;
        }
    }
}
