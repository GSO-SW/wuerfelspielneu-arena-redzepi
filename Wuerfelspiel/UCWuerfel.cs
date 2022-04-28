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
    public partial class UCWuerfel : UserControl
    {
        public UCWuerfel()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }

        private void UCWuerfel_Load(object sender, EventArgs e)
        {

        }

        private void UCWuerfel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int w = this.Size.Width;
            int h = this.Size.Height;

            //Rectangle rectObenLinks = new Rectangle(0,0,w/3,h/3);
            //Rectangle rectObenMitte = new Rectangle(w/3,0,w/3,h/3);
            //Rectangle rectObenRechts = new Rectangle(w/3*2,0,w/3,h/3);



            //Rectangle rectObenLinks = new Rectangle(w/3 * 0, 0,w/3,h/3);
            //Rectangle rectObenMitte = new Rectangle(w/3 * 1, 0,w/3,h/3);
            //Rectangle rectObenRecht = new Rectangle(w/3 * 2, 0,w/3,h/3);

            //Rectangle[] rects = new Rectangle[3];

            //rects[0] = new Rectangle(w/3 * 0, 0,w/3,h/3);
            //rects[1] = new Rectangle(w/3 * 1, 0,w/3,h/3);
            //rects[2] = new Rectangle(w/3 * 2, 0,w/3,h/3);




            //Rectangle[] rects = new Rectangle[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    rects[i] = new Rectangle(w / 3 * i, 0, w / 3, h / 3);
            //}

            //+---+---+---+
            //| 0 | 1 | 2 |
            //+---+---+---+
            //| 3 | 4 | 5 |
            //+---+---+---+
            //| 6 | 7 | 8 |
            //+---+---+---+


            //      x                        i        j
            //rects[0] = new Rectangle(w/3 * 0, h/3 * 0,w/3,h/3);
            //rects[1] = new Rectangle(w/3 * 1, h/3 * 0,w/3,h/3);
            //rects[2] = new Rectangle(w/3 * 2, h/3 * 0,w/3,h/3);

            //rects[3] = new Rectangle(w/3 * 0, h/3 * 1,w/3,h/3);
            //rects[4] = new Rectangle(w/3 * 1, h/3 * 1,w/3,h/3);
            //rects[5] = new Rectangle(w/3 * 2, h/3 * 1,w/3,h/3);


            //rects[6] = new Rectangle(w/3 * 0, h/3 * 2,w/3,h/3);
            //rects[7] = new Rectangle(w/3 * 1, h/3 * 2,w/3,h/3);
            //rects[8] = new Rectangle(w/3 * 2, h/3 * 2,w/3,h/3);

            // x aus i und j berechnen...
            //+---+---+---+
            //| x | i | j |
            //+---+---+---+
            //| 0 | 0 | 0 | x = i
            //+---+---+---+
            //| 1 | 1 | 0 | x = i
            //+---+---+---+
            //| 2 | 2 | 0 | x = i
            //+---+---+---+
            //| 3 | 0 | 1 | x = i + j * 3
            //+---+---+---+
            //| 4 | 1 | 1 | x = i + j * 3
            //+---+---+---+
            //| 5 | 2 | 1 |
            //+---+---+---+
            //| 6 | 0 | 2 | x = i + j * 3
            //+---+---+---+
            //| 7 | 1 | 2 |
            //+---+---+---+
            //| 8 | 2 | 2 |
            //+---+---+---+










            Rectangle[] rects = new Rectangle[9];
            
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    rects[i + j * 3] = new Rectangle(w / 3 * i, h/3 * j, w / 3, h / 3);
                }
            }


            Pen pen = new Pen(Color.Black, 2);
            Brush brush = new SolidBrush(Color.Black);

            //g.DrawRectangle(pen, rectObenMitte);

            for (int i = 0; i < rects.Length; i++)
            {
                g.FillEllipse(brush, rects[i]);
            }
        }
    }
}
