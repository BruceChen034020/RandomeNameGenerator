using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class FemaleName : Form
    {
        public new string Name;
        public FemaleName(string name)
        {
            InitializeComponent();
            Name = name;
        }

        private void FemaleName_Load(object sender, EventArgs e)
        {
            label1.Text = Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.This.button2.PerformClick();
            Close();
        }
    }
}
