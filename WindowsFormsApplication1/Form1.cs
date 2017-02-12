using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List<int> nlist = new List<int>(); 
            int l = Int32.Parse(textBox1.Text);
            int u = Int32.Parse(textBox2.Text);
            for (int i = l; i < u; i++)
            {
                
            }
        }
        
    }
}
