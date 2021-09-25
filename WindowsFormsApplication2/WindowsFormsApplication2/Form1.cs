using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void lineBres(int x1, int y1, int x2, int y2)
        {
            var Brsh = Brushes.Red;
            var g = board.CreateGraphics();
            int dx = Math.Abs(x2 - x1), dy = Math.Abs(y2 - y1);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);

            /* Determine which endpoint to use as start position.  */
            if (x1 > x2)
            {
                x = x2; y = y2; x2 = x1;
            }
            else
            {
                x = x1; y = y1;
            }
            g.FillRectangle(Brsh, x, y, 2, 2);

            while (x < x2)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                g.FillRectangle(Brsh, x, y, 2, 2);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = int.Parse(x1.Text); ;
            int y = int.Parse(y1.Text); ;
            int m = int.Parse(x2.Text); ;
            int p = int.Parse(y2.Text); ;
            lineBres(x, y, m, p);
        }

        private void x1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
