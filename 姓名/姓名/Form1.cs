using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 姓名
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = textBox1.Text.Length;
            int n2 = textBox2.Text.Length;
            Random random1 = new Random();
            int r = random1.Next(n1);
            string toShow = "";
            
            int i;
            for(i=0;textBox1.Text[r] == '\n' || textBox1.Text[r] == '\r';i++)
            {
                r = random1.Next(n1);
            }
            toShow += textBox1.Text[r];
            r = random1.Next(n2);
            toShow += textBox2.Text[r];
            r = random1.Next(n2);
            toShow += textBox2.Text[r];
            Form2 f2 = new Form2();
            f2.ShowText(toShow);
        }
    }
}
