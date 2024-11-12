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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sisii = int.Parse(textBox1.Text);
            int luaspersegipanjang = sisii * sisii;

            label4.Text = luaspersegipanjang.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
