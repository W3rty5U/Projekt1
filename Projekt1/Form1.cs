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
            Point p = this.PointToClient(Cursor.Position);
            label1.Text = p.X.ToString() + ", " + p.Y.ToString() + "\n";
            int x = button1.Left;
            int y = button1.Top;
            label1.Text += x.ToString() + ", " + y.ToString() + "\n";
            button1.Left++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
