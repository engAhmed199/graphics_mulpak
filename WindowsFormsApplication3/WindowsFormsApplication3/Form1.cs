using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void circleplotpoint(int xcntr, int ycntr, int x, int y)
        {
            var g = board.CreateGraphics();
            var Brsh = Brushes.Red;
            g.FillRectangle(Brsh, xcntr + x, ycntr + y, 2, 2);
            g.FillRectangle(Brsh, xcntr - x, ycntr + y, 2, 2);
            g.FillRectangle(Brsh, xcntr + x, ycntr - y, 2, 2);
            g.FillRectangle(Brsh, xcntr - x, ycntr - y, 2, 2);
            g.FillRectangle(Brsh, xcntr + y, ycntr + x, 2, 2);
            g.FillRectangle(Brsh, xcntr - y, ycntr + x, 2, 2);
            g.FillRectangle(Brsh, xcntr + y, ycntr - x, 2, 2);
            g.FillRectangle(Brsh, xcntr - y, ycntr - x, 2, 2);

        }

        void circlemidpoint(int xcntr, int ycntr, int radius)
        {
            int x = 0;
            int y = radius;
            int p = 1 - radius;
            circleplotpoint(xcntr, ycntr, x, y);

            while (x < y)
            {
                x++;
                if (p < 0)
                    p += 2 * x + 1;
                else
                {
                    p += 2 * (x - y) + 1;
                    y--;
                }
                circleplotpoint(xcntr, ycntr, x, y);
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xcntr.Text); ;
            int y = int.Parse(ycntr.Text); ;
            int r = int.Parse(radius.Text); ;
            circlemidpoint(x, y, r);
        }

        private void board_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
