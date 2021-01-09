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
    public partial class Scores : Form
    {
        mainMenu mainWindow;
        public Scores(mainMenu menu)
        {
            InitializeComponent();
            mainWindow = menu;

            if (mainWindow.choosenTheme == 1)
            {
                this.BackgroundImage = new Bitmap(".\\..\\..\\picture\\tlo.jpg");
                panel_scores.BackColor=Color.FromArgb(100, 0, 0, 0);
            }
            else
            {
                this.BackColor = Color.FromArgb(209, 238, 244);
                
                this.BackgroundImage = null;
                panel_scores.BackColor = Color.White;
            }

            int scoreIt = mainWindow.scoreIT;
            it_pt.Text = scoreIt.ToString();
            int scoreElectronics = mainWindow.scoreElectronics;
            elect_pt.Text = scoreElectronics.ToString();
            int scoreChemistry = mainWindow.scoreChemistry;
            chemistry_pt.Text = scoreChemistry.ToString();
            int scorePhysics = mainWindow.scorePhysics;
            physics_pt.Text = scorePhysics.ToString();

            starVisibility();
        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            mainWindow.Visible = true;
            this.Close();
        }

        private int checkStars() 
        {
            int numberOfStars = 0;
            int allScores = mainWindow.scoreChemistry + mainWindow.scoreIT + mainWindow.scoreElectronics + mainWindow.scorePhysics;
            if (mainWindow.isPhysicsDone == true)
            {
                numberOfStars++;
            }
            if (mainWindow.isChemistryDone == true)
            {
                numberOfStars++;
            }
            if (mainWindow.isElectronicsDone == true)
            {
                numberOfStars++;
            }
            if (mainWindow.isITDone == true)
            {
                numberOfStars++;
            }
            if (numberOfStars==4 && allScores > 150)
            {
                numberOfStars++;
            }
            return numberOfStars;
        }

        private void starVisibility()
        {
            star0.Visible = false;
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            star5.Visible = false;

           int numberOfStars = checkStars();
           switch(numberOfStars)
            {
                case 0: star0.Visible = true;
                    break;
                case 1:
                    star1.Visible = true;
                    break;
                case 2:
                    star2.Visible = true;
                    break;
                case 3:
                    star3.Visible = true;
                    break;
                case 4:
                    star4.Visible = true;
                    break;
                case 5:
                    star5.Visible = true;
                    break;
            }
        }

    }
}
