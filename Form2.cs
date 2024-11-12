using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hitung_luas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int panjang = int.Parse(textBox1.Text);
            int lebar = int.Parse(textBox2.Text);
            int luaspersegipanjang = panjang * lebar;

            label5.Text = luaspersegipanjang.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
