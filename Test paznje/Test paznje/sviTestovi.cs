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
    public partial class sviTestovi : Form
    {
        public sviTestovi()
        {
            InitializeComponent();
        }

        //StreamWriter sw = new StreamWriter(@"podaci.txt");

        private void button1_Click(object sender, EventArgs e)
        {
            krugovi krug = new krugovi();
            krug.ShowDialog();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test2 t2 = new test2();
            t2.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //sw.WriteLine("Test 2: " + textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sw.WriteLine("Test 1: " + textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = @"podaci.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Test 1: " + textBox1.Text);
                sw.WriteLine("Test 2: " + textBox2.Text);
                sw.WriteLine("Test 3: " + textBox3.Text);
                sw.WriteLine("Test 4: " + textBox4.Text);
            }
            //sw.Close();
            MessageBox.Show("Hvala Vam na učešću!", "Kraj testa!");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            test3 test = new test3();
            test.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //sw.WriteLine("Test 3: " + textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            test4 t4 = new test4();
            t4.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //sw.WriteLine("Test 4: " + textBox4.Text);
        }

        private void sviTestovi_Load(object sender, EventArgs e)
        {
            var form2 = new unosPodataka();
            form2.Closed += (s, args) => this.Close();
            this.Show();
        }
    }
}
