using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrtanjeSATA
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {

        }

        private void Clock_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pn = new Pen(Color.Blue, 100);
            Rectangle rect1 = new Rectangle(40, 40, 690, 690);
            g.DrawEllipse(pn, rect1);
            Pen pen2 = new Pen(Color.White, 5);
            Rectangle rect2 = new Rectangle(40, 40, 690, 690);
            e.Graphics.DrawEllipse(pen2, rect2);
            Image myImage = Image.FromFile("C:\\Users\\Minela\\source\\repos\\CrtanjeSATA\\CrtanjeSATA\\Resources\\Slika3.png");
            TextureBrush myTextureBrush = new TextureBrush(myImage);
            g.FillEllipse(myTextureBrush, 40, 40, 690, 690);

            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            e.Graphics.TranslateTransform(ClientSize.Width / 2, ClientSize.Height / 2);
            e.Graphics.FillEllipse(Brushes.White, -5, -5, 15,15);//centar
            Pen pen3 = new Pen(Color.White, 3);
            Rectangle rect3 = new Rectangle(-300, -300, 600, 600);
            e.Graphics.DrawEllipse(pen3, rect3);

            using (Pen thick_pen = new Pen(Color.White, 4))
            {
                // Get scale factors.
                float outer_x_factor = 0.45f * ClientSize.Width;
                float outer_y_factor = 0.45f * ClientSize.Height;
                float inner_x_factor = 0.425f * ClientSize.Width;
                float inner_y_factor = 0.425f * ClientSize.Height;
                float big_x_factor = 0.4f * ClientSize.Width;
                float big_y_factor = 0.4f * ClientSize.Height;

                // Draw the tick marks.
                thick_pen.StartCap = LineCap.Triangle;
                for (int minute = 1; minute <= 60; minute++)
                {
                    double angle = Math.PI * minute / 30.0;
                    float cos_angle = (float)Math.Cos(angle);
                    float sin_angle = (float)Math.Sin(angle);
                    PointF outer_pt = new PointF(
                        outer_x_factor * cos_angle,
                        outer_y_factor * sin_angle);
                    if (minute % 5 == 0)
                    {
                        PointF inner_pt = new PointF(
                            big_x_factor * cos_angle,
                            big_y_factor * sin_angle);
                        g.DrawLine(thick_pen, inner_pt, outer_pt);
                    }
                    else
                    {
                        PointF inner_pt = new PointF(
                            inner_x_factor * cos_angle,
                            inner_y_factor * sin_angle);
                        g.DrawLine(Pens.White, inner_pt, outer_pt);
                    }
                }
                Pen pn1 = new Pen(Color.RoyalBlue, 50);
                g.DrawLine(pn1, -100, -100, 100, -100);
                SolidBrush bkk = new SolidBrush(Color.RoyalBlue);
                Rectangle rect6 = new Rectangle(-62, -142, 140, 80);
                g.FillEllipse(bkk, rect6);
                g.DrawString("Royal", new Font("Times New Roman", 19), Brushes.White, new PointF(-32, -120));

                Pen pen5 = new Pen(Color.White, 10);
                pen5.StartCap = LineCap.ArrowAnchor;
                pen5.EndCap = LineCap.RoundAnchor;
                e.Graphics.DrawLine(pen5, 90, 90, -5,0);
                e.Graphics.DrawLine(pen5, 190, 0, -5, 0);

                g.DrawString("3", new Font("Times New Roman", 52), Brushes.White, new PointF(190, -50));
                g.DrawString("9", new Font("Times New Roman", 52), Brushes.White, new PointF(-265, -52));
                g.DrawString("12", new Font("Times New Roman", 52), Brushes.White, new PointF(-42, -242));
                g.DrawString("6", new Font("Times New Roman", 52), Brushes.White, new PointF(-30, 180));

                g.DrawString("Wall Clock", new Font("Times New Roman", 32), Brushes.RoyalBlue, new PointF(-102, 90));

            }

        }
    }
}
