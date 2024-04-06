using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our_Hearts_game
{
    public partial class SetupMenu : Form
    {
        public SetupMenu()
        {
            InitializeComponent();
        }
        public void theme_changed()
        {
            if (theme_default.Checked)
            {
                Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
                theme_pic_box.ImageLocation = "..\\..\\images\\Themes\\default\\QH.png";
                card_back_theme.ImageLocation = "..\\..\\images\\Themes\\default\\2B.png";
                Program.theme_info = "..\\..\\images\\Themes\\default\\";

            }
            else
            {
                if (theme_day.Checked) 
                {
                      this.BackColor = Color.FromArgb(255, 220, 204);
                    theme_pic_box.ImageLocation = "..\\..\\images\\Themes\\day\\QH.png";
                    card_back_theme.ImageLocation = "..\\..\\images\\Themes\\day\\1B.png";
                    Program.theme_info = "..\\..\\images\\Themes\\day\\";

                }
                else
                {
                    if (theme_night.Checked)
                    {
                        theme_pic_box.ImageLocation = "..\\..\\images\\Themes\\dark\\QH.png";
                        card_back_theme.ImageLocation = "..\\..\\images\\Themes\\dark\\1B.png";
                        Program.theme_info = "..\\..\\images\\Themes\\dark\\";
                    }
                    else
                    {
                        theme_pic_box.ImageLocation = "..\\..\\images\\Themes\\custom1\\QH.png";
                        card_back_theme.ImageLocation = "..\\..\\images\\Themes\\custom1\\2B.png";
                        Program.theme_info = "..\\..\\images\\Themes\\custom1\\";
                    }
                }

            }
        }

        private void theme_night_CheckedChanged(object sender, EventArgs e)
        {
            theme_changed();
        }

        private void SetupMenu_Load(object sender, EventArgs e)
        {
            theme_changed();
        }
        public void change_welcome(string msg)
        {
            welcome_msg.Text = welcome_msg.Text+msg;
            Console.WriteLine(msg);
        }

        private void reset1_Click(object sender, EventArgs e)
        {
            theme_default.Checked=true;
            NoOfPlayers.Value = 1;
            MaxScore.Value = 10;


        }

        private void start_game4_Click(object sender, EventArgs e)
        {
            //VALIDATION IF ANY LEFT.
            Deck mydeck=new Deck();

        }
    }
}
