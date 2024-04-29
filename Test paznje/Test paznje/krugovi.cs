using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_paznje
{
    public partial class krugovi : Form
    {
        public krugovi()
        {
            InitializeComponent();
        }

        class Krug
        {
            private int x, y, r;
            private Color boja;

            public Krug()
            {
                x = 0;
                y = 0;
                boja = Color.Black;
            }
            public Krug(int x, int y, int r, Color boja)
            {
                this.x = x;
                this.y = y;
                this.r = r;
                this.boja = boja;
            }

            public void Crtaj(Graphics g)
            {
                Pen olovka = new Pen(boja, 10);
                g.DrawEllipse(olovka, x, y, r, r);
            }
        }

        Random r = new Random();
        Graphics g;
        //unosPodataka f;
        private void krugovi_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            //unosPodataka.ActiveForm.Disposed += new EventHandler(closeForm2);
            //if (f != null)
                //f.Close();
        }

        //System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void button1_Click(object sender, EventArgs e)
        {
            int brojKrugova = r.Next(10, 20);
            for (int i = 0; i < brojKrugova; i++)
            {
                int polu = r.Next(10, 100);
                Krug k = new Krug(r.Next(ClientRectangle.Width - polu), r.Next(ClientRectangle.Height - polu), polu, Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)));
                k.Crtaj(g);
            }
            button1.Enabled = false;

            //timer.Interval = 10000;
            //timer.Tick += new EventHandler(timer_Tick);
            //timer.Start();

            Timer tmr;
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            //tmr.Interval = (int)TimeSpan.FromMinutes(10).TotalMilliseconds;
            tmr.Interval = (int)TimeSpan.FromSeconds(2).TotalMilliseconds;
            tmr.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //this.Close();
        }

        //private void closeForm2(object sender, EventArgs e)
        //{
        //unosPodataka.ActiveForm.Dispose();
        //}
    }
}
