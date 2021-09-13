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
        int points = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            points++;
            label1.Text = "Score: " + points;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = this.PointToClient(Cursor.Position);
            int x = (button1.Left + button1.Right) / 2;
            int y = (button1.Top + button1.Bottom) / 2;
            if (p.X < x && this.ClientSize.Width > button1.Right)
                button1.Left++;
            else if (button1.Left > 0)
                button1.Left--;
            if (p.Y < y && this.ClientSize.Height > button1.Bottom)
                button1.Top++;
            else if (button1.Top > 0)
                button1.Top--;
        }
    }
}
