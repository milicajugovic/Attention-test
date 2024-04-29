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
    public partial class test4 : Form
    {
        public test4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Milica\\Skola\\Psihologija\\Slike-test paznje\\test4.jpg");
            Timer tmr;
            tmr = new System.Windows.Forms.Timer();
            tmr.Tick += delegate {
                this.Close();
            };
            //tmr.Interval = (int)TimeSpan.FromMinutes(10).TotalMilliseconds;
            tmr.Interval = (int)TimeSpan.FromSeconds(3).TotalMilliseconds;
            tmr.Start();
        }
    }
}
