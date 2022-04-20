using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Zadatak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g =this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            Rectangle rect = new Rectangle(50, 50, 150, 30);
            SolidBrush boja = new SolidBrush(Color.White);
            g.DrawEllipse(p,rect);
            g.FillEllipse(boja,rect);
            Font f = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("START", f, b, 90, 55);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 130, 80, 130, 100);

            ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            Point[] po = { new Point(50, 100), new Point(200, 100), new Point(180, 130), new Point(70, 130) };
            SolidBrush boja = new SolidBrush(Color.White);
            g.DrawPolygon(p, po);
            g.FillPolygon(boja, po);
            String s = this.textBox1.Text;
            Font f = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString(s, f, b, 100, 100);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 130, 130, 130, 150);
            SolidBrush boja = new SolidBrush(Color.White);
            Rectangle rect = new Rectangle(70, 150, 110, 30);
            g.DrawRectangle(p, rect);
            g.FillRectangle(boja, rect);
            String s = this.textBox1.Text;
            Font f = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString(s, f, b, 90, 150);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            Rectangle rect = new Rectangle(50, 250, 150, 30);
            SolidBrush boja = new SolidBrush(Color.White);
            g.DrawEllipse(p, rect);
            g.FillEllipse(boja, rect);
            Font f = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString("END", f, b, 90, 255);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 130, 230, 130, 250);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            Point[] po = { new Point(70, 200), new Point(170, 200), new Point(200, 230), new Point(50, 230) };
            SolidBrush boja = new SolidBrush(Color.White);
            g.DrawPolygon(p, po);
            g.FillPolygon(boja, po);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 130, 180, 130, 200);
            String s = this.textBox1.Text;
            Font f = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString(s, f, b, 100, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
