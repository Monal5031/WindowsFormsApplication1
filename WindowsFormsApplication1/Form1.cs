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
            int a = 1,b=0;
            if (checkBox1.Checked)
            {
                a = 2;
                n = n / 2;
            }

            else if (checkBox2.Checked)
            {
                b = 1;
                n = n / 2;
            }
            if(checkBox1.Checked && checkBox2.Checked)
            {
                a = 1;
                b = 0;
                n = 2 * n;
            }
                
            if (n <= 10000)
            {
                for (int i = 0; i < n; i++)
                {
                    long g = a*Rand.Next(l, u)+b;
                    progressBar1.Value = 100*i/n;
                    nlist.Add(g.ToString());
                }
                Clipboard.Clear();
                string s1 = "";
                foreach (object item in nlist) s1 += item.ToString() + "\r\n";
                Clipboard.SetText(s1);
                MessageBox.Show("Copied to clipboard.");
            }
            else
            {
                string path = @"d:\TestFile.txt";
                //File.CreateText(path);
                int j = n;
                while(n>0)
                {
                    long g = a*Rand.Next(l, u)+b;
                    progressBar1.Value = 100*(j - n - 1)/j;
                    string appendText = g.ToString() + Environment.NewLine;
                    File.AppendAllText(path, appendText);
                    n--;
                }

                MessageBox.Show("File created in "+path);
            }
            progressBar1.Value = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This portable software can be used to generate test cases. For n<=50000 it can take upto 2 seconds for generating cases and coping to your clipboard. For n>100000 the taken time is very high, I do not recomend you to generate random data for n>100000. But in case you want to generate random test data at any cost you are recomended to stay calm. For n>=100000 a TXT file is created in your D drive.                                                   -mky");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
