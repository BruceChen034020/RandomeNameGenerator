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
    public partial class MaleName : Form
    {
        public string Name;
        public MaleName(string name)
        {
            InitializeComponent();
            Name = name;
        }

        private void MaleName_Load(object sender, EventArgs e)
        {
            label1.Text = Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.This.button1.PerformClick();
            Close();
        }
    }
}
