using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Our_Hearts_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            animation.ImageLocation = "..\\..\\images\\Animations\\loading.gif";
           
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameInstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new InsForm("Instruction to Play the Game.")) 
            {
                form.ShowDialog(); 
            }
        }

        private void aboutTheAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new InsForm("The Authors of this Game are\n 1. Varun Singh(100865156)\n 2. Drashya Patel(100863337)\n 3. Saksham Verma(100886325)\n 4. Sahil Tankaria"))
            {
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var rform = new register())
            {
                rform.ShowDialog();
            }

        }

        private void guest_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var setupform = new SetupMenu())
            {
                setupform.change_welcome(" Guest");
                setupform.ShowDialog();
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            login.Text = "";
            password.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Controls.Remove(animation);
            this.Controls.Remove(amsg);
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            // VALIDATION REQUIRED
            //DO VALIDATION FIRST
            //IF SUCCESS START THE GAME.

        }
    }
}
