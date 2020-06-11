using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Memory
{
    public partial class MainMenu : Form
    {
        System.Windows.Forms.Timer timer;

        public MainMenu()
        {
            InitializeComponent();
            this.Controls.Add(pictureBox1);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += (sender, args) =>
            {
                Random random = new Random();
                int pic = random.Next(1, 21);
                switch (pic)
                {
                    case 1:
                        pictureBox1.Image = Memory.Properties.Resources.Atlanta_Reign;
                        break;
                    case 2:
                        pictureBox1.Image = Memory.Properties.Resources.Boston_Uprising;
                        break;
                    case 3:
                        pictureBox1.Image = Memory.Properties.Resources.Chengou_Hunters;
                        break;
                    case 4:
                        pictureBox1.Image = Memory.Properties.Resources.Dallas_Fuel;
                        break;
                    case 5:
                        pictureBox1.Image = Memory.Properties.Resources.Florida_Mayhem;
                        break;
                    case 6:
                        pictureBox1.Image = Memory.Properties.Resources.Guangzhou_Charge;
                        break;
                    case 7:
                        pictureBox1.Image = Memory.Properties.Resources.Hangzhou_Spark;
                        break;
                    case 8:
                        pictureBox1.Image = Memory.Properties.Resources.Houston_Outlaws;
                        break;
                    case 9:
                        pictureBox1.Image = Memory.Properties.Resources.LA_Gladiators;
                        break;
                    case 10:
                        pictureBox1.Image = Memory.Properties.Resources.LA_Valiant;
                        break;
                    case 11:
                        pictureBox1.Image = Memory.Properties.Resources.London_Spitfire;
                        break;
                    case 12:
                        pictureBox1.Image = Memory.Properties.Resources.New_York_Excelsior;
                        break;
                    case 13:
                        pictureBox1.Image = Memory.Properties.Resources.Paris_Eternal;
                        break;
                    case 14:
                        pictureBox1.Image = Memory.Properties.Resources.Philadelphia_Fusion;
                        break;
                    case 15:
                        pictureBox1.Image = Memory.Properties.Resources.Sanfran_Shock;
                        break;
                    case 16:
                        pictureBox1.Image = Memory.Properties.Resources.Seoul_Dynasty;
                        break;
                    case 17:
                        pictureBox1.Image = Memory.Properties.Resources.Shanghai_Dragons;
                        break;
                    case 18:
                        pictureBox1.Image = Memory.Properties.Resources.Toronto_Defiant;
                        break;
                    case 19:
                        pictureBox1.Image = Memory.Properties.Resources.Vancouver_Titans;
                        break;
                    case 20:
                        pictureBox1.Image = Memory.Properties.Resources.Washington_Justice;
                        break;
                }
                
            };
            timer.Start();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Are you sure you want to quit?", "Close?", MessageBoxButtons.YesNo);
            e.Cancel = (window == DialogResult.No);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Christian Mascunana" + Environment.NewLine + "All Images Copywrite Blizzard-Activision", "Info", MessageBoxButtons.OK);
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowToPlay Tutorial = new HowToPlay();
            Tutorial.RefToMainMenu = this;
            this.Visible = false;
            Tutorial.Show();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game MainGame = new Game();
            MainGame.RefToMainMenu = this;
            this.Visible = false;
            MainGame.Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Game MainGame = new Game();
            MainGame.RefToMainMenu = this;
            this.Visible = false;
            MainGame.Show();
        }
    }
}
