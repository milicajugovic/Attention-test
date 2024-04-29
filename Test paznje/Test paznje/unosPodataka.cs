using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_paznje
{
    public partial class unosPodataka : Form
    {
        public unosPodataka()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter(@"podaci.txt");
            string path = @"podaci.txt";
            string ime = textBox1.Text;
            int godine = int.Parse(textBox2.Text);
            float uspeh = float.Parse(textBox3.Text);
            string pol;
            if (checkBox1.Checked == true)
            {
                pol = "žensko";
            }
            else
            {
                pol = "muško";
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(ime + " " + godine.ToString() + " " + uspeh.ToString("0.00") + " " + pol);
            }

            //sw.WriteLine(ime + " " + godine.ToString() + " " + uspeh.ToString() + " " + pol);
            //sw.Close();

            sviTestovi testovi = new sviTestovi();
            testovi.ShowDialog();
        }

        private void unosPodataka_Load(object sender, EventArgs e)
        {
            /*
            var form2 = new uvod();
            form2.Closed += (s, args) => this.Close();
            this.Show();
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sw.WriteLine(textBox1.Text);
        }
    }
}
