using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Game : Form
    {
        public Form RefToMainMenu { get; set; }
        int image, i, spot, pic1, pic2, guess1=-1, guess2=-1, score;
        bool correctguess=false;
        int[] imagesused = new int [20];
        int[] spotsused = new int[24];
        int[,] matches = new int[12, 2];
        int[] bothguess = new int[2];
        
        public Game()
        {
            InitializeComponent();
            cards[0] = pbxR1C1;
            cards[1] = pbxR1C2;
            cards[2] = pbxR1C3;
            cards[3] = pbxR1C4;
            cards[4] = pbxR1C5;
            cards[5] = pbxR2C1;
            cards[6] = pbxR2C2;
            cards[7] = pbxR2C3;
            cards[8] = pbxR2C4;
            cards[9] = pbxR2C5;
            cards[10] = pbxR3C1;
            cards[11] = pbxR3C2;
            cards[12] = pbxR3C4;
            cards[13] = pbxR3C5;
            cards[14] = pbxR4C1;
            cards[15] = pbxR4C2;
            cards[16] = pbxR4C3;
            cards[17] = pbxR4C4;
            cards[18] = pbxR4C5;
            cards[19] = pbxR5C1;
            cards[20] = pbxR5C2;
            cards[21] = pbxR5C3;
            cards[22] = pbxR5C4;
            cards[23] = pbxR5C5;

            button[0] = btnR1C1;
            button[1] = btnR1C2;
            button[2] = btnR1C3;
            button[3] = btnR1C4;
            button[4] = btnR1C5;
            button[5] = btnR2C1;
            button[6] = btnR2C2;
            button[7] = btnR2C3;
            button[8] = btnR2C4;
            button[9] = btnR2C5;
            button[10] = btnR3C1;
            button[11] = btnR3C2;
            button[12] = btnR3C4;
            button[13] = btnR3C5;
            button[14] = btnR4C1;
            button[15] = btnR4C2;
            button[16] = btnR4C3;
            button[17] = btnR4C4;
            button[18] = btnR4C5;
            button[19] = btnR5C1;
            button[20] = btnR5C2;
            button[21] = btnR5C3;
            button[22] = btnR5C4;
            button[23] = btnR5C5;
        }
        Button[] button = new Button[24];
        PictureBox[] cards = new PictureBox[24];
        private void Game_Load(object sender, EventArgs e)
        {
            
                chooseimage();
            
            
        }

        public void chooseimage()
        {
            for (i = 0; i < 12; i++)
            {
                bool imagechosen = false;
                while (!imagechosen)
                {
                    Random random = new Random();
                    image = random.Next(1, 21);
                    switch (image)
                    {
                        case 1:
                            if (imagesused[0] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[0] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Atlanta_Reign;
                                cards[pic2].Image = Memory.Properties.Resources.Atlanta_Reign;
                            }
                            break;
                        case 2:
                            if (imagesused[1] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[1] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Boston_Uprising;
                                cards[pic2].Image = Memory.Properties.Resources.Boston_Uprising;
                            }
                            break;
                        case 3:
                            if (imagesused[2] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[2] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Chengou_Hunters;
                                cards[pic2].Image = Memory.Properties.Resources.Chengou_Hunters;
                            }
                            break;
                        case 4:
                            if (imagesused[3] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[3] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Dallas_Fuel;
                                cards[pic2].Image = Memory.Properties.Resources.Dallas_Fuel;
                            }
                            break;
                        case 5:
                            if (imagesused[4] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[4] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Florida_Mayhem;
                                cards[pic2].Image = Memory.Properties.Resources.Florida_Mayhem;
                            }
                            break;
                        case 6:
                            if (imagesused[5] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[5] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Guangzhou_Charge;
                                cards[pic2].Image = Memory.Properties.Resources.Guangzhou_Charge;
                            }
                            break;
                        case 7:
                            if (imagesused[6] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[6] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Hangzhou_Spark;
                                cards[pic2].Image = Memory.Properties.Resources.Hangzhou_Spark;
                            }
                            break;
                        case 8:
                            if (imagesused[7] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[7] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Houston_Outlaws;
                                cards[pic2].Image = Memory.Properties.Resources.Houston_Outlaws;
                            }
                            break;
                        case 9:
                            if (imagesused[8] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[8] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.LA_Gladiators;
                                cards[pic2].Image = Memory.Properties.Resources.LA_Gladiators;
                            }
                            break;
                        case 10:
                            if (imagesused[9] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[9] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.LA_Valiant;
                                cards[pic2].Image = Memory.Properties.Resources.LA_Valiant;
                            }
                            break;
                        case 11:
                            if (imagesused[10] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[10] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.London_Spitfire;
                                cards[pic2].Image = Memory.Properties.Resources.London_Spitfire;
                            }
                            break;
                        case 12:
                            if (imagesused[11] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[11] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.New_York_Excelsior;
                                cards[pic2].Image = Memory.Properties.Resources.New_York_Excelsior;
                            }
                            break;
                        case 13:
                            if (imagesused[12] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[12] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Paris_Eternal;
                                cards[pic2].Image = Memory.Properties.Resources.Paris_Eternal;
                            }
                            break;
                        case 14:
                            if (imagesused[13] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[13] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Philadelphia_Fusion;
                                cards[pic2].Image = Memory.Properties.Resources.Philadelphia_Fusion;
                            }
                            break;
                        case 15:
                            if (imagesused[14] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[14] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Sanfran_Shock;
                                cards[pic2].Image = Memory.Properties.Resources.Sanfran_Shock;
                            }
                            break;
                        case 16:
                            if (imagesused[15] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[15] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Seoul_Dynasty;
                                cards[pic2].Image = Memory.Properties.Resources.Seoul_Dynasty;
                            }
                            break;
                        case 17:
                            if (imagesused[16] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[16] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Shanghai_Dragons;
                                cards[pic2].Image = Memory.Properties.Resources.Shanghai_Dragons;
                            }
                            break;
                        case 18:
                            if (imagesused[17] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[17] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Toronto_Defiant;
                                cards[pic2].Image = Memory.Properties.Resources.Toronto_Defiant;
                            }
                            break;
                        case 19:
                            if (imagesused[18] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[18] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Vancouver_Titans;
                                cards[pic2].Image = Memory.Properties.Resources.Vancouver_Titans;
                            }
                            break;
                        case 20:
                            if (imagesused[19] == 0)
                            {
                                imagechosen = !imagechosen;
                                imagesused[19] = 1;
                                choosespots();
                                cards[pic1].Image = Memory.Properties.Resources.Washington_Justice;
                                cards[pic2].Image = Memory.Properties.Resources.Washington_Justice;
                            }
                            break;
                    }
                }
            }
        }

        private void choosespots()
        {
            pic1 = -1;
            pic2 = -1;
            bool spot1, spot2;
            spot1 = false;
            spot2 = false;
            while (!spot1 || !spot2)
            {
                Random random2 = new Random();
                spot = random2.Next(1, 25);
                switch (spot)
                {
                    case 1:
                        if (spotsused[0] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[0] = 1;
                                pic1 = 0;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[0] = 1;
                                pic2 = 0;
                            }
                        }
                        break;
                    case 2:
                        if (spotsused[1] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[1] = 1;
                                pic1 = 1;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[1] = 1;
                                pic2 = 1;
                            }
                        }
                        break;
                    case 3:
                        if (spotsused[2] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[2] = 1;
                                pic1 = 2;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[2] = 1;
                                pic2 = 2;
                            }
                        }
                        break;
                    case 4:
                        if (spotsused[3] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[3] = 1;
                                pic1 = 3;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[3] = 1;
                                pic2 = 3;
                            }
                        }
                        break;
                    case 5:
                        if (spotsused[4] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[4] = 1;
                                pic1 = 4;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[4] = 1;
                                pic2 = 4;
                            }
                        }
                        break;
                    case 6:
                        if (spotsused[5] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[5] = 1;
                                pic1 = 5;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[5] = 1;
                                pic2 = 5;
                            }
                        }
                        break;
                    case 7:
                        if (spotsused[6] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[6] = 1;
                                pic1 = 6;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[6] = 1;
                                pic2 = 6;
                            }
                        }
                        break;
                    case 8:
                        if (spotsused[7] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[7] = 1;
                                pic1 = 7;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[7] = 1;
                                pic2 = 7;
                            }
                        }
                        break;
                    case 9:
                        if (spotsused[8] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[8] = 1;
                                pic1 = 8;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[8] = 1;
                                pic2 = 8;
                            }
                        }
                        break;
                    case 10:
                        if (spotsused[9] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[9] = 1;
                                pic1 = 9;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[9] = 1;
                                pic2 = 9;
                            }
                        }
                        break;
                    case 11:
                        if (spotsused[10] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[10] = 1;
                                pic1 = 10;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[10] = 1;
                                pic2 = 10;
                            }
                        }
                        break;
                    case 12:
                        if (spotsused[11] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[11] = 1;
                                pic1 = 11;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[11] = 1;
                                pic2 = 11;
                            }
                        }
                        break;
                    case 13:
                        if (spotsused[12] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[12] = 1;
                                pic1 = 12;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[12] = 1;
                                pic2 = 12;
                            }
                        }
                        break;
                    case 14:
                        if (spotsused[13] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[13] = 1;
                                pic1 = 13;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[13] = 1;
                                pic2 = 13;
                            }
                        }
                        break;
                    case 15:
                        if (spotsused[14] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[14] = 1;
                                pic1 = 14;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[14] = 1;
                                pic2 = 14;
                            }
                        }
                        break;
                    case 16:
                        if (spotsused[15] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[15] = 1;
                                pic1 = 15;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[15] = 1;
                                pic2 = 15;
                            }
                        }
                        break;
                    case 17:
                        if (spotsused[16] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[16] = 1;
                                pic1 = 16;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[16] = 1;
                                pic2 = 16;
                            }
                        }
                        break;
                    case 18:
                        if (spotsused[17] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[17] = 1;
                                pic1 = 17;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[17] = 1;
                                pic2 = 17;
                            }
                        }
                        break;
                    case 19:
                        if (spotsused[18] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[18] = 1;
                                pic1 = 18;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[18] = 1;
                                pic2 = 18;
                            }
                        }
                        break;
                    case 20:
                        if (spotsused[19] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[19] = 1;
                                pic1 = 19;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[19] = 1;
                                pic2 = 19;
                            }
                        }
                        break;
                    case 21:
                        if (spotsused[20] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[20] = 1;
                                pic1 = 20;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[20] = 1;
                                pic2 = 20;
                            }
                        }
                        break;
                    case 22:
                        if (spotsused[21] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[21] = 1;
                                pic1 = 21;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[21] = 1;
                                pic2 = 21;
                            }
                        }
                        break;
                    case 23:
                        if (spotsused[22] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[22] = 1;
                                pic1 = 22;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[22] = 1;
                                pic2 = 22;
                            }
                        }
                        break;
                    case 24:
                        if (spotsused[23] == 0)
                        {
                            if (!spot1)
                            {
                                spot1 = !spot1;
                                spotsused[23] = 1;
                                pic1 = 23;
                            }
                            else
                            {
                                spot2 = !spot2;
                                spotsused[23] = 1;
                                pic2 = 23;
                            }
                        }
                        break;
                }

            }
            matches[i, 0] = pic1;
            matches[i, 1] = pic2;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefToMainMenu.Show();
        }

        private void btnR1C1_Click(object sender, EventArgs e)
        {
            pbxR1C1.Visible = true;
            btnR1C1.Visible = false;
            if (guess1 == -1)
            {
                guess1 = 0;
            }
            else
            {
                guess2 = 0;
            }
            checkguess();
        }

        private void btnR1C2_Click(object sender, EventArgs e)
        {
            pbxR1C2.Visible = true;
            btnR1C2.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 1;
            }
            else
            {
                guess2 = 1;
            }
            checkguess();
        }

        private void btnR1C3_Click(object sender, EventArgs e)
        {
            pbxR1C3.Visible = true;
            btnR1C3.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 2;
            }
            else
            {
                guess2 = 2;
            }
            checkguess();
        }

        private void btnR1C4_Click(object sender, EventArgs e)
        {
            pbxR1C4.Visible = true;
            btnR1C4.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 3;
            }
            else
            {
                guess2 = 3;
            }
            checkguess();
        }

        private void btnR1C5_Click(object sender, EventArgs e)
        {
            pbxR1C5.Visible = true;
            btnR1C5.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 4;
            }
            else
            {
                guess2 = 4;
            }
            checkguess();
        }

        private void btnR2C1_Click(object sender, EventArgs e)
        {
            pbxR2C1.Visible = true;
            btnR2C1.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 5;
            }
            else
            {
                guess2 = 5;
            }
            checkguess();

        }

        private void btnR2C2_Click(object sender, EventArgs e)
        {
            pbxR2C2.Visible = true;
            btnR2C2.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 6;
            }
            else
            {
                guess2 = 6;
            }
            checkguess();
        }

        private void btnR2C3_Click(object sender, EventArgs e)
        {
            pbxR2C3.Visible = true;
            btnR2C3.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 7;
            }
            else
            {
                guess2 = 7;
            }
            checkguess();
        }

        private void btnR2C4_Click(object sender, EventArgs e)
        {
            pbxR2C4.Visible = true;
            btnR2C4.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 8;
            }
            else
            {
                guess2 = 8;
            }
            checkguess();
        }

        private void btnR2C5_Click(object sender, EventArgs e)
        {
            pbxR2C5.Visible = true;
            btnR2C5.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 9;
            }
            else
            {
                guess2 = 9;
            }
            checkguess();
        }

        private void btnR3C1_Click(object sender, EventArgs e)
        {
            pbxR3C1.Visible = true;
            btnR3C1.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 10;
            }
            else
            {
                guess2 = 10;
            }
            checkguess();
        }

        private void btnR3C2_Click(object sender, EventArgs e)
        {
            pbxR3C2.Visible = true;
            btnR3C2.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 11;
            }
            else
            {
                guess2 = 11;
            }
            checkguess();
        }


        private void btnR3C4_Click(object sender, EventArgs e)
        {
            pbxR3C4.Visible = true;
            btnR3C4.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 12;
            }
            else
            {
                guess2 = 12;
            }
            checkguess();
        }

        private void btnR3C5_Click(object sender, EventArgs e)
        {
            pbxR3C5.Visible = true;
            btnR3C5.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 13;
            }
            else
            {
                guess2 = 13;
            }
            checkguess();
        }

        private void btnR4C1_Click(object sender, EventArgs e)
        {
            pbxR4C1.Visible = true;
            btnR4C1.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 14;
            }
            else
            {
                guess2 = 14;
            }
            checkguess();
        }

        private void btnR4C2_Click(object sender, EventArgs e)
        {
            pbxR4C2.Visible = true;
            btnR4C2.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 15;
            }
            else
            {
                guess2 = 15;
            }
            checkguess();
        }

        private void btnR4C3_Click(object sender, EventArgs e)
        {
            pbxR4C3.Visible = true;
            btnR4C3.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 16;
            }
            else
            {
                guess2 = 16;
            }
            checkguess();
        }

        private void btnR4C4_Click(object sender, EventArgs e)
        {
            pbxR4C4.Visible = true;
            btnR4C4.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 17;
            }
            else
            {
                guess2 = 17;
            }
            checkguess();
        }

        private void btnR4C5_Click(object sender, EventArgs e)
        {
            pbxR4C5.Visible = true;
            btnR4C5.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 18;
            }
            else
            {
                guess2 = 18;
            }
            checkguess();
        }


        private void btnR5C1_Click(object sender, EventArgs e)
        {
            pbxR5C1.Visible = true;
            btnR5C1.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 19;
            }
            else
            {
                guess2 = 19;
            }
            checkguess();
        }

        private void btnR5C2_Click(object sender, EventArgs e)
        {
            pbxR5C2.Visible = true;
            btnR5C2.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 20;
            }
            else
            {
                guess2 = 20;
            }
            checkguess();
        }

        private void btnR5C3_Click(object sender, EventArgs e)
        {
            pbxR5C3.Visible = true;
            btnR5C3.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 21;
            }
            else
            {
                guess2 = 21;
            }
            checkguess();
        }

        private void btnR5C4_Click(object sender, EventArgs e)
        {
            pbxR5C4.Visible = true;
            btnR5C4.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 22;
            }
            else
            {
                guess2 = 22;
            }
            checkguess();

        }

        private void btnR5C5_Click(object sender, EventArgs e)
        {
            pbxR5C5.Visible = true;
            btnR5C5.Visible = true;
            if (guess1 == -1)
            {
                guess1 = 23;
            }
            else
            {
                guess2 = 23;
            }
            checkguess();
        }

        private void checkguess()
        {
            bothguess[0] = guess1;
            bothguess[1] = guess2;
            for (i = 0; i < 12; i++)
            {
                if ((matches[i, 0] == bothguess[1] && matches[i, 1] == bothguess[0])
                || matches[i, 0] == bothguess[0] && matches[i, 1] == bothguess[1])
                {
                    correctguess = true;
                    guess1 = -1;
                    guess2 = -1;
                    score = score + 3;
                    label1.Text = ("Score: " + score);
                }
                else if (guess1 != -1 && guess2 != -1 && i==11)
                {
                    wait(500);
                    cards[guess1].Visible = false;
                    cards[guess2].Visible = false;
                    button[guess1].Visible = true;
                    button[guess2].Visible = true;
                    guess1 = -1;
                    guess2 = -1;
                    score = score - 1;
                    label1.Text = ("Score: " + score);
                }
            }
        }
        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

    }
}
