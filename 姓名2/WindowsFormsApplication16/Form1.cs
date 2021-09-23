using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            This = this;
        }

        Button b_textBox1 = new Button();
        Button b_textBox2 = new Button();
        Button btb3 = new Button();
        Button btb4 = new Button();
        Button btb5 = new Button();

        private void button1_Click(object sender, EventArgs e)
        {
            string toShow = "";
            toShow += GenerateLastName();
            
            Random randomizer1 = new Random();
            int r = randomizer1.Next(textBox4.Text.Length);
            toShow += textBox4.Text[r];
            r = randomizer1.Next(textBox4.Text.Length);
            toShow += textBox4.Text[r];
            MaleName f2 = new MaleName(toShow);
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ForeColor = Color.FromArgb(153, 153, 171);
            //Font = new Font("標楷體", 12);
            /*textBox1.ForeColor = Color.FromArgb(201, 201, 201);
            textBox2.ForeColor = Color.FromArgb(201, 201, 201);
            textBox3.ForeColor = Color.FromArgb(201, 201, 201);
            textBox4.ForeColor = Color.FromArgb(201, 201, 201);
            textBox5.ForeColor = Color.FromArgb(201, 201, 201);
            textBox1.Font = new Font("標楷體", 20, FontStyle.Regular);
            textBox2.Font = new Font("標楷體", 20, FontStyle.Regular);
            textBox3.Font = new Font("標楷體", 20, FontStyle.Regular);
            textBox4.Font = new Font("標楷體", 36, FontStyle.Regular);
            textBox5.Font = new Font("標楷體", 36, FontStyle.Regular);*/
            
            b_textBox1.Location = textBox1.Location;
            Controls.Add(b_textBox1);
            b_textBox1.Size = textBox1.Size;
            b_textBox1.BackgroundImage = Properties.Resources.constantly;
            b_textBox1.BringToFront();
            b_textBox1.Click += B_textBox1_Click;
            b_textBox1.BackgroundImageLayout = ImageLayout.Stretch;

            b_textBox2.Location = textBox2.Location;
            Controls.Add(b_textBox2);
            b_textBox2.Size = textBox2.Size;
            b_textBox2.BackgroundImage = Properties.Resources.rare;
            b_textBox2.BringToFront();
            b_textBox2.Click += B_textBox2_Click;
            b_textBox2.BackgroundImageLayout = ImageLayout.Stretch;

            btb3.Location = textBox3.Location;
            btb3.Size = textBox2.Size;
            Controls.Add(btb3);
            btb3.BackgroundImage = Properties.Resources.very_rare;
            btb3.BringToFront();
            btb3.Click += Btb3_Click;
            btb3.BackgroundImageLayout = ImageLayout.Stretch;

            btb4.Location = textBox4.Location;
            btb4.Size = textBox4.Size;
            Controls.Add(btb4);
            btb4.BackgroundImage = Properties.Resources.male;
            btb4.BringToFront();
            btb4.Click += Btb4_Click;
            btb4.BackgroundImageLayout = ImageLayout.Stretch;

            btb5.Location = textBox5.Location;
            btb5.Size = textBox5.Size;
            Controls.Add(btb5);
            btb5.BackgroundImage = Properties.Resources.female;
            btb5.BringToFront();
            btb5.Click += Btb5_Click;
            btb5.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Btb5_Click(object sender, EventArgs e)
        {
            btb5.Dispose();
            textBox5.Focus();
        }

        private void Btb4_Click(object sender, EventArgs e)
        {
            btb4.Dispose();
            textBox4.Focus();
        }

        private void Btb3_Click(object sender, EventArgs e)
        {
            btb3.Dispose();
            textBox3.Focus();
        }

        private void B_textBox2_Click(object sender, EventArgs e)
        {
            b_textBox2.Dispose();
            textBox2.Focus();
        }

        private void B_textBox1_Click(object sender, EventArgs e)
        {
            b_textBox1.Dispose();
            textBox1.Focus();
        }

        private string GenerateLastName()
        {
            string toShow = "";
            Random randomizer1 = new Random();
            int percentage = randomizer1.Next(100);
            if(0 <= percentage && percentage < Setting.ConstantFrequency)
            {
                int n1 = textBox1.Text.Length;
                int r = randomizer1.Next(n1);
                
                int i;
                for (i = 0; textBox1.Text[r] == '\n' || textBox1.Text[r] == '\r'; i++)
                {
                    r = randomizer1.Next(n1);
                }
                toShow += textBox1.Text[r];
            }
            else if(Setting.ConstantFrequency<=percentage && percentage < 100 - Setting.VeryRareFrequency)
            {
                int n2 = textBox2.Text.Length;
                int r = randomizer1.Next(n2);
                
                int i;
                for (i = 0; textBox2.Text[r] == '\n' || textBox2.Text[r] == '\r'; i++)
                {
                    r = randomizer1.Next(n2);
                }
                toShow += textBox2.Text[r];
            }
            else if (100 - Setting.VeryRareFrequency <= percentage &&  percentage < 100)
            {
                int n3 = textBox3.Text.Length;
                int r = randomizer1.Next(n3);
                
                int i;
                for(i=0;textBox3.Text[r] == '\n' || textBox3.Text[r] == '\r'; i++)
                {
                    r = randomizer1.Next(n3);
                }
                toShow += textBox3.Text[r];
            }
            else
            {
                MessageBox.Show("Error\r\nin Form1.button1_Click()");
            }
            return toShow;
        }

        public static Form1 This;

        private void button2_Click(object sender, EventArgs e)
        {
            string toShow = "";
            toShow += GenerateLastName();
            Random randomizer1 = new Random();
            int r = randomizer1.Next(textBox5.Text.Length);
            toShow += textBox5.Text[r];
            r = randomizer1.Next(textBox5.Text.Length);
            toShow += textBox5.Text[r];
            FemaleName f2 = new FemaleName(toShow);
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Setting f2 = new Setting();
            f2.Show();
        }

        /*[DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("User32.dll")]
        private static extern IntPtr GetWindowDC(IntPtr hWnd);

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            const int WM_NCPAINT = 0x85;
            if (m.Msg == WM_NCPAINT)
            {
                IntPtr hdc = GetWindowDC(m.HWnd);
                if ((int)hdc != 0)
                {
                    Graphics g = Graphics.FromHdc(hdc);
                    g.FillRectangle(Brushes.Green, new Rectangle(0, 0, 4800, 23));
                    g.Flush();
                    ReleaseDC(m.HWnd, hdc);
                }
            }
        }*/
    }
}
