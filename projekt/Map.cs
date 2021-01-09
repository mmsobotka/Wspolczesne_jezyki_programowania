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
    public enum Direction { Up, Down, Left, Right, UpLeft, UpRight, DownLeft, DownRight, None }

    public partial class Map : Form
    {
        public static int openedTasks = 0;
        public Direction busDirection=Direction.None;
        public Direction busPrevDirection=Direction.None;
        public mainMenu mainWindow;
        public Chemistry chemistry;
        public Electronics electronics;
        public IT it;
        public Physics physics;
        Point busLocation = new Point();
        Point busOrginalLocation = new Point();
        public SoundPlayer player = new SoundPlayer();
        bool keyUp = false;
        bool keyDown = false;
        bool keyLeft = false;
        bool keyRight = false;
        bool fireworksTick = false;

        public Map(mainMenu menu)
        {
            InitializeComponent();
            mainWindow = menu;

            if (mainWindow.choosenTheme == 1)
            {
                this.BackgroundImage = new Bitmap(".\\..\\..\\picture\\tlop.png");
            }
            else
            {
                this.BackgroundImage = new Bitmap(".\\..\\..\\picture\\tlonieb.png");
            }

            busDownRight.Visible = true;
            openedTasks = 0;
            tasksDone();
            busLocation = busControl.Location;
            busOrginalLocation = busControl.Location;
            timer1.Start();
            help_Map.Visible = false;
            fireworks.Visible = false;
        }      

        public void tasksDone()
        {
            int numberOfTasksDone = 0;
            if (mainWindow.isPhysicsDone == true) 
            {
                ministar1.Visible = true;
                button_physics.FlatAppearance.BorderColor = Color.LimeGreen;
                numberOfTasksDone++;
            }
            if (mainWindow.isChemistryDone == true)
            {
                ministar2.Visible = true;
                button_chemistry.FlatAppearance.BorderColor = Color.LimeGreen;
                numberOfTasksDone++;
            }
            if (mainWindow.isElectronicsDone == true)
            {
                ministar3.Visible = true;
                button_electronics.FlatAppearance.BorderColor = Color.LimeGreen;
                numberOfTasksDone++;
            }
            if (mainWindow.isITDone == true)
            {
                ministar4.Visible = true;
                button_IT.FlatAppearance.BorderColor = Color.LimeGreen;
                numberOfTasksDone++;
            }

            if( numberOfTasksDone == 4)
            {
                gameover.Visible = true;
                gameover_ribbon.Visible = true;
                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + ".\\..\\..\\music\\Fireworks.wav";
                player.Play();
                timer2.Start();
            }
        }

        private void back_to_menu_Click(object sender, EventArgs e)
        {
            mainWindow.Visible = true;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            busMove();
        }

        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyDown = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyRight = true;
            }
        }

        private void Map_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyDown = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyRight = false;
            }
        }

        private void setDirection() 
        {
            busPrevDirection = busDirection;

            if (keyUp == true && keyLeft == true)
            {
                busDirection = Direction.UpLeft;
            }
            else if (keyUp == true && keyRight == true)
            {
                busDirection = Direction.UpRight;
            }
            else if (keyDown == true && keyLeft == true)
            {
                busDirection = Direction.DownLeft;
            }
            else if (keyDown == true && keyRight == true)
            {
                busDirection = Direction.DownRight;
            }
            else if (keyUp == true)
            {
                busDirection = Direction.Up;
            }
            else if (keyDown == true)
            {
                busDirection = Direction.Down;
            }
            else if (keyLeft == true)
            {
                busDirection = Direction.Left;
            }
            else if (keyRight == true)
            {
                busDirection = Direction.Right;
            }
            else 
            {
                busDirection = Direction.None;
            }
        }

        private void busVisibility() 
        {
            busUp.Visible = false;
            busDown.Visible = false;
            busLeft.Visible = false;
            busRight.Visible = false;
            busUpLeft.Visible = false;
            busUpRight.Visible = false;
            busDownLeft.Visible = false;
            busDownRight.Visible = false;
        }

        private void busMove() 
        {
            int speed = 1;
            setDirection();

            switch (busDirection) 
            {    
                case Direction.Up: 
                    {
                        if(busDirection != busPrevDirection)
                        {
                            busVisibility();
                            busUp.Visible = true;
                        }

                        busLocation.Y -= speed;
                        busUp.Location = busLocation;
                    }
                    break;

                case Direction.Down:
                    {
                        if (busDirection != busPrevDirection)
                        {
                            busVisibility();
                            busDown.Visible = true;
                        }

                        busLocation.Y += speed;
                        busDown.Location = busLocation;
                    }
                    break;

                case Direction.Left:
                    {
                        if (busDirection != busPrevDirection)
                        {
                            busVisibility();
                            busLeft.Visible = true;

                        }
                        busLocation.X -= speed;
                        busLeft.Location = busLocation;
                    }
                    break;

                case Direction.Right:
                    {
                        if (busDirection != busPrevDirection)
                        {
                            busVisibility();
                            busRight.Visible = true;

                        }
                        busLocation.X += speed;
                        busRight.Location = busLocation;
                    }
                    break;

                case Direction.UpLeft:
                    {
                        if (busDirection != busPrevDirection)
                        {
                            busVisibility();
                            busUpLeft.Visible = true;
                        }

                        busLocation.Y -= speed;
                        busLocation.X -= speed;
                        busUpLeft.Location = busLocation;
                    }
                    break;

                case Direction.UpRight:
                    {
                        if (busDirection != busPrevDirection)
                        {
                            busVisibility();
                            busUpRight.Visible = true;
                        }

                        busLocation.Y -= speed;
                        busLocation.X += speed;
                        busUpRight.Location = busLocation;
                    }
                    break;

                case Direction.DownLeft:
                    {
                        if (busDirection != busPrevDirection)
                        {
                            busVisibility();
                            busDownLeft.Visible = true;
                        }

                        busLocation.Y += speed;
                        busLocation.X -= speed;
                        busDownLeft.Location = busLocation;
                    }
                    break;

                case Direction.DownRight:
                    {
                        if (busDirection != busPrevDirection)
                        {
                            busVisibility();
                            busDownRight.Visible = true;
                        }

                        busLocation.Y += speed;
                        busLocation.X += speed;
                        busDownRight.Location = busLocation;
                    }
                    break;

                case Direction.None:
                    {

                    }
                    break;
            }
            checkMission();
        }

        private void checkMission() 
        {

            if ((Math.Abs(busLocation.X - button_physics.Location.X) < 30) && (Math.Abs(busLocation.Y - button_physics.Location.Y) < 30))
            {
                startMission1.Visible = true;
            }
            else
            {
                startMission1.Visible = false;
            }

            if ((Math.Abs(busLocation.X - button_chemistry.Location.X) < 30) && (Math.Abs(busLocation.Y - button_chemistry.Location.Y) < 30))
            {
                startMission2.Visible = true;
            }
            else
            {
                startMission2.Visible = false;
            }

            if ((Math.Abs(busLocation.X - button_electronics.Location.X) < 30) && (Math.Abs(busLocation.Y - button_electronics.Location.Y) < 30))
            {
                startMission3.Visible = true;
            }
            else
            {
                startMission3.Visible = false;
            }

            if ((Math.Abs(busLocation.X - button_IT.Location.X) < 30) && (Math.Abs(busLocation.Y - button_IT.Location.Y) < 30))
            {
                startMission4.Visible = true;
            }
            else
            {
                startMission4.Visible = false;
            }
        }

        private void startMission1_Click(object sender, EventArgs e)
        {
            if (openedTasks == 0)
            {
                this.physics = new Physics(this);
                this.physics.Location = this.Location;
                this.physics.StartPosition = FormStartPosition.Manual;
                this.physics.Show();
                this.Visible = false;
            }
        }

        private void startMission2_Click(object sender, EventArgs e)
        {
            if (openedTasks == 0)
            {
                this.chemistry = new Chemistry(this);
                this.chemistry.Location = this.Location;
                this.chemistry.StartPosition = FormStartPosition.Manual;
                this.chemistry.Show();
                this.Visible = false;
            }
        }

        private void startMission3_Click(object sender, EventArgs e)
        {
            if (openedTasks == 0)
            {
                this.electronics = new Electronics(this);
                this.electronics.Location = this.Location;
                this.electronics.StartPosition = FormStartPosition.Manual;
                this.electronics.Show();
                this.Visible = false;
            }
        }

        private void startMission4_Click(object sender, EventArgs e)
        {
            if (openedTasks == 0)
            {
                this.it = new IT(this);
                this.it.Location = this.Location;
                this.it.StartPosition = FormStartPosition.Manual;
                this.it.Show();
                this.Visible = false;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            help_Map.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            help_Map.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (fireworksTick == true)
            {
                fireworks.Visible = true;
            }
            else
            {
                fireworks.Visible = false;
            }
          
            fireworksTick  = !fireworksTick;
        }
    }
}
