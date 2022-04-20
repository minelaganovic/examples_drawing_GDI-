using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerZaMenjanjeBojeCetkiceIPozadine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int x1, x2, x3, y1, y2, y3, brojac = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog drugidijalog = new ColorDialog();
            if(drugidijalog.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.BackColor = drugidijalog.Color;
            }
        }

        public Color boja = Color.Black;

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            boja=colorDialog1.Color;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //e.X koordinata-x koordinata
            //e.Y koordinata-y kordinata gde smo kliknuli

            Graphics g = pictureBox1.CreateGraphics();
            Pen olovka = new Pen(boja, 3);
            if(brojac %3==0)//prva tacka
            {
                x1=e.X;
                y1 = e.Y;
            }
            else if(brojac % 3 ==1)
            {
                x2 = e.X;
                y2 = e.Y;
                g.DrawLine(olovka, x1, y1, x2, y2);
            }
            else if (brojac % 3 == 2)
            {
                x3 = e.X;
                y3 = e.Y;
                g.DrawLine(olovka, x1, y1, x3, y3);
                g.DrawLine(olovka, x2, y2, x3, y3);
            }
            brojac++;
        }
    }
}
