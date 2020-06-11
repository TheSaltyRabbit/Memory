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
    public partial class HowToPlay : Form
    {
        public bool firstTurn = true;
        public Form RefToMainMenu { get; set; }
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void HowToPlay_Load(object sender, EventArgs e)
        {
            MessageBox.Show("The Goal of the game is to match all the pairs." + Environment.NewLine + "Cards reset if they do not match" + Environment.NewLine + "Go ahead and try it with these two here.", "Tutorial", MessageBoxButtons.OK);
        }

        private void HowToPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefToMainMenu.Show();
        }

        private void CheckMatch()
        {
            if (firstTurn==false)
            {
                MessageBox.Show("YOU WIN!", "YOU WIN");
            }
            firstTurn = !firstTurn;
        }

        private void btnTutorial1_Click(object sender, EventArgs e)
        {
            btnTutorial1.Visible = false;
            pictureBox1.Visible = true;
            CheckMatch();
        }

        private void btnTutorial2_Click(object sender, EventArgs e)
        {
            btnTutorial2.Visible = false;
            pictureBox2.Visible = true;
            CheckMatch();
        }
    }
}
