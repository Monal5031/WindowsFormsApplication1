using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();
            List<string> nlist = new List<string>(); 
            int n = int.Parse(textBox1.Text);
            int l = int.Parse(textBox2.Text);
            int u = int.Parse(textBox3.Text);
            for (int i = 0; i < n; i++)
            {
                long g = Rand.Next(l, u);
                nlist.Add(g.ToString());
            }
            Clipboard.Clear();
            string s1 = "";
            foreach (object item in nlist) s1 += item.ToString() + "\r\n";
            Clipboard.SetText(s1);
            MessageBox.Show("Copied to clipboard.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
