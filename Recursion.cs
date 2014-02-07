using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RecursionExperiments
{
    public partial class Recursion : Form
    {
        private Pen redPen, bluePen, greenPen, pinkPen,blackPen;
        private SolidBrush redBrush, purpleBrush;




        public Recursion()
        {
            InitializeComponent();
            redPen = new Pen(Color.Red);
            bluePen = new Pen(Color.Blue);
            greenPen = new Pen(Color.Green);
            pinkPen = new Pen(Color.Pink);
            blackPen = new Pen(Color.Black);

            redBrush = new SolidBrush(Color.Red);
            purpleBrush = new SolidBrush(Color.Purple);

        }


        private void Recursion_Paint(object sender, PaintEventArgs e)
        {
            //drawBox(e.Graphics, 200, 300);
            //drawLine(e.Graphics, 0, 80, 150, 300);
            //drawSquare(e.Graphics, 5, 100, 0, 100, 100, 200, 1000);
            drawSquare4corner(e.Graphics, 100, 100, 100, 400);
        }

        private void drawBox(Graphics g, int size, int sleepTime)
        { // drawBox

            //if (size < 50)
            //{ // base case, just draw myself
            //    g.FillRectangle(redBrush, 0, 0, size, size);
            //} // base case, just draw myself
            //else
            //{ // sleep, then draw myself, then call myself
            //    Thread.Sleep(sleepTime);
            //    g.DrawRectangle(redPen, 0, 0, size, size);
            //    drawBox(g, size - 20, sleepTime);
            //} // sleep, then draw myself, then call myself





        }

        public void drawLine(Graphics g, int x1, int x2, int down, int sleeptime)
        {


            if (down < 80)
            {
                g.DrawLine(bluePen, x1, down, x2, down);
            }
            else
            {
                Thread.Sleep(sleeptime);
                g.DrawLine(bluePen, x1, down, x2, down);
                drawLine(g, x1 + 5, x2 - 5, down - 10, sleeptime);

            }
        } // drawBox

        public void drawSquare(Graphics g, int x, int size, int over, int down, int over2, int down2, int sleepTime)
        {
            size = over2 - over;

            if (size <= 2 * x)
            {
                g.DrawLine(greenPen, over, down, over2, down);
                g.DrawLine(greenPen, over2, down, over2, down2);
                g.DrawLine(greenPen, over2, down2, over + x, down2);
                g.DrawLine(greenPen, over + x, down2, over + x, down + x);

            }
            else
            {
                Thread.Sleep(sleepTime);
                g.DrawLine(greenPen, over, down, over2, down);
                g.DrawLine(greenPen, over2, down, over2, down2);
                g.DrawLine(greenPen, over2, down2, over + x, down2);
                g.DrawLine(greenPen, over + x, down2, over + x, down + x);
                drawSquare(g, x, size - 2 * x, over + x, down + x, over2 - x, down2 - x, sleepTime);
            }
        }

        public void drawSquare4corner(Graphics g, int size, int over, int down, int sleepTime)
        {
            if (size < 20)
            {
                g.FillRectangle(purpleBrush, over, down, size, size);
                g.DrawRectangle(blackPen, over, down, size, size);
            }
            else
            {
                Thread.Sleep(sleepTime);
                g.FillRectangle(purpleBrush, over, down, size, size);
                g.DrawRectangle(blackPen, over, down, size, size);

                drawSquare4corner(g, size / 2, over - size / 4, down - size / 4, sleepTime);
                drawSquare4corner(g, size / 2, over + size - size / 4, down - size / 4, sleepTime);
                drawSquare4corner(g, size / 2, over - size / 4, down + size - size / 4, sleepTime);
                drawSquare4corner(g, size / 2, over + size - size / 4, down + size - size / 4, sleepTime);
            }
        }

        private void Recursion_Load(object sender, EventArgs e)
        {

        }
    }
}
