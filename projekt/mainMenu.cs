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
    /// MainMenu is the main class. Includes map, options menu and scores window. It stores information about player scores and selected theme.
    /// </summary>
    public partial class mainMenu : Form
    {

        public Map map;
        public Scores scores;
        public Options options;
        public int picAnimation;
        public int choosenTheme = 1;
        public SoundPlayer player = new SoundPlayer();
        public int scoreIT = 0;
        public int scoreChemistry = 0;
        public int scorePhysics = 0;
        public int scoreElectronics = 0;
        public bool isChemistryDone = false;
        public bool isPhysicsDone = false;
        public bool isITDone = false;
        public bool isElectronicsDone = false;

        /// <summary>
        /// Constructor of MainMenu. Initialize sounds.
        /// </summary>
        public mainMenu()
        {
            InitializeComponent();
            picAnimation = 0;

            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + ".\\..\\..\\music\\BackgroundMusic.wav";
            player.Play();
        }

        /// <summary>
        /// Methode setting up choosen theme.
        /// </summary>
        public void changedTheme()
        {
            if (choosenTheme == 1)
            {
                this.BackgroundImage = new Bitmap(".\\..\\..\\picture\\tlo.jpg");
                panel_menu.BackColor = Color.FromArgb(100, 0, 0, 0);
                autobus_biel.Visible = false;
                autobus1.Visible = true;
                label2.Visible = false;
                z.Visible = true;
            }
            else
            {
                this.BackColor = Color.FromArgb(209, 238, 244);
                this.BackgroundImage = null;
                panel_menu.BackColor = Color.White;
                autobus_biel.Visible = true;
                autobus1.Visible = false;
                label2.Visible = true;
                z.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picAnimation == 0)
            {
                this.pictureBox2.Load(".\\..\\..\\picture\\fog1.png");

            }
            else if (picAnimation == 1)
            {
                this.pictureBox2.Load(".\\..\\..\\picture\\fog2.png");
            }
            picAnimation++;

            if (picAnimation == 3)
            {
                picAnimation = 0;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            this.map = new Map(this);
            this.map.Location = this.Location;
            this.map.StartPosition = FormStartPosition.Manual;
            this.map.Show();
            this.Visible = false;
        }

        private void button_scores_Click(object sender, EventArgs e)
        {
            this.scores = new Scores(this);
            this.scores.Location = this.Location;
            this.scores.StartPosition = FormStartPosition.Manual;
            this.scores.Show();
            this.Visible = false;
        }

        private void button_options_Click(object sender, EventArgs e)
        {
            this.options = new Options(this);
            this.options.Location = this.Location;
            this.options.StartPosition = FormStartPosition.Manual;
            this.options.Show();
            this.Visible = false;
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            panel_menu.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
