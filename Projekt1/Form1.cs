using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Filip";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            label1.Text = x.ToString() + ", " + y.ToString() + "\n";
            x = button1.Left;
            y = button1.Top;
            label1.Text += x.ToString() + ", " + y.ToString() + "\n";
            button1.Left++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
