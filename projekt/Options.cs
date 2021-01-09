using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    /// <summary>
    /// The Options class is one of the menu class. This class displays the game options.
    /// </summary>
    public partial class Options : Form
    {
        mainMenu mainWindow;
        /// <summary>
        /// Constructor of Options. Generate option menu, visibility and text of controls, background of theme.
        /// </summary>
        /// <param name="menu"></param>
        public Options(mainMenu menu)
        {
            InitializeComponent();
            mainWindow = menu;

            if (mainWindow.choosenTheme == 1)
            {
                picture_l.Visible = true;
                picture_r.Visible = false;
                this.BackgroundImage = new Bitmap(".\\..\\..\\picture\\tlo.jpg");
                panel_options.BackColor = Color.FromArgb(100, 0, 0, 0);
            }
            else
            {
                picture_r.Visible = true;
                picture_l.Visible = false;
                this.BackColor = Color.FromArgb(209, 238, 244);
                this.BackgroundImage = null;
                panel_options.BackColor = Color.White;
            }
            panel_help.Visible = false;
        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            mainWindow.Visible = true;
            this.Close();
        }

        private void soundx_Click(object sender, EventArgs e)
        {
            mainWindow.player.Play();
            sound.Visible = true;
            soundx.Visible = false;
        }

        private void sound_Click(object sender, EventArgs e)
        {
            mainWindow.player.Stop();
            soundx.Visible = true;
            sound.Visible = false;
        }

        private void picture_r_Click(object sender, EventArgs e)
        {
            picture_l.Visible = true;
            picture_r.Visible = false;

            mainWindow.choosenTheme = 1;
            mainWindow.changedTheme();

            this.BackgroundImage = new Bitmap(".\\..\\..\\picture\\tlo.jpg");
            panel_options.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void picture_l_Click(object sender, EventArgs e)
        {
            picture_r.Visible = true;
            picture_l.Visible = false;

            mainWindow.choosenTheme = 2;
            mainWindow.changedTheme();

            this.BackColor = Color.FromArgb(209, 238, 244);
            panel_options.BackColor = Color.White;
            this.BackgroundImage = null;
        }

        private void help_Click(object sender, EventArgs e)
        {
            panel_help.Visible = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            panel_help.Visible = false;
        }
    }
}
