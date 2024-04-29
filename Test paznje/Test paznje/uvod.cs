using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Test_paznje
{
    public partial class uvod : Form
    {
        public uvod()
        {
            InitializeComponent();
        }

        public void uvod_Click(object sender, EventArgs e)
        {
            unosPodataka unos = new unosPodataka();
            unos.ShowDialog();
            uvod uvod1 = new uvod();
            uvod1.Close();
        }

        OleDbConnection conn;
        private void uvod_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
