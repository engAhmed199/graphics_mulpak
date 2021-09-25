using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void elipseplotpoint(int xcntr, int ycntr, int x, int y)
        {
            var g = board.CreateGraphics();
            var Brsh = Brushes.Red;
            g.FillRectangle(Brsh, xcntr + x, ycntr + y, 2, 2);
            g.FillRectangle(Brsh, xcntr - x, ycntr + y, 2, 2);
            g.FillRectangle(Brsh, xcntr + x, ycntr - y, 2, 2);
            g.FillRectangle(Brsh, xcntr - x, ycntr - y, 2, 2);

        }

        void midptellipse(int xcntr, int ycntr,int rx, int ry)
        {
            int  dx, dy, d1, d2, x, y;
            x = 0;
            y = ry;

            // Initial decision parameter of region 1 
            d1 = (ry * ry) - (rx * rx * ry) +(rx * rx);
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;

            // For region 1 
            elipseplotpoint(xcntr, ycntr, x, y); 
            while (dx < dy)
            {

                // Print points based on 4-way symmetry 
                // Checking and updating value of 
                // decision parameter based on algorithm 
                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);
                }
                elipseplotpoint(xcntr, ycntr, x, y);
            }

            // Decision parameter of region 2 
            d2 = ((ry * ry) * ((x) * (x)))
                + ((rx * rx) * ((y - 1) * (y - 1)))
                - (rx * rx * ry * ry);
            elipseplotpoint(xcntr, ycntr, x, y);
            // Plotting points of region 2 
            while (y >= 0)
            {

                
                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                }
                elipseplotpoint(xcntr, ycntr, x, y);
            } 


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(xcntr.Text); ;
            int y = int.Parse(ycntr.Text); ;
            int r = int.Parse(rx.Text); ;
            int n = int.Parse(ry.Text); ;
            midptellipse(x, y, r,n);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
