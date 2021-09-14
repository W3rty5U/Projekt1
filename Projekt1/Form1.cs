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
            buttonX = button1.Left;
            buttonY = button1.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = this.PointToClient(Cursor.Position);

            int buttonCenterX = (button1.Left + button1.Right) / 2;
            int buttonCenterY = (button1.Top + button1.Bottom) / 2;

            double speedX, speedY;
            speedX = Math.Abs(buttonX - p.X);
            speedX = 1 - speedX / this.ClientSize.Width;
            speedX *= 2;
            speedY = Math.Abs(buttonY - p.Y);
            speedY = 1 - speedY / this.ClientSize.Height;
            speedY *= 2;

            if (p.X < buttonCenterX && this.ClientSize.Width > button1.Right)
                buttonX += speedX;
            else if (p.X > buttonCenterX && button1.Left > 0)
                buttonX -= speedX;
            if (p.Y < buttonCenterY && this.ClientSize.Height > button1.Bottom)
                buttonY += speedY;
            else if (p.Y > buttonCenterY && button1.Top > 0)
                buttonY -= speedY;

            button1.Left = (int)(buttonX );
            button1.Top = (int)(buttonY );
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            points++;
            button1.Text = "Score: " + points;
        }
    }
}
