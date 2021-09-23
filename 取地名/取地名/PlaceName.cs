using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 取地名
{
    public partial class PlaceName : Form
    {
        public string Name;

        public PlaceName(string name)
        {
            InitializeComponent();
            Name = name;
        }

        private void PlaceName_Load(object sender, EventArgs e)
        {
            label1.Text = Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LenName = Name.Length;
            switch (LenName)
            {
                case 1:
                    Form1.This.button1.PerformClick();
                    break;
                case 2:
                    Form1.This.button2.PerformClick();
                    break;
                case 3:
                    Form1.This.button3.PerformClick();
                    break;
                case 4:
                    Form1.This.button4.PerformClick();
                    break;
                case 5:
                    Form1.This.button5.PerformClick();
                    break;
                default:
                    Form1.This.button6.PerformClick();
                    //MessageBox.Show("Bug! \r\nPlacename.button1_click");
                    break;
            }
            Close();
        }
    }
}
