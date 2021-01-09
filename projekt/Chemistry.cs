using System;
using System.Collections;
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
    public partial class Chemistry : Form
    {
        Map mainWindowMap;
        int selectedIndexOfPicture = 0;
        int selectedIndexOfSymbols = 0;
        Element[] elements = new Element[8];
        Random random = new Random();
        int score = 0;
        int combo = 1;
        int correctAnswears = 0;
        Dictionary<string, string> elementsNames = new Dictionary<string, string>()
        {
            {"Magnez", "Mg" },
            {"Tlen", "O" },
            {"Glin", "Al" },
            {"Fluor", "F" },
            {"Neon", "N" },
            {"Siarka", "S" },
            {"Cez", "Cs" },
            {"Lit", "Li" },
            {"Polon", "Po" },
            {"Jod", "I" },
            {"Fosfor", "P" },
            {"Nikiel", "Ni" },
            {"Kobalt", "Co" },
            {"Tytan", "Ti" },
            {"Beryl", "Be" },
            {"Stront", "Sr" },
            {"Molibden", "Mo" },
        };             

        public Chemistry(Map map)
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
            elements[0] = new Element("25", "54,938", "II III IV VI VII", "Mn", "mangan");
            elements[1] = new Element("8", "15,999", "II", "O", "tlen");
            elements[2] = new Element("17", "35,45", "I III V VII", "Cl", "chlor");
            elements[3] = new Element("19", "39,098", "I", "K", "potas");
            elements[4] = new Element("1", "1,008", "I", "H", "wodor");
            elements[5] = new Element("2", "4,003", "0", "He", "hel");
            elements[6] = new Element("20", "40,078", "II", "Ca", "wapn");
            elements[7] = new Element("30", "65,38", "II", "Zn", "cynk");
            help_chemistry.Visible = false;
            facts_chemistry.Visible = false;
            generateGame();
            refresh();
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

        private void generateGame()
        {
            noVisibility();
            selectedIndexOfPicture = random.Next(0, 7);
            visibility();
            selectedIndexOfSymbols = random.Next(0, 17);
            string selectedElementName= elementsNames.ElementAt(selectedIndexOfSymbols).Key;
            labelElementName.Text = selectedElementName;
        }

        private void noVisibility()
        {
            mangan.Visible = false;
            tlen.Visible = false;
            chlor.Visible = false;
            potas.Visible = false;
            wodor.Visible = false;
            hel.Visible = false;
            wapn.Visible = false;
            cynk.Visible = false;
        }

        private void visibility()
        {
            if (selectedIndexOfPicture == 0)
            {
                mangan.Visible = true;
            }
            else if (selectedIndexOfPicture == 1)
            {
                tlen.Visible = true;
            }
            else if (selectedIndexOfPicture == 2)
            {
                chlor.Visible = true;
            }
            else if (selectedIndexOfPicture == 3)
            {
                potas.Visible = true;
            }
            else if (selectedIndexOfPicture == 4)
            {
                wodor.Visible = true;
            }
            else if (selectedIndexOfPicture == 5)
            {
                hel.Visible = true;
            }
            else if (selectedIndexOfPicture == 6)
            {
                wapn.Visible = true;
            }
            else
            {
                cynk.Visible = true;
            }            
        }

        private void start_Click(object sender, EventArgs e)
        {
            refresh();
            generateGame();            
        }

        private void checkTask1(object sender, EventArgs e)
        {
            checkElement();
        }

        private void checkTask2(object sender, EventArgs e)
        {
            checkSymbols();
        }

        private void checkElement()
        {
            if (textBox1.Text == elements[selectedIndexOfPicture].liczbaAtomowa)
            {
                score += 10;
                mainWindowMap.mainWindow.scoreChemistry += 10;
                correctAnswears++;
                textBox1.BackColor = Color.LightGreen;
                check_bad1.Visible = false;
                check_good1.Visible = true;
                check.Visible = false;
            }
            else
            {
                score -= 10;
                mainWindowMap.mainWindow.scoreChemistry -= 10;
                textBox1.BackColor = Color.FromArgb(241,78,86);
                check_bad1.Visible = true;
                check_good1.Visible = false;
                check.Visible = false;
            }

            if (textBox2.Text == elements[selectedIndexOfPicture].wartosciowosc)
            {
                score += 10;
                mainWindowMap.mainWindow.scoreChemistry += 10;
                correctAnswears++;
                textBox2.BackColor = Color.LightGreen;
                check_bad1.Visible = false;
                check_good1.Visible = true;
                check.Visible = false;
            }
            else
            {
                score -= 10;
                mainWindowMap.mainWindow.scoreChemistry -= 10;
                textBox2.BackColor = Color.FromArgb(241, 78, 86);
                check_bad1.Visible = true;
                check_good1.Visible = false;
                check.Visible = false;
            }

            if (textBox3.Text == elements[selectedIndexOfPicture].masaAtomowa)
            {
                score += 10;
                mainWindowMap.mainWindow.scoreChemistry += 10;
                correctAnswears++;
                textBox3.BackColor = Color.LightGreen;
                check_bad1.Visible = false;
                check_good1.Visible = true;
                check.Visible = false;
            }
            else
            {
                score -= 10;
                mainWindowMap.mainWindow.scoreChemistry -= 10;
                textBox3.BackColor = Color.FromArgb(241, 78, 86);
                check_bad1.Visible = true;
                check_good1.Visible = false;
                check.Visible = false;
            }

            if (textBox4.Text == elements[selectedIndexOfPicture].nazwaPierwiastka)
            {
                score += 10;
                mainWindowMap.mainWindow.scoreChemistry += 10;
                correctAnswears++;
                textBox4.BackColor = Color.LightGreen;
                check_bad1.Visible = false;
                check_good1.Visible = true;
                check.Visible = false;
            }
            else
            {
                score -= 10;
                mainWindowMap.mainWindow.scoreChemistry -= 10;
                textBox4.BackColor = Color.FromArgb(241, 78, 86);
                check_bad1.Visible = true;
                check_good1.Visible = false;
                check.Visible = false;
            }

            if (textBox5.Text == elements[selectedIndexOfPicture].symbolPierwiastka)
            {
                score += 10;
                mainWindowMap.mainWindow.scoreChemistry += 10;
                correctAnswears++;
                textBox5.BackColor = Color.LightGreen;
                check_bad1.Visible = false;
                check_good1.Visible = true;
                check.Visible = false;
            }
            else
            {
                score -= 10;
                mainWindowMap.mainWindow.scoreChemistry -= 10;
                textBox5.BackColor = Color.FromArgb(241, 78, 86);
                check_bad1.Visible = true;
                check_good1.Visible = false;
                check.Visible = false;
            }

            points.Text = score.ToString();
        }

        private void checkSymbols()
        {
            string elementName = labelElementName.Text;
            string elementSymbol = elementsNames[elementName];
            if (answerSymbol.Text == elementSymbol)
            {
                score += 10*combo;
                mainWindowMap.mainWindow.scoreChemistry += 10 * combo;
                correctAnswears++;
                if (combo <= 5)
                {
                    comboNumber1.Text = "x" + combo.ToString();
                    combo++;
                }
                answerSymbol.BackColor = Color.LightGreen;
                check_bad2.Visible = false;
                check_good2.Visible = true;
                checkSymbol.Visible = false;
            }
            else
            {
                score -= 10;
                mainWindowMap.mainWindow.scoreChemistry -= 10;
                combo = 1;
                answerSymbol.BackColor = Color.FromArgb(241, 78, 86);
                comboNumber1.Text = "";
                check_bad2.Visible = true;
                check_good2.Visible = false;
                checkSymbol.Visible = false;
            }
            points.Text = score.ToString();
        }

        private void refresh()
        {
            answerSymbol.Text = "";
            answerSymbol.BackColor = Color.White;

            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox2.Text = "";
            textBox2.BackColor = Color.White;
            textBox3.Text = "";
            textBox3.BackColor = Color.White;
            textBox4.Text = "";
            textBox4.BackColor = Color.White;
            textBox5.Text = "";
            textBox5.BackColor = Color.White;

            check_bad2.Visible = false;
            check_good2.Visible = false;
            checkSymbol.Visible = true;
            check_bad1.Visible = false;
            check_good1.Visible = false;
            check.Visible = true;
        }
        private void isGameDone()
        {
            if (correctAnswears >= 5)
            {
                mainWindowMap.mainWindow.isChemistryDone = true;
                mainWindowMap.tasksDone();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            help_chemistry.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            help_chemistry.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            facts_chemistry.Visible = true;
        }

        private void close_facts_Click(object sender, EventArgs e)
        {
            facts_chemistry.Visible = false;
        }
    }
}
