namespace Piano_Almost_Master
{
    partial class Piano_Keyboard
    {
        Form1 parent;
        public bool is_visible;
        public static bool is_opened = false;
        private int counter = 0;
        string[] sounds;
        private string actualSound;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(Piano_Keyboard.is_opened == true) { Piano_Keyboard.is_opened = false; }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(65, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 330);
            this.button1.TabIndex = 0;
            this.button1.Text = "a";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(146, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 330);
            this.button2.TabIndex = 1;
            this.button2.Text = "s";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click_1);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(227, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 330);
            this.button3.TabIndex = 2;
            this.button3.Text = "d";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click_1);
            this.button3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(308, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 330);
            this.button4.TabIndex = 3;
            this.button4.Text = "f";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button1_Click_1);
            this.button4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(389, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 330);
            this.button5.TabIndex = 4;
            this.button5.Text = "g";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button1_Click_1);
            this.button5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(470, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 330);
            this.button6.TabIndex = 5;
            this.button6.Text = "h";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button1_Click_1);
            this.button6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(551, 221);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 330);
            this.button7.TabIndex = 6;
            this.button7.Text = "j";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button1_Click_1);
            this.button7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(632, 221);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 330);
            this.button8.TabIndex = 7;
            this.button8.Text = "k";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button1_Click_1);
            this.button8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(126, 221);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 209);
            this.button9.TabIndex = 8;
            this.button9.Text = "w";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button1_Click_1);
            this.button9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(202, 221);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 209);
            this.button10.TabIndex = 9;
            this.button10.Text = "e";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button1_Click_1);
            this.button10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Location = new System.Drawing.Point(363, 221);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 209);
            this.button11.TabIndex = 10;
            this.button11.Text = "t";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button1_Click_1);
            this.button11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button12.Location = new System.Drawing.Point(442, 221);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(49, 209);
            this.button12.TabIndex = 11;
            this.button12.Text = "y";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button1_Click_1);
            this.button12.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button13.Location = new System.Drawing.Point(524, 221);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(49, 209);
            this.button13.TabIndex = 12;
            this.button13.Text = "u";
            this.button13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button1_Click_1);
            this.button13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.piano_KeyPress);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.Location = new System.Drawing.Point(713, 221);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 330);
            this.button15.TabIndex = 14;
            this.button15.Text = "l";
            this.button15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button16.Location = new System.Drawing.Point(794, 221);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 330);
            this.button16.TabIndex = 15;
            this.button16.Text = "E";
            this.button16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button17.Location = new System.Drawing.Point(687, 221);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(49, 209);
            this.button17.TabIndex = 16;
            this.button17.Text = "o";
            this.button17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.Location = new System.Drawing.Point(768, 221);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(49, 209);
            this.button14.TabIndex = 17;
            this.button14.Text = "p";
            this.button14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(433, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 18);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Add drums :)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(72, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Score : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(429, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Level :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(807, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Lives :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "label4";
            // 
            // Piano_Keyboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 592);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Piano_Keyboard";
            this.Text = "Piano_Keyboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}