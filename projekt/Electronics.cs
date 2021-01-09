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
    /// <summary>
    /// Electronics class is one of the tasks to be played by the user. The topic of the task is logical gateways 
    /// and the basics of digital technology
    /// </summary>
    public partial class Electronics : Form
    {
        bool a = false;
        bool b = false;
        bool c = false;
        bool d = false;
        bool isAnswer0 = false;
        bool isAnswer1 = false;
        int score = 0;
        int combo = 1;
        int correctAnswears = 0;
        bool isGame1Clicked = false;
        bool isGame2Clicked = false;

        string[] gatesNames = { "AND", "NAND", "NOR", "OR", "XOR", "NOT" };
        string gateName;

        Random random = new Random();
        /// <summary>
        /// Constructor of Electronics. Generate task and visibility of controls.
        /// </summary>
        /// <param name="map"></param>
        public Electronics(Map map)
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
            help_electronics.Visible = false;
            facts_electronics.Visible = false;
            generateGame();
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

        private void bit1_off_Click(object sender, EventArgs e)
        {
            bit1_off.Visible = false;
            bit1_on.Visible = true;
            bit0_off.Visible = true;
            bit0_on.Visible = false;

            isAnswer0 = false;
            isAnswer1 = true;
        }

        private void bit0_off_Click(object sender, EventArgs e)
        {
            bit0_off.Visible = false;
            bit0_on.Visible = true;
            bit1_off.Visible = true;
            bit1_on.Visible = false;

            isAnswer0 = true;
            isAnswer1 = false;
        }

        private void bit1_on_Click(object sender, EventArgs e)
        {
            bit1_off.Visible = true;
            bit1_on.Visible = false;

            isAnswer1 = false;
        }

        private void bit0_on_Click(object sender, EventArgs e)
        {
            bit0_off.Visible = true;
            bit0_on.Visible = false;

            isAnswer0 = false;
        }

        private bool checkGate()
        {
            bool gate1 = !(a || b);
            bool gate2 = !(gate1 && c);
            bool gate3 = !(c || d);
            bool gate4 = !(gate2 && gate3);

            return gate4;
        }

        private void start_Click(object sender, EventArgs e)
        {
            generateGame();
        }

        private void generateGame()
        {
            isGame1Clicked = false;
            isGame2Clicked = false;

            check_good.Visible = false;
            check_bad.Visible = false;
            check_Gate.Visible = true;

            bit1_off.Visible = true;
            bit1_on.Visible = false;
            bit0_off.Visible = true;
            bit0_on.Visible = false;

            a = (random.Next(0, 2) == 0);
            b = (random.Next(0, 2) == 0);
            c = (random.Next(0, 2) == 0);
            d = (random.Next(0, 2) == 0);

            labela.Text = Convert.ToInt32(a).ToString();
            labelb.Text = Convert.ToInt32(b).ToString();
            labelc.Text = Convert.ToInt32(c).ToString();
            labeld.Text = Convert.ToInt32(d).ToString();

            int selectedIndexOfGates = random.Next(0, 6);
            gateName = gatesNames[selectedIndexOfGates];
            labelgate.Text = gateName;

            and.BackColor = Color.Transparent;
            nand.BackColor = Color.Transparent;
            nor.BackColor = Color.Transparent;
            or.BackColor = Color.Transparent;
            xor.BackColor = Color.Transparent;
            not.BackColor = Color.Transparent;
        }

        private void check_Gate_Click(object sender, EventArgs e)
        {
            if (isGame1Clicked == false)
            {
                bool result = checkGate();

                if (result == true && isAnswer1 == true)
                {
                    score += 10;
                    mainWindowMap.mainWindow.scoreElectronics += 10;
                    correctAnswears++;
                    check_good.Visible = true;
                    check_bad.Visible = false;
                    check_Gate.Visible = false;
                }
                else if (result == false && isAnswer0 == true)
                {
                    score += 10;
                    mainWindowMap.mainWindow.scoreElectronics += 10;
                    correctAnswears++;
                    check_good.Visible = true;
                    check_bad.Visible = false;
                    check_Gate.Visible = false;
                }
                else
                {
                    score -= 10;
                    mainWindowMap.mainWindow.scoreElectronics -= 10;
                    check_good.Visible = false;
                    check_bad.Visible = true;
                    check_Gate.Visible = false;
                }

                points.Text = score.ToString();
                isGame1Clicked = true;
            }
        }

        private void and_Click(object sender, EventArgs e)
        {
            if (isGame2Clicked == false)
            {
                if (gateName == "AND")
                {
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scoreElectronics += 10 * combo;
                    correctAnswears++;
                    if (combo <= 5)
                    {
                        comboNumber.Text = "x" + combo.ToString();
                        combo++;
                    }
                    and.BackColor = Color.LightGreen;
                }
                else
                {
                    score -= 10;
                    mainWindowMap.mainWindow.scoreElectronics -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                    and.BackColor = Color.FromArgb(241, 78, 86);
                }
                points.Text = score.ToString();
                isGame2Clicked = true;
            }
        }

        private void not_Click(object sender, EventArgs e)
        {
            if (isGame2Clicked == false)
            {
                if (gateName == "NOT")
                {
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scoreElectronics += 10 * combo;
                    correctAnswears++;
                    if (combo <= 5)
                    {
                        comboNumber.Text = "x" + combo.ToString();
                        combo++;
                    }
                    not.BackColor = Color.LightGreen;
                }
                else
                {
                    score -= 10;
                    mainWindowMap.mainWindow.scoreElectronics -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                    not.BackColor = Color.FromArgb(241, 78, 86);
                }
                points.Text = score.ToString();
                isGame2Clicked = true;
            }
        }

        private void nand_Click(object sender, EventArgs e)
        {
            if (isGame2Clicked == false)
            {
                if (gateName == "NAND")
                {
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scoreElectronics += 10 * combo;
                    correctAnswears++;
                    if (combo <= 5)
                    {
                        comboNumber.Text = "x" + combo.ToString();
                        combo++;
                    }
                    nand.BackColor = Color.LightGreen;
                }
                else
                {
                    score -= 10;
                    mainWindowMap.mainWindow.scoreElectronics -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                    nand.BackColor = Color.FromArgb(241, 78, 86);
                }
                points.Text = score.ToString();
                isGame2Clicked = true;
            }
        }

        private void or_Click(object sender, EventArgs e)
        {
            if (isGame2Clicked == false)
            {
                if (gateName == "OR")
                {
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scoreElectronics += 10 * combo;
                    correctAnswears++;
                    if (combo <= 5)
                    {
                        comboNumber.Text = "x" + combo.ToString();
                        combo++;
                    }
                    or.BackColor = Color.LightGreen;
                }
                else
                {
                    score -= 10;
                    mainWindowMap.mainWindow.scoreElectronics -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                    or.BackColor = Color.FromArgb(241, 78, 86);
                }
                points.Text = score.ToString();
                isGame2Clicked = true;
            }
        }

        private void nor_Click(object sender, EventArgs e)
        {
            if (isGame2Clicked == false)
            {
                if (gateName == "NOR")
                {
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scoreElectronics += 10 * combo;
                    correctAnswears++;
                    if (combo <= 5)
                    {
                        comboNumber.Text = "x" + combo.ToString();
                        combo++;
                    }
                    nor.BackColor = Color.LightGreen;
                }
                else
                {
                    score -= 10;
                    mainWindowMap.mainWindow.scoreElectronics -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                    nor.BackColor = Color.FromArgb(241, 78, 86);
                }
                points.Text = score.ToString();
                isGame2Clicked = true;
            }
        }

        private void xor_Click(object sender, EventArgs e)
        {
            if (isGame2Clicked == false)
            {
                if (gateName == "XOR")
                {
                    score += 10 * combo;
                    mainWindowMap.mainWindow.scoreElectronics += 10 * combo;
                    correctAnswears++;
                    if (combo <= 5)
                    {
                        comboNumber.Text = "x" + combo.ToString();
                        combo++;
                    }
                    xor.BackColor = Color.LightGreen;
                }
                else
                {
                    score -= 10;
                    mainWindowMap.mainWindow.scoreElectronics -= 10;
                    combo = 1;
                    comboNumber.Text = "";
                    xor.BackColor = Color.FromArgb(241, 78, 86);
                }
                points.Text = score.ToString();
                isGame2Clicked = true;
            }
        }
        private void isGameDone()
        {
            if (correctAnswears >= 5)
            {
                mainWindowMap.mainWindow.isElectronicsDone = true;
                mainWindowMap.tasksDone();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            help_electronics.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            facts_electronics.Visible = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            help_electronics.Visible = false;
        }

        private void close_facts_Click(object sender, EventArgs e)
        {
            facts_electronics.Visible = false;
        }
    }
}
