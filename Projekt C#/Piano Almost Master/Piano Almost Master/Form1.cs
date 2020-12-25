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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(song_choice.is_opened == false)
            {
                this.songs = new song_choice(this);
                this.songs.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Piano_Keyboard.is_opened == false)
            {
                this.keyboard = new Piano_Keyboard(true, this);
                this.keyboard.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            color = button.BackColor;
            button.BackColor = Color.BlueViolet;

        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = color;
        }
    }
}
