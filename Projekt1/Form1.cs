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
        int points = 0;
        double buttonX, buttonY;
        public Form1()
        {
            InitializeComponent();
            buttonX = (button1.Left + button1.Right) / 2;
            buttonY = (button1.Top + button1.Bottom) / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = this.PointToClient(Cursor.Position);

            double speedX, speedY;
            speedX = Math.Abs(buttonX - p.X);
            speedX = 1 - speedX / this.ClientSize.Width;
            speedY = Math.Abs(buttonY - p.Y);
            speedX = 1 - speedY / this.ClientSize.Height;

            if (p.X < buttonX && this.ClientSize.Width > button1.Right)
                buttonX += speedX * 0.05;
            else if (p.X > buttonX && button1.Left > 0)
                buttonX -= speedX * 0.05;
            if (p.Y < buttonY && this.ClientSize.Height > button1.Bottom)
                buttonY += speedY * 0.05;
            else if (p.Y > buttonY && button1.Top > 0)
                buttonY -= speedY * 0.05;

            button1.Left = (int)buttonX;
            button1.Top = (int)buttonY;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            points++;
            button1.Text = "Score: " + points;
        }
    }
}
