using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int h = 400; int w = 400;
            this.ClientSize = new Size(w, h);
            btnWuerfeln.Location = new Point(ClientSize.Width / 2, ClientSize.Height / 2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            int h = 400; int w = 400;
            this.ClientSize = new Size(w, h);


            Brush brush = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(brush, new Rectangle(w/4, h/4, w/2, h/2));
        }

        private void BtnWuerfeln_Click(object sender, EventArgs e)
        {
            Wuerfel neueWuerfel = new Wuerfel(6);
            neueWuerfel.Wuerfeln();
        }
    }
}
