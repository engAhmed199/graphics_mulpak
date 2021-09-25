using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

            double preang = 0;

            ArrayList row;
            string rep;
            bool cor = true;
            bool strat;
            void cors()
            {
                corx1.X = 0;
                corx1.Y = 675 / 2;
                corx2.X = 771;
                corx2.Y = 675 / 2;

                cory1.X = 771 / 2;
                cory1.Y = 0;
                cory2.X = 771 / 2;
                cory2.Y = 675;
                DDA(corx1, corx2);
                DDA(cory1, cory2);
            }
            Point corx1, corx2, cory1, cory2, newcen, trycen, temp1, temp2, Pp1;
            Point pa;
            Point pb;
            List<core> cores = new List<core>();
            List<points> pos = new List<points>();
            int con;
            Point max, min, temp;
            int d = 0;
            int tx, ty;
            float sx, sy;
            double sin, cos, ang;
            int num, x;
            char s;
            Bitmap p = null;
            Point locxy;
            Point locx1y1;
            bool click1 = true, click2 = false, dir = false, rot = true, abxy = false;
            Rectangle rect;
            public Form1()
            {

                InitializeComponent();
                p = new Bitmap(pp.Width, pp.Height);
                cors();
                row = null;
                newcen.X = 771 / 2;
                newcen.Y = 675 / 2;
                //trycen.X=0;
                //trycen.Y=0;
                //DDA(newcen, trycen);
            }



            public Form1()
        {
            InitializeComponent();
        }
        void lineDDA(int x1, int y1, int x2, int y2)
        {
            var g = board.CreateGraphics();
            int dx = x2 - x1, dy = y2 - y1, steps , k;
            float xIncrement, yIncrement, x = x1, y = y1;
            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;

            var Brsh = Brushes.Red;
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                g.FillRectangle(Brsh, x, y, 2, 2);
            }
        }
            public void button1_Click(object sender, EventArgs e)
            {
                int x = int.Parse(x1.Text); ;
                int y = int.Parse(y1.Text); ;
                int m = int.Parse(x2.Text); ;
                int p = int.Parse(y2.Text); ;
                lineDDA(x, y, m, p);
            }



        //rotation about (0,0)----------------------------------------------------------------------------
        public void button2_Click(object sender, EventArgs e)
        {
            if (angle.Text != "ANGLE")
            {

                if (s == '5')
                {
                    ang = double.Parse(angle.Text);
                    ang += preang;
                    preang = ang;
                    sin = Math.Sin((ang * Math.PI) / 180);
                    cos = Math.Cos((ang * Math.PI) / 180);
                    p = new Bitmap(pp.Width, pp.Height);
                }
                else
                {
                    ang = double.Parse(angle.Text);
                    sin = Math.Sin((ang * Math.PI) / 180);
                    cos = Math.Cos((ang * Math.PI) / 180);
                    p = new Bitmap(pp.Width, pp.Height);
                }

            }
            int x1, x2, y1, y2;
            d = cores.Count();
            for (int i = 0; i < d; i++)
            {

                if (s != '5')
                {
                    x1 = cores[i].p1.X - newcen.X;
                    y1 = cores[i].p1.Y - newcen.Y;

                    cores[i].p1.X = (int)Math.Round((x1 * cos) + (y1 * sin));
                    cores[i].p1.Y = (int)Math.Round((y1 * cos) - (x1 * sin));
                    x2 = cores[i].p2.X - newcen.X;
                    y2 = cores[i].p2.Y - newcen.Y;
                    cores[i].p2.X = (int)Math.Round((x2 * cos) + (y2 * sin));
                    cores[i].p2.Y = (int)Math.Round((y2 * cos) - (x2 * sin));
                    cores[i].p2.X += newcen.X;
                    cores[i].p2.Y += newcen.Y;
                    cores[i].p1.X += newcen.X;
                    cores[i].p1.Y += newcen.Y;
                }

                switch (s)
                {
                    case '1':
                    case '8':
                        DDA(cores[i].p1, cores[i].p2);
                        break;

                }
                if (s == '0')
                {
                    DDA(cores[i].p1, cores[i].p2);
                }
            }
            dir = false;
            cors();
        }







        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
