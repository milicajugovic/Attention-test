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
    public partial class test3 : Form
    {
        public test3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PictureBox pb = new PictureBox();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Milica\\Skola\\Psihologija\\Slike-test paznje\\test3.png");
            Timer tmr;
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            //tmr.Interval = (int)TimeSpan.FromMinutes(10).TotalMilliseconds;
            tmr.Interval = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;
            tmr.Start();
        }
    }
}
