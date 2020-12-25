using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano_Almost_Master
{
    public partial class song_choice : Form
    {
        public song_choice(Form1 main_frame)
        {
            InitializeComponent();
            main_frame = main_frame;
            song_choice.is_opened = true;
        }

        private void song_choice_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //standard + pipsenka przesłana do grania
            if (Piano_Keyboard.is_opened == false)
            {
                keyboard = new Piano_Keyboard(false, main_frame);
                keyboard.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //standard + pipsenka przesłana do grania
            if (Piano_Keyboard.is_opened == false)
            {
                keyboard = new Piano_Keyboard(false, main_frame);
                keyboard.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //standard + pipsenka przesłana do grania
            if (Piano_Keyboard.is_opened == false)
            {
                keyboard = new Piano_Keyboard(false, main_frame);
                keyboard.Show();
            }
        }
    }
}
