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
    public partial class Piano_Keyboard : Form
    {
        public Piano_Keyboard(bool is_visible, Form1 parent)
        {
            InitializeComponent();
            this.is_visible = is_visible;
            this.parent = parent;
            checkTypeOfGame(is_visible);
            Piano_Keyboard.is_opened = true;
            sounds = Song.getSong("song1");
        }
        
        private void piano_KeyPress(object sender, KeyPressEventArgs e)
        {
            //label4.Text = e.KeyChar.ToString();
             someFunc(e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ///cosiek tu będzie
        }
        private void checkTypeOfGame(bool isVisible)
        {
            if(isVisible == true)
            {
                this.checkBox1.Visible = true;
            }
            else
            {
                this.checkBox1.Visible = false;
            }
        }

        private void clearButton()
        {
            this.button1.BackColor = Color.White;
            this.button2.BackColor = Color.White;
            this.button3.BackColor = Color.White;
            this.button4.BackColor = Color.White;
            this.button5.BackColor = Color.White;
            this.button6.BackColor = Color.White;
            this.button7.BackColor = Color.White;
            this.button8.BackColor = Color.White;
            this.button15.BackColor = Color.White;
            this.button16.BackColor = Color.White;
            this.button9.BackColor = Color.Black;
            this.button10.BackColor = Color.Black;
            this.button11.BackColor = Color.Black;
            this.button12.BackColor = Color.Black;
            this.button13.BackColor = Color.Black;
            this.button17.BackColor = Color.Black;
            this.button14.BackColor = Color.Black;
        }

        /// <summary>
        /// piano work 
        /// 
        /// </summary>
        /// <param name="c"></param>
        private void someFunc(KeyPressEventArgs c)
        {
            if (c.KeyChar == 'a')
            {
                this.button1.PerformClick();
               // this.button1.BackColor = Color.Lime;
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 's')
            {
                this.button2.PerformClick();
                //this.button2.BackColor = Color.Lime;
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'd')
            {
                this.button3.PerformClick();
                //this.button3.BackColor = Color.Lime;
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'f')
            {
                this.button4.PerformClick();
                //this.button4.BackColor = Color.Lime;
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'g')
            {
                this.button5.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'h')
            {
                this.button6.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'j')
            {
                this.button7.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'k')
            {
                this.button8.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'l')
            {
                this.button15.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == ';')
            {
                this.button16.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            ////# notes
            else if (c.KeyChar == 'w')
            {
                this.button9.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'e')
            {
                this.button10.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 't')
            {
                this.button11.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'y')
            {
                this.button12.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'u')
            {
                this.button13.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'o')
            {
                this.button17.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            else if (c.KeyChar == 'p')
            {
                this.button14.PerformClick();
                this.label2.Text = "Key " + c.KeyChar.ToString() + " was pressed";
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clearButton();
            Button b = sender as Button;
            this.label3.Text = b.Text;
            correctClick(b, "m");
        }
        private void correctClick(Button button, string sound)
        {
            try
            {
                if (true)//wartość true zostanie podmieniona na wyrażenie sprawdzające równość wybranego dźwięku do aktualnego wyświetlanego z tablicy
                {
                    this.label4.Text = "Good ;)";
                    button.BackColor = Color.Lime;
                }
                else
                {
                    this.label4.Text = "Maybe later will you succed";
                    button.BackColor = Color.Red;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }
    }
}
