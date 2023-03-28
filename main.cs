using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mesa
{
    public partial class Form1 : Form
    {
        private int angle = 0;
        private int radius = 50;
        private int xCenter = 100;
        private int yCenter = 100;
        private Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();

            // Set up the timer to tick every 10 milliseconds
            timer.Interval = 10;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Rotate the loader by increasing the angle
            angle += 5;

            // Redraw the loader
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Draw the loader
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(Brushes.Blue, xCenter - radius, yCenter - radius, radius * 2, radius * 2);
            e.Graphics.FillPie(Brushes.White, xCenter - radius, yCenter - radius, radius * 2, radius * 2, angle, 60);
            e.Graphics.FillPie(Brushes.White, xCenter - radius, yCenter - radius, radius * 2, radius * 2, angle + 120, 60);
            e.Graphics.FillPie(Brushes.White, xCenter - radius, yCenter - radius, radius * 2, radius * 2, angle + 240, 60);
        }
    }
}
